<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoryManagement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlAlerts = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblAlertTitle = New System.Windows.Forms.Label()
        Me.flpAlerts = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlGridContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvInventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnWalkIn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbStockStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tlpStats = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlStatMostSold = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMostSoldVal = New System.Windows.Forms.Label()
        Me.lblMostSoldTitle = New System.Windows.Forms.Label()
        Me.pnlStatRevenue = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblRevVal = New System.Windows.Forms.Label()
        Me.lblRevTitle = New System.Windows.Forms.Label()
        Me.pnlStatOutOfStock = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblOutVal = New System.Windows.Forms.Label()
        Me.lblOutTitle = New System.Windows.Forms.Label()
        Me.pnlStatLowStock = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLowVal = New System.Windows.Forms.Label()
        Me.lblLowTitle = New System.Windows.Forms.Label()
        Me.pnlStatTotal = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotalVal = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain.SuspendLayout()
        Me.pnlAlerts.SuspendLayout()
        Me.pnlGridContainer.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.tlpStats.SuspendLayout()
        Me.pnlStatMostSold.SuspendLayout()
        Me.pnlStatRevenue.SuspendLayout()
        Me.pnlStatOutOfStock.SuspendLayout()
        Me.pnlStatLowStock.SuspendLayout()
        Me.pnlStatTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlAlerts)
        Me.pnlMain.Controls.Add(Me.pnlGridContainer)
        Me.pnlMain.Controls.Add(Me.pnlToolbar)
        Me.pnlMain.Controls.Add(Me.tlpStats)
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1200, 800)
        Me.pnlMain.TabIndex = 0
        '
        'pnlAlerts
        '
        Me.pnlAlerts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAlerts.BackColor = System.Drawing.Color.Transparent
        Me.pnlAlerts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlAlerts.BorderRadius = 15
        Me.pnlAlerts.BorderThickness = 1
        Me.pnlAlerts.Controls.Add(Me.lblAlertTitle)
        Me.pnlAlerts.Controls.Add(Me.flpAlerts)
        Me.pnlAlerts.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlAlerts.Location = New System.Drawing.Point(948, 280)
        Me.pnlAlerts.Name = "pnlAlerts"
        Me.pnlAlerts.Size = New System.Drawing.Size(240, 508)
        Me.pnlAlerts.TabIndex = 4
        '
        'lblAlertTitle
        '
        Me.lblAlertTitle.AutoSize = True
        Me.lblAlertTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAlertTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblAlertTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblAlertTitle.Name = "lblAlertTitle"
        Me.lblAlertTitle.Size = New System.Drawing.Size(165, 21)
        Me.lblAlertTitle.TabIndex = 1
        Me.lblAlertTitle.Text = "⚠️ CRITICAL ALERTS"
        '
        'flpAlerts
        '
        Me.flpAlerts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flpAlerts.Location = New System.Drawing.Point(12, 45)
        Me.flpAlerts.Name = "flpAlerts"
        Me.flpAlerts.Size = New System.Drawing.Size(215, 450)
        Me.flpAlerts.TabIndex = 0
        '
        'pnlGridContainer
        '
        Me.pnlGridContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGridContainer.BackColor = System.Drawing.Color.Transparent
        Me.pnlGridContainer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlGridContainer.BorderRadius = 15
        Me.pnlGridContainer.BorderThickness = 1
        Me.pnlGridContainer.Controls.Add(Me.dgvInventory)
        Me.pnlGridContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlGridContainer.Location = New System.Drawing.Point(12, 280)
        Me.pnlGridContainer.Name = "pnlGridContainer"
        Me.pnlGridContainer.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlGridContainer.Size = New System.Drawing.Size(920, 508)
        Me.pnlGridContainer.TabIndex = 3
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AllowUserToResizeColumns = False
        Me.dgvInventory.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvInventory.ColumnHeadersHeight = 40
        Me.dgvInventory.ContextMenuStrip = Me.cms
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvInventory.Location = New System.Drawing.Point(1, 1)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.RowTemplate.Height = 50
        Me.dgvInventory.Size = New System.Drawing.Size(918, 506)
        Me.dgvInventory.TabIndex = 0
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvInventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvInventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvInventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvInventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.dgvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventory.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvInventory.ThemeStyle.ReadOnly = True
        Me.dgvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.Height = 50
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'cms
        '
        Me.cms.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RestockToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms.Name = "cms"
        Me.cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cms.Size = New System.Drawing.Size(208, 94)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RestockToolStripMenuItem
        '
        Me.RestockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.RestockToolStripMenuItem.Name = "RestockToolStripMenuItem"
        Me.RestockToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.RestockToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.RestockToolStripMenuItem.Text = "    📦  Restock Inventory"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(227, 30)
        Me.DeleteToolStripMenuItem.Text = "    🗑  Delete Permanently"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlToolbar.BackColor = System.Drawing.Color.Transparent
        Me.pnlToolbar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlToolbar.BorderRadius = 15
        Me.pnlToolbar.BorderThickness = 1
        Me.pnlToolbar.Controls.Add(Me.btnWalkIn)
        Me.pnlToolbar.Controls.Add(Me.btnAdd)
        Me.pnlToolbar.Controls.Add(Me.cmbStockStatus)
        Me.pnlToolbar.Controls.Add(Me.cmbCategory)
        Me.pnlToolbar.Controls.Add(Me.txtSearch)
        Me.pnlToolbar.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlToolbar.Location = New System.Drawing.Point(20, 200)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1168, 65)
        Me.pnlToolbar.TabIndex = 2
        '
        'btnWalkIn
        '
        Me.btnWalkIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWalkIn.BorderRadius = 10
        Me.btnWalkIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWalkIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWalkIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWalkIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWalkIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnWalkIn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnWalkIn.ForeColor = System.Drawing.Color.Black
        Me.btnWalkIn.Location = New System.Drawing.Point(839, 12)
        Me.btnWalkIn.Name = "btnWalkIn"
        Me.btnWalkIn.Size = New System.Drawing.Size(145, 40)
        Me.btnWalkIn.TabIndex = 4
        Me.btnWalkIn.Text = "Walk In Sale"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(1008, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(145, 40)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "+ ADD NEW ITEM"
        '
        'cmbStockStatus
        '
        Me.cmbStockStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStockStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbStockStatus.BorderRadius = 10
        Me.cmbStockStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStockStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStockStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmbStockStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cmbStockStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cmbStockStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStockStatus.ForeColor = System.Drawing.Color.Silver
        Me.cmbStockStatus.ItemHeight = 34
        Me.cmbStockStatus.Items.AddRange(New Object() {"All", "In Stock", "Low Stock", "Out of Stock"})
        Me.cmbStockStatus.Location = New System.Drawing.Point(520, 12)
        Me.cmbStockStatus.Name = "cmbStockStatus"
        Me.cmbStockStatus.Size = New System.Drawing.Size(180, 40)
        Me.cmbStockStatus.StartIndex = 0
        Me.cmbStockStatus.TabIndex = 2
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbCategory.BorderRadius = 10
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.Silver
        Me.cmbCategory.ItemHeight = 34
        Me.cmbCategory.Items.AddRange(New Object() {"All Categories", "Drinks", "Snacks", "Accessories"})
        Me.cmbCategory.Location = New System.Drawing.Point(320, 12)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(180, 40)
        Me.cmbCategory.StartIndex = 0
        Me.cmbCategory.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(15, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtSearch.PlaceholderText = "Search items..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(280, 40)
        Me.txtSearch.TabIndex = 0
        '
        'tlpStats
        '
        Me.tlpStats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpStats.BackColor = System.Drawing.Color.Transparent
        Me.tlpStats.ColumnCount = 5
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpStats.Controls.Add(Me.pnlStatMostSold, 4, 0)
        Me.tlpStats.Controls.Add(Me.pnlStatRevenue, 3, 0)
        Me.tlpStats.Controls.Add(Me.pnlStatOutOfStock, 2, 0)
        Me.tlpStats.Controls.Add(Me.pnlStatLowStock, 1, 0)
        Me.tlpStats.Controls.Add(Me.pnlStatTotal, 0, 0)
        Me.tlpStats.Location = New System.Drawing.Point(15, 70)
        Me.tlpStats.Name = "tlpStats"
        Me.tlpStats.RowCount = 1
        Me.tlpStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStats.Size = New System.Drawing.Size(1173, 110)
        Me.tlpStats.TabIndex = 1
        '
        'pnlStatMostSold
        '
        Me.pnlStatMostSold.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlStatMostSold.BorderRadius = 15
        Me.pnlStatMostSold.BorderThickness = 1
        Me.pnlStatMostSold.Controls.Add(Me.lblMostSoldVal)
        Me.pnlStatMostSold.Controls.Add(Me.lblMostSoldTitle)
        Me.pnlStatMostSold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatMostSold.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlStatMostSold.Location = New System.Drawing.Point(941, 5)
        Me.pnlStatMostSold.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlStatMostSold.Name = "pnlStatMostSold"
        Me.pnlStatMostSold.Size = New System.Drawing.Size(227, 100)
        Me.pnlStatMostSold.TabIndex = 4
        '
        'lblMostSoldVal
        '
        Me.lblMostSoldVal.AutoSize = True
        Me.lblMostSoldVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblMostSoldVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblMostSoldVal.Location = New System.Drawing.Point(12, 45)
        Me.lblMostSoldVal.Name = "lblMostSoldVal"
        Me.lblMostSoldVal.Size = New System.Drawing.Size(98, 32)
        Me.lblMostSoldVal.TabIndex = 1
        Me.lblMostSoldVal.Text = "Embers"
        '
        'lblMostSoldTitle
        '
        Me.lblMostSoldTitle.AutoSize = True
        Me.lblMostSoldTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMostSoldTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblMostSoldTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblMostSoldTitle.Name = "lblMostSoldTitle"
        Me.lblMostSoldTitle.Size = New System.Drawing.Size(103, 19)
        Me.lblMostSoldTitle.TabIndex = 0
        Me.lblMostSoldTitle.Text = "Most Sold Item"
        '
        'pnlStatRevenue
        '
        Me.pnlStatRevenue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlStatRevenue.BorderRadius = 15
        Me.pnlStatRevenue.BorderThickness = 1
        Me.pnlStatRevenue.Controls.Add(Me.lblRevVal)
        Me.pnlStatRevenue.Controls.Add(Me.lblRevTitle)
        Me.pnlStatRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatRevenue.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlStatRevenue.Location = New System.Drawing.Point(707, 5)
        Me.pnlStatRevenue.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlStatRevenue.Name = "pnlStatRevenue"
        Me.pnlStatRevenue.Size = New System.Drawing.Size(224, 100)
        Me.pnlStatRevenue.TabIndex = 3
        '
        'lblRevVal
        '
        Me.lblRevVal.AutoSize = True
        Me.lblRevVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.lblRevVal.Location = New System.Drawing.Point(12, 45)
        Me.lblRevVal.Name = "lblRevVal"
        Me.lblRevVal.Size = New System.Drawing.Size(111, 41)
        Me.lblRevVal.TabIndex = 1
        Me.lblRevVal.Text = "$1,240"
        '
        'lblRevTitle
        '
        Me.lblRevTitle.AutoSize = True
        Me.lblRevTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblRevTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblRevTitle.Name = "lblRevTitle"
        Me.lblRevTitle.Size = New System.Drawing.Size(101, 19)
        Me.lblRevTitle.TabIndex = 0
        Me.lblRevTitle.Text = "Revenue Today"
        '
        'pnlStatOutOfStock
        '
        Me.pnlStatOutOfStock.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlStatOutOfStock.BorderRadius = 15
        Me.pnlStatOutOfStock.BorderThickness = 1
        Me.pnlStatOutOfStock.Controls.Add(Me.lblOutVal)
        Me.pnlStatOutOfStock.Controls.Add(Me.lblOutTitle)
        Me.pnlStatOutOfStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatOutOfStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlStatOutOfStock.Location = New System.Drawing.Point(473, 5)
        Me.pnlStatOutOfStock.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlStatOutOfStock.Name = "pnlStatOutOfStock"
        Me.pnlStatOutOfStock.Size = New System.Drawing.Size(224, 100)
        Me.pnlStatOutOfStock.TabIndex = 2
        '
        'lblOutVal
        '
        Me.lblOutVal.AutoSize = True
        Me.lblOutVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblOutVal.Location = New System.Drawing.Point(12, 45)
        Me.lblOutVal.Name = "lblOutVal"
        Me.lblOutVal.Size = New System.Drawing.Size(35, 41)
        Me.lblOutVal.TabIndex = 1
        Me.lblOutVal.Text = "3"
        '
        'lblOutTitle
        '
        Me.lblOutTitle.AutoSize = True
        Me.lblOutTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblOutTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblOutTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblOutTitle.Name = "lblOutTitle"
        Me.lblOutTitle.Size = New System.Drawing.Size(86, 19)
        Me.lblOutTitle.TabIndex = 0
        Me.lblOutTitle.Text = "Out of Stock"
        '
        'pnlStatLowStock
        '
        Me.pnlStatLowStock.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlStatLowStock.BorderRadius = 15
        Me.pnlStatLowStock.BorderThickness = 1
        Me.pnlStatLowStock.Controls.Add(Me.lblLowVal)
        Me.pnlStatLowStock.Controls.Add(Me.lblLowTitle)
        Me.pnlStatLowStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatLowStock.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlStatLowStock.Location = New System.Drawing.Point(239, 5)
        Me.pnlStatLowStock.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlStatLowStock.Name = "pnlStatLowStock"
        Me.pnlStatLowStock.Size = New System.Drawing.Size(224, 100)
        Me.pnlStatLowStock.TabIndex = 1
        '
        'lblLowVal
        '
        Me.lblLowVal.AutoSize = True
        Me.lblLowVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblLowVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLowVal.Location = New System.Drawing.Point(12, 45)
        Me.lblLowVal.Name = "lblLowVal"
        Me.lblLowVal.Size = New System.Drawing.Size(35, 41)
        Me.lblLowVal.TabIndex = 1
        Me.lblLowVal.Text = "8"
        '
        'lblLowTitle
        '
        Me.lblLowTitle.AutoSize = True
        Me.lblLowTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLowTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblLowTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblLowTitle.Name = "lblLowTitle"
        Me.lblLowTitle.Size = New System.Drawing.Size(109, 19)
        Me.lblLowTitle.TabIndex = 0
        Me.lblLowTitle.Text = "Low Stock Items"
        '
        'pnlStatTotal
        '
        Me.pnlStatTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlStatTotal.BorderRadius = 15
        Me.pnlStatTotal.BorderThickness = 1
        Me.pnlStatTotal.Controls.Add(Me.lblTotalVal)
        Me.pnlStatTotal.Controls.Add(Me.lblTotalTitle)
        Me.pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatTotal.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlStatTotal.Location = New System.Drawing.Point(5, 5)
        Me.pnlStatTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlStatTotal.Name = "pnlStatTotal"
        Me.pnlStatTotal.Size = New System.Drawing.Size(224, 100)
        Me.pnlStatTotal.TabIndex = 0
        '
        'lblTotalVal
        '
        Me.lblTotalVal.AutoSize = True
        Me.lblTotalVal.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTotalVal.Location = New System.Drawing.Point(12, 45)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Size = New System.Drawing.Size(52, 41)
        Me.lblTotalVal.TabIndex = 1
        Me.lblTotalVal.Text = "42"
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblTotalTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(76, 19)
        Me.lblTotalTitle.TabIndex = 0
        Me.lblTotalTitle.Text = "Total Items"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(443, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "INVENTORY MANAGEMENT"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        '
        'frmInventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventoryManagement"
        Me.Text = "Inventory Management"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlAlerts.ResumeLayout(False)
        Me.pnlAlerts.PerformLayout()
        Me.pnlGridContainer.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms.ResumeLayout(False)
        Me.pnlToolbar.ResumeLayout(False)
        Me.tlpStats.ResumeLayout(False)
        Me.pnlStatMostSold.ResumeLayout(False)
        Me.pnlStatMostSold.PerformLayout()
        Me.pnlStatRevenue.ResumeLayout(False)
        Me.pnlStatRevenue.PerformLayout()
        Me.pnlStatOutOfStock.ResumeLayout(False)
        Me.pnlStatOutOfStock.PerformLayout()
        Me.pnlStatLowStock.ResumeLayout(False)
        Me.pnlStatLowStock.PerformLayout()
        Me.pnlStatTotal.ResumeLayout(False)
        Me.pnlStatTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tlpStats As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlStatTotal As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalVal As System.Windows.Forms.Label
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatLowStock As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLowVal As System.Windows.Forms.Label
    Friend WithEvents lblLowTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatOutOfStock As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblOutVal As System.Windows.Forms.Label
    Friend WithEvents lblOutTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatRevenue As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblRevVal As System.Windows.Forms.Label
    Friend WithEvents lblRevTitle As System.Windows.Forms.Label
    Friend WithEvents pnlStatMostSold As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMostSoldVal As System.Windows.Forms.Label
    Friend WithEvents lblMostSoldTitle As System.Windows.Forms.Label
    Friend WithEvents pnlToolbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbStockStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlGridContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvInventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlAlerts As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAlertTitle As System.Windows.Forms.Label
    Friend WithEvents flpAlerts As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnWalkIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cms As ContextMenuStrip
    Friend WithEvents RestockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
