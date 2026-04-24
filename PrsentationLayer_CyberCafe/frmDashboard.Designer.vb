<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.btnMinWin = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTopBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLogoIcon = New System.Windows.Forms.Label()
        Me.lblLogoText = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.pnlUserBadge = New System.Windows.Forms.Panel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.btnCloseWin = New Guna.UI2.WinForms.Guna2Button()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDevices = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tblKpis = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlKpiCustomers = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblKpiCustIcon = New System.Windows.Forms.Label()
        Me.lblCustNum = New System.Windows.Forms.Label()
        Me.lblKpiCustTitle = New System.Windows.Forms.Label()
        Me.pnlKpiDevices = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblKpiDevIcon = New System.Windows.Forms.Label()
        Me.lblDevNum = New System.Windows.Forms.Label()
        Me.lblKpiDevTitle = New System.Windows.Forms.Label()
        Me.pnlKpiSessions = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblKpiSessIcon = New System.Windows.Forms.Label()
        Me.lblSessNum = New System.Windows.Forms.Label()
        Me.lblKpiSessTitle = New System.Windows.Forms.Label()
        Me.pnlKpiRevenue = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblKpiRevIcon = New System.Windows.Forms.Label()
        Me.lblRevNum = New System.Windows.Forms.Label()
        Me.lblKpiRevTitle = New System.Windows.Forms.Label()
        Me.lblHomeSubtitle = New System.Windows.Forms.Label()
        Me.lblHomeGreeting = New System.Windows.Forms.Label()
        Me.btnCutomers = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlUserBadge.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.tblKpis.SuspendLayout()
        Me.pnlKpiCustomers.SuspendLayout()
        Me.pnlKpiDevices.SuspendLayout()
        Me.pnlKpiSessions.SuspendLayout()
        Me.pnlKpiRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinWin
        '
        Me.btnMinWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinWin.BorderRadius = 20
        Me.btnMinWin.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMinWin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMinWin.ForeColor = System.Drawing.Color.White
        Me.btnMinWin.Location = New System.Drawing.Point(1565, 26)
        Me.btnMinWin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinWin.Name = "btnMinWin"
        Me.btnMinWin.Size = New System.Drawing.Size(21, 18)
        Me.btnMinWin.TabIndex = 0
        '
        'pnlTopBar
        '
        Me.pnlTopBar.Controls.Add(Me.lblLogoIcon)
        Me.pnlTopBar.Controls.Add(Me.lblLogoText)
        Me.pnlTopBar.Controls.Add(Me.lblClock)
        Me.pnlTopBar.Controls.Add(Me.pnlUserBadge)
        Me.pnlTopBar.Controls.Add(Me.btnCloseWin)
        Me.pnlTopBar.Controls.Add(Me.btnMinWin)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1635, 69)
        Me.pnlTopBar.TabIndex = 0
        '
        'lblLogoIcon
        '
        Me.lblLogoIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblLogoIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblLogoIcon.Location = New System.Drawing.Point(12, 9)
        Me.lblLogoIcon.Name = "lblLogoIcon"
        Me.lblLogoIcon.Size = New System.Drawing.Size(41, 38)
        Me.lblLogoIcon.TabIndex = 3
        Me.lblLogoIcon.Text = "🎮"
        Me.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogoText
        '
        Me.lblLogoText.BackColor = System.Drawing.Color.Transparent
        Me.lblLogoText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblLogoText.Location = New System.Drawing.Point(59, 18)
        Me.lblLogoText.Name = "lblLogoText"
        Me.lblLogoText.Size = New System.Drawing.Size(177, 28)
        Me.lblLogoText.TabIndex = 4
        Me.lblLogoText.Text = "CyberCafe Pro"
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblClock.Location = New System.Drawing.Point(283, 20)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(164, 26)
        Me.lblClock.TabIndex = 1
        Me.lblClock.Text = "00:00:00   Mon, Jan 01 2025"
        '
        'pnlUserBadge
        '
        Me.pnlUserBadge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUserBadge.BackColor = System.Drawing.Color.Transparent
        Me.pnlUserBadge.Controls.Add(Me.lblUserName)
        Me.pnlUserBadge.Controls.Add(Me.lblUserRole)
        Me.pnlUserBadge.Location = New System.Drawing.Point(1251, 11)
        Me.pnlUserBadge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlUserBadge.Name = "pnlUserBadge"
        Me.pnlUserBadge.Size = New System.Drawing.Size(213, 49)
        Me.pnlUserBadge.TabIndex = 2
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(0, 2)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(123, 23)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Administrator"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.BackColor = System.Drawing.Color.Transparent
        Me.lblUserRole.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblUserRole.Location = New System.Drawing.Point(0, 28)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(49, 19)
        Me.lblUserRole.TabIndex = 1
        Me.lblUserRole.Text = "Admin"
        '
        'btnCloseWin
        '
        Me.btnCloseWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseWin.BorderRadius = 20
        Me.btnCloseWin.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCloseWin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCloseWin.ForeColor = System.Drawing.Color.White
        Me.btnCloseWin.Location = New System.Drawing.Point(1591, 26)
        Me.btnCloseWin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCloseWin.Name = "btnCloseWin"
        Me.btnCloseWin.Size = New System.Drawing.Size(21, 18)
        Me.btnCloseWin.TabIndex = 0
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlNav.Controls.Add(Me.Button1)
        Me.pnlNav.Controls.Add(Me.btnCutomers)
        Me.pnlNav.Controls.Add(Me.btnLogout)
        Me.pnlNav.Controls.Add(Me.btnDevices)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(0, 69)
        Me.pnlNav.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(242, 673)
        Me.pnlNav.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 614)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(242, 59)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "   ⬛  Logout"
        '
        'btnDevices
        '
        Me.btnDevices.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDevices.FlatAppearance.BorderSize = 0
        Me.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevices.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.btnDevices.Location = New System.Drawing.Point(2, 3)
        Me.btnDevices.Name = "btnDevices"
        Me.btnDevices.Size = New System.Drawing.Size(236, 66)
        Me.btnDevices.TabIndex = 8
        Me.btnDevices.Text = "Devices"
        Me.btnDevices.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.tblKpis)
        Me.pnlMain.Controls.Add(Me.lblHomeSubtitle)
        Me.pnlMain.Controls.Add(Me.lblHomeGreeting)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(242, 69)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1393, 673)
        Me.pnlMain.TabIndex = 3
        '
        'tblKpis
        '
        Me.tblKpis.BackColor = System.Drawing.Color.Transparent
        Me.tblKpis.ColumnCount = 4
        Me.tblKpis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblKpis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblKpis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblKpis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblKpis.Controls.Add(Me.pnlKpiCustomers, 0, 0)
        Me.tblKpis.Controls.Add(Me.pnlKpiDevices, 1, 0)
        Me.tblKpis.Controls.Add(Me.pnlKpiSessions, 2, 0)
        Me.tblKpis.Controls.Add(Me.pnlKpiRevenue, 3, 0)
        Me.tblKpis.Location = New System.Drawing.Point(11, 185)
        Me.tblKpis.Name = "tblKpis"
        Me.tblKpis.RowCount = 1
        Me.tblKpis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblKpis.Size = New System.Drawing.Size(1274, 160)
        Me.tblKpis.TabIndex = 5
        '
        'pnlKpiCustomers
        '
        Me.pnlKpiCustomers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiCustomers.BorderRadius = 12
        Me.pnlKpiCustomers.BorderThickness = 1
        Me.pnlKpiCustomers.Controls.Add(Me.lblKpiCustIcon)
        Me.pnlKpiCustomers.Controls.Add(Me.lblCustNum)
        Me.pnlKpiCustomers.Controls.Add(Me.lblKpiCustTitle)
        Me.pnlKpiCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiCustomers.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiCustomers.Location = New System.Drawing.Point(9, 9)
        Me.pnlKpiCustomers.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlKpiCustomers.Name = "pnlKpiCustomers"
        Me.pnlKpiCustomers.Size = New System.Drawing.Size(300, 142)
        Me.pnlKpiCustomers.TabIndex = 0
        '
        'lblKpiCustIcon
        '
        Me.lblKpiCustIcon.AutoSize = True
        Me.lblKpiCustIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiCustIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiCustIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblKpiCustIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblKpiCustIcon.Name = "lblKpiCustIcon"
        Me.lblKpiCustIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblKpiCustIcon.TabIndex = 0
        Me.lblKpiCustIcon.Text = "👥"
        '
        'lblCustNum
        '
        Me.lblCustNum.AutoSize = True
        Me.lblCustNum.BackColor = System.Drawing.Color.Transparent
        Me.lblCustNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblCustNum.Location = New System.Drawing.Point(17, 51)
        Me.lblCustNum.Name = "lblCustNum"
        Me.lblCustNum.Size = New System.Drawing.Size(116, 50)
        Me.lblCustNum.TabIndex = 1
        Me.lblCustNum.Text = "1,247"
        '
        'lblKpiCustTitle
        '
        Me.lblKpiCustTitle.AutoSize = True
        Me.lblKpiCustTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiCustTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiCustTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiCustTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblKpiCustTitle.Name = "lblKpiCustTitle"
        Me.lblKpiCustTitle.Size = New System.Drawing.Size(115, 20)
        Me.lblKpiCustTitle.TabIndex = 2
        Me.lblKpiCustTitle.Text = "Total Customers"
        '
        'pnlKpiDevices
        '
        Me.pnlKpiDevices.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiDevices.BorderRadius = 12
        Me.pnlKpiDevices.BorderThickness = 1
        Me.pnlKpiDevices.Controls.Add(Me.lblKpiDevIcon)
        Me.pnlKpiDevices.Controls.Add(Me.lblDevNum)
        Me.pnlKpiDevices.Controls.Add(Me.lblKpiDevTitle)
        Me.pnlKpiDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiDevices.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiDevices.Location = New System.Drawing.Point(327, 9)
        Me.pnlKpiDevices.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlKpiDevices.Name = "pnlKpiDevices"
        Me.pnlKpiDevices.Size = New System.Drawing.Size(300, 142)
        Me.pnlKpiDevices.TabIndex = 1
        '
        'lblKpiDevIcon
        '
        Me.lblKpiDevIcon.AutoSize = True
        Me.lblKpiDevIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiDevIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiDevIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblKpiDevIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblKpiDevIcon.Name = "lblKpiDevIcon"
        Me.lblKpiDevIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblKpiDevIcon.TabIndex = 0
        Me.lblKpiDevIcon.Text = "🖥"
        '
        'lblDevNum
        '
        Me.lblDevNum.AutoSize = True
        Me.lblDevNum.BackColor = System.Drawing.Color.Transparent
        Me.lblDevNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblDevNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblDevNum.Location = New System.Drawing.Point(17, 51)
        Me.lblDevNum.Name = "lblDevNum"
        Me.lblDevNum.Size = New System.Drawing.Size(142, 50)
        Me.lblDevNum.TabIndex = 1
        Me.lblDevNum.Text = "18 / 25"
        '
        'lblKpiDevTitle
        '
        Me.lblKpiDevTitle.AutoSize = True
        Me.lblKpiDevTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiDevTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiDevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiDevTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblKpiDevTitle.Name = "lblKpiDevTitle"
        Me.lblKpiDevTitle.Size = New System.Drawing.Size(105, 20)
        Me.lblKpiDevTitle.TabIndex = 2
        Me.lblKpiDevTitle.Text = "Active Devices"
        '
        'pnlKpiSessions
        '
        Me.pnlKpiSessions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiSessions.BorderRadius = 12
        Me.pnlKpiSessions.BorderThickness = 1
        Me.pnlKpiSessions.Controls.Add(Me.lblKpiSessIcon)
        Me.pnlKpiSessions.Controls.Add(Me.lblSessNum)
        Me.pnlKpiSessions.Controls.Add(Me.lblKpiSessTitle)
        Me.pnlKpiSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiSessions.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiSessions.Location = New System.Drawing.Point(645, 9)
        Me.pnlKpiSessions.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlKpiSessions.Name = "pnlKpiSessions"
        Me.pnlKpiSessions.Size = New System.Drawing.Size(300, 142)
        Me.pnlKpiSessions.TabIndex = 2
        '
        'lblKpiSessIcon
        '
        Me.lblKpiSessIcon.AutoSize = True
        Me.lblKpiSessIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiSessIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiSessIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblKpiSessIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblKpiSessIcon.Name = "lblKpiSessIcon"
        Me.lblKpiSessIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblKpiSessIcon.TabIndex = 0
        Me.lblKpiSessIcon.Text = "⏱"
        '
        'lblSessNum
        '
        Me.lblSessNum.AutoSize = True
        Me.lblSessNum.BackColor = System.Drawing.Color.Transparent
        Me.lblSessNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblSessNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblSessNum.Location = New System.Drawing.Point(17, 51)
        Me.lblSessNum.Name = "lblSessNum"
        Me.lblSessNum.Size = New System.Drawing.Size(43, 50)
        Me.lblSessNum.TabIndex = 1
        Me.lblSessNum.Text = "5"
        '
        'lblKpiSessTitle
        '
        Me.lblKpiSessTitle.AutoSize = True
        Me.lblKpiSessTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiSessTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiSessTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiSessTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblKpiSessTitle.Name = "lblKpiSessTitle"
        Me.lblKpiSessTitle.Size = New System.Drawing.Size(109, 20)
        Me.lblKpiSessTitle.TabIndex = 2
        Me.lblKpiSessTitle.Text = "Active Sessions"
        '
        'pnlKpiRevenue
        '
        Me.pnlKpiRevenue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiRevenue.BorderRadius = 12
        Me.pnlKpiRevenue.BorderThickness = 1
        Me.pnlKpiRevenue.Controls.Add(Me.lblKpiRevIcon)
        Me.pnlKpiRevenue.Controls.Add(Me.lblRevNum)
        Me.pnlKpiRevenue.Controls.Add(Me.lblKpiRevTitle)
        Me.pnlKpiRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiRevenue.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiRevenue.Location = New System.Drawing.Point(963, 9)
        Me.pnlKpiRevenue.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlKpiRevenue.Name = "pnlKpiRevenue"
        Me.pnlKpiRevenue.Size = New System.Drawing.Size(302, 142)
        Me.pnlKpiRevenue.TabIndex = 3
        '
        'lblKpiRevIcon
        '
        Me.lblKpiRevIcon.AutoSize = True
        Me.lblKpiRevIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiRevIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiRevIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblKpiRevIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblKpiRevIcon.Name = "lblKpiRevIcon"
        Me.lblKpiRevIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblKpiRevIcon.TabIndex = 0
        Me.lblKpiRevIcon.Text = "💰"
        '
        'lblRevNum
        '
        Me.lblRevNum.AutoSize = True
        Me.lblRevNum.BackColor = System.Drawing.Color.Transparent
        Me.lblRevNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblRevNum.Location = New System.Drawing.Point(17, 51)
        Me.lblRevNum.Name = "lblRevNum"
        Me.lblRevNum.Size = New System.Drawing.Size(106, 50)
        Me.lblRevNum.TabIndex = 1
        Me.lblRevNum.Text = "$284"
        '
        'lblKpiRevTitle
        '
        Me.lblKpiRevTitle.AutoSize = True
        Me.lblKpiRevTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiRevTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiRevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiRevTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblKpiRevTitle.Name = "lblKpiRevTitle"
        Me.lblKpiRevTitle.Size = New System.Drawing.Size(118, 20)
        Me.lblKpiRevTitle.TabIndex = 2
        Me.lblKpiRevTitle.Text = "Today's Revenue"
        '
        'lblHomeSubtitle
        '
        Me.lblHomeSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeSubtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblHomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblHomeSubtitle.Location = New System.Drawing.Point(11, 121)
        Me.lblHomeSubtitle.Name = "lblHomeSubtitle"
        Me.lblHomeSubtitle.Size = New System.Drawing.Size(691, 28)
        Me.lblHomeSubtitle.TabIndex = 6
        Me.lblHomeSubtitle.Text = "Here's what's happening at your cyber café today."
        '
        'lblHomeGreeting
        '
        Me.lblHomeGreeting.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeGreeting.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHomeGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblHomeGreeting.Location = New System.Drawing.Point(12, 18)
        Me.lblHomeGreeting.Name = "lblHomeGreeting"
        Me.lblHomeGreeting.Size = New System.Drawing.Size(654, 51)
        Me.lblHomeGreeting.TabIndex = 7
        Me.lblHomeGreeting.Text = "👋  Good Morning, Administrator!"
        '
        'btnCutomers
        '
        Me.btnCutomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCutomers.FlatAppearance.BorderSize = 0
        Me.btnCutomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCutomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCutomers.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.btnCutomers.Location = New System.Drawing.Point(3, 83)
        Me.btnCutomers.Name = "btnCutomers"
        Me.btnCutomers.Size = New System.Drawing.Size(236, 66)
        Me.btnCutomers.TabIndex = 10
        Me.btnCutomers.Text = "Customers"
        Me.btnCutomers.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.Location = New System.Drawing.Point(2, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 66)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Sessions"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1635, 742)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.pnlTopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlUserBadge.ResumeLayout(False)
        Me.pnlUserBadge.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.tblKpis.ResumeLayout(False)
        Me.pnlKpiCustomers.ResumeLayout(False)
        Me.pnlKpiCustomers.PerformLayout()
        Me.pnlKpiDevices.ResumeLayout(False)
        Me.pnlKpiDevices.PerformLayout()
        Me.pnlKpiSessions.ResumeLayout(False)
        Me.pnlKpiSessions.PerformLayout()
        Me.pnlKpiRevenue.ResumeLayout(False)
        Me.pnlKpiRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnMinWin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblClock As Label
    Private WithEvents pnlUserBadge As Panel
    Private WithEvents lblUserName As Label
    Private WithEvents lblUserRole As Label
    Private WithEvents btnCloseWin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents tmrClock As Timer
    Private WithEvents pnlNav As Panel
    Friend WithEvents btnDevices As Button
    Private WithEvents lblLogoIcon As Label
    Private WithEvents lblLogoText As Label
    Friend WithEvents pnlMain As Panel
    Private WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Private WithEvents tblKpis As TableLayoutPanel
    Private WithEvents pnlKpiCustomers As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblKpiCustIcon As Label
    Private WithEvents lblCustNum As Label
    Private WithEvents lblKpiCustTitle As Label
    Private WithEvents pnlKpiDevices As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblKpiDevIcon As Label
    Private WithEvents lblDevNum As Label
    Private WithEvents lblKpiDevTitle As Label
    Private WithEvents pnlKpiSessions As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblKpiSessIcon As Label
    Private WithEvents lblSessNum As Label
    Private WithEvents lblKpiSessTitle As Label
    Private WithEvents pnlKpiRevenue As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblKpiRevIcon As Label
    Private WithEvents lblRevNum As Label
    Private WithEvents lblKpiRevTitle As Label
    Private WithEvents lblHomeSubtitle As Label
    Private WithEvents lblHomeGreeting As Label
    Friend WithEvents btnCutomers As Button
    Friend WithEvents Button1 As Button
End Class
