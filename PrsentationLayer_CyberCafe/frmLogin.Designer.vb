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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRoleHdr = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPasswordHdr = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUsernameHdr = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lnkForgot = New System.Windows.Forms.LinkLabel()
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
        Me.pnlBrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(411, 554)
        Me.pnlBrand.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.PictureBox1.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources._4239781_200
        Me.PictureBox1.Location = New System.Drawing.Point(140, 162)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblTline
        '
        Me.lblTline.BackColor = System.Drawing.Color.Transparent
        Me.lblTline.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTline.ForeColor = System.Drawing.Color.Black
        Me.lblTline.Location = New System.Drawing.Point(32, 337)
        Me.lblTline.Name = "lblTline"
        Me.lblTline.Size = New System.Drawing.Size(343, 32)
        Me.lblTline.TabIndex = 0
        Me.lblTline.Text = "Gaming Center Management System"
        Me.lblTline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAppName
        '
        Me.lblAppName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppName.ForeColor = System.Drawing.Color.Black
        Me.lblAppName.Location = New System.Drawing.Point(35, 273)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(343, 53)
        Me.lblAppName.TabIndex = 1
        Me.lblAppName.Text = "CyberCafe Pro"
        Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLoginCard
        '
        Me.pnlLoginCard.Controls.Add(Me.lnkForgot)
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
        Me.pnlLoginCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLoginCard.Name = "pnlLoginCard"
        Me.pnlLoginCard.Size = New System.Drawing.Size(961, 554)
        Me.pnlLoginCard.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(909, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(52, 52)
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
        Me.btnLogin.Location = New System.Drawing.Point(460, 353)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(457, 50)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Sign In  →"
        '
        'lblRoleHdr
        '
        Me.lblRoleHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRoleHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblRoleHdr.Location = New System.Drawing.Point(80, 395)
        Me.lblRoleHdr.Name = "lblRoleHdr"
        Me.lblRoleHdr.Size = New System.Drawing.Size(229, 21)
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
        Me.txtPassword.Location = New System.Drawing.Point(459, 262)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderText = "Enter your password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(457, 47)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPasswordHdr
        '
        Me.lblPasswordHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPasswordHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPasswordHdr.Location = New System.Drawing.Point(80, 304)
        Me.lblPasswordHdr.Name = "lblPasswordHdr"
        Me.lblPasswordHdr.Size = New System.Drawing.Size(229, 21)
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
        Me.txtUsername.Location = New System.Drawing.Point(459, 171)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Enter your username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(457, 47)
        Me.txtUsername.TabIndex = 0
        '
        'lblUsernameHdr
        '
        Me.lblUsernameHdr.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblUsernameHdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblUsernameHdr.Location = New System.Drawing.Point(80, 213)
        Me.lblUsernameHdr.Name = "lblUsernameHdr"
        Me.lblUsernameHdr.Size = New System.Drawing.Size(229, 21)
        Me.lblUsernameHdr.TabIndex = 6
        Me.lblUsernameHdr.Text = "USERNAME"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(459, 112)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(457, 27)
        Me.lblSubtitle.TabIndex = 7
        Me.lblSubtitle.Text = "Sign in to your account"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(449, 53)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(457, 53)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome Back"
        '
        'lnkForgot
        '
        Me.lnkForgot.AutoSize = True
        Me.lnkForgot.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lnkForgot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!)
        Me.lnkForgot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lnkForgot.Location = New System.Drawing.Point(604, 440)
        Me.lnkForgot.Name = "lnkForgot"
        Me.lnkForgot.Size = New System.Drawing.Size(145, 20)
        Me.lnkForgot.TabIndex = 44
        Me.lnkForgot.TabStop = True
        Me.lnkForgot.Text = "Forgot Password?"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 554)
        Me.Controls.Add(Me.pnlBrand)
        Me.Controls.Add(Me.pnlLoginCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents lnkForgot As LinkLabel
End Class
