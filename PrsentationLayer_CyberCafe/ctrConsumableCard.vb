Imports CyberCafeModels
Imports System.Drawing
Imports System.Windows.Forms

Public Class ctrConsumableCard


    Private Shared ReadOnly ClrSurface As Color = Color.FromArgb(15, 20, 40)
    Private Shared ReadOnly ClrBorder As Color = Color.FromArgb(26, 34, 64)
    Private Shared ReadOnly ClrBorderHover As Color = Color.FromArgb(0, 180, 220)

    Private Shared ReadOnly ClrAccent As Color = Color.FromArgb(0, 229, 255)

    Private Shared ReadOnly ClrGreen As Color = Color.FromArgb(0, 230, 118)
    Private Shared ReadOnly ClrOrange As Color = Color.FromArgb(255, 140, 0)
    Private Shared ReadOnly ClrRed As Color = Color.FromArgb(255, 61, 90)


    Private _stock As Integer

    Private _maxStock As Integer = 1
    Private _quantity As Integer = 1
    Private _isHovered As Boolean



    Public Event AddToCart(sender As ctrConsumableCard, quantity As Integer)

    Private Enum StockStatus
        Available
        LowStock
        OutOfStock
    End Enum

    Public Property ConsumableID As Integer

    Public Property CartQuantity As Integer
        Get
            Return _quantity
        End Get

        Set(value As Integer)

            _quantity = Math.Max(1, Math.Min(_stock, value))

            lblQty.Text = _quantity.ToString()

        End Set
    End Property



    Public Sub LoadData(consumable As ConsumableDTO)

        ConsumableID = consumable.ConsumableId
        lblName.Text = consumable.ConsumableName
        lblDesc.Text = consumable.Description
        lblPrice.Text = "$" & consumable.Price.ToString("0.00")
        _stock = consumable.Quantity
        _maxStock = Math.Max(1, _stock)

        Try
            Dim fullPath = UIHelper.GetImagePath(consumable.ImagePath)

            If Not String.IsNullOrWhiteSpace(consumable.ImagePath) AndAlso IO.File.Exists(fullPath) Then
                Using fs As New IO.FileStream(fullPath, IO.FileMode.Open, IO.FileAccess.Read)
                    picThumbnail.Image = Image.FromStream(fs)
                End Using
            Else
                picThumbnail.Image = Nothing
            End If

        Catch
            picThumbnail.Image = Nothing
        End Try

        picThumbnail.SizeMode = PictureBoxSizeMode.Zoom
        lblCategory.Text = "🍟 SNACK"
        RefreshStockUI()
    End Sub

    Private Function GetStockStatus() As StockStatus

        If _stock <= 0 Then
            Return StockStatus.OutOfStock
        End If

        If (_stock / CDbl(_maxStock)) <= 0.25 Then
            Return StockStatus.LowStock
        End If

        Return StockStatus.Available

    End Function

    Private Sub RefreshStockUI()

        Select Case GetStockStatus()

            Case StockStatus.Available

                lblStock.Text = $"{_stock} in stock"
                lblStock.ForeColor = ClrGreen

                lblStatus.Text = "AVAILABLE"
                lblStatus.ForeColor = ClrGreen

                btnAddToCart.Enabled = True
                btnPlus.Enabled = True
                btnMinus.Enabled = True

            Case StockStatus.LowStock

                lblStock.Text = $"{_stock} left!"
                lblStock.ForeColor = ClrOrange

                lblStatus.Text = "LOW STOCK"
                lblStatus.ForeColor = ClrOrange

                btnAddToCart.Enabled = True
                btnPlus.Enabled = True
                btnMinus.Enabled = True

            Case StockStatus.OutOfStock

                picThumbnail.Visible = False

                lblStock.Text = "OUT OF STOCK"
                lblStock.ForeColor = ClrRed

                lblStatus.Text = "UNAVAILABLE"
                lblStatus.ForeColor = ClrRed

                btnAddToCart.Enabled = False
                btnPlus.Enabled = False
                btnMinus.Enabled = False

                btnAddToCart.Text = "UNAVAILABLE"

        End Select

        pnlStockBar.Invalidate()

    End Sub


    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        CartQuantity += 1

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click

        CartQuantity -= 1

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        If _quantity <= _stock Then


            RaiseEvent AddToCart(Me, _quantity)

            _stock -= _quantity


            CartQuantity = 1
            RefreshStockUI()
        Else
            MessageBox.Show("Not enough stock!")
        End If


    End Sub

End Class

