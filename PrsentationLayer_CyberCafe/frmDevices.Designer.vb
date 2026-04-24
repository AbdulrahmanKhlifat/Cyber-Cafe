<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFilter = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.cboTypeFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboStatusFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvDevices = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlDeviceDetail = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDetailTitle = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.lblDevNameF = New System.Windows.Forms.Label()
        Me.txtDeviceName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDevTypeF = New System.Windows.Forms.Label()
        Me.cboDeviceType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblStatusF = New System.Windows.Forms.Label()
        Me.cboStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSaveDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        CType(Me.dgvDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDeviceDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnAddDevice)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 59)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1393, 80)
        Me.pnlHeader.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(23, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🖥  Devices Management"
        '
        'btnAddDevice
        '
        Me.btnAddDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAddDevice.BorderRadius = 8
        Me.btnAddDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddDevice.ForeColor = System.Drawing.Color.White
        Me.btnAddDevice.Location = New System.Drawing.Point(1173, 10)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(160, 41)
        Me.btnAddDevice.TabIndex = 1
        Me.btnAddDevice.Text = "+  Add Device"
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Controls.Add(Me.btnSearch)
        Me.pnlFilter.Controls.Add(Me.cboTypeFilter)
        Me.pnlFilter.Controls.Add(Me.cboStatusFilter)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1393, 59)
        Me.pnlFilter.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.BorderRadius = 12
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(12, 11)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "🔍  Search by device name or IP..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(343, 43)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnSearch.BorderRadius = 15
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(377, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 43)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'cboTypeFilter
        '
        Me.cboTypeFilter.BackColor = System.Drawing.Color.Transparent
        Me.cboTypeFilter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cboTypeFilter.BorderRadius = 8
        Me.cboTypeFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cboTypeFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cboTypeFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboTypeFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cboTypeFilter.ItemHeight = 30
        Me.cboTypeFilter.Items.AddRange(New Object() {"All Types", "PC", "PS4", "PS5"})
        Me.cboTypeFilter.Location = New System.Drawing.Point(498, 13)
        Me.cboTypeFilter.Name = "cboTypeFilter"
        Me.cboTypeFilter.Size = New System.Drawing.Size(182, 36)
        Me.cboTypeFilter.TabIndex = 2
        '
        'cboStatusFilter
        '
        Me.cboStatusFilter.BackColor = System.Drawing.Color.Transparent
        Me.cboStatusFilter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cboStatusFilter.BorderRadius = 8
        Me.cboStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cboStatusFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cboStatusFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboStatusFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cboStatusFilter.ItemHeight = 30
        Me.cboStatusFilter.Items.AddRange(New Object() {"All Status", "Available", "In Use", "Maintenance"})
        Me.cboStatusFilter.Location = New System.Drawing.Point(694, 13)
        Me.cboStatusFilter.Name = "cboStatusFilter"
        Me.cboStatusFilter.Size = New System.Drawing.Size(177, 36)
        Me.cboStatusFilter.TabIndex = 3
        '
        'dgvDevices
        '
        Me.dgvDevices.AllowUserToAddRows = False
        Me.dgvDevices.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvDevices.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDevices.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDevices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDevices.ColumnHeadersHeight = 42
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDevices.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDevices.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvDevices.Location = New System.Drawing.Point(3, 141)
        Me.dgvDevices.MultiSelect = False
        Me.dgvDevices.Name = "dgvDevices"
        Me.dgvDevices.ReadOnly = True
        Me.dgvDevices.RowHeadersVisible = False
        Me.dgvDevices.RowHeadersWidth = 51
        Me.dgvDevices.RowTemplate.Height = 40
        Me.dgvDevices.Size = New System.Drawing.Size(1389, 601)
        Me.dgvDevices.TabIndex = 1
        Me.dgvDevices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvDevices.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDevices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDevices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDevices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDevices.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvDevices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvDevices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvDevices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDevices.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvDevices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.dgvDevices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDevices.ThemeStyle.HeaderStyle.Height = 42
        Me.dgvDevices.ThemeStyle.ReadOnly = True
        Me.dgvDevices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvDevices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDevices.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvDevices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvDevices.ThemeStyle.RowsStyle.Height = 40
        Me.dgvDevices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgvDevices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'pnlDeviceDetail
        '
        Me.pnlDeviceDetail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDeviceDetail.BorderThickness = 1
        Me.pnlDeviceDetail.Controls.Add(Me.lblDetailTitle)
        Me.pnlDeviceDetail.Controls.Add(Me.pnlDivider)
        Me.pnlDeviceDetail.Controls.Add(Me.lblDevNameF)
        Me.pnlDeviceDetail.Controls.Add(Me.txtDeviceName)
        Me.pnlDeviceDetail.Controls.Add(Me.lblDevTypeF)
        Me.pnlDeviceDetail.Controls.Add(Me.cboDeviceType)
        Me.pnlDeviceDetail.Controls.Add(Me.lblStatusF)
        Me.pnlDeviceDetail.Controls.Add(Me.cboStatus)
        Me.pnlDeviceDetail.Controls.Add(Me.btnSaveDevice)
        Me.pnlDeviceDetail.Controls.Add(Me.btnDeleteDevice)
        Me.pnlDeviceDetail.Controls.Add(Me.btnCancelDevice)
        Me.pnlDeviceDetail.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlDeviceDetail.Location = New System.Drawing.Point(981, 145)
        Me.pnlDeviceDetail.Name = "pnlDeviceDetail"
        Me.pnlDeviceDetail.Size = New System.Drawing.Size(411, 533)
        Me.pnlDeviceDetail.TabIndex = 0
        Me.pnlDeviceDetail.Visible = False
        '
        'lblDetailTitle
        '
        Me.lblDetailTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDetailTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblDetailTitle.Location = New System.Drawing.Point(17, 16)
        Me.lblDetailTitle.Name = "lblDetailTitle"
        Me.lblDetailTitle.Size = New System.Drawing.Size(377, 32)
        Me.lblDetailTitle.TabIndex = 0
        Me.lblDetailTitle.Text = "Device Details"
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDivider.Location = New System.Drawing.Point(0, 57)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(411, 1)
        Me.pnlDivider.TabIndex = 1
        '
        'lblDevNameF
        '
        Me.lblDevNameF.BackColor = System.Drawing.Color.Transparent
        Me.lblDevNameF.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDevNameF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDevNameF.Location = New System.Drawing.Point(18, 89)
        Me.lblDevNameF.Name = "lblDevNameF"
        Me.lblDevNameF.Size = New System.Drawing.Size(229, 19)
        Me.lblDevNameF.TabIndex = 2
        Me.lblDevNameF.Text = "DEVICE NAME"
        '
        'txtDeviceName
        '
        Me.txtDeviceName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtDeviceName.BorderRadius = 8
        Me.txtDeviceName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeviceName.DefaultText = ""
        Me.txtDeviceName.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtDeviceName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDeviceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtDeviceName.Location = New System.Drawing.Point(17, 131)
        Me.txtDeviceName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.PlaceholderText = ""
        Me.txtDeviceName.SelectedText = ""
        Me.txtDeviceName.Size = New System.Drawing.Size(377, 43)
        Me.txtDeviceName.TabIndex = 0
        '
        'lblDevTypeF
        '
        Me.lblDevTypeF.BackColor = System.Drawing.Color.Transparent
        Me.lblDevTypeF.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDevTypeF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDevTypeF.Location = New System.Drawing.Point(17, 200)
        Me.lblDevTypeF.Name = "lblDevTypeF"
        Me.lblDevTypeF.Size = New System.Drawing.Size(229, 19)
        Me.lblDevTypeF.TabIndex = 3
        Me.lblDevTypeF.Text = "DEVICE TYPE"
        '
        'cboDeviceType
        '
        Me.cboDeviceType.BackColor = System.Drawing.Color.Transparent
        Me.cboDeviceType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cboDeviceType.BorderRadius = 8
        Me.cboDeviceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeviceType.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboDeviceType.FocusedColor = System.Drawing.Color.Empty
        Me.cboDeviceType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboDeviceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cboDeviceType.ItemHeight = 30
        Me.cboDeviceType.Items.AddRange(New Object() {"PC", "PS4", "PS5"})
        Me.cboDeviceType.Location = New System.Drawing.Point(17, 222)
        Me.cboDeviceType.Name = "cboDeviceType"
        Me.cboDeviceType.Size = New System.Drawing.Size(377, 36)
        Me.cboDeviceType.TabIndex = 1
        '
        'lblStatusF
        '
        Me.lblStatusF.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusF.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatusF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblStatusF.Location = New System.Drawing.Point(18, 295)
        Me.lblStatusF.Name = "lblStatusF"
        Me.lblStatusF.Size = New System.Drawing.Size(229, 19)
        Me.lblStatusF.TabIndex = 5
        Me.lblStatusF.Text = "STATUS"
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cboStatus.BorderRadius = 8
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cboStatus.ItemHeight = 30
        Me.cboStatus.Items.AddRange(New Object() {"Available", "In Use", "Maintenance", "Offline"})
        Me.cboStatus.Location = New System.Drawing.Point(18, 317)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(377, 36)
        Me.cboStatus.TabIndex = 3
        '
        'btnSaveDevice
        '
        Me.btnSaveDevice.BorderRadius = 8
        Me.btnSaveDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSaveDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveDevice.ForeColor = System.Drawing.Color.White
        Me.btnSaveDevice.Location = New System.Drawing.Point(18, 382)
        Me.btnSaveDevice.Name = "btnSaveDevice"
        Me.btnSaveDevice.Size = New System.Drawing.Size(377, 45)
        Me.btnSaveDevice.TabIndex = 4
        Me.btnSaveDevice.Text = "Save Changes"
        '
        'btnDeleteDevice
        '
        Me.btnDeleteDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteDevice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDeleteDevice.BorderRadius = 12
        Me.btnDeleteDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnDeleteDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDeleteDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDeleteDevice.Location = New System.Drawing.Point(22, 437)
        Me.btnDeleteDevice.Name = "btnDeleteDevice"
        Me.btnDeleteDevice.Size = New System.Drawing.Size(181, 43)
        Me.btnDeleteDevice.TabIndex = 5
        Me.btnDeleteDevice.Text = "Delete"
        '
        'btnCancelDevice
        '
        Me.btnCancelDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancelDevice.BorderRadius = 8
        Me.btnCancelDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancelDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancelDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnCancelDevice.Location = New System.Drawing.Point(215, 437)
        Me.btnCancelDevice.Name = "btnCancelDevice"
        Me.btnCancelDevice.Size = New System.Drawing.Size(181, 43)
        Me.btnCancelDevice.TabIndex = 6
        Me.btnCancelDevice.Text = "Cancel"
        '
        'frmDevices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1393, 740)
        Me.Controls.Add(Me.pnlDeviceDetail)
        Me.Controls.Add(Me.dgvDevices)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFilter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDevices"
        Me.Text = "frmDevices"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        CType(Me.dgvDevices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDeviceDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblTitle As Label
    Private WithEvents btnAddDevice As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlFilter As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Private WithEvents cboTypeFilter As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents cboStatusFilter As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents dgvDevices As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents pnlDeviceDetail As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblDetailTitle As Label
    Private WithEvents pnlDivider As Panel
    Private WithEvents lblDevNameF As Label
    Private WithEvents txtDeviceName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblDevTypeF As Label
    Private WithEvents cboDeviceType As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents lblStatusF As Label
    Private WithEvents cboStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents btnSaveDevice As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnDeleteDevice As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnCancelDevice As Guna.UI2.WinForms.Guna2Button
End Class
