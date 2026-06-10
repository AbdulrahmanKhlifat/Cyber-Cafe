<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTournamentWinner
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
        Me.lblDateFinished = New System.Windows.Forms.Label()
        Me.lblTournamentName = New System.Windows.Forms.Label()
        Me.lblWinnerName = New System.Windows.Forms.Label()
        Me.lblCongratulate = New System.Windows.Forms.Label()
        Me.lblTrophy = New System.Windows.Forms.Label()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMain.BorderThickness = 1
        Me.pnlMain.Controls.Add(Me.lblDateFinished)
        Me.pnlMain.Controls.Add(Me.lblTournamentName)
        Me.pnlMain.Controls.Add(Me.lblWinnerName)
        Me.pnlMain.Controls.Add(Me.lblCongratulate)
        Me.pnlMain.Controls.Add(Me.lblTrophy)
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(450, 380)
        Me.pnlMain.TabIndex = 0
        '
        'lblDateFinished
        '
        Me.lblDateFinished.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateFinished.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDateFinished.Location = New System.Drawing.Point(20, 260)
        Me.lblDateFinished.Name = "lblDateFinished"
        Me.lblDateFinished.Size = New System.Drawing.Size(410, 20)
        Me.lblDateFinished.TabIndex = 9
        Me.lblDateFinished.Text = "COMPLETED ON: 2026-06-08 20:00"
        Me.lblDateFinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTournamentName
        '
        Me.lblTournamentName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblTournamentName.Location = New System.Drawing.Point(20, 230)
        Me.lblTournamentName.Name = "lblTournamentName"
        Me.lblTournamentName.Size = New System.Drawing.Size(410, 25)
        Me.lblTournamentName.TabIndex = 8
        Me.lblTournamentName.Text = "SPRING CHAMPIONSHIP"
        Me.lblTournamentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWinnerName
        '
        Me.lblWinnerName.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblWinnerName.ForeColor = System.Drawing.Color.Gold
        Me.lblWinnerName.Location = New System.Drawing.Point(20, 180)
        Me.lblWinnerName.Name = "lblWinnerName"
        Me.lblWinnerName.Size = New System.Drawing.Size(410, 45)
        Me.lblWinnerName.TabIndex = 7
        Me.lblWinnerName.Text = "CHAMPION NAME"
        Me.lblWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCongratulate
        '
        Me.lblCongratulate.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCongratulate.ForeColor = System.Drawing.Color.White
        Me.lblCongratulate.Location = New System.Drawing.Point(20, 150)
        Me.lblCongratulate.Name = "lblCongratulate"
        Me.lblCongratulate.Size = New System.Drawing.Size(410, 25)
        Me.lblCongratulate.TabIndex = 6
        Me.lblCongratulate.Text = "CONGRATULATIONS TO THE CHAMPION!"
        Me.lblCongratulate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrophy
        '
        Me.lblTrophy.Font = New System.Drawing.Font("Segoe UI", 48.0!)
        Me.lblTrophy.ForeColor = System.Drawing.Color.Gold
        Me.lblTrophy.Location = New System.Drawing.Point(20, 55)
        Me.lblTrophy.Name = "lblTrophy"
        Me.lblTrophy.Size = New System.Drawing.Size(410, 90)
        Me.lblTrophy.TabIndex = 5
        Me.lblTrophy.Text = "🏆"
        Me.lblTrophy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOk
        '
        Me.btnOk.BorderRadius = 6
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(150, 310)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 40)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Close"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(450, 50)
        Me.pnlHeader.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(400, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 50)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(159, 21)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Tournament Winner"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'frmTournamentWinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 380)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTournamentWinner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tournament Winner"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDateFinished As System.Windows.Forms.Label
    Friend WithEvents lblTournamentName As System.Windows.Forms.Label
    Friend WithEvents lblWinnerName As System.Windows.Forms.Label
    Friend WithEvents lblCongratulate As System.Windows.Forms.Label
    Friend WithEvents lblTrophy As System.Windows.Forms.Label
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
