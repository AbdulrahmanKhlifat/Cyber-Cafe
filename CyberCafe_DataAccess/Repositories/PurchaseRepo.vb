Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class PurchaseRepo

    Public Shared Function GetPurchaseByID(purchaseID As Integer) As PurchaseDTO

        Dim purchase As PurchaseDTO = Nothing

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "SELECT *FROM PurchasesWHERE PurchaseID = @PurchaseIDAND IsDeleted = 0"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@PurchaseID", SqlDbType.Int).Value =
                    purchaseID

                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            purchase = New PurchaseDTO With {
                                .PurchaseID = Convert.ToInt32(reader("PurchaseID")),
                                .ProcessedByAdminID = If(IsDBNull(reader("ProcessedByAdminID")), Nothing, Convert.ToInt32(reader("ProcessedByAdminID"))),
                                .SessionID = If(IsDBNull(reader("SessionID")), Nothing, Convert.ToInt32(reader("SessionID"))),
                                .PurchaseType = reader("PurchaseType").ToString(),
                                .PurchaseDate = Convert.ToDateTime(reader("PurchaseDate")),
                                .TotalAmount = Convert.ToDecimal(reader("TotalAmount")),
                                .IsDeleted = Convert.ToBoolean(reader("IsDeleted"))
                            }

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            Throw New Exception("Error While Getting Purchase By ID.", ex)

        End Try

        Return purchase

    End Function


    Public Shared Function GetAllPurchases() As DataTable

        Dim dt As New DataTable()

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "select * from Purchases where IsDeleted = 0ORDER BY PurchaseDate desc"

                Using cmd As New SqlCommand(query, conn)

                    conn.Open()

                    dt.Load(cmd.ExecuteReader())

                End Using

            End Using

        Catch ex As Exception

            Throw New Exception("Error While Getting Purchases.", ex)

        End Try

        Return dt

    End Function


    Public Shared Function DeletePurchase(purchaseID As Integer) As Boolean

        Dim rowsAffected As Integer = 0

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "UPDATE Purchases SET IsDeleted = 1WHERE PurchaseID = @PurchaseID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@PurchaseID", SqlDbType.Int).Value =
                    purchaseID

                    conn.Open()

                    rowsAffected = cmd.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception

            Throw New Exception("Error While Deleting Purchase.", ex)

        End Try

        Return rowsAffected > 0

    End Function


    Public Shared Function AddPurchase(purchase As PurchaseDTO, conn As SqlConnection, trans As SqlTransaction) As Integer

        Dim purchaseID As Integer = -1

        Try



            Dim query As String = "INSERT INTO Purchases(ProcessedByAdminID,SessionID,PurchaseType,PurchaseDate,TotalAmount,IsDeleted)
                                       VALUES(@ProcessedByAdminID,@SessionID,@PurchaseType,@PurchaseDate,@TotalAmount,@IsDeleted);
                                       SELECT SCOPE_IDENTITY();"

            Using cmd As New SqlCommand(query, conn, trans)

                cmd.Parameters.Add("@ProcessedByAdminID", SqlDbType.Int).Value = If(purchase.ProcessedByAdminID.HasValue, purchase.ProcessedByAdminID, DBNull.Value)

                cmd.Parameters.Add("@SessionID", SqlDbType.Int).Value = If(purchase.SessionID.HasValue, purchase.SessionID, DBNull.Value)

                cmd.Parameters.Add("@PurchaseType", SqlDbType.NVarChar, 50).Value = purchase.PurchaseType

                cmd.Parameters.Add("@PurchaseDate", SqlDbType.DateTime).Value = purchase.PurchaseDate

                cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = purchase.TotalAmount

                cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = purchase.IsDeleted


                purchaseID = Convert.ToInt32(cmd.ExecuteScalar())

            End Using


        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

        Return purchaseID

    End Function




    Private Shared Function PrepareStockDataTable(items As List(Of CartItemDTO)) As DataTable

        Dim dt As New DataTable()

        dt.Columns.Add("ConsumableID", GetType(Integer))
        dt.Columns.Add("Quantity", GetType(Integer))

        For Each item In items

            dt.Rows.Add(item.ConsumableID, item.Quantity)

        Next

        Return dt

    End Function

    Private Shared Function PrepareDetailsDataTable(purchaseID As Integer, items As List(Of CartItemDTO)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("PurchaseID", GetType(Integer))
        dt.Columns.Add("ConsumableID", GetType(Integer))
        dt.Columns.Add("Quantity", GetType(Integer))
        dt.Columns.Add("UnitPrice", GetType(Decimal))
        For Each item In items
            dt.Rows.Add(purchaseID, item.ConsumableID, item.Quantity, item.UnitPrice)
        Next
        Return dt
    End Function

    Private Shared Sub SavePurchaseDetailsBulk(detailsTable As DataTable, conn As SqlConnection, trans As SqlTransaction)
        Using bulk As New SqlBulkCopy(conn, SqlBulkCopyOptions.Default, trans)
            bulk.DestinationTableName = "PurchaseItems"
            bulk.ColumnMappings.Add("PurchaseID", "PurchaseID")
            bulk.ColumnMappings.Add("ConsumableID", "ConsumableID")
            bulk.ColumnMappings.Add("Quantity", "Quantity")
            bulk.ColumnMappings.Add("UnitPrice", "UnitPrice")
            bulk.WriteToServer(detailsTable)
        End Using
    End Sub


    Private Shared Sub UpdateStockBulk(stockTable As DataTable, conn As SqlConnection, trans As SqlTransaction)

        Using cmd As New SqlCommand("sp_DecreaseStockBulk", conn, trans)
            cmd.CommandType = CommandType.StoredProcedure

            Dim param = cmd.Parameters.AddWithValue("@ItemItems", stockTable)

            param.SqlDbType = SqlDbType.Structured

            param.TypeName = "dbo.UDT_PurchaseItems"

            cmd.ExecuteNonQuery()

        End Using
    End Sub


    Private Shared Sub RegisterFinancialTransaction(transdto As TransactionDTO, conn As SqlConnection, trans As SqlTransaction)
        Dim transactionID = TransactionRepo.AddTransaction(transdto, conn, trans)

        If transactionID <= 0 Then

            Throw New Exception("Failed to create financial transaction.")

        End If
    End Sub


    Public Shared Function ProcessWalkInPurchase(purchase As PurchaseDTO, items As List(Of CartItemDTO), adminID As Integer, totalAmount As Decimal) As Boolean

        Dim stockTable = PrepareStockDataTable(items)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            conn.Open()
            Using transaction = conn.BeginTransaction()
                Try

                    Dim purchaseID = AddPurchase(purchase, conn, transaction)
                    If purchaseID <= 0 Then

                        Throw New Exception("Failed to create purchase.")

                    End If


                    Dim detailsTable = PrepareDetailsDataTable(purchaseID, items)
                    SavePurchaseDetailsBulk(detailsTable, conn, transaction)


                    UpdateStockBulk(stockTable, conn, transaction)



                    Dim transactionDto As New TransactionDTO With {
             .ProcessedByAdminID = adminID,
             .TransactionType = 3,
             .PaidAmount = totalAmount,
             .TransactionDate = DateTime.Now,
             .TransactionNotes = "Walk-In Purchase",
             .IsDeleted = False
             }

                    RegisterFinancialTransaction(transactionDto, conn, transaction)

                    transaction.Commit()
                    Return True

                Catch ex As Exception
                    Try

                        If transaction IsNot Nothing Then
                            transaction.Rollback()
                        End If

                    Catch
                    End Try

                    ErrorLogger.LogErrorToFile(
                        ex,
                        Reflection.MethodBase.GetCurrentMethod().Name
                    )

                    Throw
                End Try

            End Using

        End Using

    End Function


    Public Shared Function ProcessPurchasePerSession(purchase As PurchaseDTO, items As List(Of CartItemDTO), sessionID As Integer, customerID As Integer, totalAmount As Decimal) As Boolean


        Dim stockTable As DataTable = PrepareStockDataTable(items)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            conn.Open()

            Using transaction As SqlTransaction = conn.BeginTransaction()

                Try


                    Dim customerCredits As Decimal =
                    CustomerRepo.GetCustomerCredits(customerID, conn, transaction)

                    If customerCredits < totalAmount Then

                        Throw New Exception("Insufficient customer credits.")

                    End If


                    purchase.SessionID = sessionID
                    purchase.TotalAmount = totalAmount
                    purchase.PurchaseDate = DateTime.Now

                    Dim purchaseID As Integer =
                    AddPurchase(purchase, conn, transaction)

                    If purchaseID <= 0 Then

                        Throw New Exception("Failed to create purchase.")

                    End If


                    Dim detailsTable =
                    PrepareDetailsDataTable(purchaseID, items)

                    SavePurchaseDetailsBulk(detailsTable, conn, transaction)


                    UpdateStockBulk(stockTable, conn, transaction)

                    Dim deducted As Boolean = CustomerRepo.DeductCredits(customerID, totalAmount, conn, transaction)

                    If Not deducted Then

                        Throw New Exception("Failed to deduct customer credits.")

                    End If


                    Dim transactionDto As New TransactionDTO With {
                    .ProcessedByAdminID = Nothing,
                    .SessionID = sessionID,
                    .TransactionType = CByte(TransactionType.SessionSnackPurchase),
                    .PaidAmount = totalAmount,
                    .TransactionDate = DateTime.Now,
                    .TransactionNotes = "Session Purchase",
                    .IsDeleted = False
                }

                    RegisterFinancialTransaction(transactionDto, conn, transaction)




                    transaction.Commit()

                    Return True

                Catch ex As Exception

                    Try

                        transaction.Rollback()

                    Catch


                    End Try

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

                    Throw

                End Try

            End Using

        End Using

    End Function




End Class

