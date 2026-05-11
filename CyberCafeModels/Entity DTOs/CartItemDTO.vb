Public Class CartItemDTO

    Public Property PurchaseItemID As Integer

    Public Property PurchaseID As Integer

    Public Property ConsumableID As Integer

    Public Property Quantity As Integer

    Public Property UnitPrice As Decimal

    Public ReadOnly Property TotalPrice As Decimal
        Get
            Return Quantity * UnitPrice
        End Get
    End Property


End Class
