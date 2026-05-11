<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerCart

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCloseWin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddConsumable = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFilter = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.cboCategoryFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.flpConsumbleCards = New System.Windows.Forms.FlowLayoutPanel()
        Me.ScrollBar = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.pnlInvoice = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpInvoiceItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlInvoiceHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblItemCount = New System.Windows.Forms.Label()
        Me.lblInvoiceTitle = New System.Windows.Forms.Label()
        Me.pnlInvoiceSeparator = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlInvoiceSummary = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblGrandTotalVal = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblTaxVal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotalVal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.pnlInvoiceActions = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPurchase = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlInvoice.SuspendLayout()
        Me.pnlInvoiceHeader.SuspendLayout()
        Me.pnlInvoiceSummary.SuspendLayout()
        Me.pnlInvoiceActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnCloseWin)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnAddConsumable)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1300, 56)
        Me.pnlHeader.TabIndex = 3
        '
        'btnCloseWin
        '
        Me.btnCloseWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseWin.BorderRadius = 20
        Me.btnCloseWin.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCloseWin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCloseWin.ForeColor = System.Drawing.Color.White
        Me.btnCloseWin.Location = New System.Drawing.Point(1253, 15)
        Me.btnCloseWin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCloseWin.Name = "btnCloseWin"
        Me.btnCloseWin.Size = New System.Drawing.Size(21, 17)
        Me.btnCloseWin.TabIndex = 2
        Me.btnCloseWin.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(17, 15)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(173, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🍔  Customer Cart"
        '
        'btnAddConsumable
        '
        Me.btnAddConsumable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddConsumable.BorderRadius = 8
        Me.btnAddConsumable.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddConsumable.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddConsumable.ForeColor = System.Drawing.Color.White
        Me.btnAddConsumable.Location = New System.Drawing.Point(1883, 13)
        Me.btnAddConsumable.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddConsumable.Name = "btnAddConsumable"
        Me.btnAddConsumable.Size = New System.Drawing.Size(137, 33)
        Me.btnAddConsumable.TabIndex = 1
        Me.btnAddConsumable.Text = "+  Add Item"
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Controls.Add(Me.btnSearch)
        Me.pnlFilter.Controls.Add(Me.cboCategoryFilter)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlFilter.Location = New System.Drawing.Point(0, 56)
        Me.pnlFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1300, 48)
        Me.pnlFilter.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(17, 7)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "🔍  Search items..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(257, 35)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 8
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(283, 7)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 35)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'cboCategoryFilter
        '
        Me.cboCategoryFilter.BackColor = System.Drawing.Color.Transparent
        Me.cboCategoryFilter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cboCategoryFilter.BorderRadius = 8
        Me.cboCategoryFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoryFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cboCategoryFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cboCategoryFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboCategoryFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cboCategoryFilter.ItemHeight = 30
        Me.cboCategoryFilter.Items.AddRange(New Object() {"All Categories", "Snacks", "Drinks", "Hot Food", "Merch"})
        Me.cboCategoryFilter.Location = New System.Drawing.Point(374, 7)
        Me.cboCategoryFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCategoryFilter.Name = "cboCategoryFilter"
        Me.cboCategoryFilter.Size = New System.Drawing.Size(138, 36)
        Me.cboCategoryFilter.TabIndex = 2
        '
        'flpConsumbleCards
        '
        Me.flpConsumbleCards.AutoScroll = True
        Me.flpConsumbleCards.Location = New System.Drawing.Point(1, 106)
        Me.flpConsumbleCards.Name = "flpConsumbleCards"
        Me.flpConsumbleCards.Size = New System.Drawing.Size(946, 486)
        Me.flpConsumbleCards.TabIndex = 6
        '
        'ScrollBar
        '
        Me.ScrollBar.BindingContainer = Me.flpConsumbleCards
        Me.ScrollBar.BorderRadius = 10
        Me.ScrollBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ScrollBar.HighlightOnWheel = True
        Me.ScrollBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ScrollBar.InUpdate = False
        Me.ScrollBar.LargeChange = 10
        Me.ScrollBar.Location = New System.Drawing.Point(927, 109)
        Me.ScrollBar.Margin = New System.Windows.Forms.Padding(1)
        Me.ScrollBar.Name = "ScrollBar"
        Me.ScrollBar.ScrollbarSize = 18
        Me.ScrollBar.Size = New System.Drawing.Size(18, 476)
        Me.ScrollBar.TabIndex = 1
        Me.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset
        '
        'pnlInvoice
        '
        Me.pnlInvoice.BackColor = System.Drawing.Color.Transparent
        Me.pnlInvoice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlInvoice.BorderRadius = 15
        Me.pnlInvoice.BorderThickness = 1
        Me.pnlInvoice.Controls.Add(Me.flpInvoiceItems)
        Me.pnlInvoice.Controls.Add(Me.pnlInvoiceHeader)
        Me.pnlInvoice.Controls.Add(Me.pnlInvoiceSeparator)
        Me.pnlInvoice.Controls.Add(Me.pnlInvoiceSummary)
        Me.pnlInvoice.Controls.Add(Me.pnlInvoiceActions)
        Me.pnlInvoice.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlInvoice.Location = New System.Drawing.Point(950, 104)
        Me.pnlInvoice.Name = "pnlInvoice"
        Me.pnlInvoice.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlInvoice.Size = New System.Drawing.Size(350, 486)
        Me.pnlInvoice.TabIndex = 7
        '
        'flpInvoiceItems
        '
        Me.flpInvoiceItems.AutoScroll = True
        Me.flpInvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpInvoiceItems.Location = New System.Drawing.Point(10, 50)
        Me.flpInvoiceItems.Name = "flpInvoiceItems"
        Me.flpInvoiceItems.Size = New System.Drawing.Size(330, 251)
        Me.flpInvoiceItems.TabIndex = 1
        '
        'pnlInvoiceHeader
        '
        Me.pnlInvoiceHeader.Controls.Add(Me.lblItemCount)
        Me.pnlInvoiceHeader.Controls.Add(Me.lblInvoiceTitle)
        Me.pnlInvoiceHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInvoiceHeader.Location = New System.Drawing.Point(10, 10)
        Me.pnlInvoiceHeader.Name = "pnlInvoiceHeader"
        Me.pnlInvoiceHeader.Size = New System.Drawing.Size(330, 40)
        Me.pnlInvoiceHeader.TabIndex = 0
        '
        'lblItemCount
        '
        Me.lblItemCount.AutoSize = True
        Me.lblItemCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblItemCount.Location = New System.Drawing.Point(165, 10)
        Me.lblItemCount.Name = "lblItemCount"
        Me.lblItemCount.Size = New System.Drawing.Size(56, 15)
        Me.lblItemCount.TabIndex = 1
        Me.lblItemCount.Text = "(0 items)"
        '
        'lblInvoiceTitle
        '
        Me.lblInvoiceTitle.AutoSize = True
        Me.lblInvoiceTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInvoiceTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblInvoiceTitle.Location = New System.Drawing.Point(5, 5)
        Me.lblInvoiceTitle.Name = "lblInvoiceTitle"
        Me.lblInvoiceTitle.Size = New System.Drawing.Size(167, 21)
        Me.lblInvoiceTitle.TabIndex = 0
        Me.lblInvoiceTitle.Text = "🧾 CURRENT ORDER"
        '
        'pnlInvoiceSeparator
        '
        Me.pnlInvoiceSeparator.BackColor = System.Drawing.Color.Transparent
        Me.pnlInvoiceSeparator.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlInvoiceSeparator.BorderThickness = 1
        Me.pnlInvoiceSeparator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInvoiceSeparator.Location = New System.Drawing.Point(10, 301)
        Me.pnlInvoiceSeparator.Name = "pnlInvoiceSeparator"
        Me.pnlInvoiceSeparator.Size = New System.Drawing.Size(330, 1)
        Me.pnlInvoiceSeparator.TabIndex = 4
        '
        'pnlInvoiceSummary
        '
        Me.pnlInvoiceSummary.Controls.Add(Me.lblGrandTotalVal)
        Me.pnlInvoiceSummary.Controls.Add(Me.lblGrandTotal)
        Me.pnlInvoiceSummary.Controls.Add(Me.lblTaxVal)
        Me.pnlInvoiceSummary.Controls.Add(Me.lblTax)
        Me.pnlInvoiceSummary.Controls.Add(Me.lblSubtotalVal)
        Me.pnlInvoiceSummary.Controls.Add(Me.lblSubtotal)
        Me.pnlInvoiceSummary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInvoiceSummary.Location = New System.Drawing.Point(10, 302)
        Me.pnlInvoiceSummary.Name = "pnlInvoiceSummary"
        Me.pnlInvoiceSummary.Size = New System.Drawing.Size(330, 100)
        Me.pnlInvoiceSummary.TabIndex = 2
        '
        'lblGrandTotalVal
        '
        Me.lblGrandTotalVal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrandTotalVal.AutoSize = True
        Me.lblGrandTotalVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrandTotalVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.lblGrandTotalVal.Location = New System.Drawing.Point(340, 55)
        Me.lblGrandTotalVal.Name = "lblGrandTotalVal"
        Me.lblGrandTotalVal.Size = New System.Drawing.Size(77, 32)
        Me.lblGrandTotalVal.TabIndex = 5
        Me.lblGrandTotalVal.Text = "$0.00"
        Me.lblGrandTotalVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblGrandTotal.Location = New System.Drawing.Point(8, 60)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(98, 21)
        Me.lblGrandTotal.TabIndex = 4
        Me.lblGrandTotal.Text = "Grand Total"
        '
        'lblTaxVal
        '
        Me.lblTaxVal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTaxVal.AutoSize = True
        Me.lblTaxVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTaxVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTaxVal.Location = New System.Drawing.Point(390, 30)
        Me.lblTaxVal.Name = "lblTaxVal"
        Me.lblTaxVal.Size = New System.Drawing.Size(38, 15)
        Me.lblTaxVal.TabIndex = 3
        Me.lblTaxVal.Text = "$0.00"
        Me.lblTaxVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblTax.Location = New System.Drawing.Point(10, 30)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(24, 15)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Tax"
        '
        'lblSubtotalVal
        '
        Me.lblSubtotalVal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalVal.AutoSize = True
        Me.lblSubtotalVal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubtotalVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblSubtotalVal.Location = New System.Drawing.Point(390, 10)
        Me.lblSubtotalVal.Name = "lblSubtotalVal"
        Me.lblSubtotalVal.Size = New System.Drawing.Size(38, 15)
        Me.lblSubtotalVal.TabIndex = 1
        Me.lblSubtotalVal.Text = "$0.00"
        Me.lblSubtotalVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblSubtotal.Location = New System.Drawing.Point(10, 10)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(51, 15)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal"
        '
        'pnlInvoiceActions
        '
        Me.pnlInvoiceActions.Controls.Add(Me.btnClear)
        Me.pnlInvoiceActions.Controls.Add(Me.btnPurchase)
        Me.pnlInvoiceActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInvoiceActions.Location = New System.Drawing.Point(10, 402)
        Me.pnlInvoiceActions.Name = "pnlInvoiceActions"
        Me.pnlInvoiceActions.Size = New System.Drawing.Size(330, 74)
        Me.pnlInvoiceActions.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClear.BorderRadius = 8
        Me.btnClear.BorderThickness = 1
        Me.btnClear.FillColor = System.Drawing.Color.Transparent
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(5, 50)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(320, 20)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "CLEAR ORDER"
        '
        'btnPurchase
        '
        Me.btnPurchase.BorderRadius = 10
        Me.btnPurchase.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnPurchase.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPurchase.ForeColor = System.Drawing.Color.Black
        Me.btnPurchase.Location = New System.Drawing.Point(5, 5)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(320, 40)
        Me.btnPurchase.TabIndex = 0
        Me.btnPurchase.Text = "PURCHASE"
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.BindingContainer = Me.flpConsumbleCards
        Me.Guna2VScrollBar1.BorderRadius = 10
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2VScrollBar1.HighlightOnWheel = True
        Me.Guna2VScrollBar1.HoverState.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(929, 106)
        Me.Guna2VScrollBar1.Margin = New System.Windows.Forms.Padding(1)
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.ScrollbarSize = 18
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(18, 486)
        Me.Guna2VScrollBar1.TabIndex = 1
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmCustomerCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 589)
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Controls.Add(Me.pnlInvoice)
        Me.Controls.Add(Me.flpConsumbleCards)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerCart"
        Me.Text = "frmManageConsumables"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlInvoice.ResumeLayout(False)
        Me.pnlInvoiceHeader.ResumeLayout(False)
        Me.pnlInvoiceHeader.PerformLayout()
        Me.pnlInvoiceSummary.ResumeLayout(False)
        Me.pnlInvoiceSummary.PerformLayout()
        Me.pnlInvoiceActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblTitle As Label
    Private WithEvents btnAddConsumable As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlFilter As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Private WithEvents cboCategoryFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents flpConsumbleCards As FlowLayoutPanel
    Friend WithEvents ScrollBar As Guna.UI2.WinForms.Guna2VScrollBar
    Private WithEvents btnCloseWin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlInvoice As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlInvoiceHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblInvoiceTitle As Label
    Friend WithEvents lblItemCount As Label
    Friend WithEvents flpInvoiceItems As FlowLayoutPanel
    Friend WithEvents pnlInvoiceSummary As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSubtotalVal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTaxVal As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents lblGrandTotalVal As Label
    Friend WithEvents pnlInvoiceActions As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPurchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlInvoiceSeparator As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
