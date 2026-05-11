<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestockConsumable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblConsumableName = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblCurrentStockVal = New System.Windows.Forms.Label()
        Me.lblCurrentStock = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlContainer.BorderRadius = 20
        Me.pnlContainer.BorderThickness = 2
        Me.pnlContainer.Controls.Add(Me.lblConsumableName)
        Me.pnlContainer.Controls.Add(Me.btnCancel)
        Me.pnlContainer.Controls.Add(Me.btnUpdate)
        Me.pnlContainer.Controls.Add(Me.txtQuantity)
        Me.pnlContainer.Controls.Add(Me.lblQuantity)
        Me.pnlContainer.Controls.Add(Me.lblCurrentStockVal)
        Me.pnlContainer.Controls.Add(Me.lblCurrentStock)
        Me.pnlContainer.Controls.Add(Me.lblItemName)
        Me.pnlContainer.Controls.Add(Me.lblHeader)
        Me.pnlContainer.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(400, 380)
        Me.pnlContainer.TabIndex = 0
        '
        'lblConsumableName
        '
        Me.lblConsumableName.AutoSize = True
        Me.lblConsumableName.BackColor = System.Drawing.Color.Transparent
        Me.lblConsumableName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblConsumableName.ForeColor = System.Drawing.Color.White
        Me.lblConsumableName.Location = New System.Drawing.Point(40, 105)
        Me.lblConsumableName.Name = "lblConsumableName"
        Me.lblConsumableName.Size = New System.Drawing.Size(88, 20)
        Me.lblConsumableName.TabIndex = 13
        Me.lblConsumableName.Text = "Item Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Silver
        Me.btnCancel.Location = New System.Drawing.Point(210, 300)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 45)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "CANCEL"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnUpdate.BorderRadius = 10
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(40, 300)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(150, 45)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "UPDATE STOCK"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.Transparent
        Me.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtQuantity.BorderRadius = 10
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.White
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(40, 230)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PlaceholderText = "Enter Quantity..."
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.Size = New System.Drawing.Size(320, 40)
        Me.txtQuantity.TabIndex = 2
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblQuantity.Location = New System.Drawing.Point(40, 208)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(94, 15)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quantity To Add"
        '
        'lblCurrentStockVal
        '
        Me.lblCurrentStockVal.AutoSize = True
        Me.lblCurrentStockVal.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentStockVal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentStockVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.lblCurrentStockVal.Location = New System.Drawing.Point(40, 165)
        Me.lblCurrentStockVal.Name = "lblCurrentStockVal"
        Me.lblCurrentStockVal.Size = New System.Drawing.Size(63, 21)
        Me.lblCurrentStockVal.TabIndex = 4
        Me.lblCurrentStockVal.Text = "0 Units"
        '
        'lblCurrentStock
        '
        Me.lblCurrentStock.AutoSize = True
        Me.lblCurrentStock.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCurrentStock.Location = New System.Drawing.Point(40, 145)
        Me.lblCurrentStock.Name = "lblCurrentStock"
        Me.lblCurrentStock.Size = New System.Drawing.Size(79, 15)
        Me.lblCurrentStock.TabIndex = 3
        Me.lblCurrentStock.Text = "Current Stock"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblItemName.Location = New System.Drawing.Point(40, 85)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(66, 15)
        Me.lblItemName.TabIndex = 1
        Me.lblItemName.Text = "Item Name"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(35, 30)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(183, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "RESTOCK ITEM"
        '
        'frmRestockConsumable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 380)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRestockConsumable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restock Consumable"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblCurrentStock As System.Windows.Forms.Label
    Friend WithEvents lblCurrentStockVal As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblConsumableName As System.Windows.Forms.Label
End Class
