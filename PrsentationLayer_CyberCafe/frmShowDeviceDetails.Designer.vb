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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowDeviceDetails))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.tabDeviceGames = New System.Windows.Forms.TabPage()
        Me.flpDeviceGames = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.tabDeviceGames.SuspendLayout()
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
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(800, 100)
        Me.pnlHeader.TabIndex = 0
        '
        'pbDeviceIcon
        '
        Me.pbDeviceIcon.Image = CType(resources.GetObject("pbDeviceIcon.Image"), System.Drawing.Image)
        Me.pbDeviceIcon.Location = New System.Drawing.Point(9, 10)
        Me.pbDeviceIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.pbDeviceIcon.Name = "pbDeviceIcon"
        Me.pbDeviceIcon.Size = New System.Drawing.Size(87, 82)
        Me.pbDeviceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDeviceIcon.TabIndex = 5
        Me.pbDeviceIcon.TabStop = False
        '
        'lblDeviceName
        '
        Me.lblDeviceName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeviceName.ForeColor = System.Drawing.Color.White
        Me.lblDeviceName.Location = New System.Drawing.Point(114, 20)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(86, 30)
        Me.lblDeviceName.TabIndex = 2
        Me.lblDeviceName.Text = "Device Name"
        '
        'pbStatusDot
        '
        Me.pbStatusDot.FillColor = System.Drawing.Color.LimeGreen
        Me.pbStatusDot.ImageRotate = 0!
        Me.pbStatusDot.Location = New System.Drawing.Point(116, 64)
        Me.pbStatusDot.Name = "pbStatusDot"
        Me.pbStatusDot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbStatusDot.Size = New System.Drawing.Size(12, 12)
        Me.pbStatusDot.TabIndex = 4
        Me.pbStatusDot.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.LightGray
        Me.lblStatus.Location = New System.Drawing.Point(134, 60)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(63, 19)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Available"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(743, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'flpStats
        '
        Me.flpStats.Controls.Add(Me.pnlCardRevenue)
        Me.flpStats.Controls.Add(Me.pnlCardTime)
        Me.flpStats.Controls.Add(Me.pnlCardSessions)
        Me.flpStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpStats.Location = New System.Drawing.Point(0, 100)
        Me.flpStats.Name = "flpStats"
        Me.flpStats.Padding = New System.Windows.Forms.Padding(15)
        Me.flpStats.Size = New System.Drawing.Size(800, 120)
        Me.flpStats.TabIndex = 1
        '
        'pnlCardRevenue
        '
        Me.pnlCardRevenue.BorderRadius = 10
        Me.pnlCardRevenue.Controls.Add(Me.lblRevenueValue)
        Me.pnlCardRevenue.Controls.Add(Me.lblRevenueTitle)
        Me.pnlCardRevenue.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlCardRevenue.Location = New System.Drawing.Point(18, 18)
        Me.pnlCardRevenue.Name = "pnlCardRevenue"
        Me.pnlCardRevenue.Size = New System.Drawing.Size(240, 80)
        Me.pnlCardRevenue.TabIndex = 0
        '
        'lblRevenueValue
        '
        Me.lblRevenueValue.AutoSize = True
        Me.lblRevenueValue.BackColor = System.Drawing.Color.Transparent
        Me.lblRevenueValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblRevenueValue.Location = New System.Drawing.Point(15, 35)
        Me.lblRevenueValue.Name = "lblRevenueValue"
        Me.lblRevenueValue.Size = New System.Drawing.Size(71, 30)
        Me.lblRevenueValue.TabIndex = 1
        Me.lblRevenueValue.Text = "$0.00"
        '
        'lblRevenueTitle
        '
        Me.lblRevenueTitle.AutoSize = True
        Me.lblRevenueTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblRevenueTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRevenueTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblRevenueTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblRevenueTitle.Name = "lblRevenueTitle"
        Me.lblRevenueTitle.Size = New System.Drawing.Size(94, 19)
        Me.lblRevenueTitle.TabIndex = 0
        Me.lblRevenueTitle.Text = "Total Revenue"
        '
        'pnlCardTime
        '
        Me.pnlCardTime.BorderRadius = 10
        Me.pnlCardTime.Controls.Add(Me.lblTimeValue)
        Me.pnlCardTime.Controls.Add(Me.lblTimeTitle)
        Me.pnlCardTime.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlCardTime.Location = New System.Drawing.Point(264, 18)
        Me.pnlCardTime.Name = "pnlCardTime"
        Me.pnlCardTime.Size = New System.Drawing.Size(240, 80)
        Me.pnlCardTime.TabIndex = 1
        '
        'lblTimeValue
        '
        Me.lblTimeValue.AutoSize = True
        Me.lblTimeValue.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimeValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblTimeValue.Location = New System.Drawing.Point(15, 35)
        Me.lblTimeValue.Name = "lblTimeValue"
        Me.lblTimeValue.Size = New System.Drawing.Size(68, 30)
        Me.lblTimeValue.TabIndex = 1
        Me.lblTimeValue.Text = "0 Hrs"
        '
        'lblTimeTitle
        '
        Me.lblTimeTitle.AutoSize = True
        Me.lblTimeTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTimeTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblTimeTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTimeTitle.Name = "lblTimeTitle"
        Me.lblTimeTitle.Size = New System.Drawing.Size(71, 19)
        Me.lblTimeTitle.TabIndex = 0
        Me.lblTimeTitle.Text = "Total Time"
        '
        'pnlCardSessions
        '
        Me.pnlCardSessions.BorderRadius = 10
        Me.pnlCardSessions.Controls.Add(Me.lblSessionsValue)
        Me.pnlCardSessions.Controls.Add(Me.lblSessionsTitle)
        Me.pnlCardSessions.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlCardSessions.Location = New System.Drawing.Point(510, 18)
        Me.pnlCardSessions.Name = "pnlCardSessions"
        Me.pnlCardSessions.Size = New System.Drawing.Size(240, 80)
        Me.pnlCardSessions.TabIndex = 2
        '
        'lblSessionsValue
        '
        Me.lblSessionsValue.AutoSize = True
        Me.lblSessionsValue.BackColor = System.Drawing.Color.Transparent
        Me.lblSessionsValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSessionsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblSessionsValue.Location = New System.Drawing.Point(15, 35)
        Me.lblSessionsValue.Name = "lblSessionsValue"
        Me.lblSessionsValue.Size = New System.Drawing.Size(26, 30)
        Me.lblSessionsValue.TabIndex = 1
        Me.lblSessionsValue.Text = "0"
        '
        'lblSessionsTitle
        '
        Me.lblSessionsTitle.AutoSize = True
        Me.lblSessionsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSessionsTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSessionsTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblSessionsTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblSessionsTitle.Name = "lblSessionsTitle"
        Me.lblSessionsTitle.Size = New System.Drawing.Size(96, 19)
        Me.lblSessionsTitle.TabIndex = 0
        Me.lblSessionsTitle.Text = "Session Count"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabActiveSessions)
        Me.TabControl1.Controls.Add(Me.tabDeviceGames)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.Location = New System.Drawing.Point(0, 220)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 380)
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
        Me.tabActiveSessions.Name = "tabActiveSessions"
        Me.tabActiveSessions.Padding = New System.Windows.Forms.Padding(15)
        Me.tabActiveSessions.Size = New System.Drawing.Size(792, 332)
        Me.tabActiveSessions.TabIndex = 0
        Me.tabActiveSessions.Text = "Active Sessions"
        '
        'dgvActiveSessions
        '
        Me.dgvActiveSessions.AllowUserToAddRows = False
        Me.dgvActiveSessions.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvActiveSessions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvActiveSessions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActiveSessions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvActiveSessions.ColumnHeadersHeight = 35
        Me.dgvActiveSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActiveSessions.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvActiveSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActiveSessions.GridColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.dgvActiveSessions.Location = New System.Drawing.Point(15, 15)
        Me.dgvActiveSessions.Name = "dgvActiveSessions"
        Me.dgvActiveSessions.ReadOnly = True
        Me.dgvActiveSessions.RowHeadersVisible = False
        Me.dgvActiveSessions.RowHeadersWidth = 51
        Me.dgvActiveSessions.RowTemplate.Height = 30
        Me.dgvActiveSessions.Size = New System.Drawing.Size(762, 302)
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
        'tabDeviceGames
        '
        Me.tabDeviceGames.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.tabDeviceGames.Controls.Add(Me.flpDeviceGames)
        Me.tabDeviceGames.Location = New System.Drawing.Point(4, 44)
        Me.tabDeviceGames.Name = "tabDeviceGames"
        Me.tabDeviceGames.Padding = New System.Windows.Forms.Padding(15)
        Me.tabDeviceGames.Size = New System.Drawing.Size(792, 332)
        Me.tabDeviceGames.TabIndex = 1
        Me.tabDeviceGames.Text = "Device Games"
        '
        'flpDeviceGames
        '
        Me.flpDeviceGames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpDeviceGames.Location = New System.Drawing.Point(15, 15)
        Me.flpDeviceGames.Name = "flpDeviceGames"
        Me.flpDeviceGames.Size = New System.Drawing.Size(762, 302)
        Me.flpDeviceGames.TabIndex = 1
        '
        'frmShowDeviceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.flpStats)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
        Me.tabDeviceGames.ResumeLayout(False)
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
    Friend WithEvents tabDeviceGames As System.Windows.Forms.TabPage
    Friend WithEvents dgvActiveSessions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pbDeviceIcon As PictureBox
    Friend WithEvents flpDeviceGames As FlowLayoutPanel
End Class
