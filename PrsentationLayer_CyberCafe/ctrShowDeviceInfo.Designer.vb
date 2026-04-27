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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbStatusDot = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
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
        Me.gnCard.BorderRadius = 15
        Me.gnCard.BorderThickness = 1
        Me.gnCard.Controls.Add(Me.Panel1)
        Me.gnCard.Controls.Add(Me.pbStatusDot)
        Me.gnCard.Controls.Add(Me.lblStatus)
        Me.gnCard.Controls.Add(Me.lblDeviceType)
        Me.gnCard.Controls.Add(Me.lblDeviceName)
        Me.gnCard.Controls.Add(Me.pbDeviceIcon)
        Me.gnCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gnCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.gnCard.Location = New System.Drawing.Point(0, 0)
        Me.gnCard.Name = "gnCard"
        Me.gnCard.ShadowDecoration.BorderRadius = 15
        Me.gnCard.ShadowDecoration.Depth = 10
        Me.gnCard.ShadowDecoration.Enabled = True
        Me.gnCard.Size = New System.Drawing.Size(220, 208)
        Me.gnCard.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 2)
        Me.Panel1.TabIndex = 5
        '
        'pbStatusDot
        '
        Me.pbStatusDot.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.pbStatusDot.ImageRotate = 0!
        Me.pbStatusDot.Location = New System.Drawing.Point(43, 177)
        Me.pbStatusDot.Name = "pbStatusDot"
        Me.pbStatusDot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbStatusDot.Size = New System.Drawing.Size(12, 12)
        Me.pbStatusDot.TabIndex = 4
        Me.pbStatusDot.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(63, 168)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(110, 25)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Available"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeviceType
        '
        Me.lblDeviceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeviceType.ForeColor = System.Drawing.Color.Gray
        Me.lblDeviceType.Location = New System.Drawing.Point(65, 113)
        Me.lblDeviceType.Name = "lblDeviceType"
        Me.lblDeviceType.Size = New System.Drawing.Size(81, 25)
        Me.lblDeviceType.TabIndex = 2
        Me.lblDeviceType.Text = "PC"
        Me.lblDeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeviceName
        '
        Me.lblDeviceName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeviceName.ForeColor = System.Drawing.Color.White
        Me.lblDeviceName.Location = New System.Drawing.Point(41, 9)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(136, 30)
        Me.lblDeviceName.TabIndex = 1
        Me.lblDeviceName.Text = "Device #01"
        Me.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbDeviceIcon
        '
        Me.pbDeviceIcon.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.imac
        Me.pbDeviceIcon.ImageRotate = 0!
        Me.pbDeviceIcon.Location = New System.Drawing.Point(67, 41)
        Me.pbDeviceIcon.Name = "pbDeviceIcon"
        Me.pbDeviceIcon.Size = New System.Drawing.Size(79, 60)
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
        Me.Size = New System.Drawing.Size(220, 208)
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
    Friend WithEvents Panel1 As Panel
End Class