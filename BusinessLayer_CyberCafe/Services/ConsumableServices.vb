Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class ConsumableServices

    Public Shared Function GetAllConsumables() As List(Of ConsumableDTO)

        Return ConsumablesRepo.GetAllConsumables()

    End Function

    Public Shared Function GetConsumablesDataTable() As DataTable
        Return ConsumablesRepo.GetAllConsumablesAsDT()
    End Function

    Public Shared Function GetConsumableByID(consumableID As Integer) As ConsumableDTO

        If consumableID <= 0 Then
            Throw New Exception("Invalid Consumable ID.")
        End If

        Return ConsumablesRepo.GetConsumableByID(consumableID)

    End Function

    Public Shared Function AddConsumable(consumable As ConsumableDTO) As Integer

        ValidateConsumable(consumable)

        Return ConsumablesRepo.AddConsumable(consumable)

    End Function

    Public Shared Function UpdateConsumable(consumable As ConsumableDTO) As Boolean

        If consumable.ConsumableId <= 0 Then
            Throw New Exception("Invalid Consumable ID.")
        End If

        ValidateConsumable(consumable)

        Return ConsumablesRepo.UpdateConsumable(consumable)

    End Function

    Public Shared Function DeleteConsumable(consumableID As Integer) As Boolean

        If consumableID <= 0 Then
            Throw New Exception("Invalid Consumable ID.")
        End If

        Return ConsumablesRepo.DeleteConsumable(consumableID)

    End Function

    Public Shared Function UpdateStock(consumableID As Integer,
                                       quantity As Integer, path As String) As Boolean

        If consumableID <= 0 Then
            Throw New Exception("Invalid Consumable ID.")
        End If

        If quantity < 0 Then
            Throw New Exception("Quantity Cannot Be Negative.")
        End If

        Return ConsumablesRepo.UpdateStock(consumableID, quantity, path)

    End Function

    Public Shared Function SearchConsumables(searchText As String) As DataTable

        If String.IsNullOrWhiteSpace(searchText) Then
            Throw New Exception("Search Text Cannot Be Empty.")
        End If

        Return ConsumablesRepo.SearchConsumables(searchText)

    End Function

    Public Shared Function GetLowStockConsumables() As DataTable

        Return ConsumablesRepo.GetLowStockConsumables()

    End Function

    Public Shared Function GetOutOfStockConsumables() As DataTable

        Return ConsumablesRepo.GetOutOfStockConsumables()

    End Function

    Private Shared Sub ValidateConsumable(consumable As ConsumableDTO)

        If consumable Is Nothing Then
            Throw New Exception("Consumable Object Cannot Be Null.")
        End If

        If String.IsNullOrWhiteSpace(consumable.ConsumableName) Then
            Throw New Exception("Consumable Name Is Required.")
        End If

        If consumable.Price <= 0 Then
            Throw New Exception("Price Must Be Greater Than Zero.")
        End If

        If consumable.Quantity < 0 Then
            Throw New Exception("Quantity Cannot Be Negative.")
        End If

    End Sub


    Public Shared Function ValidateStock(items As List(Of CartItemDTO)) As String

        If items Is Nothing OrElse items.Count = 0 Then
            Return "No items in the cart."
        End If

        For Each item In items

            If item Is Nothing Then
                Return "Invalid item in the cart."
            End If

            If item.ConsumableID <= 0 Then
                Return "Invalid Consumable ID for item in the cart."
            End If

            If item.Quantity <= 0 Then
                Return "Quantity must be greater than zero for item in the cart."
            End If

        Next

        Return ConsumablesRepo.ValidateStock(items)

    End Function
End Class