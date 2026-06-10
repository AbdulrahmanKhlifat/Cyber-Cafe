<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTournamentBracket
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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblBracketTitle = New System.Windows.Forms.Label()
        Me.pnlBracketCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBracketPlaceholder = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBracketCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblBracketTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 55)
        Me.pnlHeader.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnClose.BorderRadius = 8
        Me.btnClose.BorderThickness = 1
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1100, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "✕ Close"
        '
        'lblBracketTitle
        '
        Me.lblBracketTitle.AutoSize = True
        Me.lblBracketTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBracketTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblBracketTitle.ForeColor = System.Drawing.Color.White
        Me.lblBracketTitle.Location = New System.Drawing.Point(20, 13)
        Me.lblBracketTitle.Name = "lblBracketTitle"
        Me.lblBracketTitle.Size = New System.Drawing.Size(181, 25)
        Me.lblBracketTitle.TabIndex = 0
        Me.lblBracketTitle.Text = "BRACKET PREVIEW"
        '
        'pnlBracketCard
        '
        Me.pnlBracketCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlBracketCard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlBracketCard.Controls.Add(Me.lblBracketPlaceholder)
        Me.pnlBracketCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBracketCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlBracketCard.Location = New System.Drawing.Point(0, 55)
        Me.pnlBracketCard.Name = "pnlBracketCard"
        Me.pnlBracketCard.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlBracketCard.Size = New System.Drawing.Size(1200, 645)
        Me.pnlBracketCard.TabIndex = 1
        '
        'lblBracketPlaceholder
        '
        Me.lblBracketPlaceholder.BackColor = System.Drawing.Color.Transparent
        Me.lblBracketPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBracketPlaceholder.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic)
        Me.lblBracketPlaceholder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblBracketPlaceholder.Location = New System.Drawing.Point(10, 10)
        Me.lblBracketPlaceholder.Name = "lblBracketPlaceholder"
        Me.lblBracketPlaceholder.Size = New System.Drawing.Size(1180, 625)
        Me.lblBracketPlaceholder.TabIndex = 0
        Me.lblBracketPlaceholder.Text = "No matches generated yet for this tournament."
        Me.lblBracketPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTournamentBracket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlBracketCard)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTournamentBracket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tournament Bracket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBracketCard.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblBracketTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlBracketCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblBracketPlaceholder As System.Windows.Forms.Label

End Class
