<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTournamentDetails
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
        Me.lblTournamentStatus = New System.Windows.Forms.Label()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlDetailsGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDetRevenueVal = New System.Windows.Forms.Label()
        Me.lblDetRevenueTitle = New System.Windows.Forms.Label()
        Me.lblDetPlayersVal = New System.Windows.Forms.Label()
        Me.lblDetPlayersTitle = New System.Windows.Forms.Label()
        Me.lblDetPrizeVal = New System.Windows.Forms.Label()
        Me.lblDetPrizeTitle = New System.Windows.Forms.Label()
        Me.lblDetEntryFeeVal = New System.Windows.Forms.Label()
        Me.lblDetEntryFeeTitle = New System.Windows.Forms.Label()
        Me.lblDetDurationVal = New System.Windows.Forms.Label()
        Me.lblDetDurationTitle = New System.Windows.Forms.Label()
        Me.lblDetExpectedEndVal = New System.Windows.Forms.Label()
        Me.lblDetExpectedEndTitle = New System.Windows.Forms.Label()
        Me.lblDetStartTimeVal = New System.Windows.Forms.Label()
        Me.lblDetStartTimeTitle = New System.Windows.Forms.Label()
        Me.lblDetGameNameVal = New System.Windows.Forms.Label()
        Me.lblDetGameNameTitle = New System.Windows.Forms.Label()
        Me.pnlTimerCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLiveTimer = New System.Windows.Forms.Label()
        Me.lblDetTitle = New System.Windows.Forms.Label()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.pnlDetailsGrid.SuspendLayout()
        Me.pnlTimerCard.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMain.BorderThickness = 1
        Me.pnlMain.Controls.Add(Me.lblTournamentStatus)
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Controls.Add(Me.pnlDetailsGrid)
        Me.pnlMain.Controls.Add(Me.pnlTimerCard)
        Me.pnlMain.Controls.Add(Me.lblDetTitle)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(500, 560)
        Me.pnlMain.TabIndex = 0
        '
        'lblTournamentStatus
        '
        Me.lblTournamentStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.lblTournamentStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblTournamentStatus.ForeColor = System.Drawing.Color.White
        Me.lblTournamentStatus.Location = New System.Drawing.Point(193, 95)
        Me.lblTournamentStatus.Name = "lblTournamentStatus"
        Me.lblTournamentStatus.Size = New System.Drawing.Size(120, 30)
        Me.lblTournamentStatus.TabIndex = 6
        Me.lblTournamentStatus.Text = "UPCOMING"
        Me.lblTournamentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOk
        '
        Me.btnOk.BorderRadius = 8
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(175, 489)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 45)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "Close"
        '
        'pnlDetailsGrid
        '
        Me.pnlDetailsGrid.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDetailsGrid.BorderRadius = 12
        Me.pnlDetailsGrid.BorderThickness = 1
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetRevenueVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetRevenueTitle)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetPlayersVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetPlayersTitle)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetPrizeVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetPrizeTitle)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetEntryFeeVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetEntryFeeTitle)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetDurationVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetDurationTitle)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetExpectedEndVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetExpectedEndTitle)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetStartTimeVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetStartTimeTitle)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetGameNameVal)
        Me.pnlDetailsGrid.Controls.Add(Me.lblDetGameNameTitle)
        Me.pnlDetailsGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlDetailsGrid.Location = New System.Drawing.Point(25, 230)
        Me.pnlDetailsGrid.Name = "pnlDetailsGrid"
        Me.pnlDetailsGrid.Size = New System.Drawing.Size(450, 240)
        Me.pnlDetailsGrid.TabIndex = 4
        '
        'lblDetRevenueVal
        '
        Me.lblDetRevenueVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetRevenueVal.ForeColor = System.Drawing.Color.White
        Me.lblDetRevenueVal.Location = New System.Drawing.Point(340, 190)
        Me.lblDetRevenueVal.Name = "lblDetRevenueVal"
        Me.lblDetRevenueVal.Size = New System.Drawing.Size(95, 20)
        Me.lblDetRevenueVal.TabIndex = 15
        Me.lblDetRevenueVal.Text = "$250"
        '
        'lblDetRevenueTitle
        '
        Me.lblDetRevenueTitle.AutoSize = True
        Me.lblDetRevenueTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetRevenueTitle.Location = New System.Drawing.Point(240, 190)
        Me.lblDetRevenueTitle.Name = "lblDetRevenueTitle"
        Me.lblDetRevenueTitle.Size = New System.Drawing.Size(84, 17)
        Me.lblDetRevenueTitle.TabIndex = 14
        Me.lblDetRevenueTitle.Text = "Est. Revenue:"
        '
        'lblDetPlayersVal
        '
        Me.lblDetPlayersVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetPlayersVal.ForeColor = System.Drawing.Color.White
        Me.lblDetPlayersVal.Location = New System.Drawing.Point(120, 190)
        Me.lblDetPlayersVal.Name = "lblDetPlayersVal"
        Me.lblDetPlayersVal.Size = New System.Drawing.Size(100, 20)
        Me.lblDetPlayersVal.TabIndex = 13
        Me.lblDetPlayersVal.Text = "32/32"
        '
        'lblDetPlayersTitle
        '
        Me.lblDetPlayersTitle.AutoSize = True
        Me.lblDetPlayersTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetPlayersTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetPlayersTitle.Location = New System.Drawing.Point(15, 190)
        Me.lblDetPlayersTitle.Name = "lblDetPlayersTitle"
        Me.lblDetPlayersTitle.Size = New System.Drawing.Size(52, 17)
        Me.lblDetPlayersTitle.TabIndex = 12
        Me.lblDetPlayersTitle.Text = "Players:"
        '
        'lblDetPrizeVal
        '
        Me.lblDetPrizeVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetPrizeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblDetPrizeVal.Location = New System.Drawing.Point(340, 135)
        Me.lblDetPrizeVal.Name = "lblDetPrizeVal"
        Me.lblDetPrizeVal.Size = New System.Drawing.Size(95, 20)
        Me.lblDetPrizeVal.TabIndex = 11
        Me.lblDetPrizeVal.Text = "$5,000"
        '
        'lblDetPrizeTitle
        '
        Me.lblDetPrizeTitle.AutoSize = True
        Me.lblDetPrizeTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetPrizeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetPrizeTitle.Location = New System.Drawing.Point(240, 135)
        Me.lblDetPrizeTitle.Name = "lblDetPrizeTitle"
        Me.lblDetPrizeTitle.Size = New System.Drawing.Size(69, 17)
        Me.lblDetPrizeTitle.TabIndex = 10
        Me.lblDetPrizeTitle.Text = "Prize Pool:"
        '
        'lblDetEntryFeeVal
        '
        Me.lblDetEntryFeeVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetEntryFeeVal.ForeColor = System.Drawing.Color.White
        Me.lblDetEntryFeeVal.Location = New System.Drawing.Point(120, 135)
        Me.lblDetEntryFeeVal.Name = "lblDetEntryFeeVal"
        Me.lblDetEntryFeeVal.Size = New System.Drawing.Size(100, 20)
        Me.lblDetEntryFeeVal.TabIndex = 9
        Me.lblDetEntryFeeVal.Text = "$20.00"
        '
        'lblDetEntryFeeTitle
        '
        Me.lblDetEntryFeeTitle.AutoSize = True
        Me.lblDetEntryFeeTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetEntryFeeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetEntryFeeTitle.Location = New System.Drawing.Point(15, 135)
        Me.lblDetEntryFeeTitle.Name = "lblDetEntryFeeTitle"
        Me.lblDetEntryFeeTitle.Size = New System.Drawing.Size(64, 17)
        Me.lblDetEntryFeeTitle.TabIndex = 8
        Me.lblDetEntryFeeTitle.Text = "Entry Fee:"
        '
        'lblDetDurationVal
        '
        Me.lblDetDurationVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetDurationVal.ForeColor = System.Drawing.Color.White
        Me.lblDetDurationVal.Location = New System.Drawing.Point(340, 75)
        Me.lblDetDurationVal.Name = "lblDetDurationVal"
        Me.lblDetDurationVal.Size = New System.Drawing.Size(95, 20)
        Me.lblDetDurationVal.TabIndex = 7
        Me.lblDetDurationVal.Text = "2 Days"
        '
        'lblDetDurationTitle
        '
        Me.lblDetDurationTitle.AutoSize = True
        Me.lblDetDurationTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetDurationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetDurationTitle.Location = New System.Drawing.Point(240, 75)
        Me.lblDetDurationTitle.Name = "lblDetDurationTitle"
        Me.lblDetDurationTitle.Size = New System.Drawing.Size(61, 17)
        Me.lblDetDurationTitle.TabIndex = 6
        Me.lblDetDurationTitle.Text = "Duration:"
        '
        'lblDetExpectedEndVal
        '
        Me.lblDetExpectedEndVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetExpectedEndVal.ForeColor = System.Drawing.Color.White
        Me.lblDetExpectedEndVal.Location = New System.Drawing.Point(120, 75)
        Me.lblDetExpectedEndVal.Name = "lblDetExpectedEndVal"
        Me.lblDetExpectedEndVal.Size = New System.Drawing.Size(100, 20)
        Me.lblDetExpectedEndVal.TabIndex = 5
        Me.lblDetExpectedEndVal.Text = "TBD"
        '
        'lblDetExpectedEndTitle
        '
        Me.lblDetExpectedEndTitle.AutoSize = True
        Me.lblDetExpectedEndTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetExpectedEndTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetExpectedEndTitle.Location = New System.Drawing.Point(15, 75)
        Me.lblDetExpectedEndTitle.Name = "lblDetExpectedEndTitle"
        Me.lblDetExpectedEndTitle.Size = New System.Drawing.Size(90, 17)
        Me.lblDetExpectedEndTitle.TabIndex = 4
        Me.lblDetExpectedEndTitle.Text = "Expected End:"
        '
        'lblDetStartTimeVal
        '
        Me.lblDetStartTimeVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetStartTimeVal.ForeColor = System.Drawing.Color.White
        Me.lblDetStartTimeVal.Location = New System.Drawing.Point(340, 20)
        Me.lblDetStartTimeVal.Name = "lblDetStartTimeVal"
        Me.lblDetStartTimeVal.Size = New System.Drawing.Size(95, 20)
        Me.lblDetStartTimeVal.TabIndex = 3
        Me.lblDetStartTimeVal.Text = "2026-06-01"
        '
        'lblDetStartTimeTitle
        '
        Me.lblDetStartTimeTitle.AutoSize = True
        Me.lblDetStartTimeTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetStartTimeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetStartTimeTitle.Location = New System.Drawing.Point(240, 20)
        Me.lblDetStartTimeTitle.Name = "lblDetStartTimeTitle"
        Me.lblDetStartTimeTitle.Size = New System.Drawing.Size(70, 17)
        Me.lblDetStartTimeTitle.TabIndex = 2
        Me.lblDetStartTimeTitle.Text = "Start Time:"
        '
        'lblDetGameNameVal
        '
        Me.lblDetGameNameVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDetGameNameVal.ForeColor = System.Drawing.Color.White
        Me.lblDetGameNameVal.Location = New System.Drawing.Point(120, 20)
        Me.lblDetGameNameVal.Name = "lblDetGameNameVal"
        Me.lblDetGameNameVal.Size = New System.Drawing.Size(100, 20)
        Me.lblDetGameNameVal.TabIndex = 1
        Me.lblDetGameNameVal.Text = "Fifa 26"
        '
        'lblDetGameNameTitle
        '
        Me.lblDetGameNameTitle.AutoSize = True
        Me.lblDetGameNameTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDetGameNameTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDetGameNameTitle.Location = New System.Drawing.Point(15, 20)
        Me.lblDetGameNameTitle.Name = "lblDetGameNameTitle"
        Me.lblDetGameNameTitle.Size = New System.Drawing.Size(45, 17)
        Me.lblDetGameNameTitle.TabIndex = 0
        Me.lblDetGameNameTitle.Text = "Game:"
        '
        'pnlTimerCard
        '
        Me.pnlTimerCard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTimerCard.BorderRadius = 12
        Me.pnlTimerCard.BorderThickness = 1
        Me.pnlTimerCard.Controls.Add(Me.lblLiveTimer)
        Me.pnlTimerCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlTimerCard.Location = New System.Drawing.Point(25, 140)
        Me.pnlTimerCard.Name = "pnlTimerCard"
        Me.pnlTimerCard.Size = New System.Drawing.Size(450, 70)
        Me.pnlTimerCard.TabIndex = 3
        '
        'lblLiveTimer
        '
        Me.lblLiveTimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLiveTimer.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblLiveTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblLiveTimer.Location = New System.Drawing.Point(0, 0)
        Me.lblLiveTimer.Name = "lblLiveTimer"
        Me.lblLiveTimer.Size = New System.Drawing.Size(450, 70)
        Me.lblLiveTimer.TabIndex = 0
        Me.lblLiveTimer.Text = "Starts In: 02:15:22"
        Me.lblLiveTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDetTitle
        '
        Me.lblDetTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetTitle.ForeColor = System.Drawing.Color.White
        Me.lblDetTitle.Location = New System.Drawing.Point(25, 55)
        Me.lblDetTitle.Name = "lblDetTitle"
        Me.lblDetTitle.Size = New System.Drawing.Size(450, 35)
        Me.lblDetTitle.TabIndex = 1
        Me.lblDetTitle.Text = "Spring Championship"
        Me.lblDetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(500, 50)
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
        Me.btnClose.Location = New System.Drawing.Point(450, 0)
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
        Me.lblHeaderTitle.Size = New System.Drawing.Size(160, 21)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Tournament Details"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'frmTournamentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 560)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTournamentDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tournament Details"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlDetailsGrid.ResumeLayout(False)
        Me.pnlDetailsGrid.PerformLayout()
        Me.pnlTimerCard.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDetTitle As System.Windows.Forms.Label
    Friend WithEvents pnlTimerCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLiveTimer As System.Windows.Forms.Label
    Friend WithEvents pnlDetailsGrid As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblDetGameNameTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetGameNameVal As System.Windows.Forms.Label
    Friend WithEvents lblDetStartTimeTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetStartTimeVal As System.Windows.Forms.Label
    Friend WithEvents lblDetExpectedEndTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetExpectedEndVal As System.Windows.Forms.Label
    Friend WithEvents lblDetDurationTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetDurationVal As System.Windows.Forms.Label
    Friend WithEvents lblDetEntryFeeTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetEntryFeeVal As System.Windows.Forms.Label
    Friend WithEvents lblDetPrizeTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetPrizeVal As System.Windows.Forms.Label
    Friend WithEvents lblDetPlayersTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetPlayersVal As System.Windows.Forms.Label
    Friend WithEvents lblDetRevenueTitle As System.Windows.Forms.Label
    Friend WithEvents lblDetRevenueVal As System.Windows.Forms.Label
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents lblTournamentStatus As Label
End Class
