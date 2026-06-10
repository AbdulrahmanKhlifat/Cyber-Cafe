<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatchResult
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
        Me.lblWinnerVal = New System.Windows.Forms.Label()
        Me.lblWinnerTitle = New System.Windows.Forms.Label()
        Me.lblVS = New System.Windows.Forms.Label()
        Me.numPlayer2Score = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.numPlayer1Score = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.lblPlayer2Name = New System.Windows.Forms.Label()
        Me.lblPlayer1Name = New System.Windows.Forms.Label()
        Me.pnlMetaCard = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMatchOrderVal = New System.Windows.Forms.Label()
        Me.lblRoundVal = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlMain.SuspendLayout()
        CType(Me.numPlayer2Score, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPlayer1Score, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMetaCard.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMain.BorderThickness = 1
        Me.pnlMain.Controls.Add(Me.lblWinnerVal)
        Me.pnlMain.Controls.Add(Me.lblWinnerTitle)
        Me.pnlMain.Controls.Add(Me.lblVS)
        Me.pnlMain.Controls.Add(Me.numPlayer2Score)
        Me.pnlMain.Controls.Add(Me.numPlayer1Score)
        Me.pnlMain.Controls.Add(Me.lblPlayer2Name)
        Me.pnlMain.Controls.Add(Me.lblPlayer1Name)
        Me.pnlMain.Controls.Add(Me.pnlMetaCard)
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Controls.Add(Me.btnSave)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(480, 420)
        Me.pnlMain.TabIndex = 0
        '
        'lblWinnerVal
        '
        Me.lblWinnerVal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWinnerVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblWinnerVal.Location = New System.Drawing.Point(30, 298)
        Me.lblWinnerVal.Name = "lblWinnerVal"
        Me.lblWinnerVal.Size = New System.Drawing.Size(420, 30)
        Me.lblWinnerVal.TabIndex = 10
        Me.lblWinnerVal.Text = "TBD"
        Me.lblWinnerVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWinnerTitle
        '
        Me.lblWinnerTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblWinnerTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblWinnerTitle.Location = New System.Drawing.Point(30, 275)
        Me.lblWinnerTitle.Name = "lblWinnerTitle"
        Me.lblWinnerTitle.Size = New System.Drawing.Size(420, 20)
        Me.lblWinnerTitle.TabIndex = 9
        Me.lblWinnerTitle.Text = "WINNER ESTIMATE"
        Me.lblWinnerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVS
        '
        Me.lblVS.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblVS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblVS.Location = New System.Drawing.Point(215, 175)
        Me.lblVS.Name = "lblVS"
        Me.lblVS.Size = New System.Drawing.Size(50, 40)
        Me.lblVS.TabIndex = 8
        Me.lblVS.Text = "VS"
        Me.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numPlayer2Score
        '
        Me.numPlayer2Score.BackColor = System.Drawing.Color.Transparent
        Me.numPlayer2Score.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.numPlayer2Score.BorderRadius = 6
        Me.numPlayer2Score.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numPlayer2Score.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.numPlayer2Score.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.numPlayer2Score.ForeColor = System.Drawing.Color.White
        Me.numPlayer2Score.Location = New System.Drawing.Point(300, 215)
        Me.numPlayer2Score.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numPlayer2Score.Name = "numPlayer2Score"
        Me.numPlayer2Score.Size = New System.Drawing.Size(100, 40)
        Me.numPlayer2Score.TabIndex = 7
        Me.numPlayer2Score.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.numPlayer2Score.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'numPlayer1Score
        '
        Me.numPlayer1Score.BackColor = System.Drawing.Color.Transparent
        Me.numPlayer1Score.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.numPlayer1Score.BorderRadius = 6
        Me.numPlayer1Score.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numPlayer1Score.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.numPlayer1Score.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.numPlayer1Score.ForeColor = System.Drawing.Color.White
        Me.numPlayer1Score.Location = New System.Drawing.Point(80, 215)
        Me.numPlayer1Score.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numPlayer1Score.Name = "numPlayer1Score"
        Me.numPlayer1Score.Size = New System.Drawing.Size(100, 40)
        Me.numPlayer1Score.TabIndex = 6
        Me.numPlayer1Score.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.numPlayer1Score.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'lblPlayer2Name
        '
        Me.lblPlayer2Name.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayer2Name.ForeColor = System.Drawing.Color.White
        Me.lblPlayer2Name.Location = New System.Drawing.Point(260, 185)
        Me.lblPlayer2Name.Name = "lblPlayer2Name"
        Me.lblPlayer2Name.Size = New System.Drawing.Size(190, 20)
        Me.lblPlayer2Name.TabIndex = 5
        Me.lblPlayer2Name.Text = "PLAYER 2"
        Me.lblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1Name
        '
        Me.lblPlayer1Name.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayer1Name.ForeColor = System.Drawing.Color.White
        Me.lblPlayer1Name.Location = New System.Drawing.Point(30, 185)
        Me.lblPlayer1Name.Name = "lblPlayer1Name"
        Me.lblPlayer1Name.Size = New System.Drawing.Size(190, 20)
        Me.lblPlayer1Name.TabIndex = 4
        Me.lblPlayer1Name.Text = "PLAYER 1"
        Me.lblPlayer1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMetaCard
        '
        Me.pnlMetaCard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMetaCard.BorderRadius = 8
        Me.pnlMetaCard.BorderThickness = 1
        Me.pnlMetaCard.Controls.Add(Me.lblMatchOrderVal)
        Me.pnlMetaCard.Controls.Add(Me.lblRoundVal)
        Me.pnlMetaCard.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlMetaCard.Location = New System.Drawing.Point(30, 75)
        Me.pnlMetaCard.Name = "pnlMetaCard"
        Me.pnlMetaCard.Size = New System.Drawing.Size(420, 80)
        Me.pnlMetaCard.TabIndex = 3
        '
        'lblMatchOrderVal
        '
        Me.lblMatchOrderVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMatchOrderVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblMatchOrderVal.Location = New System.Drawing.Point(0, 42)
        Me.lblMatchOrderVal.Name = "lblMatchOrderVal"
        Me.lblMatchOrderVal.Size = New System.Drawing.Size(420, 20)
        Me.lblMatchOrderVal.TabIndex = 1
        Me.lblMatchOrderVal.Text = "Match #1"
        Me.lblMatchOrderVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRoundVal
        '
        Me.lblRoundVal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblRoundVal.ForeColor = System.Drawing.Color.White
        Me.lblRoundVal.Location = New System.Drawing.Point(0, 12)
        Me.lblRoundVal.Name = "lblRoundVal"
        Me.lblRoundVal.Size = New System.Drawing.Size(420, 25)
        Me.lblRoundVal.TabIndex = 0
        Me.lblRoundVal.Text = "Round 1"
        Me.lblRoundVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(80, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 40)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 6
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(260, 350)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 40)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Result"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(480, 50)
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
        Me.btnClose.Location = New System.Drawing.Point(430, 0)
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
        Me.lblHeaderTitle.Size = New System.Drawing.Size(111, 21)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Match Result"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'frmMatchResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 420)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMatchResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Match Result"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.numPlayer2Score, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPlayer1Score, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMetaCard.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlMetaCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMatchOrderVal As System.Windows.Forms.Label
    Friend WithEvents lblRoundVal As System.Windows.Forms.Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents numPlayer2Score As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents numPlayer1Score As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents lblPlayer2Name As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1Name As System.Windows.Forms.Label
    Friend WithEvents lblVS As System.Windows.Forms.Label
    Friend WithEvents lblWinnerVal As System.Windows.Forms.Label
    Friend WithEvents lblWinnerTitle As System.Windows.Forms.Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
