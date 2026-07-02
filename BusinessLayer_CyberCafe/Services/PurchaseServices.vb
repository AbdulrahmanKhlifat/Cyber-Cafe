Imports CyberCafeModels
Imports CyberCafe_DataAccess

Public Class PurchaseServices

    Private Shared Function CalculateTotal(items As List(Of CartItemDTO)) As Decimal
        Return items.Sum(Function(i) i.Quantity * i.UnitPrice)
    End Function

    Private Shared Function ValidatePurchaseItems(items As List(Of CartItemDTO)) As String

        If items Is Nothing OrElse items.Count = 0 Then
            Return "Cart is empty."
        End If

        For Each item In items

            If item Is Nothing Then
                Return "Invalid cart item."
            End If

            If item.ConsumableID <= 0 Then
                Return "Invalid consumable ID."
            End If

            If item.Quantity <= 0 Then
                Return "Quantity must be greater than zero."
            End If

            If item.UnitPrice < 0 Then
                Return "Invalid item price."
            End If

        Next

        Return String.Empty

    End Function

    Public Shared Function ProcessWalkInPurchase(purchase As PurchaseDTO, items As List(Of CartItemDTO), adminID As Integer) As Boolean


        Dim totalAmount As Decimal = CalculateTotal(items)

        Try

            If purchase Is Nothing Then

                Throw New ArgumentNullException(NameOf(purchase))

            End If

            If adminID <= 0 Then

                Throw New Exception("Invalid admin ID.")

            End If

            If totalAmount <= 0 Then
                Throw New Exception("Total amount must be greater than zero.")
            End If

            Dim validationResult = ValidatePurchaseItems(items)

            If validationResult <> String.Empty Then

                Throw New Exception(validationResult)

            End If

            Return PurchaseRepo.ProcessWalkInPurchase(purchase, items, adminID, totalAmount)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function

    Public Shared Function ProcessPurchasePerSession(purchase As PurchaseDTO, items As List(Of CartItemDTO), sessionID As Integer, customerID As Integer) As Boolean

        Dim totalAmount As Decimal = CalculateTotal(items)

        Try

            If purchase Is Nothing Then
                Throw New ArgumentNullException(NameOf(purchase))
            End If

            If sessionID <= 0 Then
                Throw New Exception("Invalid session ID.")
            End If

            If customerID <= 0 Then
                Throw New Exception("Invalid customer ID.")
            End If

            If totalAmount <= 0 Then
                Throw New Exception("Total amount must be greater than zero.")
            End If


            Dim validationResult As String = ValidatePurchaseItems(items)

            If validationResult <> String.Empty Then

                Throw New Exception(validationResult)

            End If


            Return PurchaseRepo.ProcessPurchasePerSession(purchase, items, sessionID, customerID, totalAmount)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function


End Class