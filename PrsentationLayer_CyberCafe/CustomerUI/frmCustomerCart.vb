Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmCustomerCart

    Public Event PurchaseCompleted()

    Private _allItems As List(Of ConsumableDTO)
    Private ReadOnly _CustomerID As Integer?
    Private ReadOnly _SessionID As Integer?
    Dim items As New List(Of CartItemDTO)
    Private _IsWalkIn As Boolean

    Sub New(customerID As Integer, sessionID As Integer)

        InitializeComponent()
        btnCloseWin.Visible = False
        _CustomerID = customerID
        _SessionID = sessionID
        _IsWalkIn = False

    End Sub

    Sub New()

        InitializeComponent()
        btnCloseWin.Visible = True
        _IsWalkIn = True

    End Sub

    Private Sub EnableDoubleBuffering(ctrl As Control)
        Dim prop As PropertyInfo = GetType(Control).GetProperty(
            "DoubleBuffered",
            BindingFlags.Instance Or BindingFlags.NonPublic)
        prop.SetValue(ctrl, True, Nothing)


        Dim setStyle As MethodInfo = GetType(Control).GetMethod(
            "SetStyle",
            BindingFlags.Instance Or BindingFlags.NonPublic)
        setStyle.Invoke(ctrl, New Object() {
            ControlStyles.OptimizedDoubleBuffer Or
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.UserPaint,
            True})
    End Sub

    Private Sub frmManageConsumables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToParent()
        EnableDoubleBuffering(flpConsumbleCards)
        EnableDoubleBuffering(flpInvoiceItems)
        DragHelper.EnableDragging(pnlHeader)
        SetupFlowPanel()
        _allItems = ConsumableServices.GetAllConsumables()
        RenderCards(_allItems)
        UpdateTotals()

    End Sub

    Private Sub SetupFlowPanel()
        flpConsumbleCards.AutoScroll = True
        flpConsumbleCards.Padding = New Padding(12)
        flpConsumbleCards.BackColor = Color.FromArgb(13, 17, 23)
        flpConsumbleCards.WrapContents = True

        flpInvoiceItems.AutoScroll = True
        flpInvoiceItems.Padding = New Padding(5)
        flpInvoiceItems.BackColor = Color.Transparent
        flpInvoiceItems.WrapContents = True
    End Sub


    Private Sub RenderCards(items As List(Of ConsumableDTO))

        _allItems = ConsumableServices.GetAllConsumables()

        If items Is Nothing Then

            MessageBox.Show("Items list is NULL")
            Return

        End If

        flpConsumbleCards.SuspendLayout()
        flpConsumbleCards.Controls.Clear()

        For Each item In items

            Dim card As New ctrConsumableCard()
            card.Size = New Size(208, 296)
            card.Margin = New Padding(8)
            card.LoadData(item)
            card.lblSoldCount.Text = 15 & " sold"

            Dim capturedItem = item
            AddHandler card.AddToCart,
                Sub(s As ctrConsumableCard, qty As Integer)

                    OnAddToCart(capturedItem, qty)

                End Sub

            flpConsumbleCards.Controls.Add(card)

        Next

        flpConsumbleCards.ResumeLayout()
        flpConsumbleCards.AutoScroll = False
        flpConsumbleCards.AutoScroll = True

    End Sub


    Private Sub OnAddToCart(item As ConsumableDTO, qty As Integer)
        Dim existingItem = items.FirstOrDefault(Function(i) i.ConsumableID = item.ConsumableId)

        If existingItem IsNot Nothing Then

            existingItem.Quantity += qty

        Else

            items.Add(New CartItemDTO With {
            .ConsumableID = item.ConsumableId,
            .Quantity = qty,
            .UnitPrice = item.Price
        })

        End If

        RefreshInvoiceUI()

    End Sub

    Private Sub RefreshInvoiceUI()

        flpInvoiceItems.Controls.Clear()

        For Each item In items

            Dim consumable = _allItems.
            FirstOrDefault(Function(c) c.ConsumableId = item.ConsumableID)

            If consumable Is Nothing Then
                Continue For
            End If

            AddInvoiceItem(consumable.ConsumableName, item.Quantity, item.UnitPrice
        )

        Next

        UpdateTotals()

    End Sub
    Private Sub UpdateTotals()

        Dim subtotal As Decimal = items.Sum(Function(i) i.Quantity * i.UnitPrice)

        Dim itemCount As Integer = items.Sum(Function(i) i.Quantity)

        Dim tax = subtotal * 0.05D
        Dim grandTotal = subtotal + tax

        lblSubtotalVal.Text = $"${subtotal:0.00}"
        lblTaxVal.Text = $"${tax:0.00}"
        lblGrandTotalVal.Text = $"${grandTotal:0.00}"
        lblItemCount.Text = $"({itemCount} items)"

    End Sub
    Private Sub AddInvoiceItem(itemName As String, qty As Integer, price As Decimal)
        Dim total = qty * price

        Dim pnlRow As New Guna2Panel With {
            .Size = New Size(flpInvoiceItems.Width - 25, 50),
            .BackColor = Color.Transparent,
            .Padding = New Padding(0, 0, 0, 5),
            .Margin = New Padding(0, 0, 0, 5)
        }

        Dim lblName As New Label With {
            .Text = itemName,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9.5, FontStyle.Bold),
            .Location = New Point(5, 5),
            .AutoSize = True,
            .BackColor = Color.Transparent
        }


        Dim lblDetail As New Label With {
            .Text = $"{qty} × ${price:0.00}",
            .ForeColor = Color.FromArgb(139, 148, 158),
            .Font = New Font("Segoe UI", 8.5),
            .Location = New Point(5, 25),
            .AutoSize = True,
            .BackColor = Color.Transparent
        }

        Dim lblTotal As New Label With {
            .Text = $"${total:0.00}",
            .ForeColor = Color.FromArgb(0, 255, 157),
            .Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold),
            .AutoSize = False,
            .Size = New Size(100, 25),
            .Location = New Point(pnlRow.Width - 105, 12),
            .TextAlign = ContentAlignment.TopRight,
            .BackColor = Color.Transparent
        }


        Dim pnlSep As New Guna2Panel With {
            .Size = New Size(pnlRow.Width - 10, 1),
            .FillColor = Color.FromArgb(48, 54, 61),
            .Location = New Point(5, 48),
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        }

        pnlRow.Controls.Add(lblName)
        pnlRow.Controls.Add(lblDetail)
        pnlRow.Controls.Add(lblTotal)
        pnlRow.Controls.Add(pnlSep)

        flpInvoiceItems.Controls.Add(pnlRow)
        flpInvoiceItems.ScrollControlIntoView(pnlRow)

    End Sub



    Private Sub btnCloseWin_Click(sender As Object, e As EventArgs) Handles btnCloseWin.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        items.Clear()
        flpInvoiceItems.Controls.Clear()
        UpdateTotals()
    End Sub


    Private Sub ResetCartUI()

        flpInvoiceItems.Controls.Clear()
        flpInvoiceItems.SuspendLayout()
        items.Clear()

        RenderCards(_allItems)
        flpInvoiceItems.ResumeLayout()
        UpdateTotals()

    End Sub

    Private Sub ShowPurchaseSuccess(totalAmount As Decimal)

        UIHelper.ShowGunaMessage($"Purchase completed successfully! Total: ${totalAmount:0.00}", "Success", MessageDialogIcon.Information)

    End Sub

    Private Function ValidateCart() As Boolean

        If items Is Nothing OrElse items.Count = 0 Then

            UIHelper.ShowGunaMessage(
            "Your cart is empty!",
            "Checkout",
            MessageDialogIcon.Warning
        )

            Return False

        End If

        Return True

    End Function

    Private Function CalculateTotalAmount() As Decimal

        Return items.Sum(Function(i) i.Quantity * i.UnitPrice)

    End Function

    Private Function CreateWalkInPurchase(totalAmount As Decimal) As PurchaseDTO

        Return New PurchaseDTO With {
        .SessionID = Nothing,
        .PurchaseDate = DateTime.Now,
        .TotalAmount = totalAmount,
        .PurchaseType = enPurchaseType.WalkIn,
        .ProcessedByAdminID = LoggedInUser.CurrentUser.UserID,
        .IsDeleted = False
    }

    End Function

    Private Function CreateSessionPurchase(totalAmount As Decimal) As PurchaseDTO

        Return New PurchaseDTO With {
        .SessionID = _SessionID,
        .PurchaseDate = DateTime.Now,
        .TotalAmount = totalAmount,
        .PurchaseType = enPurchaseType.PerSession,
        .ProcessedByAdminID = Nothing,
        .IsDeleted = False
    }

    End Function


    Private Sub ProcessWalkInPurchase()

        Dim stockError As String = ConsumableServices.ValidateStock(items)

        If Not String.IsNullOrWhiteSpace(stockError) Then

            UIHelper.ShowGunaMessage(stockError, "Insufficient Stock", MessageDialogIcon.Warning
        )

            Return

        End If

        Dim totalAmount As Decimal = CalculateTotalAmount()

        Dim purchase As PurchaseDTO = CreateWalkInPurchase(totalAmount)

        Dim success As Boolean = PurchaseServices.ProcessWalkInPurchase(purchase, items, LoggedInUser.CurrentUser.UserID)

        If Not success Then

            Throw New Exception("Purchase failed.")

        End If

        ShowPurchaseSuccess(totalAmount)

        ResetCartUI()

        RaiseEvent PurchaseCompleted()

    End Sub


    Private Sub ProcessSessionPurchase()

        Dim stockError As String = ConsumableServices.ValidateStock(items)

        If Not String.IsNullOrWhiteSpace(stockError) Then

            UIHelper.ShowGunaMessage(stockError, "Insufficient Stock", MessageDialogIcon.Warning)

            Return

        End If

        Dim totalAmount As Decimal = CalculateTotalAmount()

        Dim purchase As PurchaseDTO = CreateSessionPurchase(totalAmount)

        Dim success As Boolean = PurchaseServices.ProcessPurchasePerSession(purchase, items, _SessionID, _CustomerID)

        If Not success Then

            Throw New Exception("Purchase failed.")

        End If

        ShowPurchaseSuccess(totalAmount)

        RaiseEvent PurchaseCompleted()

        ResetCartUI()

    End Sub


    Private Sub ProcessPurchase()

        If _IsWalkIn Then
            ProcessWalkInPurchase()
        Else
            ProcessSessionPurchase()
        End If

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        Try

            If Not ValidateCart() Then

                Return

            End If

            ProcessPurchase()


        Catch ex As Exception

            UIHelper.ShowGunaMessage(ex.Message, "Error", MessageDialogIcon.Error
            )

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

        End Try

    End Sub


End Class