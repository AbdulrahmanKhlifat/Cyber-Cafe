<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegisterTournamentPlayer
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
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbCustomers = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCustomerSearch = New System.Windows.Forms.Label()
        Me.pnlDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblWalletBalance = New System.Windows.Forms.Label()
        Me.lblEntryFee = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlMain.BorderThickness = 2
        Me.pnlMain.Controls.Add(Me.cmbCustomers)
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Controls.Add(Me.lblCustomerSearch)
        Me.pnlMain.Controls.Add(Me.pnlDetails)
        Me.pnlMain.Controls.Add(Me.btnConfirm)
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(450, 380)
        Me.pnlMain.TabIndex = 0
        '
        'cmbCustomers
        '
        Me.cmbCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmbCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCustomers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCustomers.ForeColor = System.Drawing.Color.White
        Me.cmbCustomers.ItemHeight = 17
        Me.cmbCustomers.Location = New System.Drawing.Point(24, 103)
        Me.cmbCustomers.Name = "cmbCustomers"
        Me.cmbCustomers.Size = New System.Drawing.Size(350, 25)
        Me.cmbCustomers.TabIndex = 7
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(196, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "REGISTER PLAYER"
        '
        'lblCustomerSearch
        '
        Me.lblCustomerSearch.AutoSize = True
        Me.lblCustomerSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCustomerSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCustomerSearch.Location = New System.Drawing.Point(20, 70)
        Me.lblCustomerSearch.Name = "lblCustomerSearch"
        Me.lblCustomerSearch.Size = New System.Drawing.Size(222, 19)
        Me.lblCustomerSearch.TabIndex = 1
        Me.lblCustomerSearch.Text = "Search Customer (ID or Username)"
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetails.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDetails.BorderRadius = 10
        Me.pnlDetails.BorderThickness = 1
        Me.pnlDetails.Controls.Add(Me.lblCustomerName)
        Me.pnlDetails.Controls.Add(Me.lblWalletBalance)
        Me.pnlDetails.Controls.Add(Me.lblEntryFee)
        Me.pnlDetails.Controls.Add(Me.lblStatus)
        Me.pnlDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlDetails.Location = New System.Drawing.Point(24, 150)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(400, 140)
        Me.pnlDetails.TabIndex = 4
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(15, 15)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(101, 20)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer: ---"
        '
        'lblWalletBalance
        '
        Me.lblWalletBalance.AutoSize = True
        Me.lblWalletBalance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblWalletBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblWalletBalance.Location = New System.Drawing.Point(15, 45)
        Me.lblWalletBalance.Name = "lblWalletBalance"
        Me.lblWalletBalance.Size = New System.Drawing.Size(138, 19)
        Me.lblWalletBalance.TabIndex = 1
        Me.lblWalletBalance.Text = "Wallet Balance: $0.00"
        '
        'lblEntryFee
        '
        Me.lblEntryFee.AutoSize = True
        Me.lblEntryFee.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEntryFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEntryFee.Location = New System.Drawing.Point(15, 75)
        Me.lblEntryFee.Name = "lblEntryFee"
        Me.lblEntryFee.Size = New System.Drawing.Size(166, 19)
        Me.lblEntryFee.TabIndex = 2
        Me.lblEntryFee.Text = "Required Entry Fee: $0.00"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(15, 105)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(235, 19)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Please search for a customer first."
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnConfirm.BorderRadius = 8
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(24, 310)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(190, 45)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Confirm Registration"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(234, 310)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(190, 45)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlMain
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'frmRegisterTournamentPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 380)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegisterTournamentPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register Player"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCustomerSearch As System.Windows.Forms.Label
    Friend WithEvents pnlDetails As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblWalletBalance As System.Windows.Forms.Label
    Friend WithEvents lblEntryFee As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents cmbCustomers As ComboBox
End Class
