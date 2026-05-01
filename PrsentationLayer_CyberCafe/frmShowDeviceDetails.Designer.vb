<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowDeviceDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.pbDeviceIcon = New System.Windows.Forms.PictureBox()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.pbStatusDot = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.flpStats = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCardRevenue = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblRevenueValue = New System.Windows.Forms.Label()
        Me.lblRevenueTitle = New System.Windows.Forms.Label()
        Me.pnlCardTime = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTimeValue = New System.Windows.Forms.Label()
        Me.lblTimeTitle = New System.Windows.Forms.Label()
        Me.pnlCardSessions = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblSessionsValue = New System.Windows.Forms.Label()
        Me.lblSessionsTitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tabActiveSessions = New System.Windows.Forms.TabPage()
        Me.dgvActiveSessions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tabDeviceSpecs = New System.Windows.Forms.TabPage()
        Me.lblCPUValue = New System.Windows.Forms.Label()
        Me.lblCPUTitle = New System.Windows.Forms.Label()
        Me.lblRAMValue = New System.Windows.Forms.Label()
        Me.lblRAMTitle = New System.Windows.Forms.Label()
        Me.lblMACValue = New System.Windows.Forms.Label()
        Me.lblMACTitle = New System.Windows.Forms.Label()
        Me.lblIPValue = New System.Windows.Forms.Label()
        Me.lblIPTitle = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbDeviceIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStatusDot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpStats.SuspendLayout()
        Me.pnlCardRevenue.SuspendLayout()
        Me.pnlCardTime.SuspendLayout()
        Me.pnlCardSessions.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabActiveSessions.SuspendLayout()
        CType(Me.dgvActiveSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDeviceSpecs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Transparent
        Me.pnlHeader.Controls.Add(Me.pbDeviceIcon)
        Me.pnlHeader.Controls.Add(Me.lblDeviceName)
        Me.pnlHeader.Controls.Add(Me.pbStatusDot)
        Me.pnlHeader.Controls.Add(Me.lblStatus)
        Me.pnlHeader.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1067, 123)
        Me.pnlHeader.TabIndex = 0
        '
        'pbDeviceIcon
        '
        Me.pbDeviceIcon.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources._771247
        Me.pbDeviceIcon.Location = New System.Drawing.Point(12, 12)
        Me.pbDeviceIcon.Name = "pbDeviceIcon"
        Me.pbDeviceIcon.Size = New System.Drawing.Size(116, 101)
        Me.pbDeviceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDeviceIcon.TabIndex = 5
        Me.pbDeviceIcon.TabStop = False
        '
        'lblDeviceName
        '
        Me.lblDeviceName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeviceName.ForeColor = System.Drawing.Color.White
        Me.lblDeviceName.Location = New System.Drawing.Point(152, 25)
        Me.lblDeviceName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(114, 37)
        Me.lblDeviceName.TabIndex = 2
        Me.lblDeviceName.Text = "Device Name"
        '
        'pbStatusDot
        '
        Me.pbStatusDot.FillColor = System.Drawing.Color.LimeGreen
        Me.pbStatusDot.ImageRotate = 0!
        Me.pbStatusDot.Location = New System.Drawing.Point(155, 79)
        Me.pbStatusDot.Margin = New System.Windows.Forms.Padding(4)
        Me.pbStatusDot.Name = "pbStatusDot"
        Me.pbStatusDot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbStatusDot.Size = New System.Drawing.Size(16, 15)
        Me.pbStatusDot.TabIndex = 4
        Me.pbStatusDot.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.LightGray
        Me.lblStatus.Location = New System.Drawing.Point(179, 74)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(78, 23)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Available"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(991, 15)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(60, 36)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'flpStats
        '
        Me.flpStats.Controls.Add(Me.pnlCardRevenue)
        Me.flpStats.Controls.Add(Me.pnlCardTime)
        Me.flpStats.Controls.Add(Me.pnlCardSessions)
        Me.flpStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpStats.Location = New System.Drawing.Point(0, 123)
        Me.flpStats.Margin = New System.Windows.Forms.Padding(4)
        Me.flpStats.Name = "flpStats"
        Me.flpStats.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
        Me.flpStats.Size = New System.Drawing.Size(1067, 148)
        Me.flpStats.TabIndex = 1
        '
        'pnlCardRevenue
        '
        Me.pnlCardRevenue.BorderRadius = 10
        Me.pnlCardRevenue.Controls.Add(Me.lblRevenueValue)
        Me.pnlCardRevenue.Controls.Add(Me.lblRevenueTitle)
        Me.pnlCardRevenue.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlCardRevenue.Location = New System.Drawing.Point(24, 22)
        Me.pnlCardRevenue.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCardRevenue.Name = "pnlCardRevenue"
        Me.pnlCardRevenue.Size = New System.Drawing.Size(320, 98)
        Me.pnlCardRevenue.TabIndex = 0
        '
        'lblRevenueValue
        '
        Me.lblRevenueValue.AutoSize = True
        Me.lblRevenueValue.BackColor = System.Drawing.Color.Transparent
        Me.lblRevenueValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblRevenueValue.Location = New System.Drawing.Point(20, 43)
        Me.lblRevenueValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRevenueValue.Name = "lblRevenueValue"
        Me.lblRevenueValue.Size = New System.Drawing.Size(88, 37)
        Me.lblRevenueValue.TabIndex = 1
        Me.lblRevenueValue.Text = "$0.00"
        '
        'lblRevenueTitle
        '
        Me.lblRevenueTitle.AutoSize = True
        Me.lblRevenueTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblRevenueTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRevenueTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblRevenueTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblRevenueTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRevenueTitle.Name = "lblRevenueTitle"
        Me.lblRevenueTitle.Size = New System.Drawing.Size(116, 23)
        Me.lblRevenueTitle.TabIndex = 0
        Me.lblRevenueTitle.Text = "Total Revenue"
        '
        'pnlCardTime
        '
        Me.pnlCardTime.BorderRadius = 10
        Me.pnlCardTime.Controls.Add(Me.lblTimeValue)
        Me.pnlCardTime.Controls.Add(Me.lblTimeTitle)
        Me.pnlCardTime.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlCardTime.Location = New System.Drawing.Point(352, 22)
        Me.pnlCardTime.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCardTime.Name = "pnlCardTime"
        Me.pnlCardTime.Size = New System.Drawing.Size(320, 98)
        Me.pnlCardTime.TabIndex = 1
        '
        'lblTimeValue
        '
        Me.lblTimeValue.AutoSize = True
        Me.lblTimeValue.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimeValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblTimeValue.Location = New System.Drawing.Point(20, 43)
        Me.lblTimeValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeValue.Name = "lblTimeValue"
        Me.lblTimeValue.Size = New System.Drawing.Size(84, 37)
        Me.lblTimeValue.TabIndex = 1
        Me.lblTimeValue.Text = "0 Hrs"
        '
        'lblTimeTitle
        '
        Me.lblTimeTitle.AutoSize = True
        Me.lblTimeTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTimeTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblTimeTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTimeTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeTitle.Name = "lblTimeTitle"
        Me.lblTimeTitle.Size = New System.Drawing.Size(88, 23)
        Me.lblTimeTitle.TabIndex = 0
        Me.lblTimeTitle.Text = "Total Time"
        '
        'pnlCardSessions
        '
        Me.pnlCardSessions.BorderRadius = 10
        Me.pnlCardSessions.Controls.Add(Me.lblSessionsValue)
        Me.pnlCardSessions.Controls.Add(Me.lblSessionsTitle)
        Me.pnlCardSessions.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlCardSessions.Location = New System.Drawing.Point(680, 22)
        Me.pnlCardSessions.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCardSessions.Name = "pnlCardSessions"
        Me.pnlCardSessions.Size = New System.Drawing.Size(320, 98)
        Me.pnlCardSessions.TabIndex = 2
        '
        'lblSessionsValue
        '
        Me.lblSessionsValue.AutoSize = True
        Me.lblSessionsValue.BackColor = System.Drawing.Color.Transparent
        Me.lblSessionsValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSessionsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblSessionsValue.Location = New System.Drawing.Point(20, 43)
        Me.lblSessionsValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSessionsValue.Name = "lblSessionsValue"
        Me.lblSessionsValue.Size = New System.Drawing.Size(33, 37)
        Me.lblSessionsValue.TabIndex = 1
        Me.lblSessionsValue.Text = "0"
        '
        'lblSessionsTitle
        '
        Me.lblSessionsTitle.AutoSize = True
        Me.lblSessionsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSessionsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSessionsTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblSessionsTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblSessionsTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSessionsTitle.Name = "lblSessionsTitle"
        Me.lblSessionsTitle.Size = New System.Drawing.Size(118, 23)
        Me.lblSessionsTitle.TabIndex = 0
        Me.lblSessionsTitle.Text = "Session Count"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabActiveSessions)
        Me.TabControl1.Controls.Add(Me.tabDeviceSpecs)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.Location = New System.Drawing.Point(0, 271)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1067, 467)
        Me.TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.LightGray
        Me.TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'tabActiveSessions
        '
        Me.tabActiveSessions.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.tabActiveSessions.Controls.Add(Me.dgvActiveSessions)
        Me.tabActiveSessions.Location = New System.Drawing.Point(4, 44)
        Me.tabActiveSessions.Margin = New System.Windows.Forms.Padding(4)
        Me.tabActiveSessions.Name = "tabActiveSessions"
        Me.tabActiveSessions.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
        Me.tabActiveSessions.Size = New System.Drawing.Size(1059, 419)
        Me.tabActiveSessions.TabIndex = 0
        Me.tabActiveSessions.Text = "Active Sessions"
        '
        'dgvActiveSessions
        '
        Me.dgvActiveSessions.AllowUserToAddRows = False
        Me.dgvActiveSessions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvActiveSessions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActiveSessions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActiveSessions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvActiveSessions.ColumnHeadersHeight = 35
        Me.dgvActiveSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActiveSessions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvActiveSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActiveSessions.GridColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.dgvActiveSessions.Location = New System.Drawing.Point(20, 18)
        Me.dgvActiveSessions.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvActiveSessions.Name = "dgvActiveSessions"
        Me.dgvActiveSessions.ReadOnly = True
        Me.dgvActiveSessions.RowHeadersVisible = False
        Me.dgvActiveSessions.RowHeadersWidth = 51
        Me.dgvActiveSessions.RowTemplate.Height = 30
        Me.dgvActiveSessions.Size = New System.Drawing.Size(1019, 383)
        Me.dgvActiveSessions.TabIndex = 0
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvActiveSessions.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvActiveSessions.ThemeStyle.ReadOnly = True
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.LightGray
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.Height = 30
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'tabDeviceSpecs
        '
        Me.tabDeviceSpecs.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.tabDeviceSpecs.Controls.Add(Me.lblCPUValue)
        Me.tabDeviceSpecs.Controls.Add(Me.lblCPUTitle)
        Me.tabDeviceSpecs.Controls.Add(Me.lblRAMValue)
        Me.tabDeviceSpecs.Controls.Add(Me.lblRAMTitle)
        Me.tabDeviceSpecs.Controls.Add(Me.lblMACValue)
        Me.tabDeviceSpecs.Controls.Add(Me.lblMACTitle)
        Me.tabDeviceSpecs.Controls.Add(Me.lblIPValue)
        Me.tabDeviceSpecs.Controls.Add(Me.lblIPTitle)
        Me.tabDeviceSpecs.Location = New System.Drawing.Point(4, 44)
        Me.tabDeviceSpecs.Margin = New System.Windows.Forms.Padding(4)
        Me.tabDeviceSpecs.Name = "tabDeviceSpecs"
        Me.tabDeviceSpecs.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
        Me.tabDeviceSpecs.Size = New System.Drawing.Size(1059, 419)
        Me.tabDeviceSpecs.TabIndex = 1
        Me.tabDeviceSpecs.Text = "Device Specs"
        '
        'lblCPUValue
        '
        Me.lblCPUValue.AutoSize = True
        Me.lblCPUValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCPUValue.ForeColor = System.Drawing.Color.White
        Me.lblCPUValue.Location = New System.Drawing.Point(160, 185)
        Me.lblCPUValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCPUValue.Name = "lblCPUValue"
        Me.lblCPUValue.Size = New System.Drawing.Size(206, 28)
        Me.lblCPUValue.TabIndex = 7
        Me.lblCPUValue.Text = "Intel Core i5-10400F"
        '
        'lblCPUTitle
        '
        Me.lblCPUTitle.AutoSize = True
        Me.lblCPUTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblCPUTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblCPUTitle.Location = New System.Drawing.Point(40, 185)
        Me.lblCPUTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCPUTitle.Name = "lblCPUTitle"
        Me.lblCPUTitle.Size = New System.Drawing.Size(53, 28)
        Me.lblCPUTitle.TabIndex = 6
        Me.lblCPUTitle.Text = "CPU:"
        '
        'lblRAMValue
        '
        Me.lblRAMValue.AutoSize = True
        Me.lblRAMValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRAMValue.ForeColor = System.Drawing.Color.White
        Me.lblRAMValue.Location = New System.Drawing.Point(160, 135)
        Me.lblRAMValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRAMValue.Name = "lblRAMValue"
        Me.lblRAMValue.Size = New System.Drawing.Size(69, 28)
        Me.lblRAMValue.TabIndex = 5
        Me.lblRAMValue.Text = "16 GB"
        '
        'lblRAMTitle
        '
        Me.lblRAMTitle.AutoSize = True
        Me.lblRAMTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblRAMTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblRAMTitle.Location = New System.Drawing.Point(40, 135)
        Me.lblRAMTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRAMTitle.Name = "lblRAMTitle"
        Me.lblRAMTitle.Size = New System.Drawing.Size(59, 28)
        Me.lblRAMTitle.TabIndex = 4
        Me.lblRAMTitle.Text = "RAM:"
        '
        'lblMACValue
        '
        Me.lblMACValue.AutoSize = True
        Me.lblMACValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMACValue.ForeColor = System.Drawing.Color.White
        Me.lblMACValue.Location = New System.Drawing.Point(160, 86)
        Me.lblMACValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMACValue.Name = "lblMACValue"
        Me.lblMACValue.Size = New System.Drawing.Size(186, 28)
        Me.lblMACValue.TabIndex = 3
        Me.lblMACValue.Text = "00:1A:2B:3C:4D:5E"
        '
        'lblMACTitle
        '
        Me.lblMACTitle.AutoSize = True
        Me.lblMACTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblMACTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblMACTitle.Location = New System.Drawing.Point(40, 86)
        Me.lblMACTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMACTitle.Name = "lblMACTitle"
        Me.lblMACTitle.Size = New System.Drawing.Size(59, 28)
        Me.lblMACTitle.TabIndex = 2
        Me.lblMACTitle.Text = "MAC:"
        '
        'lblIPValue
        '
        Me.lblIPValue.AutoSize = True
        Me.lblIPValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblIPValue.ForeColor = System.Drawing.Color.White
        Me.lblIPValue.Location = New System.Drawing.Point(160, 37)
        Me.lblIPValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIPValue.Name = "lblIPValue"
        Me.lblIPValue.Size = New System.Drawing.Size(147, 28)
        Me.lblIPValue.TabIndex = 1
        Me.lblIPValue.Text = "192.168.1.100"
        '
        'lblIPTitle
        '
        Me.lblIPTitle.AutoSize = True
        Me.lblIPTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblIPTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblIPTitle.Location = New System.Drawing.Point(40, 37)
        Me.lblIPTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIPTitle.Name = "lblIPTitle"
        Me.lblIPTitle.Size = New System.Drawing.Size(32, 28)
        Me.lblIPTitle.TabIndex = 0
        Me.lblIPTitle.Text = "IP:"
        '
        'frmShowDeviceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 738)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.flpStats)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmShowDeviceDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Device Details"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.pbDeviceIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStatusDot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpStats.ResumeLayout(False)
        Me.pnlCardRevenue.ResumeLayout(False)
        Me.pnlCardRevenue.PerformLayout()
        Me.pnlCardTime.ResumeLayout(False)
        Me.pnlCardTime.PerformLayout()
        Me.pnlCardSessions.ResumeLayout(False)
        Me.pnlCardSessions.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabActiveSessions.ResumeLayout(False)
        CType(Me.dgvActiveSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDeviceSpecs.ResumeLayout(False)
        Me.tabDeviceSpecs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblDeviceName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pbStatusDot As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents flpStats As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlCardRevenue As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblRevenueTitle As System.Windows.Forms.Label
    Friend WithEvents lblRevenueValue As System.Windows.Forms.Label
    Friend WithEvents pnlCardTime As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblTimeTitle As System.Windows.Forms.Label
    Friend WithEvents pnlCardSessions As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSessionsValue As System.Windows.Forms.Label
    Friend WithEvents lblSessionsTitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabActiveSessions As System.Windows.Forms.TabPage
    Friend WithEvents tabDeviceSpecs As System.Windows.Forms.TabPage
    Friend WithEvents dgvActiveSessions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblIPTitle As System.Windows.Forms.Label
    Friend WithEvents lblIPValue As System.Windows.Forms.Label
    Friend WithEvents lblMACValue As System.Windows.Forms.Label
    Friend WithEvents lblMACTitle As System.Windows.Forms.Label
    Friend WithEvents lblRAMValue As System.Windows.Forms.Label
    Friend WithEvents lblRAMTitle As System.Windows.Forms.Label
    Friend WithEvents lblCPUValue As System.Windows.Forms.Label
    Friend WithEvents lblCPUTitle As System.Windows.Forms.Label
    Friend WithEvents pbDeviceIcon As PictureBox
End Class
