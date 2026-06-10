<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListTournamentPlayers
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvPlayers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblTournamentName = New System.Windows.Forms.Label()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.colPlayerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlayerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMain.BorderThickness = 1
        Me.pnlMain.Controls.Add(Me.Guna2VScrollBar1)
        Me.pnlMain.Controls.Add(Me.btnOk)
        Me.pnlMain.Controls.Add(Me.dgvPlayers)
        Me.pnlMain.Controls.Add(Me.lblTournamentName)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(550, 480)
        Me.pnlMain.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.BorderRadius = 6
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(200, 420)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 40)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Close"
        '
        'dgvPlayers
        '
        Me.dgvPlayers.AllowUserToAddRows = False
        Me.dgvPlayers.AllowUserToDeleteRows = False
        Me.dgvPlayers.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPlayers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPlayers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlayers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPlayers.ColumnHeadersHeight = 35
        Me.dgvPlayers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPlayerID, Me.colPlayerName, Me.colRegDate})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPlayers.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPlayers.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvPlayers.Location = New System.Drawing.Point(20, 115)
        Me.dgvPlayers.Name = "dgvPlayers"
        Me.dgvPlayers.ReadOnly = True
        Me.dgvPlayers.RowHeadersVisible = False
        Me.dgvPlayers.RowTemplate.Height = 35
        Me.dgvPlayers.Size = New System.Drawing.Size(510, 285)
        Me.dgvPlayers.TabIndex = 3
        Me.dgvPlayers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPlayers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPlayers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPlayers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPlayers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.dgvPlayers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPlayers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPlayers.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvPlayers.ThemeStyle.ReadOnly = True
        Me.dgvPlayers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPlayers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvPlayers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.RowsStyle.Height = 35
        Me.dgvPlayers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvPlayers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'lblTournamentName
        '
        Me.lblTournamentName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTournamentName.ForeColor = System.Drawing.Color.White
        Me.lblTournamentName.Location = New System.Drawing.Point(20, 65)
        Me.lblTournamentName.Name = "lblTournamentName"
        Me.lblTournamentName.Size = New System.Drawing.Size(510, 35)
        Me.lblTournamentName.TabIndex = 2
        Me.lblTournamentName.Text = "TOURNAMENT NAME"
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
        Me.pnlHeader.Size = New System.Drawing.Size(550, 50)
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
        Me.btnClose.Location = New System.Drawing.Point(500, 0)
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
        Me.lblHeaderTitle.Size = New System.Drawing.Size(150, 21)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Registered Players"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'colPlayerID
        '
        Me.colPlayerID.DataPropertyName = "TournamentPlayerID"
        Me.colPlayerID.HeaderText = "ID"
        Me.colPlayerID.Name = "colPlayerID"
        Me.colPlayerID.ReadOnly = True
        '
        'colPlayerName
        '
        Me.colPlayerName.DataPropertyName = "PlayerName"
        Me.colPlayerName.HeaderText = "Player Name"
        Me.colPlayerName.Name = "colPlayerName"
        Me.colPlayerName.ReadOnly = True
        '
        'colRegDate
        '
        Me.colRegDate.DataPropertyName = "RegistrationDate"
        Me.colRegDate.HeaderText = "Registration Date"
        Me.colRegDate.Name = "colRegDate"
        Me.colRegDate.ReadOnly = True
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.BindingContainer = Me.dgvPlayers
        Me.Guna2VScrollBar1.BorderRadius = 10
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(517, 115)
        Me.Guna2VScrollBar1.Minimum = 1
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.ScrollbarSize = 13
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(13, 285)
        Me.Guna2VScrollBar1.TabIndex = 5
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2VScrollBar1.Value = 1
        '
        'frmListTournamentPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 480)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListTournamentPlayers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registered Players"
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTournamentName As System.Windows.Forms.Label
    Friend WithEvents dgvPlayers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents colPlayerID As DataGridViewTextBoxColumn
    Friend WithEvents colPlayerName As DataGridViewTextBoxColumn
    Friend WithEvents colRegDate As DataGridViewTextBoxColumn
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
End Class
