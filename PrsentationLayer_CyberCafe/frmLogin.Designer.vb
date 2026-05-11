<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.pnlBrand = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTline = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.pnlLoginCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRememberMe = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.lblTries = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRoleHdr = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPasswordHdr = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUsernameHdr = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlBrand.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBrand
        '
        Me.pnlBrand.Controls.Add(Me.PictureBox1)
        Me.pnlBrand.Controls.Add(Me.lblTline)
        Me.pnlBrand.Controls.Add(Me.lblAppName)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBrand.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(308, 450)
        Me.pnlBrand.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.PictureBox1.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources._4239781_200
        Me.PictureBox1.Location = New System.Drawing.Point(105, 132)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblTline
        '
        Me.lblTline.BackColor = System.Drawing.Color.Transparent
        Me.lblTline.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTline.ForeColor = System.Drawing.Color.Black
        Me.lblTline.Location = New System.Drawing.Point(24, 274)
        Me.lblTline.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTline.Name = "lblTline"
        Me.lblTline.Size = New System.Drawing.Size(257, 26)
        Me.lblTline.TabIndex = 0
        Me.lblTline.Text = "Gaming Center Management System"
        Me.lblTline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAppName
        '
        Me.lblAppName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppName.ForeColor = System.Drawing.Color.Black
        Me.lblAppName.Location = New System.Drawing.Point(26, 222)
        Me.lblAppName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(257, 43)
        Me.lblAppName.TabIndex = 1
        Me.lblAppName.Text = "CyberCafe Pro"
        Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLoginCard
        '
        Me.pnlLoginCard.Controls.Add(Me.Label1)
        Me.pnlLoginCard.Controls.Add(Me.chkRememberMe)
        Me.pnlLoginCard.Controls.Add(Me.lblTries)
        Me.pnlLoginCard.Controls.Add(Me.btnExit)
        Me.pnlLoginCard.Controls.Add(Me.btnLogin)
        Me.pnlLoginCard.Controls.Add(Me.lblRoleHdr)
        Me.pnlLoginCard.Controls.Add(Me.txtPassword)
        Me.pnlLoginCard.Controls.Add(Me.lblPasswordHdr)
        Me.pnlLoginCard.Controls.Add(Me.txtUsername)
        Me.pnlLoginCard.Controls.Add(Me.lblUsernameHdr)
        Me.pnlLoginCard.Controls.Add(Me.lblSubtitle)
        Me.pnlLoginCard.Controls.Add(Me.lblWelcome)
        Me.pnlLoginCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlLoginCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoginCard.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLoginCard.Name = "pnlLoginCard"
        Me.pnlLoginCard.Size = New System.Drawing.Size(721, 450)
        Me.pnlLoginCard.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(382, 260)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Remember me"
        '
        'chkRememberMe
        '
        Me.chkRememberMe.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.chkRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkRememberMe.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.chkRememberMe.CheckedState.InnerColor = System.Drawing.Color.White
        Me.chkRememberMe.Location = New System.Drawing.Point(347, 258)
        Me.chkRememberMe.Name = "chkRememberMe"
        Me.chkRememberMe.Size = New System.Drawing.Size(35, 18)
        Me.chkRememberMe.TabIndex = 46
        Me.chkRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkRememberMe.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.chkRememberMe.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'lblTries
        '
        Me.lblTries.AutoSize = True
        Me.lblTries.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblTries.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.lblTries.ForeColor = System.Drawing.Color.Red
        Me.lblTries.Location = New System.Drawing.Point(418, 366)
        Me.lblTries.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTries.Name = "lblTries"
        Me.lblTries.Size = New System.Drawing.Size(188, 34)
        Me.lblTries.TabIndex = 45
        Me.lblTries.Tag = "5"
        Me.lblTries.Text = "Wrong Username or Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Number of Tries Left: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTries.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(682, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(39, 42)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "✕"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLogin.BorderRadius = 10
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(345, 287)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(343, 41)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Sign In  →"
        '
        'lblRoleHdr
        '
        Me.lblRoleHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRoleHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblRoleHdr.Location = New System.Drawing.Point(60, 321)
        Me.lblRoleHdr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoleHdr.Name = "lblRoleHdr"
        Me.lblRoleHdr.Size = New System.Drawing.Size(172, 17)
        Me.lblRoleHdr.TabIndex = 4
        Me.lblRoleHdr.Text = "ROLE"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPassword.BorderRadius = 8
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(344, 213)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderText = "Enter your password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(343, 38)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPasswordHdr
        '
        Me.lblPasswordHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPasswordHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPasswordHdr.Location = New System.Drawing.Point(60, 247)
        Me.lblPasswordHdr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswordHdr.Name = "lblPasswordHdr"
        Me.lblPasswordHdr.Size = New System.Drawing.Size(172, 17)
        Me.lblPasswordHdr.TabIndex = 5
        Me.lblPasswordHdr.Text = "PASSWORD"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtUsername.BorderRadius = 8
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(344, 139)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Enter your username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(343, 38)
        Me.txtUsername.TabIndex = 0
        '
        'lblUsernameHdr
        '
        Me.lblUsernameHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblUsernameHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblUsernameHdr.Location = New System.Drawing.Point(60, 173)
        Me.lblUsernameHdr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsernameHdr.Name = "lblUsernameHdr"
        Me.lblUsernameHdr.Size = New System.Drawing.Size(172, 17)
        Me.lblUsernameHdr.TabIndex = 6
        Me.lblUsernameHdr.Text = "USERNAME"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(344, 91)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(343, 22)
        Me.lblSubtitle.TabIndex = 7
        Me.lblSubtitle.Text = "Sign in to your account"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(337, 43)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(343, 43)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome Back"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 450)
        Me.Controls.Add(Me.pnlBrand)
        Me.Controls.Add(Me.pnlLoginCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlBrand.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginCard.ResumeLayout(False)
        Me.pnlLoginCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlBrand As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblTline As Label
    Private WithEvents lblAppName As Label
    Private WithEvents pnlLoginCard As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Private WithEvents lblRoleHdr As Label
    Private WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblPasswordHdr As Label
    Private WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblUsernameHdr As Label
    Private WithEvents lblSubtitle As Label
    Private WithEvents lblWelcome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents btnExit As Button
    Private WithEvents lblTries As Label
    Friend WithEvents chkRememberMe As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Label1 As Label
End Class
