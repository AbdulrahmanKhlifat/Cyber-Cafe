<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrShowDeviceInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.gnCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.pbStatusDot = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.gnSeparator = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblDeviceType = New System.Windows.Forms.Label()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.pbDeviceIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.gnCard.SuspendLayout()
        CType(Me.pbStatusDot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDeviceIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gnCard
        '
        Me.gnCard.BackColor = System.Drawing.Color.Transparent
        Me.gnCard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.gnCard.BorderRadius = 18
        Me.gnCard.BorderThickness = 1
        Me.gnCard.Controls.Add(Me.pbStatusDot)
        Me.gnCard.Controls.Add(Me.lblStatus)
        Me.gnCard.Controls.Add(Me.gnSeparator)
        Me.gnCard.Controls.Add(Me.lblDeviceType)
        Me.gnCard.Controls.Add(Me.lblDeviceName)
        Me.gnCard.Controls.Add(Me.pbDeviceIcon)
        Me.gnCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gnCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.gnCard.Location = New System.Drawing.Point(0, 0)
        Me.gnCard.Name = "gnCard"
        Me.gnCard.ShadowDecoration.BorderRadius = 18
        Me.gnCard.ShadowDecoration.Enabled = True
        Me.gnCard.Size = New System.Drawing.Size(220, 210)
        Me.gnCard.TabIndex = 0
        '
        'pbStatusDot
        '
        Me.pbStatusDot.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.pbStatusDot.ImageRotate = 0!
        Me.pbStatusDot.Location = New System.Drawing.Point(22, 170)
        Me.pbStatusDot.Name = "pbStatusDot"
        Me.pbStatusDot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbStatusDot.Size = New System.Drawing.Size(12, 12)
        Me.pbStatusDot.TabIndex = 5
        Me.pbStatusDot.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(40, 162)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 28)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Available"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gnSeparator
        '
        Me.gnSeparator.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.gnSeparator.Location = New System.Drawing.Point(15, 145)
        Me.gnSeparator.Name = "gnSeparator"
        Me.gnSeparator.Size = New System.Drawing.Size(190, 10)
        Me.gnSeparator.TabIndex = 4
        '
        'lblDeviceType
        '
        Me.lblDeviceType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDeviceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblDeviceType.Location = New System.Drawing.Point(18, 115)
        Me.lblDeviceType.Name = "lblDeviceType"
        Me.lblDeviceType.Size = New System.Drawing.Size(150, 25)
        Me.lblDeviceType.TabIndex = 3
        Me.lblDeviceType.Text = "Type"
        Me.lblDeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeviceName
        '
        Me.lblDeviceName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeviceName.ForeColor = System.Drawing.Color.White
        Me.lblDeviceName.Location = New System.Drawing.Point(15, 75)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(190, 40)
        Me.lblDeviceName.TabIndex = 2
        Me.lblDeviceName.Text = "PC-01"
        Me.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbDeviceIcon
        '
        Me.pbDeviceIcon.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.images__1__removebg_preview
        Me.pbDeviceIcon.ImageRotate = 0!
        Me.pbDeviceIcon.Location = New System.Drawing.Point(20, 20)
        Me.pbDeviceIcon.Name = "pbDeviceIcon"
        Me.pbDeviceIcon.Size = New System.Drawing.Size(45, 45)
        Me.pbDeviceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDeviceIcon.TabIndex = 0
        Me.pbDeviceIcon.TabStop = False
        '
        'ctrShowDeviceInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gnCard)
        Me.Name = "ctrShowDeviceInfo"
        Me.Size = New System.Drawing.Size(220, 210)
        Me.gnCard.ResumeLayout(False)
        CType(Me.pbStatusDot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDeviceIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gnCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pbDeviceIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblDeviceName As Label
    Friend WithEvents lblDeviceType As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents pbStatusDot As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents gnSeparator As Guna.UI2.WinForms.Guna2Separator
End Class