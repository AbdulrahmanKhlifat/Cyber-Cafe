<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTournamentResults
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
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvResults = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colRound = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMatchOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlayer1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colP1Score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colP2Score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlayer2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWinnerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMatchStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTournamentName = New System.Windows.Forms.Label()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMain.BorderThickness = 1
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Controls.Add(Me.dgvResults)
        Me.pnlMain.Controls.Add(Me.lblTournamentName)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(780, 520)
        Me.pnlMain.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.BorderRadius = 6
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(315, 460)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 40)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Close"
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToResizeRows = False
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        dataGridViewCellStyle1.Font = Nothing
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
        Me.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True
        Me.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
        Me.dgvResults.ColumnHeadersHeight = 35
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRound, Me.colMatchOrder, Me.colPlayer1, Me.colP1Score, Me.colVS, Me.colP2Score, Me.colPlayer2, Me.colWinnerName, Me.colMatchStatus})
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        dataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False
        Me.dgvResults.DefaultCellStyle = dataGridViewCellStyle3
        Me.dgvResults.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvResults.Location = New System.Drawing.Point(20, 115)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.RowTemplate.Height = 35
        Me.dgvResults.Size = New System.Drawing.Size(740, 325)
        Me.dgvResults.TabIndex = 3
        Me.dgvResults.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvResults.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvResults.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvResults.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvResults.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvResults.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvResults.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvResults.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvResults.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvResults.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.dgvResults.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvResults.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvResults.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvResults.ThemeStyle.ReadOnly = True
        Me.dgvResults.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvResults.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvResults.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvResults.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvResults.ThemeStyle.RowsStyle.Height = 35
        Me.dgvResults.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvResults.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'colRound
        '
        Me.colRound.DataPropertyName = "RoundNumber"
        Me.colRound.HeaderText = "Round"
        Me.colRound.Name = "colRound"
        Me.colRound.ReadOnly = True
        Me.colRound.Width = 60
        '
        'colMatchOrder
        '
        Me.colMatchOrder.DataPropertyName = "MatchOrder"
        Me.colMatchOrder.HeaderText = "Match #"
        Me.colMatchOrder.Name = "colMatchOrder"
        Me.colMatchOrder.ReadOnly = True
        Me.colMatchOrder.Width = 70
        '
        'colPlayer1
        '
        Me.colPlayer1.DataPropertyName = "Player1Name"
        Me.colPlayer1.HeaderText = "Player 1"
        Me.colPlayer1.Name = "colPlayer1"
        Me.colPlayer1.ReadOnly = True
        Me.colPlayer1.Width = 140
        '
        'colP1Score
        '
        Me.colP1Score.DataPropertyName = "Player1Score"
        Me.colP1Score.HeaderText = "Score 1"
        Me.colP1Score.Name = "colP1Score"
        Me.colP1Score.ReadOnly = True
        Me.colP1Score.Width = 70
        '
        'colVS
        '
        Me.colVS.HeaderText = "VS"
        Me.colVS.Name = "colVS"
        Me.colVS.ReadOnly = True
        Me.colVS.Width = 40
        '
        'colP2Score
        '
        Me.colP2Score.DataPropertyName = "Player2Score"
        Me.colP2Score.HeaderText = "Score 2"
        Me.colP2Score.Name = "colP2Score"
        Me.colP2Score.ReadOnly = True
        Me.colP2Score.Width = 70
        '
        'colPlayer2
        '
        Me.colPlayer2.DataPropertyName = "Player2Name"
        Me.colPlayer2.HeaderText = "Player 2"
        Me.colPlayer2.Name = "colPlayer2"
        Me.colPlayer2.ReadOnly = True
        Me.colPlayer2.Width = 140
        '
        'colWinnerName
        '
        Me.colWinnerName.DataPropertyName = "WinnerName"
        Me.colWinnerName.HeaderText = "Winner"
        Me.colWinnerName.Name = "colWinnerName"
        Me.colWinnerName.ReadOnly = True
        Me.colWinnerName.Width = 140
        '
        'colMatchStatus
        '
        Me.colMatchStatus.DataPropertyName = "MatchStatusText"
        Me.colMatchStatus.HeaderText = "Status"
        Me.colMatchStatus.Name = "colMatchStatus"
        Me.colMatchStatus.ReadOnly = True
        Me.colMatchStatus.Width = 110
        '
        'lblTournamentName
        '
        Me.lblTournamentName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTournamentName.ForeColor = System.Drawing.Color.White
        Me.lblTournamentName.Location = New System.Drawing.Point(20, 65)
        Me.lblTournamentName.Name = "lblTournamentName"
        Me.lblTournamentName.Size = New System.Drawing.Size(740, 35)
        Me.lblTournamentName.TabIndex = 2
        Me.lblTournamentName.Text = "TOURNAMENT RESULTS"
        Me.lblTournamentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(780, 50)
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
        Me.btnClose.Location = New System.Drawing.Point(730, 0)
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
        Me.lblHeaderTitle.Size = New System.Drawing.Size(155, 21)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Tournament Results"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'frmTournamentResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 520)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTournamentResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tournament Results"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTournamentName As System.Windows.Forms.Label
    Friend WithEvents dgvResults As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents colRound As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMatchOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlayer1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colP1Score As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colP2Score As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlayer2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWinnerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMatchStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
