<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnSessions = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDevices = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlUserBadge.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinWin
        '
        Me.btnMinWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinWin.BorderRadius = 20
        Me.btnMinWin.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMinWin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMinWin.ForeColor = System.Drawing.Color.White
        Me.btnMinWin.Location = New System.Drawing.Point(1166, 21)
        Me.btnMinWin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinWin.Name = "btnMinWin"
        Me.btnMinWin.Size = New System.Drawing.Size(12, 12)
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
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1226, 56)
        Me.pnlTopBar.TabIndex = 0
        '
        'lblLogoIcon
        '
        Me.lblLogoIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblLogoIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblLogoIcon.Location = New System.Drawing.Point(7, 6)
        Me.lblLogoIcon.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogoIcon.Name = "lblLogoIcon"
        Me.lblLogoIcon.Size = New System.Drawing.Size(23, 25)
        Me.lblLogoIcon.TabIndex = 3
        Me.lblLogoIcon.Text = "🎮"
        Me.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogoText
        '
        Me.lblLogoText.BackColor = System.Drawing.Color.Transparent
        Me.lblLogoText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblLogoText.Location = New System.Drawing.Point(33, 12)
        Me.lblLogoText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogoText.Name = "lblLogoText"
        Me.lblLogoText.Size = New System.Drawing.Size(100, 19)
        Me.lblLogoText.TabIndex = 4
        Me.lblLogoText.Text = "CyberCafe Pro"
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblClock.Location = New System.Drawing.Point(186, 13)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(92, 17)
        Me.lblClock.TabIndex = 1
        Me.lblClock.Text = "00:00:00   Mon, Jan 01 2025"
        '
        'pnlUserBadge
        '
        Me.pnlUserBadge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUserBadge.BackColor = System.Drawing.Color.Transparent
        Me.pnlUserBadge.Controls.Add(Me.lblUserName)
        Me.pnlUserBadge.Controls.Add(Me.lblUserRole)
        Me.pnlUserBadge.Location = New System.Drawing.Point(933, 9)
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
        Me.lblUserName.Location = New System.Drawing.Point(14, 2)
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
        Me.lblUserRole.Location = New System.Drawing.Point(14, 23)
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
        Me.btnCloseWin.Location = New System.Drawing.Point(1193, 21)
        Me.btnCloseWin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCloseWin.Name = "btnCloseWin"
        Me.btnCloseWin.Size = New System.Drawing.Size(12, 12)
        Me.btnCloseWin.TabIndex = 0
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlNav.Controls.Add(Me.btnTransactions)
        Me.pnlNav.Controls.Add(Me.btnDashboard)
        Me.pnlNav.Controls.Add(Me.btnSessions)
        Me.pnlNav.Controls.Add(Me.btnCustomers)
        Me.pnlNav.Controls.Add(Me.btnLogout)
        Me.pnlNav.Controls.Add(Me.btnDevices)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(0, 56)
        Me.pnlNav.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(182, 547)
        Me.pnlNav.TabIndex = 2
        '
        'btnTransactions
        '
        Me.btnTransactions.FlatAppearance.BorderSize = 0
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTransactions.ForeColor = System.Drawing.Color.White
        Me.btnTransactions.Location = New System.Drawing.Point(3, 232)
        Me.btnTransactions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(178, 54)
        Me.btnTransactions.TabIndex = 0
        Me.btnTransactions.Text = "Transactions"
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(182, 54)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        '
        'btnSessions
        '
        Me.btnSessions.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSessions.FlatAppearance.BorderSize = 0
        Me.btnSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSessions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSessions.ForeColor = System.Drawing.Color.White
        Me.btnSessions.Location = New System.Drawing.Point(1, 173)
        Me.btnSessions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSessions.Name = "btnSessions"
        Me.btnSessions.Size = New System.Drawing.Size(177, 44)
        Me.btnSessions.TabIndex = 11
        Me.btnSessions.Text = "Sessions"
        Me.btnSessions.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Location = New System.Drawing.Point(2, 115)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(177, 44)
        Me.btnCustomers.TabIndex = 10
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(0, 508)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(182, 39)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "   ⬛  Logout"
        '
        'btnDevices
        '
        Me.btnDevices.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDevices.FlatAppearance.BorderSize = 0
        Me.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevices.ForeColor = System.Drawing.Color.White
        Me.btnDevices.Location = New System.Drawing.Point(3, 58)
        Me.btnDevices.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDevices.Name = "btnDevices"
        Me.btnDevices.Size = New System.Drawing.Size(177, 44)
        Me.btnDevices.TabIndex = 8
        Me.btnDevices.Text = "Devices"
        Me.btnDevices.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(182, 56)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1044, 547)
        Me.pnlMain.TabIndex = 3
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1226, 603)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.pnlTopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlUserBadge.ResumeLayout(False)
        Me.pnlUserBadge.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
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
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnSessions As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnTransactions As Button
End Class
