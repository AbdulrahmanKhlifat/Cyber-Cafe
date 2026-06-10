<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUpdateTournament
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
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.numMaxPlayers = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.lblMaxPlayers = New System.Windows.Forms.Label()
        Me.txtPrizePool = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPrizePool = New System.Windows.Forms.Label()
        Me.txtEntryFee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblEntryFee = New System.Windows.Forms.Label()
        Me.lblStartPreview = New System.Windows.Forms.Label()
        Me.dtpStartTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.cmbGames = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.txtTournamentName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTournamentName = New System.Windows.Forms.Label()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlMain.SuspendLayout()
        CType(Me.numMaxPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlMain.BorderThickness = 1
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Controls.Add(Me.btnSave)
        Me.pnlMain.Controls.Add(Me.numMaxPlayers)
        Me.pnlMain.Controls.Add(Me.lblMaxPlayers)
        Me.pnlMain.Controls.Add(Me.txtPrizePool)
        Me.pnlMain.Controls.Add(Me.lblPrizePool)
        Me.pnlMain.Controls.Add(Me.txtEntryFee)
        Me.pnlMain.Controls.Add(Me.lblEntryFee)
        Me.pnlMain.Controls.Add(Me.lblStartPreview)
        Me.pnlMain.Controls.Add(Me.dtpStartTimePicker)
        Me.pnlMain.Controls.Add(Me.dtpStartDate)
        Me.pnlMain.Controls.Add(Me.lblStartTime)
        Me.pnlMain.Controls.Add(Me.cmbGames)
        Me.pnlMain.Controls.Add(Me.lblGame)
        Me.pnlMain.Controls.Add(Me.txtTournamentName)
        Me.pnlMain.Controls.Add(Me.lblTournamentName)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(450, 650)
        Me.pnlMain.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.BorderThickness = 1
        Me.btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(140, 575)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 45)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 8
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(270, 575)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 45)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        '
        'numMaxPlayers
        '
        Me.numMaxPlayers.BackColor = System.Drawing.Color.Transparent
        Me.numMaxPlayers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.numMaxPlayers.BorderRadius = 8
        Me.numMaxPlayers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numMaxPlayers.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.numMaxPlayers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.numMaxPlayers.ForeColor = System.Drawing.Color.White
        Me.numMaxPlayers.Location = New System.Drawing.Point(30, 480)
        Me.numMaxPlayers.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numMaxPlayers.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numMaxPlayers.Name = "numMaxPlayers"
        Me.numMaxPlayers.Size = New System.Drawing.Size(390, 40)
        Me.numMaxPlayers.TabIndex = 12
        Me.numMaxPlayers.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.numMaxPlayers.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'lblMaxPlayers
        '
        Me.lblMaxPlayers.AutoSize = True
        Me.lblMaxPlayers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblMaxPlayers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblMaxPlayers.Location = New System.Drawing.Point(30, 455)
        Me.lblMaxPlayers.Name = "lblMaxPlayers"
        Me.lblMaxPlayers.Size = New System.Drawing.Size(82, 19)
        Me.lblMaxPlayers.TabIndex = 11
        Me.lblMaxPlayers.Text = "Max Players"
        '
        'txtPrizePool
        '
        Me.txtPrizePool.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPrizePool.BorderRadius = 8
        Me.txtPrizePool.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrizePool.DefaultText = "0"
        Me.txtPrizePool.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtPrizePool.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtPrizePool.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPrizePool.ForeColor = System.Drawing.Color.White
        Me.txtPrizePool.Location = New System.Drawing.Point(235, 400)
        Me.txtPrizePool.Name = "txtPrizePool"
        Me.txtPrizePool.PlaceholderText = ""
        Me.txtPrizePool.SelectedText = ""
        Me.txtPrizePool.Size = New System.Drawing.Size(185, 40)
        Me.txtPrizePool.TabIndex = 10
        '
        'lblPrizePool
        '
        Me.lblPrizePool.AutoSize = True
        Me.lblPrizePool.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPrizePool.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPrizePool.Location = New System.Drawing.Point(235, 375)
        Me.lblPrizePool.Name = "lblPrizePool"
        Me.lblPrizePool.Size = New System.Drawing.Size(68, 19)
        Me.lblPrizePool.TabIndex = 9
        Me.lblPrizePool.Text = "Prize Pool"
        '
        'txtEntryFee
        '
        Me.txtEntryFee.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtEntryFee.BorderRadius = 8
        Me.txtEntryFee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEntryFee.DefaultText = "0"
        Me.txtEntryFee.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtEntryFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtEntryFee.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEntryFee.ForeColor = System.Drawing.Color.White
        Me.txtEntryFee.Location = New System.Drawing.Point(30, 400)
        Me.txtEntryFee.Name = "txtEntryFee"
        Me.txtEntryFee.PlaceholderText = ""
        Me.txtEntryFee.SelectedText = ""
        Me.txtEntryFee.Size = New System.Drawing.Size(185, 40)
        Me.txtEntryFee.TabIndex = 8
        '
        'lblEntryFee
        '
        Me.lblEntryFee.AutoSize = True
        Me.lblEntryFee.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEntryFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblEntryFee.Location = New System.Drawing.Point(30, 375)
        Me.lblEntryFee.Name = "lblEntryFee"
        Me.lblEntryFee.Size = New System.Drawing.Size(66, 19)
        Me.lblEntryFee.TabIndex = 7
        Me.lblEntryFee.Text = "Entry Fee"
        '
        'lblStartPreview
        '
        Me.lblStartPreview.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblStartPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblStartPreview.Location = New System.Drawing.Point(30, 310)
        Me.lblStartPreview.Name = "lblStartPreview"
        Me.lblStartPreview.Size = New System.Drawing.Size(390, 50)
        Me.lblStartPreview.TabIndex = 15
        Me.lblStartPreview.Text = "Starts At:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--"
        '
        'dtpStartTimePicker
        '
        Me.dtpStartTimePicker.BorderRadius = 8
        Me.dtpStartTimePicker.Checked = True
        Me.dtpStartTimePicker.CustomFormat = "hh:mm tt"
        Me.dtpStartTimePicker.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dtpStartTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStartTimePicker.ForeColor = System.Drawing.Color.White
        Me.dtpStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTimePicker.Location = New System.Drawing.Point(235, 265)
        Me.dtpStartTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartTimePicker.Name = "dtpStartTimePicker"
        Me.dtpStartTimePicker.ShowUpDown = True
        Me.dtpStartTimePicker.Size = New System.Drawing.Size(185, 40)
        Me.dtpStartTimePicker.TabIndex = 7
        Me.dtpStartTimePicker.Value = New Date(2026, 5, 21, 20, 30, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.BorderRadius = 8
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStartDate.Location = New System.Drawing.Point(30, 265)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(185, 40)
        Me.dtpStartDate.TabIndex = 6
        Me.dtpStartDate.Value = New Date(2026, 5, 21, 0, 0, 0, 0)
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblStartTime.Location = New System.Drawing.Point(30, 240)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(119, 19)
        Me.lblStartTime.TabIndex = 5
        Me.lblStartTime.Text = "Start Date && Time"
        '
        'cmbGames
        '
        Me.cmbGames.BackColor = System.Drawing.Color.Transparent
        Me.cmbGames.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbGames.BorderRadius = 8
        Me.cmbGames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGames.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.cmbGames.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cmbGames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cmbGames.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGames.ForeColor = System.Drawing.Color.White
        Me.cmbGames.ItemHeight = 30
        Me.cmbGames.Items.AddRange(New Object() {"Valorant", "League of Legends", "CS:GO", "FIFA 24", "Tekken 8", "Rocket League"})
        Me.cmbGames.Location = New System.Drawing.Point(30, 185)
        Me.cmbGames.Name = "cmbGames"
        Me.cmbGames.Size = New System.Drawing.Size(390, 36)
        Me.cmbGames.TabIndex = 4
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblGame.Location = New System.Drawing.Point(30, 160)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(84, 19)
        Me.lblGame.TabIndex = 3
        Me.lblGame.Text = "Select Game"
        '
        'txtTournamentName
        '
        Me.txtTournamentName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtTournamentName.BorderRadius = 8
        Me.txtTournamentName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTournamentName.DefaultText = ""
        Me.txtTournamentName.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtTournamentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtTournamentName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTournamentName.ForeColor = System.Drawing.Color.White
        Me.txtTournamentName.Location = New System.Drawing.Point(30, 105)
        Me.txtTournamentName.Name = "txtTournamentName"
        Me.txtTournamentName.PlaceholderText = "e.g., Weekend Brawl"
        Me.txtTournamentName.SelectedText = ""
        Me.txtTournamentName.Size = New System.Drawing.Size(390, 40)
        Me.txtTournamentName.TabIndex = 2
        '
        'lblTournamentName
        '
        Me.lblTournamentName.AutoSize = True
        Me.lblTournamentName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblTournamentName.Location = New System.Drawing.Point(30, 80)
        Me.lblTournamentName.Name = "lblTournamentName"
        Me.lblTournamentName.Size = New System.Drawing.Size(123, 19)
        Me.lblTournamentName.TabIndex = 1
        Me.lblTournamentName.Text = "Tournament Name"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(450, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(400, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 60)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(208, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add New Tournament"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'frmAddUpdateTournament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 650)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddUpdateTournament"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Tournament"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.numMaxPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTournamentName As System.Windows.Forms.Label
    Friend WithEvents txtTournamentName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents cmbGames As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblStartPreview As System.Windows.Forms.Label
    Friend WithEvents lblEntryFee As System.Windows.Forms.Label
    Friend WithEvents txtEntryFee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPrizePool As System.Windows.Forms.Label
    Friend WithEvents txtPrizePool As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMaxPlayers As System.Windows.Forms.Label
    Friend WithEvents numMaxPlayers As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl

End Class
