Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class ConsumablesRepo



    Public Shared Function GetAllConsumablesAsDT() As DataTable
        Dim dt As New DataTable()

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String = "SELECT ConsumableID,ConsumableName,ConsumableDescription,Price,Quantity 
                                       FROM Consumables"

                Using cmd As New SqlCommand(query, conn)

                    conn.Open()
                    dt.Load(cmd.ExecuteReader())

                End Using

            End Using

        Catch ex As Exception
            Throw New Exception("Error While Loading Consumables.", ex)
        End Try

        Return dt

    End Function

    Public Shared Function GetAllConsumables() As List(Of ConsumableDTO)

        Dim consumables As New List(Of ConsumableDTO)

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String = "SELECT ConsumableID,ConsumableName,ConsumableDescription,Price,Quantity,ImagePath 
                                       FROM Consumables"

                Using cmd As New SqlCommand(query, conn)

                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            consumables.Add(New ConsumableDTO With {
                            .ConsumableId = Convert.ToInt32(reader("ConsumableID")),
                            .ConsumableName = reader("ConsumableName").ToString(),
                            .Description = reader("ConsumableDescription").ToString(),
                            .Price = Convert.ToDecimal(reader("Price")),
                            .Quantity = Convert.ToInt32(reader("Quantity")),
                            .ImagePath = reader("ImagePath").ToString()
                        })

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            Throw New Exception("Error While Loading Consumables.", ex)

        End Try

        Return consumables

    End Function

    Public Shared Function GetKpiConsumables() As ConsumablesSummaryDTO

        Dim query As String = "SELECT
                                      (SELECT COUNT(*) FROM Consumables) AS TotalItems,
                                  
                                      (SELECT COUNT(*) 
                                       FROM Consumables 
                                       WHERE Quantity < 5) AS LowStockItems,
                                  
                                      (SELECT COUNT(*) 
                                       FROM Consumables 
                                       WHERE Quantity = 0) AS OutOfStock,
                                  
                                      (SELECT ISNULL(SUM(PaidAmount),0)
                                       FROM Transactions
                                       WHERE CAST(TransactionDate AS DATE) = CAST(GETDATE() AS DATE)
                                      ) AS RevenueToday,
                                  
                                      (
                                          SELECT TOP 1 C.ConsumableName
                                          FROM PurchaseItems TD
                                          INNER JOIN Consumables C
                                          ON TD.ConsumableID = C.ConsumableID
                                          GROUP BY C.ConsumableName
                                          ORDER BY SUM(TD.Quantity) DESC
                                      ) AS MostSoldItem"

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Using cmd As New SqlCommand(query, conn)

                conn.Open()

                Try

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim summary As New ConsumablesSummaryDTO With {
                                .TotalItems = Convert.ToInt32(reader("TotalItems")),
                                .LowStock = Convert.ToInt32(reader("LowStockItems")),
                                .OutOfStock = Convert.ToInt32(reader("OutOfStock")),
                                .TotalValue = Convert.ToDecimal(reader("RevenueToday")),
                                .MostSoldItem = If(reader("MostSoldItem") Is DBNull.Value, "N/A", reader("MostSoldItem").ToString())
                                }

                            Return summary

                        End If

                    End Using

                Catch ex As Exception

                    Throw New Exception("Error While Loading KPI Consumables.", ex)

                End Try
            End Using

        End Using

        Return Nothing

    End Function

    Public Shared Function GetConsumableByID(consumableID As Integer) As ConsumableDTO

        Dim consumable As ConsumableDTO = Nothing

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String = "select * from Consumables where ConsumableID = @ConsumableID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@ConsumableID", SqlDbType.Int).Value = consumableID

                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            consumable = New ConsumableDTO With {
                            .ConsumableId = Convert.ToInt32(reader("ConsumableID")),
                            .ConsumableName = reader("ConsumableName").ToString(),
                            .Description = reader("ConsumableDescription").ToString(),
                            .Price = Convert.ToDecimal(reader("Price")),
                            .Quantity = Convert.ToInt32(reader("Quantity")),
                            .ImagePath = reader("ImagePath").ToString()
                        }

                        End If

                    End Using

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Getting Consumable By ID.", ex)

        End Try

        Return consumable

    End Function

    Public Shared Function AddConsumable(consumable As ConsumableDTO) As Integer

        Dim insertedID As Integer = -1

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String = "INSERT INTO Consumables (ConsumableName,ImagePath,ConsumableDescription,Price,Quantity)

                                       VALUES(@ConsumableName,@ImagePath,@Description,@Price,@Quantity);

                                       SELECT SCOPE_IDENTITY();"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@ConsumableName", SqlDbType.NVarChar, 50).Value = consumable.ConsumableName

                    cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 255).Value = If(String.IsNullOrWhiteSpace(consumable.ImagePath), DBNull.Value, consumable.ImagePath)

                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 255).Value = consumable.Description

                    cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = consumable.Price

                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = consumable.Quantity

                    conn.Open()

                    insertedID = Convert.ToInt32(cmd.ExecuteScalar())

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Adding Consumable.", ex)

        End Try

        Return insertedID

    End Function

    Public Shared Function UpdateConsumable(consumable As ConsumableDTO) As Boolean

        Dim rowsAffected As Integer = 0

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "UPDATE Consumables
                 SET ConsumableName = @ConsumableName,ImagePath = @ImagePath,ConsumableDescription = @Description,
                 Price = @Price,Quantity = @Quantity
                 WHERE ConsumableID = @ConsumableID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@ConsumableID", SqlDbType.Int).Value = consumable.ConsumableId

                    cmd.Parameters.Add("@ConsumableName", SqlDbType.NVarChar, 100).Value = consumable.ConsumableName

                    cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 500).Value = consumable.ImagePath

                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = consumable.Description

                    cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = consumable.Price

                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = consumable.Quantity

                    conn.Open()

                    rowsAffected = cmd.ExecuteNonQuery()

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Updating Consumable.", ex)

        End Try

        Return rowsAffected > 0

    End Function

    Public Shared Function DeleteConsumable(consumableID As Integer) As Boolean

        Dim rowsAffected As Integer = 0

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                    "DELETE FROM Consumables
                     WHERE ConsumableID = @ConsumableID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@ConsumableID", SqlDbType.Int).Value = consumableID

                    conn.Open()

                    rowsAffected = cmd.ExecuteNonQuery()

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Deleting Consumable.", ex)

        End Try

        Return rowsAffected > 0

    End Function

    Public Shared Function UpdateStock(consumableID As Integer, quantity As Integer, imagePath As String) As Boolean

        Dim rowsAffected As Integer = 0

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                    "UPDATE Consumables
                     SET Quantity = @Quantity,ImagePath = @ImagePath
                     WHERE ConsumableID = @ConsumableID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@ConsumableID", SqlDbType.Int).Value = consumableID

                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity

                    If String.IsNullOrEmpty(imagePath) Then
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 255).Value = DBNull.Value
                    Else
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 255).Value = imagePath
                    End If

                    conn.Open()

                    rowsAffected = cmd.ExecuteNonQuery()

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Updating Stock.", ex)

        End Try

        Return rowsAffected > 0

    End Function

    Public Shared Function SearchConsumables(searchText As String) As DataTable

        Dim dt As New DataTable()

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "SELECT *
                 FROM Consumables
                 WHERE ConsumableName LIKE '%' + @Search + '%'
                 OR ConsumableDescription LIKE @Search "

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@Search", SqlDbType.NVarChar, 100).Value = "%" & searchText & "%"

                    conn.Open()

                    dt.Load(cmd.ExecuteReader())

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Searching Consumables.", ex)

        End Try

        Return dt

    End Function

    Public Shared Function GetLowStockConsumables() As DataTable

        Dim dt As New DataTable()

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                    "select *
                     from Consumables
                     where Quantity Between 1 AND 5"

                Using cmd As New SqlCommand(query, conn)

                    conn.Open()

                    dt.Load(cmd.ExecuteReader())

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Loading Low Stock Consumables.", ex)

        End Try

        Return dt

    End Function

    Public Shared Function GetOutOfStockConsumables() As DataTable

        Dim dt As New DataTable()

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                    "select *
                     from Consumables
                     where Quantity <= 0"

                Using cmd As New SqlCommand(query, conn)

                    conn.Open()

                    dt.Load(cmd.ExecuteReader())

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Error While Loading Out Of Stock Consumables.", ex)

        End Try

        Return dt

    End Function


    Public Shared Function ValidateStock(items As List(Of CartItemDTO)) As String

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "SELECT ConsumableName,Quantity FROM Consumables WHERE ConsumableID = @ConsumableID"

                conn.Open()

                For Each item In items

                    Using cmd As New SqlCommand(query, conn)

                        cmd.Parameters.Add("@ConsumableID", SqlDbType.Int).Value =
                        item.ConsumableID

                        Using reader As SqlDataReader = cmd.ExecuteReader()

                            If reader.Read() Then

                                Dim itemName As String =
                                reader("ConsumableName").ToString()

                                Dim availableQuantity As Integer = Convert.ToInt32(reader("Quantity"))

                                If availableQuantity < item.Quantity Then

                                    Return $"{itemName} only has {availableQuantity} left."

                                End If

                            Else

                                Return $"Item With ID {item.ConsumableID} Not Found."

                            End If

                        End Using

                    End Using

                Next

            End Using

            Return String.Empty

        Catch ex As Exception

            Throw New Exception("Error While Validating Stock.", ex)

        End Try

    End Function

End Class