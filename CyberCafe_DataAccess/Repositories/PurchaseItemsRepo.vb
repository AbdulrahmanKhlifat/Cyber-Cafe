Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class PurchaseItemsRepo

    Public Shared Function AddPurchaseItem(item As CartItemDTO) As Integer

        Dim purchaseItemID As Integer = -1

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "INSERT INTO PurchaseItems (PurchaseID,ConsumableID,Quantity,UnitPrice)
                 VALUES(@PurchaseID,@ConsumableID,@Quantity,@UnitPrice);
                 SELECT SCOPE_IDENTITY();"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@PurchaseID", SqlDbType.Int).Value =
                    item.PurchaseID

                    cmd.Parameters.Add("@ConsumableID", SqlDbType.Int).Value =
                    item.ConsumableID

                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value =
                    item.Quantity

                    cmd.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value =
                    item.UnitPrice

                    conn.Open()

                    purchaseItemID = Convert.ToInt32(cmd.ExecuteScalar())

                End Using

            End Using

        Catch ex As Exception

            Throw New Exception("Error While Adding Purchase Item.", ex)

        End Try

        Return purchaseItemID

    End Function

    Public Shared Function GetPurchaseItemsByPurchaseID(purchaseID As Integer) As DataTable

        Dim dt As New DataTable()

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "SELECT * FROM PurchaseItems WHERE PurchaseID = @PurchaseID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@PurchaseID", SqlDbType.Int).Value =
                    purchaseID

                    conn.Open()

                    dt.Load(cmd.ExecuteReader())

                End Using

            End Using

        Catch ex As Exception

            Throw New Exception("Error While Getting Purchase Items.", ex)

        End Try

        Return dt

    End Function

    Public Shared Function DeletePurchaseItemsByPurchaseID(purchaseID As Integer) As Boolean

        Dim rowsAffected As Integer = 0

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
                "DELETE FROM PurchaseItems WHERE PurchaseID = @PurchaseID"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@PurchaseID", SqlDbType.Int).Value =
                    purchaseID

                    conn.Open()

                    rowsAffected = cmd.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception

            Throw New Exception("Error While Deleting Purchase Items.", ex)

        End Try

        Return rowsAffected > 0

    End Function




End Class