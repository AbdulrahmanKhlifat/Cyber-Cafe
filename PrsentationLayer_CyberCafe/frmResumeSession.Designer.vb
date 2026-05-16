Imports Guna.UI2.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResumeSession
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlInfoCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblSessionID = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCurrentDevice = New System.Windows.Forms.Label()
        Me.lblDeviceType = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.lblSelectDevice = New System.Windows.Forms.Label()
        Me.cmbDevices = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblHelperText = New System.Windows.Forms.Label()
        Me.btnResume = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlInfoCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(255, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Resume Paused Session"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 55)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(295, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Select an available device with the same platform type."
        '
        'pnlInfoCard
        '
        Me.pnlInfoCard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlInfoCard.BorderRadius = 8
        Me.pnlInfoCard.BorderThickness = 1
        Me.pnlInfoCard.Controls.Add(Me.lblSessionID)
        Me.pnlInfoCard.Controls.Add(Me.lblCustomerName)
        Me.pnlInfoCard.Controls.Add(Me.lblCurrentDevice)
        Me.pnlInfoCard.Controls.Add(Me.lblDeviceType)
        Me.pnlInfoCard.Controls.Add(Me.lblRemainingTime)
        Me.pnlInfoCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlInfoCard.Location = New System.Drawing.Point(24, 77)
        Me.pnlInfoCard.Name = "pnlInfoCard"
        Me.pnlInfoCard.Size = New System.Drawing.Size(350, 140)
        Me.pnlInfoCard.TabIndex = 2
        '
        'lblSessionID
        '
        Me.lblSessionID.AutoSize = True
        Me.lblSessionID.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSessionID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSessionID.ForeColor = System.Drawing.Color.White
        Me.lblSessionID.Location = New System.Drawing.Point(15, 15)
        Me.lblSessionID.Name = "lblSessionID"
        Me.lblSessionID.Size = New System.Drawing.Size(67, 15)
        Me.lblSessionID.TabIndex = 0
        Me.lblSessionID.Text = "Session ID:"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(15, 40)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(62, 15)
        Me.lblCustomerName.TabIndex = 1
        Me.lblCustomerName.Text = "Customer:"
        '
        'lblCurrentDevice
        '
        Me.lblCurrentDevice.AutoSize = True
        Me.lblCurrentDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCurrentDevice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCurrentDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblCurrentDevice.Location = New System.Drawing.Point(15, 65)
        Me.lblCurrentDevice.Name = "lblCurrentDevice"
        Me.lblCurrentDevice.Size = New System.Drawing.Size(88, 15)
        Me.lblCurrentDevice.TabIndex = 2
        Me.lblCurrentDevice.Text = "Current Device:"
        '
        'lblDeviceType
        '
        Me.lblDeviceType.AutoSize = True
        Me.lblDeviceType.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblDeviceType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDeviceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblDeviceType.Location = New System.Drawing.Point(15, 90)
        Me.lblDeviceType.Name = "lblDeviceType"
        Me.lblDeviceType.Size = New System.Drawing.Size(73, 15)
        Me.lblDeviceType.TabIndex = 3
        Me.lblDeviceType.Text = "Device Type:"
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.AutoSize = True
        Me.lblRemainingTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblRemainingTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRemainingTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblRemainingTime.Location = New System.Drawing.Point(15, 115)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(97, 15)
        Me.lblRemainingTime.TabIndex = 4
        Me.lblRemainingTime.Text = "Remaining Time:"
        '
        'lblSelectDevice
        '
        Me.lblSelectDevice.AutoSize = True
        Me.lblSelectDevice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelectDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblSelectDevice.Location = New System.Drawing.Point(22, 250)
        Me.lblSelectDevice.Name = "lblSelectDevice"
        Me.lblSelectDevice.Size = New System.Drawing.Size(119, 15)
        Me.lblSelectDevice.TabIndex = 3
        Me.lblSelectDevice.Text = "SELECT NEW DEVICE"
        '
        'cmbDevices
        '
        Me.cmbDevices.BackColor = System.Drawing.Color.Transparent
        Me.cmbDevices.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbDevices.BorderRadius = 8
        Me.cmbDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDevices.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmbDevices.FocusedColor = System.Drawing.Color.Empty
        Me.cmbDevices.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDevices.ForeColor = System.Drawing.Color.White
        Me.cmbDevices.ItemHeight = 30
        Me.cmbDevices.Location = New System.Drawing.Point(25, 275)
        Me.cmbDevices.Name = "cmbDevices"
        Me.cmbDevices.Size = New System.Drawing.Size(350, 36)
        Me.cmbDevices.TabIndex = 4
        '
        'lblHelperText
        '
        Me.lblHelperText.AutoSize = True
        Me.lblHelperText.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblHelperText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblHelperText.Location = New System.Drawing.Point(25, 320)
        Me.lblHelperText.Name = "lblHelperText"
        Me.lblHelperText.Size = New System.Drawing.Size(304, 13)
        Me.lblHelperText.TabIndex = 5
        Me.lblHelperText.Text = "Only devices matching the session platform are displayed."
        '
        'btnResume
        '
        Me.btnResume.BorderRadius = 8
        Me.btnResume.Enabled = False
        Me.btnResume.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnResume.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnResume.ForeColor = System.Drawing.Color.White
        Me.btnResume.Location = New System.Drawing.Point(215, 360)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(160, 45)
        Me.btnResume.TabIndex = 6
        Me.btnResume.Text = "Resume Session"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(25, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 45)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'frmResumeSession
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 430)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.lblHelperText)
        Me.Controls.Add(Me.cmbDevices)
        Me.Controls.Add(Me.lblSelectDevice)
        Me.Controls.Add(Me.pnlInfoCard)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmResumeSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resume Session"
        Me.pnlInfoCard.ResumeLayout(False)
        Me.pnlInfoCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlInfoCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSessionID As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCurrentDevice As Label
    Friend WithEvents lblDeviceType As Label
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents lblSelectDevice As Label
    Friend WithEvents cmbDevices As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblHelperText As Label
    Friend WithEvents btnResume As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
