<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrDeviceInfo
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
        Me.pnlDevice = New Guna.UI2.WinForms.Guna2Panel()
        Me.pbStatusDot = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.gnSeparator = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblDeviceType = New System.Windows.Forms.Label()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.pbDeviceIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlDevice.SuspendLayout()
        CType(Me.pbStatusDot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDeviceIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDevice
        '
        Me.pnlDevice.BorderRadius = 10
        Me.pnlDevice.Controls.Add(Me.pbStatusDot)
        Me.pnlDevice.Controls.Add(Me.lblStatus)
        Me.pnlDevice.Controls.Add(Me.gnSeparator)
        Me.pnlDevice.Controls.Add(Me.lblDeviceType)
        Me.pnlDevice.Controls.Add(Me.lblDeviceName)
        Me.pnlDevice.Controls.Add(Me.pbDeviceIcon)
        Me.pnlDevice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDevice.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlDevice.Location = New System.Drawing.Point(0, 0)
        Me.pnlDevice.Name = "pnlDevice"
        Me.pnlDevice.Size = New System.Drawing.Size(220, 210)
        Me.pnlDevice.TabIndex = 0
        '
        'pbStatusDot
        '
        Me.pbStatusDot.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pbStatusDot.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.pbStatusDot.ImageRotate = 0!
        Me.pbStatusDot.Location = New System.Drawing.Point(22, 170)
        Me.pbStatusDot.Name = "pbStatusDot"
        Me.pbStatusDot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbStatusDot.Size = New System.Drawing.Size(12, 12)
        Me.pbStatusDot.TabIndex = 23
        Me.pbStatusDot.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(40, 162)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 28)
        Me.lblStatus.TabIndex = 24
        Me.lblStatus.Text = "Available"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gnSeparator
        '
        Me.gnSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gnSeparator.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.gnSeparator.Location = New System.Drawing.Point(15, 145)
        Me.gnSeparator.Name = "gnSeparator"
        Me.gnSeparator.Size = New System.Drawing.Size(190, 10)
        Me.gnSeparator.TabIndex = 22
        '
        'lblDeviceType
        '
        Me.lblDeviceType.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblDeviceType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDeviceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblDeviceType.Location = New System.Drawing.Point(18, 115)
        Me.lblDeviceType.Name = "lblDeviceType"
        Me.lblDeviceType.Size = New System.Drawing.Size(150, 25)
        Me.lblDeviceType.TabIndex = 21
        Me.lblDeviceType.Text = "Type"
        Me.lblDeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeviceName
        '
        Me.lblDeviceName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblDeviceName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeviceName.ForeColor = System.Drawing.Color.White
        Me.lblDeviceName.Location = New System.Drawing.Point(15, 75)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(190, 40)
        Me.lblDeviceName.TabIndex = 20
        Me.lblDeviceName.Text = "PC-01"
        Me.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbDeviceIcon
        '
        Me.pbDeviceIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pbDeviceIcon.Image = My.Resources.VR_icon
        Me.pbDeviceIcon.ImageRotate = 0!
        Me.pbDeviceIcon.Location = New System.Drawing.Point(20, 20)
        Me.pbDeviceIcon.Name = "pbDeviceIcon"
        Me.pbDeviceIcon.Size = New System.Drawing.Size(45, 45)
        Me.pbDeviceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDeviceIcon.TabIndex = 19
        Me.pbDeviceIcon.TabStop = False
        '
        'ctrDeviceInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Controls.Add(Me.pnlDevice)
        Me.Name = "ctrDeviceInfo"
        Me.Size = New System.Drawing.Size(220, 210)
        Me.pnlDevice.ResumeLayout(False)
        CType(Me.pbStatusDot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDeviceIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDevice As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pbStatusDot As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents gnSeparator As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblDeviceType As Label
    Friend WithEvents lblDeviceName As Label
    Friend WithEvents pbDeviceIcon As Guna.UI2.WinForms.Guna2PictureBox
End Class