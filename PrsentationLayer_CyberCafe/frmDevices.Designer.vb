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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevices))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
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
        Me.btnClearDeviceInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelDevice = New Guna.UI2.WinForms.Guna2Button()
        Me.flpDevices = New System.Windows.Forms.FlowLayoutPanel()
        Me.ScrollBar = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.DeviceContextMenu = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.tsShowDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsUpdateDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAssignGames = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsDeleteDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.pnlTop.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlDeviceDetail.SuspendLayout()
        CType(Me.nUpDownPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeviceContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.lblTitle, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.pnlTop, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.pnlFilter.Controls.Add(Me.btnAddDevice)
        Me.pnlFilter.Controls.Add(Me.cmbDeviceType)
        Me.Guna2Transition1.SetDecoration(Me.pnlFilter, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 66)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1341, 64)
        Me.pnlFilter.TabIndex = 8
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.BorderRadius = 12
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtSearch, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.cmbStatus, Guna.UI2.AnimatorNS.DecorationType.None)
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
        'btnAddDevice
        '
        Me.btnAddDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddDevice.BorderRadius = 8
        Me.Guna2Transition1.SetDecoration(Me.btnAddDevice, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.cmbDeviceType, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.cmbDeviceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeviceType.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbDeviceType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbDeviceType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDeviceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cmbDeviceType.ItemHeight = 30
        Me.cmbDeviceType.Items.AddRange(New Object() {"All Types", "PC", "PS4", "PS5", "XBOX", "Virtual Reality"})
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
        Me.pnlDeviceDetail.Controls.Add(Me.btnClearDeviceInfo)
        Me.pnlDeviceDetail.Controls.Add(Me.btnCancelDevice)
        Me.Guna2Transition1.SetDecoration(Me.pnlDeviceDetail, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.nUpDownPrice, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.lblDetailTitle, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.pnlDivider, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlDivider.Location = New System.Drawing.Point(-2, 52)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(411, 1)
        Me.pnlDivider.TabIndex = 10
        '
        'lblDevNameF
        '
        Me.lblDevNameF.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.lblDevNameF, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.txtDeviceName, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.lblDevTypeF, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.cboDeviceType, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.lblStatusF, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.btnSaveDevice, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnSaveDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSaveDevice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveDevice.ForeColor = System.Drawing.Color.White
        Me.btnSaveDevice.Location = New System.Drawing.Point(16, 377)
        Me.btnSaveDevice.Name = "btnSaveDevice"
        Me.btnSaveDevice.Size = New System.Drawing.Size(364, 45)
        Me.btnSaveDevice.TabIndex = 14
        Me.btnSaveDevice.Text = "Save Changes"
        '
        'btnClearDeviceInfo
        '
        Me.btnClearDeviceInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClearDeviceInfo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClearDeviceInfo.BorderRadius = 12
        Me.Guna2Transition1.SetDecoration(Me.btnClearDeviceInfo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnClearDeviceInfo.FillColor = System.Drawing.Color.DimGray
        Me.btnClearDeviceInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClearDeviceInfo.ForeColor = System.Drawing.Color.White
        Me.btnClearDeviceInfo.Location = New System.Drawing.Point(18, 432)
        Me.btnClearDeviceInfo.Name = "btnClearDeviceInfo"
        Me.btnClearDeviceInfo.Size = New System.Drawing.Size(181, 43)
        Me.btnClearDeviceInfo.TabIndex = 16
        Me.btnClearDeviceInfo.Text = "Clear"
        '
        'btnCancelDevice
        '
        Me.btnCancelDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancelDevice.BorderRadius = 8
        Me.Guna2Transition1.SetDecoration(Me.btnCancelDevice, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.flpDevices, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.flpDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpDevices.Location = New System.Drawing.Point(0, 130)
        Me.flpDevices.Name = "flpDevices"
        Me.flpDevices.Size = New System.Drawing.Size(932, 591)
        Me.flpDevices.TabIndex = 11
        '
        'ScrollBar
        '
        Me.ScrollBar.BindingContainer = Me.flpDevices
        Me.ScrollBar.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.ScrollBar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ScrollBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ScrollBar.HighlightOnWheel = True
        Me.ScrollBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ScrollBar.InUpdate = False
        Me.ScrollBar.LargeChange = 591
        Me.ScrollBar.Location = New System.Drawing.Point(914, 130)
        Me.ScrollBar.Margin = New System.Windows.Forms.Padding(1)
        Me.ScrollBar.Maximum = 592
        Me.ScrollBar.Name = "ScrollBar"
        Me.ScrollBar.ScrollbarSize = 18
        Me.ScrollBar.Size = New System.Drawing.Size(18, 591)
        Me.ScrollBar.SmallChange = 5
        Me.ScrollBar.TabIndex = 0
        Me.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        Me.Guna2Transition1.Interval = 1
        Me.Guna2Transition1.MaxAnimationTime = 300
        Me.Guna2Transition1.TimeStep = 0.05!
        '
        'DeviceContextMenu
        '
        Me.DeviceContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.DeviceContextMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DeviceContextMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.DeviceContextMenu.ForeColor = System.Drawing.Color.White
        Me.DeviceContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DeviceContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsShowDetails, Me.tsUpdateDevice, Me.tsAssignGames, Me.tsDeleteDevice})
        Me.DeviceContextMenu.Name = "DeviceContextMenu"
        Me.DeviceContextMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.DeviceContextMenu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DeviceContextMenu.RenderStyle.ColorTable = Nothing
        Me.DeviceContextMenu.RenderStyle.RoundedEdges = True
        Me.DeviceContextMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DeviceContextMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.DeviceContextMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DeviceContextMenu.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.DeviceContextMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Me.DeviceContextMenu.Size = New System.Drawing.Size(191, 114)
        '
        'tsShowDetails
        '
        Me.tsShowDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsShowDetails.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.info_40dp_E3E3E3_FILL0_wght400_GRAD0_opsz40
        Me.tsShowDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsShowDetails.Name = "tsShowDetails"
        Me.tsShowDetails.Size = New System.Drawing.Size(190, 26)
        Me.tsShowDetails.Text = "Show Details"
        '
        'tsUpdateDevice
        '
        Me.tsUpdateDevice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdateDevice.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources._3567018
        Me.tsUpdateDevice.Name = "tsUpdateDevice"
        Me.tsUpdateDevice.Size = New System.Drawing.Size(190, 26)
        Me.tsUpdateDevice.Text = "Update Device"
        '
        'tsAssignGames
        '
        Me.tsAssignGames.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsAssignGames.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources._771247
        Me.tsAssignGames.Name = "tsAssignGames"
        Me.tsAssignGames.Padding = New System.Windows.Forms.Padding(4)
        Me.tsAssignGames.Size = New System.Drawing.Size(198, 32)
        Me.tsAssignGames.Text = "Assign Games"
        '
        'tsDeleteDevice
        '
        Me.tsDeleteDevice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDeleteDevice.ForeColor = System.Drawing.Color.GreenYellow
        Me.tsDeleteDevice.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.start_icon_start_website_button_on_white_background_HYCG99_removebg_preview
        Me.tsDeleteDevice.Name = "tsDeleteDevice"
        Me.tsDeleteDevice.Size = New System.Drawing.Size(190, 26)
        Me.tsDeleteDevice.Text = "Start Session"
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        Me.Guna2Transition1.Interval = 1
        Me.Guna2Transition1.MaxAnimationTime = 300
        Me.Guna2Transition1.TimeStep = 0.05!
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
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDevices"
        Me.Text = "frmDevices"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlDeviceDetail.ResumeLayout(False)
        CType(Me.nUpDownPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeviceContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblTitle As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlFilter As Panel
    Private WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
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
    Private WithEvents btnClearDeviceInfo As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnCancelDevice As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpDevices As FlowLayoutPanel
    Friend WithEvents ScrollBar As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents DeviceContextMenu As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents tsShowDetails As ToolStripMenuItem
    Friend WithEvents tsUpdateDevice As ToolStripMenuItem
    Friend WithEvents tsAssignGames As ToolStripMenuItem
    Friend WithEvents tsDeleteDevice As ToolStripMenuItem
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
End Class
