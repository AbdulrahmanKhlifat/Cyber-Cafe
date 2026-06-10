Imports Guna.UI2.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStartSession
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
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.cmbCustomers = New System.Windows.Forms.ComboBox()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.txtDeviceName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.numHours = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.txtSeconds = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(146, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Start Session"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCustomer.Location = New System.Drawing.Point(22, 70)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(71, 15)
        Me.lblCustomer.TabIndex = 1
        Me.lblCustomer.Text = "CUSTOMER"
        '
        'cmbCustomers
        '
        Me.cmbCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmbCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustomers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCustomers.ForeColor = System.Drawing.Color.White
        Me.cmbCustomers.ItemHeight = 17
        Me.cmbCustomers.Location = New System.Drawing.Point(25, 99)
        Me.cmbCustomers.Name = "cmbCustomers"
        Me.cmbCustomers.Size = New System.Drawing.Size(350, 25)
        Me.cmbCustomers.TabIndex = 2
        '
        'lblDevice
        '
        Me.lblDevice.AutoSize = True
        Me.lblDevice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDevice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDevice.Location = New System.Drawing.Point(22, 140)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(47, 15)
        Me.lblDevice.TabIndex = 3
        Me.lblDevice.Text = "DEVICE"
        '
        'txtDeviceName
        '
        Me.txtDeviceName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtDeviceName.BorderRadius = 8
        Me.txtDeviceName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeviceName.DefaultText = ""
        Me.txtDeviceName.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtDeviceName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDeviceName.ForeColor = System.Drawing.Color.White
        Me.txtDeviceName.Location = New System.Drawing.Point(25, 160)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.PlaceholderText = ""
        Me.txtDeviceName.ReadOnly = True
        Me.txtDeviceName.SelectedText = ""
        Me.txtDeviceName.Size = New System.Drawing.Size(350, 40)
        Me.txtDeviceName.TabIndex = 4
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblHours.Location = New System.Drawing.Point(22, 215)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(56, 15)
        Me.lblHours.TabIndex = 5
        Me.lblHours.Text = "Seconds:"
        '
        'numHours
        '
        Me.numHours.BackColor = System.Drawing.Color.Transparent
        Me.numHours.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.numHours.BorderRadius = 8
        Me.numHours.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numHours.DecimalPlaces = 1
        Me.numHours.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.numHours.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.numHours.ForeColor = System.Drawing.Color.White
        Me.numHours.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numHours.Location = New System.Drawing.Point(12, 347)
        Me.numHours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numHours.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(350, 40)
        Me.numHours.TabIndex = 6
        Me.numHours.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.numHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numHours.Visible = False
        '
        'btnStart
        '
        Me.btnStart.BorderRadius = 8
        Me.btnStart.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(215, 314)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(160, 45)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start Session"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(25, 314)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 45)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'txtSeconds
        '
        Me.txtSeconds.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtSeconds.BorderRadius = 8
        Me.txtSeconds.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSeconds.DefaultText = ""
        Me.txtSeconds.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtSeconds.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSeconds.ForeColor = System.Drawing.Color.White
        Me.txtSeconds.Location = New System.Drawing.Point(25, 250)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.PlaceholderText = ""
        Me.txtSeconds.SelectedText = ""
        Me.txtSeconds.Size = New System.Drawing.Size(350, 40)
        Me.txtSeconds.TabIndex = 11
        '
        'frmStartSession
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 399)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.numHours)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.txtDeviceName)
        Me.Controls.Add(Me.lblDevice)
        Me.Controls.Add(Me.cmbCustomers)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStartSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Start Session"
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblDevice As Label
    Friend WithEvents txtDeviceName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblHours As Label
    Friend WithEvents numHours As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna2Elipse
    Friend WithEvents cmbCustomers As ComboBox
    Friend WithEvents txtSeconds As Guna2TextBox
End Class
