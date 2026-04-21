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
        Me.lblKpiDevNum = New System.Windows.Forms.Label()
        Me.pnlKpiCustomers = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblKpiCustIcon = New System.Windows.Forms.Label()
        Me.lblKpiCustNum = New System.Windows.Forms.Label()
        Me.lblKpiCustTitle = New System.Windows.Forms.Label()
        Me.lblKpiDevTitle = New System.Windows.Forms.Label()
        Me.lblKpiSessIcon = New System.Windows.Forms.Label()
        Me.lblKpiSessNum = New System.Windows.Forms.Label()
        Me.lblKpiSessTitle = New System.Windows.Forms.Label()
        Me.lblKpiRevIcon = New System.Windows.Forms.Label()
        Me.lblKpiRevNum = New System.Windows.Forms.Label()
        Me.lblKpiRevTitle = New System.Windows.Forms.Label()
        Me.lblHomeSubtitle = New System.Windows.Forms.Label()
        Me.lblHomeGreeting = New System.Windows.Forms.Label()
        Me.pnlTopBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBreadcrumb = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.pnlUserBadge = New System.Windows.Forms.Panel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.btnCloseWin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblKpiDevIcon = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.pnlKpiDevices = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLogoIcon = New System.Windows.Forms.Label()
        Me.lblLogoText = New System.Windows.Forms.Label()
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnNavConsumables = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNavTransactions = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNavSessions = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNavGames = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNavDevices = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNavCustomers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNavUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNavDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlKpiRevenue = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.tblKpis = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlKpiSessions = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlKpiCustomers.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlUserBadge.SuspendLayout()
        Me.pnlKpiDevices.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.pnlKpiRevenue.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.tblKpis.SuspendLayout()
        Me.pnlKpiSessions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinWin
        '
        Me.btnMinWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinWin.BorderRadius = 20
        Me.btnMinWin.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMinWin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMinWin.ForeColor = System.Drawing.Color.White
        Me.btnMinWin.Location = New System.Drawing.Point(1013, 21)
        Me.btnMinWin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMinWin.Name = "btnMinWin"
        Me.btnMinWin.Size = New System.Drawing.Size(16, 15)
        Me.btnMinWin.TabIndex = 0
        '
        'lblKpiDevNum
        '
        Me.lblKpiDevNum.AutoSize = True
        Me.lblKpiDevNum.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiDevNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiDevNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblKpiDevNum.Location = New System.Drawing.Point(13, 41)
        Me.lblKpiDevNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiDevNum.Name = "lblKpiDevNum"
        Me.lblKpiDevNum.Size = New System.Drawing.Size(115, 41)
        Me.lblKpiDevNum.TabIndex = 1
        Me.lblKpiDevNum.Text = "18 / 25"
        '
        'pnlKpiCustomers
        '
        Me.pnlKpiCustomers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiCustomers.BorderRadius = 12
        Me.pnlKpiCustomers.BorderThickness = 1
        Me.pnlKpiCustomers.Controls.Add(Me.lblKpiCustIcon)
        Me.pnlKpiCustomers.Controls.Add(Me.lblKpiCustNum)
        Me.pnlKpiCustomers.Controls.Add(Me.lblKpiCustTitle)
        Me.pnlKpiCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiCustomers.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiCustomers.Location = New System.Drawing.Point(7, 7)
        Me.pnlKpiCustomers.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.pnlKpiCustomers.Name = "pnlKpiCustomers"
        Me.pnlKpiCustomers.Size = New System.Drawing.Size(202, 116)
        Me.pnlKpiCustomers.TabIndex = 0
        '
        'lblKpiCustIcon
        '
        Me.lblKpiCustIcon.AutoSize = True
        Me.lblKpiCustIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiCustIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiCustIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblKpiCustIcon.Location = New System.Drawing.Point(13, 11)
        Me.lblKpiCustIcon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiCustIcon.Name = "lblKpiCustIcon"
        Me.lblKpiCustIcon.Size = New System.Drawing.Size(47, 32)
        Me.lblKpiCustIcon.TabIndex = 0
        Me.lblKpiCustIcon.Text = "👥"
        '
        'lblKpiCustNum
        '
        Me.lblKpiCustNum.AutoSize = True
        Me.lblKpiCustNum.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiCustNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiCustNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblKpiCustNum.Location = New System.Drawing.Point(13, 41)
        Me.lblKpiCustNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiCustNum.Name = "lblKpiCustNum"
        Me.lblKpiCustNum.Size = New System.Drawing.Size(94, 41)
        Me.lblKpiCustNum.TabIndex = 1
        Me.lblKpiCustNum.Text = "1,247"
        '
        'lblKpiCustTitle
        '
        Me.lblKpiCustTitle.AutoSize = True
        Me.lblKpiCustTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiCustTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiCustTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiCustTitle.Location = New System.Drawing.Point(13, 82)
        Me.lblKpiCustTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiCustTitle.Name = "lblKpiCustTitle"
        Me.lblKpiCustTitle.Size = New System.Drawing.Size(93, 15)
        Me.lblKpiCustTitle.TabIndex = 2
        Me.lblKpiCustTitle.Text = "Total Customers"
        '
        'lblKpiDevTitle
        '
        Me.lblKpiDevTitle.AutoSize = True
        Me.lblKpiDevTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiDevTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiDevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiDevTitle.Location = New System.Drawing.Point(13, 82)
        Me.lblKpiDevTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiDevTitle.Name = "lblKpiDevTitle"
        Me.lblKpiDevTitle.Size = New System.Drawing.Size(83, 15)
        Me.lblKpiDevTitle.TabIndex = 2
        Me.lblKpiDevTitle.Text = "Active Devices"
        '
        'lblKpiSessIcon
        '
        Me.lblKpiSessIcon.AutoSize = True
        Me.lblKpiSessIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiSessIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiSessIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblKpiSessIcon.Location = New System.Drawing.Point(13, 11)
        Me.lblKpiSessIcon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiSessIcon.Name = "lblKpiSessIcon"
        Me.lblKpiSessIcon.Size = New System.Drawing.Size(47, 32)
        Me.lblKpiSessIcon.TabIndex = 0
        Me.lblKpiSessIcon.Text = "⏱"
        '
        'lblKpiSessNum
        '
        Me.lblKpiSessNum.AutoSize = True
        Me.lblKpiSessNum.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiSessNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiSessNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblKpiSessNum.Location = New System.Drawing.Point(13, 41)
        Me.lblKpiSessNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiSessNum.Name = "lblKpiSessNum"
        Me.lblKpiSessNum.Size = New System.Drawing.Size(35, 41)
        Me.lblKpiSessNum.TabIndex = 1
        Me.lblKpiSessNum.Text = "5"
        '
        'lblKpiSessTitle
        '
        Me.lblKpiSessTitle.AutoSize = True
        Me.lblKpiSessTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiSessTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiSessTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiSessTitle.Location = New System.Drawing.Point(13, 82)
        Me.lblKpiSessTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiSessTitle.Name = "lblKpiSessTitle"
        Me.lblKpiSessTitle.Size = New System.Drawing.Size(87, 15)
        Me.lblKpiSessTitle.TabIndex = 2
        Me.lblKpiSessTitle.Text = "Active Sessions"
        '
        'lblKpiRevIcon
        '
        Me.lblKpiRevIcon.AutoSize = True
        Me.lblKpiRevIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiRevIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiRevIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblKpiRevIcon.Location = New System.Drawing.Point(13, 11)
        Me.lblKpiRevIcon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiRevIcon.Name = "lblKpiRevIcon"
        Me.lblKpiRevIcon.Size = New System.Drawing.Size(47, 32)
        Me.lblKpiRevIcon.TabIndex = 0
        Me.lblKpiRevIcon.Text = "💰"
        '
        'lblKpiRevNum
        '
        Me.lblKpiRevNum.AutoSize = True
        Me.lblKpiRevNum.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiRevNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiRevNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblKpiRevNum.Location = New System.Drawing.Point(13, 41)
        Me.lblKpiRevNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiRevNum.Name = "lblKpiRevNum"
        Me.lblKpiRevNum.Size = New System.Drawing.Size(86, 41)
        Me.lblKpiRevNum.TabIndex = 1
        Me.lblKpiRevNum.Text = "$284"
        '
        'lblKpiRevTitle
        '
        Me.lblKpiRevTitle.AutoSize = True
        Me.lblKpiRevTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiRevTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKpiRevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblKpiRevTitle.Location = New System.Drawing.Point(13, 82)
        Me.lblKpiRevTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiRevTitle.Name = "lblKpiRevTitle"
        Me.lblKpiRevTitle.Size = New System.Drawing.Size(95, 15)
        Me.lblKpiRevTitle.TabIndex = 2
        Me.lblKpiRevTitle.Text = "Today's Revenue"
        '
        'lblHomeSubtitle
        '
        Me.lblHomeSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblHomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblHomeSubtitle.Location = New System.Drawing.Point(193, 73)
        Me.lblHomeSubtitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHomeSubtitle.Name = "lblHomeSubtitle"
        Me.lblHomeSubtitle.Size = New System.Drawing.Size(514, 22)
        Me.lblHomeSubtitle.TabIndex = 3
        Me.lblHomeSubtitle.Text = "Here's what's happening at your cyber café today."
        '
        'lblHomeGreeting
        '
        Me.lblHomeGreeting.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeGreeting.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblHomeGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblHomeGreeting.Location = New System.Drawing.Point(205, 13)
        Me.lblHomeGreeting.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHomeGreeting.Name = "lblHomeGreeting"
        Me.lblHomeGreeting.Size = New System.Drawing.Size(600, 41)
        Me.lblHomeGreeting.TabIndex = 4
        Me.lblHomeGreeting.Text = "👋  Good Morning, Administrator!"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.Controls.Add(Me.lblBreadcrumb)
        Me.pnlTopBar.Controls.Add(Me.lblClock)
        Me.pnlTopBar.Controls.Add(Me.pnlUserBadge)
        Me.pnlTopBar.Controls.Add(Me.btnCloseWin)
        Me.pnlTopBar.Controls.Add(Me.btnMinWin)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1066, 56)
        Me.pnlTopBar.TabIndex = 0
        '
        'lblBreadcrumb
        '
        Me.lblBreadcrumb.BackColor = System.Drawing.Color.Transparent
        Me.lblBreadcrumb.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblBreadcrumb.Location = New System.Drawing.Point(22, 15)
        Me.lblBreadcrumb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBreadcrumb.Name = "lblBreadcrumb"
        Me.lblBreadcrumb.Size = New System.Drawing.Size(160, 28)
        Me.lblBreadcrumb.TabIndex = 0
        Me.lblBreadcrumb.Text = "Dashboard"
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblClock.Location = New System.Drawing.Point(212, 15)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(123, 21)
        Me.lblClock.TabIndex = 1
        Me.lblClock.Text = "00:00:00   Mon, Jan 01 2025"
        '
        'pnlUserBadge
        '
        Me.pnlUserBadge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUserBadge.BackColor = System.Drawing.Color.Transparent
        Me.pnlUserBadge.Controls.Add(Me.lblUserName)
        Me.pnlUserBadge.Controls.Add(Me.lblUserRole)
        Me.pnlUserBadge.Location = New System.Drawing.Point(778, 9)
        Me.pnlUserBadge.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlUserBadge.Name = "pnlUserBadge"
        Me.pnlUserBadge.Size = New System.Drawing.Size(160, 40)
        Me.pnlUserBadge.TabIndex = 2
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(0, 2)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(102, 19)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Administrator"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.BackColor = System.Drawing.Color.Transparent
        Me.lblUserRole.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblUserRole.Location = New System.Drawing.Point(0, 23)
        Me.lblUserRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(40, 13)
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
        Me.btnCloseWin.Location = New System.Drawing.Point(1033, 21)
        Me.btnCloseWin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCloseWin.Name = "btnCloseWin"
        Me.btnCloseWin.Size = New System.Drawing.Size(16, 15)
        Me.btnCloseWin.TabIndex = 0
        '
        'lblKpiDevIcon
        '
        Me.lblKpiDevIcon.AutoSize = True
        Me.lblKpiDevIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblKpiDevIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblKpiDevIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblKpiDevIcon.Location = New System.Drawing.Point(13, 11)
        Me.lblKpiDevIcon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKpiDevIcon.Name = "lblKpiDevIcon"
        Me.lblKpiDevIcon.Size = New System.Drawing.Size(47, 32)
        Me.lblKpiDevIcon.TabIndex = 0
        Me.lblKpiDevIcon.Text = "🖥"
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'pnlKpiDevices
        '
        Me.pnlKpiDevices.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiDevices.BorderRadius = 12
        Me.pnlKpiDevices.BorderThickness = 1
        Me.pnlKpiDevices.Controls.Add(Me.lblKpiDevIcon)
        Me.pnlKpiDevices.Controls.Add(Me.lblKpiDevNum)
        Me.pnlKpiDevices.Controls.Add(Me.lblKpiDevTitle)
        Me.pnlKpiDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiDevices.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiDevices.Location = New System.Drawing.Point(223, 7)
        Me.pnlKpiDevices.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.pnlKpiDevices.Name = "pnlKpiDevices"
        Me.pnlKpiDevices.Size = New System.Drawing.Size(202, 116)
        Me.pnlKpiDevices.TabIndex = 1
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.lblLogoIcon)
        Me.pnlLogo.Controls.Add(Me.lblLogoText)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(188, 56)
        Me.pnlLogo.TabIndex = 0
        '
        'lblLogoIcon
        '
        Me.lblLogoIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblLogoIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblLogoIcon.Location = New System.Drawing.Point(14, 8)
        Me.lblLogoIcon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogoIcon.Name = "lblLogoIcon"
        Me.lblLogoIcon.Size = New System.Drawing.Size(31, 31)
        Me.lblLogoIcon.TabIndex = 0
        Me.lblLogoIcon.Text = "🎮"
        Me.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogoText
        '
        Me.lblLogoText.BackColor = System.Drawing.Color.Transparent
        Me.lblLogoText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblLogoText.Location = New System.Drawing.Point(50, 16)
        Me.lblLogoText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogoText.Name = "lblLogoText"
        Me.lblLogoText.Size = New System.Drawing.Size(133, 23)
        Me.lblLogoText.TabIndex = 1
        Me.lblLogoText.Text = "CyberCafe Pro"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.pnlNav)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(188, 565)
        Me.pnlSidebar.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 517)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(188, 48)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "   ⬛  Logout"
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlNav.Controls.Add(Me.btnNavConsumables)
        Me.pnlNav.Controls.Add(Me.btnNavTransactions)
        Me.pnlNav.Controls.Add(Me.btnNavSessions)
        Me.pnlNav.Controls.Add(Me.btnNavGames)
        Me.pnlNav.Controls.Add(Me.btnNavDevices)
        Me.pnlNav.Controls.Add(Me.btnNavCustomers)
        Me.pnlNav.Controls.Add(Me.btnNavUsers)
        Me.pnlNav.Controls.Add(Me.btnNavDashboard)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNav.Location = New System.Drawing.Point(0, 0)
        Me.pnlNav.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(188, 565)
        Me.pnlNav.TabIndex = 2
        '
        'btnNavConsumables
        '
        Me.btnNavConsumables.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavConsumables.ForeColor = System.Drawing.Color.White
        Me.btnNavConsumables.Location = New System.Drawing.Point(0, 0)
        Me.btnNavConsumables.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavConsumables.Name = "btnNavConsumables"
        Me.btnNavConsumables.Size = New System.Drawing.Size(154, 39)
        Me.btnNavConsumables.TabIndex = 0
        '
        'btnNavTransactions
        '
        Me.btnNavTransactions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavTransactions.ForeColor = System.Drawing.Color.White
        Me.btnNavTransactions.Location = New System.Drawing.Point(0, 0)
        Me.btnNavTransactions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavTransactions.Name = "btnNavTransactions"
        Me.btnNavTransactions.Size = New System.Drawing.Size(154, 39)
        Me.btnNavTransactions.TabIndex = 1
        '
        'btnNavSessions
        '
        Me.btnNavSessions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavSessions.ForeColor = System.Drawing.Color.White
        Me.btnNavSessions.Location = New System.Drawing.Point(0, 0)
        Me.btnNavSessions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavSessions.Name = "btnNavSessions"
        Me.btnNavSessions.Size = New System.Drawing.Size(154, 39)
        Me.btnNavSessions.TabIndex = 2
        '
        'btnNavGames
        '
        Me.btnNavGames.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavGames.ForeColor = System.Drawing.Color.White
        Me.btnNavGames.Location = New System.Drawing.Point(0, 0)
        Me.btnNavGames.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavGames.Name = "btnNavGames"
        Me.btnNavGames.Size = New System.Drawing.Size(154, 39)
        Me.btnNavGames.TabIndex = 3
        '
        'btnNavDevices
        '
        Me.btnNavDevices.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavDevices.ForeColor = System.Drawing.Color.White
        Me.btnNavDevices.Location = New System.Drawing.Point(0, 0)
        Me.btnNavDevices.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavDevices.Name = "btnNavDevices"
        Me.btnNavDevices.Size = New System.Drawing.Size(154, 39)
        Me.btnNavDevices.TabIndex = 4
        '
        'btnNavCustomers
        '
        Me.btnNavCustomers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavCustomers.ForeColor = System.Drawing.Color.White
        Me.btnNavCustomers.Location = New System.Drawing.Point(0, 0)
        Me.btnNavCustomers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavCustomers.Name = "btnNavCustomers"
        Me.btnNavCustomers.Size = New System.Drawing.Size(154, 39)
        Me.btnNavCustomers.TabIndex = 5
        '
        'btnNavUsers
        '
        Me.btnNavUsers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavUsers.ForeColor = System.Drawing.Color.White
        Me.btnNavUsers.Location = New System.Drawing.Point(0, 0)
        Me.btnNavUsers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavUsers.Name = "btnNavUsers"
        Me.btnNavUsers.Size = New System.Drawing.Size(154, 39)
        Me.btnNavUsers.TabIndex = 6
        '
        'btnNavDashboard
        '
        Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNavDashboard.ForeColor = System.Drawing.Color.White
        Me.btnNavDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnNavDashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNavDashboard.Name = "btnNavDashboard"
        Me.btnNavDashboard.Size = New System.Drawing.Size(154, 39)
        Me.btnNavDashboard.TabIndex = 7
        '
        'pnlKpiRevenue
        '
        Me.pnlKpiRevenue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiRevenue.BorderRadius = 12
        Me.pnlKpiRevenue.BorderThickness = 1
        Me.pnlKpiRevenue.Controls.Add(Me.lblKpiRevIcon)
        Me.pnlKpiRevenue.Controls.Add(Me.lblKpiRevNum)
        Me.pnlKpiRevenue.Controls.Add(Me.lblKpiRevTitle)
        Me.pnlKpiRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiRevenue.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiRevenue.Location = New System.Drawing.Point(655, 7)
        Me.pnlKpiRevenue.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.pnlKpiRevenue.Name = "pnlKpiRevenue"
        Me.pnlKpiRevenue.Size = New System.Drawing.Size(204, 116)
        Me.pnlKpiRevenue.TabIndex = 3
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlTopBar)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1066, 565)
        Me.pnlMain.TabIndex = 3
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.pnlHome)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 56)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1066, 509)
        Me.pnlContent.TabIndex = 1
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlHome.Controls.Add(Me.tblKpis)
        Me.pnlHome.Controls.Add(Me.lblHomeSubtitle)
        Me.pnlHome.Controls.Add(Me.lblHomeGreeting)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1066, 509)
        Me.pnlHome.TabIndex = 0
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
        Me.tblKpis.Location = New System.Drawing.Point(189, 108)
        Me.tblKpis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tblKpis.Name = "tblKpis"
        Me.tblKpis.RowCount = 1
        Me.tblKpis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblKpis.Size = New System.Drawing.Size(866, 130)
        Me.tblKpis.TabIndex = 2
        '
        'pnlKpiSessions
        '
        Me.pnlKpiSessions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiSessions.BorderRadius = 12
        Me.pnlKpiSessions.BorderThickness = 1
        Me.pnlKpiSessions.Controls.Add(Me.lblKpiSessIcon)
        Me.pnlKpiSessions.Controls.Add(Me.lblKpiSessNum)
        Me.pnlKpiSessions.Controls.Add(Me.lblKpiSessTitle)
        Me.pnlKpiSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiSessions.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiSessions.Location = New System.Drawing.Point(439, 7)
        Me.pnlKpiSessions.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.pnlKpiSessions.Name = "pnlKpiSessions"
        Me.pnlKpiSessions.Size = New System.Drawing.Size(202, 116)
        Me.pnlKpiSessions.TabIndex = 2
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 565)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.pnlKpiCustomers.ResumeLayout(False)
        Me.pnlKpiCustomers.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlUserBadge.ResumeLayout(False)
        Me.pnlUserBadge.PerformLayout()
        Me.pnlKpiDevices.ResumeLayout(False)
        Me.pnlKpiDevices.PerformLayout()
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlNav.ResumeLayout(False)
        Me.pnlKpiRevenue.ResumeLayout(False)
        Me.pnlKpiRevenue.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlHome.ResumeLayout(False)
        Me.tblKpis.ResumeLayout(False)
        Me.pnlKpiSessions.ResumeLayout(False)
        Me.pnlKpiSessions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnMinWin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents lblKpiDevNum As Label
    Private WithEvents pnlKpiCustomers As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblKpiCustIcon As Label
    Private WithEvents lblKpiCustNum As Label
    Private WithEvents lblKpiCustTitle As Label
    Private WithEvents lblKpiDevTitle As Label
    Private WithEvents lblKpiSessIcon As Label
    Private WithEvents lblKpiSessNum As Label
    Private WithEvents lblKpiSessTitle As Label
    Private WithEvents lblKpiRevIcon As Label
    Private WithEvents lblKpiRevNum As Label
    Private WithEvents lblKpiRevTitle As Label
    Private WithEvents lblHomeSubtitle As Label
    Private WithEvents lblHomeGreeting As Label
    Private WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblBreadcrumb As Label
    Private WithEvents lblClock As Label
    Private WithEvents pnlUserBadge As Panel
    Private WithEvents lblUserName As Label
    Private WithEvents lblUserRole As Label
    Private WithEvents btnCloseWin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents lblKpiDevIcon As Label
    Private WithEvents tmrClock As Timer
    Private WithEvents pnlKpiDevices As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlLogo As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblLogoIcon As Label
    Private WithEvents lblLogoText As Label
    Private WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlNav As Panel
    Private WithEvents btnNavConsumables As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnNavTransactions As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnNavSessions As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnNavGames As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnNavDevices As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnNavCustomers As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnNavUsers As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnNavDashboard As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlKpiRevenue As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlMain As Panel
    Private WithEvents pnlContent As Panel
    Private WithEvents pnlHome As Panel
    Private WithEvents tblKpis As TableLayoutPanel
    Private WithEvents pnlKpiSessions As Guna.UI2.WinForms.Guna2Panel
End Class
