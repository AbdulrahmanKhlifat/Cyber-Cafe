<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDevices
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbDeviceType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlDeviceDetail = New System.Windows.Forms.Panel()
        Me.nUpDownPrice = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.lblDetailTitle = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.lblDevNameF = New System.Windows.Forms.Label()
        Me.txtDeviceName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDevTypeF = New System.Windows.Forms.Label()
        Me.cboDeviceType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblStatusF = New System.Windows.Forms.Label()
        Me.btnSaveDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.flpDevices = New System.Windows.Forms.FlowLayoutPanel()
        Me.ScrollBar = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.pnlTop.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlDeviceDetail.SuspendLayout()
        CType(Me.nUpDownPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🖥  Devices Management"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1341, 66)
        Me.pnlTop.TabIndex = 7
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Controls.Add(Me.cmbStatus)
        Me.pnlFilter.Controls.Add(Me.btnSearch)
        Me.pnlFilter.Controls.Add(Me.btnAddDevice)
        Me.pnlFilter.Controls.Add(Me.cmbDeviceType)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 66)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1341, 64)
        Me.pnlFilter.TabIndex = 8
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.BorderRadius = 12
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(18, 8)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "🔍  Search by device name or IP..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(343, 43)
        Me.txtSearch.TabIndex = 4
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbStatus.BorderRadius = 8
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cmbStatus.ItemHeight = 30
        Me.cmbStatus.Items.AddRange(New Object() {"All Status", "Available", "In Use", "Maintenance"})
        Me.cmbStatus.Location = New System.Drawing.Point(367, 12)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(177, 36)
        Me.cmbStatus.StartIndex = 0
        Me.cmbStatus.TabIndex = 8
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.BorderRadius = 15
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(768, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 43)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        '
        'btnAddDevice
        '
        Me.btnAddDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddDevice.BorderRadius = 8
        Me.btnAddDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddDevice.ForeColor = System.Drawing.Color.White
        Me.btnAddDevice.Location = New System.Drawing.Point(1129, 6)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(165, 46)
        Me.btnAddDevice.TabIndex = 5
        Me.btnAddDevice.Text = "+  Add Device"
        '
        'cmbDeviceType
        '
        Me.cmbDeviceType.BackColor = System.Drawing.Color.Transparent
        Me.cmbDeviceType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbDeviceType.BorderRadius = 8
        Me.cmbDeviceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeviceType.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbDeviceType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbDeviceType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDeviceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cmbDeviceType.ItemHeight = 30
        Me.cmbDeviceType.Items.AddRange(New Object() {"All Types", "PC", "Playstation 5", "Xbox", "Virtual Reality"})
        Me.cmbDeviceType.Location = New System.Drawing.Point(559, 12)
        Me.cmbDeviceType.Name = "cmbDeviceType"
        Me.cmbDeviceType.Size = New System.Drawing.Size(182, 36)
        Me.cmbDeviceType.StartIndex = 0
        Me.cmbDeviceType.TabIndex = 7
        '
        'pnlDeviceDetail
        '
        Me.pnlDeviceDetail.Controls.Add(Me.nUpDownPrice)
        Me.pnlDeviceDetail.Controls.Add(Me.lblDetailTitle)
        Me.pnlDeviceDetail.Controls.Add(Me.pnlDivider)
        Me.pnlDeviceDetail.Controls.Add(Me.lblDevNameF)
        Me.pnlDeviceDetail.Controls.Add(Me.txtDeviceName)
        Me.pnlDeviceDetail.Controls.Add(Me.lblDevTypeF)
        Me.pnlDeviceDetail.Controls.Add(Me.cboDeviceType)
        Me.pnlDeviceDetail.Controls.Add(Me.lblStatusF)
        Me.pnlDeviceDetail.Controls.Add(Me.btnSaveDevice)
        Me.pnlDeviceDetail.Controls.Add(Me.btnDeleteDevice)
        Me.pnlDeviceDetail.Controls.Add(Me.btnCancelDevice)
        Me.pnlDeviceDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDeviceDetail.Location = New System.Drawing.Point(932, 130)
        Me.pnlDeviceDetail.Name = "pnlDeviceDetail"
        Me.pnlDeviceDetail.Size = New System.Drawing.Size(409, 591)
        Me.pnlDeviceDetail.TabIndex = 10
        Me.pnlDeviceDetail.Visible = False
        '
        'nUpDownPrice
        '
        Me.nUpDownPrice.BackColor = System.Drawing.Color.Transparent
        Me.nUpDownPrice.BorderRadius = 5
        Me.nUpDownPrice.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.nUpDownPrice.BorderThickness = 0
        Me.nUpDownPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nUpDownPrice.DecimalPlaces = 2
        Me.nUpDownPrice.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.nUpDownPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nUpDownPrice.ForeColor = System.Drawing.Color.White
        Me.nUpDownPrice.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nUpDownPrice.Location = New System.Drawing.Point(16, 317)
        Me.nUpDownPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nUpDownPrice.Name = "nUpDownPrice"
        Me.nUpDownPrice.Size = New System.Drawing.Size(360, 48)
        Me.nUpDownPrice.TabIndex = 18
        Me.nUpDownPrice.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.nUpDownPrice.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nUpDownPrice.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'lblDetailTitle
        '
        Me.lblDetailTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDetailTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblDetailTitle.Location = New System.Drawing.Point(15, 11)
        Me.lblDetailTitle.Name = "lblDetailTitle"
        Me.lblDetailTitle.Size = New System.Drawing.Size(377, 32)
        Me.lblDetailTitle.TabIndex = 8
        Me.lblDetailTitle.Text = "Device Details"
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDivider.Location = New System.Drawing.Point(-2, 52)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(411, 1)
        Me.pnlDivider.TabIndex = 10
        '
        'lblDevNameF
        '
        Me.lblDevNameF.BackColor = System.Drawing.Color.Transparent
        Me.lblDevNameF.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDevNameF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDevNameF.Location = New System.Drawing.Point(14, 84)
        Me.lblDevNameF.Name = "lblDevNameF"
        Me.lblDevNameF.Size = New System.Drawing.Size(229, 19)
        Me.lblDevNameF.TabIndex = 12
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
        Me.txtDeviceName.Location = New System.Drawing.Point(14, 126)
        Me.txtDeviceName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.PlaceholderText = ""
        Me.txtDeviceName.SelectedText = ""
        Me.txtDeviceName.Size = New System.Drawing.Size(365, 43)
        Me.txtDeviceName.TabIndex = 9
        '
        'lblDevTypeF
        '
        Me.lblDevTypeF.BackColor = System.Drawing.Color.Transparent
        Me.lblDevTypeF.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDevTypeF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDevTypeF.Location = New System.Drawing.Point(15, 195)
        Me.lblDevTypeF.Name = "lblDevTypeF"
        Me.lblDevTypeF.Size = New System.Drawing.Size(229, 19)
        Me.lblDevTypeF.TabIndex = 13
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
        Me.cboDeviceType.Location = New System.Drawing.Point(15, 217)
        Me.cboDeviceType.Name = "cboDeviceType"
        Me.cboDeviceType.Size = New System.Drawing.Size(365, 36)
        Me.cboDeviceType.TabIndex = 11
        '
        'lblStatusF
        '
        Me.lblStatusF.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusF.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatusF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblStatusF.Location = New System.Drawing.Point(15, 290)
        Me.lblStatusF.Name = "lblStatusF"
        Me.lblStatusF.Size = New System.Drawing.Size(229, 19)
        Me.lblStatusF.TabIndex = 15
        Me.lblStatusF.Text = "Price Per Hour"
        '
        'btnSaveDevice
        '
        Me.btnSaveDevice.BorderRadius = 8
        Me.btnSaveDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSaveDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveDevice.ForeColor = System.Drawing.Color.White
        Me.btnSaveDevice.Location = New System.Drawing.Point(16, 377)
        Me.btnSaveDevice.Name = "btnSaveDevice"
        Me.btnSaveDevice.Size = New System.Drawing.Size(364, 45)
        Me.btnSaveDevice.TabIndex = 14
        Me.btnSaveDevice.Text = "Save Changes"
        '
        'btnDeleteDevice
        '
        Me.btnDeleteDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteDevice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDeleteDevice.BorderRadius = 12
        Me.btnDeleteDevice.FillColor = System.Drawing.Color.DimGray
        Me.btnDeleteDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDeleteDevice.ForeColor = System.Drawing.Color.White
        Me.btnDeleteDevice.Location = New System.Drawing.Point(18, 432)
        Me.btnDeleteDevice.Name = "btnDeleteDevice"
        Me.btnDeleteDevice.Size = New System.Drawing.Size(181, 43)
        Me.btnDeleteDevice.TabIndex = 16
        Me.btnDeleteDevice.Text = "Clear"
        '
        'btnCancelDevice
        '
        Me.btnCancelDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancelDevice.BorderRadius = 8
        Me.btnCancelDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancelDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancelDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnCancelDevice.Location = New System.Drawing.Point(213, 432)
        Me.btnCancelDevice.Name = "btnCancelDevice"
        Me.btnCancelDevice.Size = New System.Drawing.Size(167, 43)
        Me.btnCancelDevice.TabIndex = 17
        Me.btnCancelDevice.Text = "Cancel"
        '
        'flpDevices
        '
        Me.flpDevices.AutoScroll = True
        Me.flpDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpDevices.Location = New System.Drawing.Point(0, 130)
        Me.flpDevices.Name = "flpDevices"
        Me.flpDevices.Size = New System.Drawing.Size(932, 591)
        Me.flpDevices.TabIndex = 11
        '
        'ScrollBar
        '
        Me.ScrollBar.BindingContainer = Me.flpDevices
        Me.ScrollBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ScrollBar.HighlightOnWheel = True
        Me.ScrollBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ScrollBar.InUpdate = False
        Me.ScrollBar.LargeChange = 591
        Me.ScrollBar.Location = New System.Drawing.Point(911, 130)
        Me.ScrollBar.Margin = New System.Windows.Forms.Padding(1)
        Me.ScrollBar.Maximum = 592
        Me.ScrollBar.Name = "ScrollBar"
        Me.ScrollBar.ScrollbarSize = 21
        Me.ScrollBar.Size = New System.Drawing.Size(21, 591)
        Me.ScrollBar.SmallChange = 5
        Me.ScrollBar.TabIndex = 0
        Me.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(26, Byte), Integer))
        '
        'frmDevices
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 721)
        Me.Controls.Add(Me.ScrollBar)
        Me.Controls.Add(Me.flpDevices)
        Me.Controls.Add(Me.pnlDeviceDetail)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDevices"
        Me.Text = "frmDevices"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlDeviceDetail.ResumeLayout(False)
        CType(Me.nUpDownPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblTitle As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlFilter As Panel
    Private WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnAddDevice As Guna.UI2.WinForms.Guna2Button
    Private WithEvents cmbDeviceType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents pnlDeviceDetail As Panel
    Friend WithEvents nUpDownPrice As Guna.UI2.WinForms.Guna2NumericUpDown
    Private WithEvents lblDetailTitle As Label
    Private WithEvents pnlDivider As Panel
    Private WithEvents lblDevNameF As Label
    Private WithEvents txtDeviceName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblDevTypeF As Label
    Private WithEvents cboDeviceType As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents lblStatusF As Label
    Private WithEvents btnSaveDevice As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnDeleteDevice As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnCancelDevice As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpDevices As FlowLayoutPanel
    Friend WithEvents ScrollBar As Guna.UI2.WinForms.Guna2VScrollBar
End Class
