<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrConsumableCard
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblSoldCount = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAvaiabilitylDot = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnAddToCart = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlQty = New System.Windows.Forms.Panel()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.btnPlus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinus = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlLowWarn = New System.Windows.Forms.Panel()
        Me.lblWarningText = New System.Windows.Forms.Label()
        Me.lblWarningIcon = New System.Windows.Forms.Label()
        Me.pnlStockBar = New System.Windows.Forms.Panel()
        Me.pnlStockRow = New System.Windows.Forms.Panel()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblStockLabel = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picThumbnail = New System.Windows.Forms.PictureBox()
        Me.lblOutOfStockext = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.pnlOutOfStock = New System.Windows.Forms.Panel()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlBody.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlQty.SuspendLayout()
        Me.pnlLowWarn.SuspendLayout()
        Me.pnlStockRow.SuspendLayout()
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOutOfStock.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.Transparent
        Me.pnlBody.Controls.Add(Me.pnlFooter)
        Me.pnlBody.Controls.Add(Me.pnlControls)
        Me.pnlBody.Controls.Add(Me.pnlLowWarn)
        Me.pnlBody.Controls.Add(Me.pnlStockBar)
        Me.pnlBody.Controls.Add(Me.pnlStockRow)
        Me.pnlBody.Controls.Add(Me.pnlDivider)
        Me.pnlBody.Controls.Add(Me.lblDesc)
        Me.pnlBody.Controls.Add(Me.lblPrice)
        Me.pnlBody.Controls.Add(Me.lblName)
        Me.pnlBody.Location = New System.Drawing.Point(0, 105)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Padding = New System.Windows.Forms.Padding(12, 8, 12, 6)
        Me.pnlBody.Size = New System.Drawing.Size(209, 190)
        Me.pnlBody.TabIndex = 0
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.lblSoldCount)
        Me.pnlFooter.Controls.Add(Me.lblStatus)
        Me.pnlFooter.Controls.Add(Me.lblAvaiabilitylDot)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFooter.Location = New System.Drawing.Point(12, 144)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pnlFooter.Size = New System.Drawing.Size(185, 24)
        Me.pnlFooter.TabIndex = 0
        '
        'lblSoldCount
        '
        Me.lblSoldCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSoldCount.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblSoldCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblSoldCount.Location = New System.Drawing.Point(98, 0)
        Me.lblSoldCount.Name = "lblSoldCount"
        Me.lblSoldCount.Size = New System.Drawing.Size(85, 24)
        Me.lblSoldCount.TabIndex = 0
        Me.lblSoldCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(18, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(80, 24)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "AVAILABLE"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAvaiabilitylDot
        '
        Me.lblAvaiabilitylDot.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAvaiabilitylDot.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblAvaiabilitylDot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblAvaiabilitylDot.Location = New System.Drawing.Point(2, 0)
        Me.lblAvaiabilitylDot.Name = "lblAvaiabilitylDot"
        Me.lblAvaiabilitylDot.Size = New System.Drawing.Size(16, 24)
        Me.lblAvaiabilitylDot.TabIndex = 2
        Me.lblAvaiabilitylDot.Text = "●"
        Me.lblAvaiabilitylDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlControls.Controls.Add(Me.btnAddToCart)
        Me.pnlControls.Controls.Add(Me.pnlQty)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(12, 110)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(185, 34)
        Me.pnlControls.TabIndex = 1
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Animated = True
        Me.btnAddToCart.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddToCart.BorderRadius = 8
        Me.btnAddToCart.BorderThickness = 1
        Me.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddToCart.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddToCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddToCart.Location = New System.Drawing.Point(86, 0)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(99, 34)
        Me.btnAddToCart.TabIndex = 0
        Me.btnAddToCart.Text = "ADD TO CART"
        '
        'pnlQty
        '
        Me.pnlQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlQty.Controls.Add(Me.lblQty)
        Me.pnlQty.Controls.Add(Me.btnPlus)
        Me.pnlQty.Controls.Add(Me.btnMinus)
        Me.pnlQty.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlQty.Location = New System.Drawing.Point(0, 0)
        Me.pnlQty.Name = "pnlQty"
        Me.pnlQty.Size = New System.Drawing.Size(86, 34)
        Me.pnlQty.TabIndex = 1
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.Transparent
        Me.lblQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblQty.Location = New System.Drawing.Point(28, 0)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(30, 34)
        Me.lblQty.TabIndex = 0
        Me.lblQty.Text = "1"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlus
        '
        Me.btnPlus.Animated = True
        Me.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlus.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPlus.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPlus.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnPlus.ForeColor = System.Drawing.Color.White
        Me.btnPlus.Location = New System.Drawing.Point(58, 0)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(28, 34)
        Me.btnPlus.TabIndex = 1
        Me.btnPlus.Text = "+"
        Me.btnPlus.TextFormatNoPrefix = True
        '
        'btnMinus
        '
        Me.btnMinus.Animated = True
        Me.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMinus.FillColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMinus.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnMinus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnMinus.Location = New System.Drawing.Point(0, 0)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(28, 34)
        Me.btnMinus.TabIndex = 2
        Me.btnMinus.Text = "−"
        Me.btnMinus.TextFormatNoPrefix = True
        '
        'pnlLowWarn
        '
        Me.pnlLowWarn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlLowWarn.Controls.Add(Me.lblWarningText)
        Me.pnlLowWarn.Controls.Add(Me.lblWarningIcon)
        Me.pnlLowWarn.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLowWarn.Location = New System.Drawing.Point(12, 86)
        Me.pnlLowWarn.Name = "pnlLowWarn"
        Me.pnlLowWarn.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pnlLowWarn.Size = New System.Drawing.Size(185, 24)
        Me.pnlLowWarn.TabIndex = 2
        Me.pnlLowWarn.Visible = False
        '
        'lblWarningText
        '
        Me.lblWarningText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWarningText.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblWarningText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWarningText.Location = New System.Drawing.Point(26, 0)
        Me.lblWarningText.Name = "lblWarningText"
        Me.lblWarningText.Size = New System.Drawing.Size(155, 24)
        Me.lblWarningText.TabIndex = 0
        Me.lblWarningText.Text = "LOW STOCK — REORDER SOON"
        Me.lblWarningText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWarningIcon
        '
        Me.lblWarningIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblWarningIcon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWarningIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWarningIcon.Location = New System.Drawing.Point(4, 0)
        Me.lblWarningIcon.Name = "lblWarningIcon"
        Me.lblWarningIcon.Size = New System.Drawing.Size(22, 24)
        Me.lblWarningIcon.TabIndex = 1
        Me.lblWarningIcon.Text = "⚠"
        Me.lblWarningIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStockBar
        '
        Me.pnlStockBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlStockBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStockBar.Location = New System.Drawing.Point(12, 81)
        Me.pnlStockBar.Name = "pnlStockBar"
        Me.pnlStockBar.Size = New System.Drawing.Size(185, 5)
        Me.pnlStockBar.TabIndex = 3
        '
        'pnlStockRow
        '
        Me.pnlStockRow.BackColor = System.Drawing.Color.Transparent
        Me.pnlStockRow.Controls.Add(Me.lblStock)
        Me.pnlStockRow.Controls.Add(Me.lblStockLabel)
        Me.pnlStockRow.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStockRow.Location = New System.Drawing.Point(12, 59)
        Me.pnlStockRow.Name = "pnlStockRow"
        Me.pnlStockRow.Size = New System.Drawing.Size(185, 22)
        Me.pnlStockRow.TabIndex = 4
        '
        'lblStock
        '
        Me.lblStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblStock.Location = New System.Drawing.Point(50, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(135, 22)
        Me.lblStock.TabIndex = 0
        Me.lblStock.Text = "-- in stock"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStockLabel
        '
        Me.lblStockLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStockLabel.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblStockLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblStockLabel.Location = New System.Drawing.Point(0, 0)
        Me.lblStockLabel.Name = "lblStockLabel"
        Me.lblStockLabel.Size = New System.Drawing.Size(50, 22)
        Me.lblStockLabel.TabIndex = 1
        Me.lblStockLabel.Text = "STOCK"
        Me.lblStockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDivider.Location = New System.Drawing.Point(12, 58)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(185, 1)
        Me.pnlDivider.TabIndex = 5
        '
        'lblDesc
        '
        Me.lblDesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.lblDesc.Location = New System.Drawing.Point(12, 30)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(185, 28)
        Me.lblDesc.TabIndex = 6
        Me.lblDesc.Text = "Short product description"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(159, 8)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.lblPrice.Size = New System.Drawing.Size(48, 19)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "$0.00"
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(12, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(185, 22)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Product Name"
        '
        'picThumbnail
        '
        Me.picThumbnail.BackColor = System.Drawing.Color.Transparent
        Me.picThumbnail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picThumbnail.Location = New System.Drawing.Point(12, 10)
        Me.picThumbnail.Name = "picThumbnail"
        Me.picThumbnail.Size = New System.Drawing.Size(187, 92)
        Me.picThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picThumbnail.TabIndex = 0
        Me.picThumbnail.TabStop = False
        '
        'lblOutOfStockext
        '
        Me.lblOutOfStockext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutOfStockext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblOutOfStockext.Location = New System.Drawing.Point(50, 40)
        Me.lblOutOfStockext.Name = "lblOutOfStockext"
        Me.lblOutOfStockext.Size = New System.Drawing.Size(110, 23)
        Me.lblOutOfStockext.TabIndex = 0
        Me.lblOutOfStockext.Text = "OUT OF STOCK"
        Me.lblOutOfStockext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(-2, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.lblCategory.Size = New System.Drawing.Size(66, 18)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.Text = "💧  DRINK"
        '
        'pnlOutOfStock
        '
        Me.pnlOutOfStock.AutoSize = True
        Me.pnlOutOfStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlOutOfStock.Controls.Add(Me.lblOutOfStockext)
        Me.pnlOutOfStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOutOfStock.Location = New System.Drawing.Point(0, 0)
        Me.pnlOutOfStock.Name = "pnlOutOfStock"
        Me.pnlOutOfStock.Size = New System.Drawing.Size(211, 296)
        Me.pnlOutOfStock.TabIndex = 1
        Me.pnlOutOfStock.Visible = False
        '
        'pnlImage
        '
        Me.pnlImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlImage.Controls.Add(Me.picThumbnail)
        Me.pnlImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlImage.Location = New System.Drawing.Point(0, 0)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Padding = New System.Windows.Forms.Padding(12, 10, 12, 8)
        Me.pnlImage.Size = New System.Drawing.Size(211, 110)
        Me.pnlImage.TabIndex = 1
        '
        'elipse
        '
        Me.elipse.BorderRadius = 20
        Me.elipse.TargetControl = Me
        '
        'ctrConsumableCard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.pnlImage)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.pnlOutOfStock)
        Me.Name = "ctrConsumableCard"
        Me.Size = New System.Drawing.Size(211, 296)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.pnlQty.ResumeLayout(False)
        Me.pnlLowWarn.ResumeLayout(False)
        Me.pnlStockRow.ResumeLayout(False)
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOutOfStock.ResumeLayout(False)
        Me.pnlImage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblSoldCount As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblAvaiabilitylDot As Label
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnAddToCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlQty As Panel
    Friend WithEvents lblQty As Label
    Friend WithEvents btnPlus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlLowWarn As Panel
    Friend WithEvents lblWarningText As Label
    Friend WithEvents lblWarningIcon As Label
    Friend WithEvents pnlStockBar As Panel
    Friend WithEvents pnlStockRow As Panel
    Friend WithEvents lblStock As Label
    Friend WithEvents lblStockLabel As Label
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblName As Label
    Friend WithEvents picThumbnail As PictureBox
    Friend WithEvents lblOutOfStockext As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents pnlOutOfStock As Panel
    Friend WithEvents pnlImage As Panel
    Friend WithEvents elipse As Guna.UI2.WinForms.Guna2Elipse
End Class
