Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class TransactionRepo

    Public Shared Function AddTransaction(transaction As TransactionDTO) As Integer
        Dim transactionID As Integer = -1

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "INSERT INTO Transactions 
                                  (CustomerID, ProcessedByAdminID, TransactionType, TransactionDate, TransactionNotes, SessionID) 
                                  VALUES 
                                  (@CustomerID, @ProcessedByAdminID, @TransactionType, @TransactionDate, @TransactionNotes, @SessionID);
                                  SELECT SCOPE_IDENTITY();"

            Using cmd As SqlCommand = New SqlCommand(query, conn)
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = transaction.CustomerID
                cmd.Parameters.Add("@ProcessedByAdminID", SqlDbType.Int).Value = transaction.ProcessedByAdminID
                cmd.Parameters.Add("@TransactionType", SqlDbType.Int).Value = Convert.ToInt32(transaction.TransactionType)
                cmd.Parameters.Add("@TransactionDate", SqlDbType.DateTime).Value = transaction.TransactionDate


                If String.IsNullOrEmpty(transaction.TransactionNotes) Then
                    cmd.Parameters.Add("@TransactionNotes", SqlDbType.NVarChar, -1).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@TransactionNotes", SqlDbType.NVarChar, -1).Value = transaction.TransactionNotes
                End If


                If transaction.SessionID.HasValue Then
                    cmd.Parameters.Add("@SessionID", SqlDbType.Int).Value = transaction.SessionID.Value
                Else
                    cmd.Parameters.Add("@SessionID", SqlDbType.Int).Value = DBNull.Value
                End If

                Try
                    conn.Open()

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), transactionID) Then

                        Return transactionID

                    End If

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                    Return -1

                End Try
            End Using
        End Using

        Return transactionID
    End Function


    Public Shared Function AddTransaction(transactionDto As TransactionDTO, conn As SqlConnection, trans As SqlTransaction) As Integer

        Dim transactionID As Integer = -1

        Try

            Dim query As String = "INSERT INTO Transactions(ProcessedByAdminID,TransactionType,PaidAmount,TransactionDate,TransactionNotes,IsDeleted)
                                  VALUES(@ProcessedByAdminID,@TransactionType,@PaidAmount,@TransactionDate,@TransactionNotes,@IsDeleted);
                                  SELECT SCOPE_IDENTITY();"

            Using cmd As New SqlCommand(query, conn, trans)

                cmd.Parameters.Add("@ProcessedByAdminID", SqlDbType.Int).Value = If(transactionDto.ProcessedByAdminID, transactionDto.ProcessedByAdminID, DBNull.Value)

                cmd.Parameters.Add("@TransactionType", SqlDbType.Int).Value = transactionDto.TransactionType

                cmd.Parameters.Add("@PaidAmount", SqlDbType.Decimal).Value = transactionDto.PaidAmount

                cmd.Parameters.Add("@TransactionDate", SqlDbType.DateTime).Value = transactionDto.TransactionDate

                cmd.Parameters.Add("@TransactionNotes", SqlDbType.NVarChar, 255).Value =
                 If(String.IsNullOrWhiteSpace(transactionDto.TransactionNotes), DBNull.Value, transactionDto.TransactionNotes)

                cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = transactionDto.IsDeleted

                transactionID = Convert.ToInt32(cmd.ExecuteScalar())

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

        Return transactionID

    End Function



    Public Shared Function GetTransactionByID(transactionID As Integer) As TransactionDTO
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT TransactionID, CustomerID, ProcessedByAdminID, TransactionType, TransactionDate, TransactionNotes, SessionID
                                   FROM Transactions 
                                   WHERE TransactionID = @TransactionID;"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@TransactionID", SqlDbType.Int).Value = transactionID

                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim transaction As New TransactionDTO With {
                                .TransactionID = CType(reader("TransactionID"), Integer),
                                .CustomerID = CType(reader("CustomerID"), Integer),
                                .ProcessedByAdminID = CType(reader("ProcessedByAdminID"), Integer),
                                .TransactionType = CType(reader("TransactionType"), Integer),
                                .TransactionDate = CType(reader("TransactionDate"), DateTime)
                            }


                            If Not IsDBNull(reader("TransactionNotes")) Then
                                transaction.TransactionNotes = CType(reader("TransactionNotes"), String)
                            Else
                                transaction.TransactionNotes = String.Empty
                            End If


                            If Not IsDBNull(reader("SessionID")) Then
                                transaction.SessionID = CType(reader("SessionID"), Integer)
                            Else
                                transaction.SessionID = Nothing
                            End If

                            Return transaction
                        End If
                    End Using
                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                    Return Nothing
                End Try

            End Using

        End Using

        Return Nothing

    End Function

    Public Shared Function GetAllTransactions() As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT TransacationID,TransactionDate,CustomerName,PaidAmount,SessionID,CreatedByAdminID FROM Transactions 
                                   INNER JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
                                   ORDER BY TransactionDate DESC;"

            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then

                            dt.Load(reader)

                        End If
                        dt.Load(reader)
                    End Using
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using
        End Using

        Return dt
    End Function

    Public Shared Function GetDailyTransactionSummary() As DailyTransactionsSummaryDTO

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT COUNT(TransactionID) AS TotalTransactions, 
                                      ISNULL(SUM(PaidAmount), 0) AS TotalRevenue
                               FROM Transactions 
                               WHERE CAST(TransactionDate AS DATE) = CAST(GETDATE() AS DATE);"

            Using cmd As New SqlCommand(query, conn)

                Try

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim summary As New DailyTransactionsSummaryDTO With {
                                .TotalTransactions = CType(reader("TotalTransactions"), Integer),
                                .TotalRevenue = CType(reader("TotalRevenue"), Decimal)
                            }

                            Return summary
                        End If
                    End Using

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                    Return Nothing
                End Try
            End Using
        End Using

        Return Nothing

    End Function

End Class