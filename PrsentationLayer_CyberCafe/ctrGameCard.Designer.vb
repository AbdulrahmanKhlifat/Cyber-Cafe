<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrGameCard
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
        Me.btnGameCard = New Guna.UI2.WinForms.Guna2Button()
        Me.chkSelected = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.SuspendLayout()
        '
        'btnGameCard
        '
        Me.btnGameCard.Animated = True
        Me.btnGameCard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnGameCard.BorderRadius = 12
        Me.btnGameCard.BorderThickness = 1
        Me.btnGameCard.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnGameCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGameCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnGameCard.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGameCard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnGameCard.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnGameCard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGameCard.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGameCard.ImageOffset = New System.Drawing.Point(0, -15)
        Me.btnGameCard.ImageSize = New System.Drawing.Size(140, 150)
        Me.btnGameCard.Location = New System.Drawing.Point(0, 1)
        Me.btnGameCard.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGameCard.Name = "btnGameCard"
        Me.btnGameCard.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGameCard.Size = New System.Drawing.Size(160, 220)
        Me.btnGameCard.TabIndex = 0
        Me.btnGameCard.Text = "Game Name"
        Me.btnGameCard.TextOffset = New System.Drawing.Point(0, 80)
        '
        'chkSelected
        '
        Me.chkSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSelected.BackColor = System.Drawing.Color.Transparent
        Me.chkSelected.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkSelected.CheckedState.BorderRadius = 4
        Me.chkSelected.CheckedState.BorderThickness = 0
        Me.chkSelected.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkSelected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSelected.Location = New System.Drawing.Point(132, 8)
        Me.chkSelected.Name = "chkSelected"
        Me.chkSelected.Size = New System.Drawing.Size(20, 20)
        Me.chkSelected.TabIndex = 1
        Me.chkSelected.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.chkSelected.UncheckedState.BorderRadius = 4
        Me.chkSelected.UncheckedState.BorderThickness = 2
        Me.chkSelected.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(30, Byte), Integer))
        '
        'ctrGameCard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Controls.Add(Me.chkSelected)
        Me.Controls.Add(Me.btnGameCard)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ctrGameCard"
        Me.Size = New System.Drawing.Size(160, 220)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGameCard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents chkSelected As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
