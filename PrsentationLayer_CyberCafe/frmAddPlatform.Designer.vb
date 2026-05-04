<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPlatform
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPlatformName = New System.Windows.Forms.Label()
        Me.txtPlatformName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.picPlatform = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnBrowseImage = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(153, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add Platform"
        '
        'lblPlatformName
        '
        Me.lblPlatformName.AutoSize = True
        Me.lblPlatformName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlatformName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPlatformName.Location = New System.Drawing.Point(22, 70)
        Me.lblPlatformName.Name = "lblPlatformName"
        Me.lblPlatformName.Size = New System.Drawing.Size(105, 15)
        Me.lblPlatformName.TabIndex = 1
        Me.lblPlatformName.Text = "PLATFORM NAME"
        '
        'txtPlatformName
        '
        Me.txtPlatformName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPlatformName.BorderRadius = 8
        Me.txtPlatformName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlatformName.DefaultText = ""
        Me.txtPlatformName.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPlatformName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPlatformName.ForeColor = System.Drawing.Color.White
        Me.txtPlatformName.Location = New System.Drawing.Point(25, 90)
        Me.txtPlatformName.Name = "txtPlatformName"
        Me.txtPlatformName.PlaceholderText = ""
        Me.txtPlatformName.SelectedText = ""
        Me.txtPlatformName.Size = New System.Drawing.Size(350, 40)
        Me.txtPlatformName.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(22, 140)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(84, 15)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "DESCRIPTION"
        '
        'txtDescription
        '
        Me.txtDescription.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtDescription.BorderRadius = 8
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDescription.ForeColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(25, 160)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(350, 80)
        Me.txtDescription.TabIndex = 4
        '
        'picPlatform
        '
        Me.picPlatform.BorderRadius = 8
        Me.picPlatform.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.picPlatform.ImageRotate = 0!
        Me.picPlatform.Location = New System.Drawing.Point(25, 260)
        Me.picPlatform.Name = "picPlatform"
        Me.picPlatform.Size = New System.Drawing.Size(100, 100)
        Me.picPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlatform.TabIndex = 5
        Me.picPlatform.TabStop = False
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.BorderRadius = 8
        Me.btnBrowseImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnBrowseImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBrowseImage.ForeColor = System.Drawing.Color.White
        Me.btnBrowseImage.Location = New System.Drawing.Point(140, 320)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(120, 40)
        Me.btnBrowseImage.TabIndex = 6
        Me.btnBrowseImage.Text = "Browse Image"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 8
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(215, 380)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 45)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Platform"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(25, 380)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 45)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'frmAddPlatform
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.picPlatform)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtPlatformName)
        Me.Controls.Add(Me.lblPlatformName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddPlatform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Platform"
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPlatformName As Label
    Friend WithEvents txtPlatformName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picPlatform As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnBrowseImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
