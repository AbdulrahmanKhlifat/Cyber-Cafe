<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTournamentManagement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMainContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGridContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvTournaments = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmsTournament = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.tsmiShowDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGenerateDraw = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewMatches = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewPlayers = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewResults = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewWinner = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReopen = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlCardsContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.tlpCards = New System.Windows.Forms.TableLayoutPanel()
        Me.cardActive = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCardActiveTitle = New System.Windows.Forms.Label()
        Me.lblCardActiveVal = New System.Windows.Forms.Label()
        Me.cardRunning = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCardRunningTitle = New System.Windows.Forms.Label()
        Me.lblCardRunningVal = New System.Windows.Forms.Label()
        Me.cardPlayers = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCardPlayersTitle = New System.Windows.Forms.Label()
        Me.lblCardPlayersVal = New System.Windows.Forms.Label()
        Me.cardPrize = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCardPrizeTitle = New System.Windows.Forms.Label()
        Me.lblCardPrizeVal = New System.Windows.Forms.Label()
        Me.cardRevenue = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCardRevenueTitle = New System.Windows.Forms.Label()
        Me.lblCardRevenueVal = New System.Windows.Forms.Label()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddTournament = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbGameFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.tmrLiveTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTournamentDuration = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMainContainer.SuspendLayout()
        Me.pnlGridContainer.SuspendLayout()
        CType(Me.dgvTournaments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsTournament.SuspendLayout()
        Me.pnlCardsContainer.SuspendLayout()
        Me.tlpCards.SuspendLayout()
        Me.cardActive.SuspendLayout()
        Me.cardRunning.SuspendLayout()
        Me.cardPlayers.SuspendLayout()
        Me.cardPrize.SuspendLayout()
        Me.cardRevenue.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainContainer
        '
        Me.pnlMainContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlMainContainer.Controls.Add(Me.pnlGridContainer)
        Me.pnlMainContainer.Controls.Add(Me.pnlCardsContainer)
        Me.pnlMainContainer.Controls.Add(Me.pnlToolbar)
        Me.pnlMainContainer.Controls.Add(Me.pnlHeader)
        Me.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainContainer.Name = "pnlMainContainer"
        Me.pnlMainContainer.Size = New System.Drawing.Size(1200, 742)
        Me.pnlMainContainer.TabIndex = 0
        '
        'pnlGridContainer
        '
        Me.pnlGridContainer.Controls.Add(Me.dgvTournaments)
        Me.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridContainer.Location = New System.Drawing.Point(0, 280)
        Me.pnlGridContainer.Name = "pnlGridContainer"
        Me.pnlGridContainer.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.pnlGridContainer.Size = New System.Drawing.Size(1200, 462)
        Me.pnlGridContainer.TabIndex = 6
        '
        'dgvTournaments
        '
        Me.dgvTournaments.AllowUserToAddRows = False
        Me.dgvTournaments.AllowUserToDeleteRows = False
        Me.dgvTournaments.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvTournaments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTournaments.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTournaments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTournaments.ColumnHeadersHeight = 45
        Me.dgvTournaments.ContextMenuStrip = Me.cmsTournament
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTournaments.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTournaments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTournaments.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvTournaments.Location = New System.Drawing.Point(20, 10)
        Me.dgvTournaments.Name = "dgvTournaments"
        Me.dgvTournaments.ReadOnly = True
        Me.dgvTournaments.RowHeadersVisible = False
        Me.dgvTournaments.RowTemplate.Height = 50
        Me.dgvTournaments.Size = New System.Drawing.Size(1160, 442)
        Me.dgvTournaments.TabIndex = 0
        Me.dgvTournaments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTournaments.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvTournaments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvTournaments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvTournaments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvTournaments.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvTournaments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvTournaments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvTournaments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTournaments.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvTournaments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.dgvTournaments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTournaments.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvTournaments.ThemeStyle.ReadOnly = True
        Me.dgvTournaments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvTournaments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTournaments.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dgvTournaments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvTournaments.ThemeStyle.RowsStyle.Height = 50
        Me.dgvTournaments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dgvTournaments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'cmsTournament
        '
        Me.cmsTournament.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmsTournament.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiShowDetails, Me.tsmiStart, Me.tsmiEdit, Me.tsmiRegister, Me.tsmiCancel, Me.tsmiGenerateDraw, Me.tsmiViewMatches, Me.tsmiViewPlayers, Me.tsmiViewResults, Me.tsmiViewWinner, Me.tsmiReopen})
        Me.cmsTournament.Name = "cmsTournament"
        Me.cmsTournament.RenderStyle.ArrowColor = System.Drawing.Color.White
        Me.cmsTournament.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmsTournament.RenderStyle.ColorTable = Nothing
        Me.cmsTournament.RenderStyle.RoundedEdges = True
        Me.cmsTournament.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.cmsTournament.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cmsTournament.RenderStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.cmsTournament.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmsTournament.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmsTournament.Size = New System.Drawing.Size(183, 246)
        '
        'tsmiShowDetails
        '
        Me.tsmiShowDetails.ForeColor = System.Drawing.Color.White
        Me.tsmiShowDetails.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.file
        Me.tsmiShowDetails.Name = "tsmiShowDetails"
        Me.tsmiShowDetails.Size = New System.Drawing.Size(182, 22)
        Me.tsmiShowDetails.Text = "Show Details"
        '
        'tsmiStart
        '
        Me.tsmiStart.ForeColor = System.Drawing.Color.White
        Me.tsmiStart.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.play
        Me.tsmiStart.Name = "tsmiStart"
        Me.tsmiStart.Size = New System.Drawing.Size(182, 22)
        Me.tsmiStart.Text = "Start Tournament"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.ForeColor = System.Drawing.Color.White
        Me.tsmiEdit.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.edit
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(182, 22)
        Me.tsmiEdit.Text = "Edit Tournament"
        '
        'tsmiRegister
        '
        Me.tsmiRegister.ForeColor = System.Drawing.Color.White
        Me.tsmiRegister.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.add_user__2_
        Me.tsmiRegister.Name = "tsmiRegister"
        Me.tsmiRegister.Size = New System.Drawing.Size(182, 22)
        Me.tsmiRegister.Text = "Register Player"
        '
        'tsmiCancel
        '
        Me.tsmiCancel.ForeColor = System.Drawing.Color.White
        Me.tsmiCancel.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.cancelled
        Me.tsmiCancel.Name = "tsmiCancel"
        Me.tsmiCancel.Size = New System.Drawing.Size(182, 22)
        Me.tsmiCancel.Text = "Cancel Tournament"
        '
        'tsmiGenerateDraw
        '
        Me.tsmiGenerateDraw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tsmiGenerateDraw.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.tournament
        Me.tsmiGenerateDraw.Name = "tsmiGenerateDraw"
        Me.tsmiGenerateDraw.Size = New System.Drawing.Size(182, 22)
        Me.tsmiGenerateDraw.Text = "Generate Draw"
        '
        'tsmiViewMatches
        '
        Me.tsmiViewMatches.ForeColor = System.Drawing.Color.White
        Me.tsmiViewMatches.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.stadium
        Me.tsmiViewMatches.Name = "tsmiViewMatches"
        Me.tsmiViewMatches.Size = New System.Drawing.Size(182, 22)
        Me.tsmiViewMatches.Text = "View Matches"
        '
        'tsmiViewPlayers
        '
        Me.tsmiViewPlayers.ForeColor = System.Drawing.Color.White
        Me.tsmiViewPlayers.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.icons8_players_64
        Me.tsmiViewPlayers.Name = "tsmiViewPlayers"
        Me.tsmiViewPlayers.Size = New System.Drawing.Size(182, 22)
        Me.tsmiViewPlayers.Text = "View Players"
        '
        'tsmiViewResults
        '
        Me.tsmiViewResults.ForeColor = System.Drawing.Color.White
        Me.tsmiViewResults.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.scoreboard
        Me.tsmiViewResults.Name = "tsmiViewResults"
        Me.tsmiViewResults.Size = New System.Drawing.Size(182, 22)
        Me.tsmiViewResults.Text = "View Results"
        '
        'tsmiViewWinner
        '
        Me.tsmiViewWinner.ForeColor = System.Drawing.Color.White
        Me.tsmiViewWinner.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.trophy
        Me.tsmiViewWinner.Name = "tsmiViewWinner"
        Me.tsmiViewWinner.Size = New System.Drawing.Size(182, 22)
        Me.tsmiViewWinner.Text = "View Winner"
        '
        'tsmiReopen
        '
        Me.tsmiReopen.ForeColor = System.Drawing.Color.White
        Me.tsmiReopen.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.programming
        Me.tsmiReopen.Name = "tsmiReopen"
        Me.tsmiReopen.Size = New System.Drawing.Size(182, 22)
        Me.tsmiReopen.Text = "Reopen Tournament"
        '
        'pnlCardsContainer
        '
        Me.pnlCardsContainer.Controls.Add(Me.tlpCards)
        Me.pnlCardsContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCardsContainer.Location = New System.Drawing.Point(0, 160)
        Me.pnlCardsContainer.Name = "pnlCardsContainer"
        Me.pnlCardsContainer.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.pnlCardsContainer.Size = New System.Drawing.Size(1200, 120)
        Me.pnlCardsContainer.TabIndex = 5
        '
        'tlpCards
        '
        Me.tlpCards.ColumnCount = 5
        Me.tlpCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpCards.Controls.Add(Me.cardActive, 0, 0)
        Me.tlpCards.Controls.Add(Me.cardRunning, 1, 0)
        Me.tlpCards.Controls.Add(Me.cardPlayers, 2, 0)
        Me.tlpCards.Controls.Add(Me.cardPrize, 3, 0)
        Me.tlpCards.Controls.Add(Me.cardRevenue, 4, 0)
        Me.tlpCards.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCards.Location = New System.Drawing.Point(20, 10)
        Me.tlpCards.Name = "tlpCards"
        Me.tlpCards.RowCount = 1
        Me.tlpCards.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCards.Size = New System.Drawing.Size(1160, 100)
        Me.tlpCards.TabIndex = 0
        '
        'cardActive
        '
        Me.cardActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cardActive.BorderRadius = 15
        Me.cardActive.BorderThickness = 1
        Me.cardActive.Controls.Add(Me.lblCardActiveTitle)
        Me.cardActive.Controls.Add(Me.lblCardActiveVal)
        Me.cardActive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cardActive.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cardActive.Location = New System.Drawing.Point(5, 5)
        Me.cardActive.Margin = New System.Windows.Forms.Padding(5)
        Me.cardActive.Name = "cardActive"
        Me.cardActive.Size = New System.Drawing.Size(222, 90)
        Me.cardActive.TabIndex = 0
        '
        'lblCardActiveTitle
        '
        Me.lblCardActiveTitle.AutoSize = True
        Me.lblCardActiveTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardActiveTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCardActiveTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCardActiveTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblCardActiveTitle.Name = "lblCardActiveTitle"
        Me.lblCardActiveTitle.Size = New System.Drawing.Size(130, 19)
        Me.lblCardActiveTitle.TabIndex = 0
        Me.lblCardActiveTitle.Text = "Active Tournaments"
        '
        'lblCardActiveVal
        '
        Me.lblCardActiveVal.AutoSize = True
        Me.lblCardActiveVal.BackColor = System.Drawing.Color.Transparent
        Me.lblCardActiveVal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardActiveVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblCardActiveVal.Location = New System.Drawing.Point(15, 40)
        Me.lblCardActiveVal.Name = "lblCardActiveVal"
        Me.lblCardActiveVal.Size = New System.Drawing.Size(38, 45)
        Me.lblCardActiveVal.TabIndex = 1
        Me.lblCardActiveVal.Text = "4"
        '
        'cardRunning
        '
        Me.cardRunning.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.cardRunning.BorderRadius = 15
        Me.cardRunning.BorderThickness = 1
        Me.cardRunning.Controls.Add(Me.lblCardRunningTitle)
        Me.cardRunning.Controls.Add(Me.lblCardRunningVal)
        Me.cardRunning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cardRunning.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cardRunning.Location = New System.Drawing.Point(237, 5)
        Me.cardRunning.Margin = New System.Windows.Forms.Padding(5)
        Me.cardRunning.Name = "cardRunning"
        Me.cardRunning.Size = New System.Drawing.Size(222, 90)
        Me.cardRunning.TabIndex = 1
        '
        'lblCardRunningTitle
        '
        Me.lblCardRunningTitle.AutoSize = True
        Me.lblCardRunningTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardRunningTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCardRunningTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCardRunningTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblCardRunningTitle.Name = "lblCardRunningTitle"
        Me.lblCardRunningTitle.Size = New System.Drawing.Size(116, 19)
        Me.lblCardRunningTitle.TabIndex = 0
        Me.lblCardRunningTitle.Text = "Running Matches"
        '
        'lblCardRunningVal
        '
        Me.lblCardRunningVal.AutoSize = True
        Me.lblCardRunningVal.BackColor = System.Drawing.Color.Transparent
        Me.lblCardRunningVal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardRunningVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblCardRunningVal.Location = New System.Drawing.Point(15, 40)
        Me.lblCardRunningVal.Name = "lblCardRunningVal"
        Me.lblCardRunningVal.Size = New System.Drawing.Size(38, 45)
        Me.lblCardRunningVal.TabIndex = 1
        Me.lblCardRunningVal.Text = "8"
        '
        'cardPlayers
        '
        Me.cardPlayers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cardPlayers.BorderRadius = 15
        Me.cardPlayers.BorderThickness = 1
        Me.cardPlayers.Controls.Add(Me.lblCardPlayersTitle)
        Me.cardPlayers.Controls.Add(Me.lblCardPlayersVal)
        Me.cardPlayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cardPlayers.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cardPlayers.Location = New System.Drawing.Point(469, 5)
        Me.cardPlayers.Margin = New System.Windows.Forms.Padding(5)
        Me.cardPlayers.Name = "cardPlayers"
        Me.cardPlayers.Size = New System.Drawing.Size(222, 90)
        Me.cardPlayers.TabIndex = 2
        '
        'lblCardPlayersTitle
        '
        Me.lblCardPlayersTitle.AutoSize = True
        Me.lblCardPlayersTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardPlayersTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCardPlayersTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCardPlayersTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblCardPlayersTitle.Name = "lblCardPlayersTitle"
        Me.lblCardPlayersTitle.Size = New System.Drawing.Size(120, 19)
        Me.lblCardPlayersTitle.TabIndex = 0
        Me.lblCardPlayersTitle.Text = "Registered Players"
        '
        'lblCardPlayersVal
        '
        Me.lblCardPlayersVal.AutoSize = True
        Me.lblCardPlayersVal.BackColor = System.Drawing.Color.Transparent
        Me.lblCardPlayersVal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardPlayersVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblCardPlayersVal.Location = New System.Drawing.Point(15, 40)
        Me.lblCardPlayersVal.Name = "lblCardPlayersVal"
        Me.lblCardPlayersVal.Size = New System.Drawing.Size(56, 45)
        Me.lblCardPlayersVal.TabIndex = 1
        Me.lblCardPlayersVal.Text = "75"
        '
        'cardPrize
        '
        Me.cardPrize.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.cardPrize.BorderRadius = 15
        Me.cardPrize.BorderThickness = 1
        Me.cardPrize.Controls.Add(Me.lblCardPrizeTitle)
        Me.cardPrize.Controls.Add(Me.lblCardPrizeVal)
        Me.cardPrize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cardPrize.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cardPrize.Location = New System.Drawing.Point(701, 5)
        Me.cardPrize.Margin = New System.Windows.Forms.Padding(5)
        Me.cardPrize.Name = "cardPrize"
        Me.cardPrize.Size = New System.Drawing.Size(222, 90)
        Me.cardPrize.TabIndex = 3
        '
        'lblCardPrizeTitle
        '
        Me.lblCardPrizeTitle.AutoSize = True
        Me.lblCardPrizeTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardPrizeTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCardPrizeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCardPrizeTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblCardPrizeTitle.Name = "lblCardPrizeTitle"
        Me.lblCardPrizeTitle.Size = New System.Drawing.Size(68, 19)
        Me.lblCardPrizeTitle.TabIndex = 0
        Me.lblCardPrizeTitle.Text = "Prize Pool"
        '
        'lblCardPrizeVal
        '
        Me.lblCardPrizeVal.AutoSize = True
        Me.lblCardPrizeVal.BackColor = System.Drawing.Color.Transparent
        Me.lblCardPrizeVal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardPrizeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.lblCardPrizeVal.Location = New System.Drawing.Point(15, 40)
        Me.lblCardPrizeVal.Name = "lblCardPrizeVal"
        Me.lblCardPrizeVal.Size = New System.Drawing.Size(92, 45)
        Me.lblCardPrizeVal.TabIndex = 1
        Me.lblCardPrizeVal.Text = "$500"
        '
        'cardRevenue
        '
        Me.cardRevenue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.cardRevenue.BorderRadius = 15
        Me.cardRevenue.BorderThickness = 1
        Me.cardRevenue.Controls.Add(Me.lblCardRevenueTitle)
        Me.cardRevenue.Controls.Add(Me.lblCardRevenueVal)
        Me.cardRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cardRevenue.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cardRevenue.Location = New System.Drawing.Point(933, 5)
        Me.cardRevenue.Margin = New System.Windows.Forms.Padding(5)
        Me.cardRevenue.Name = "cardRevenue"
        Me.cardRevenue.Size = New System.Drawing.Size(222, 90)
        Me.cardRevenue.TabIndex = 4
        '
        'lblCardRevenueTitle
        '
        Me.lblCardRevenueTitle.AutoSize = True
        Me.lblCardRevenueTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardRevenueTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCardRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCardRevenueTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblCardRevenueTitle.Name = "lblCardRevenueTitle"
        Me.lblCardRevenueTitle.Size = New System.Drawing.Size(139, 19)
        Me.lblCardRevenueTitle.TabIndex = 0
        Me.lblCardRevenueTitle.Text = "Tournament Revenue"
        '
        'lblCardRevenueVal
        '
        Me.lblCardRevenueVal.AutoSize = True
        Me.lblCardRevenueVal.BackColor = System.Drawing.Color.Transparent
        Me.lblCardRevenueVal.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardRevenueVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.lblCardRevenueVal.Location = New System.Drawing.Point(15, 40)
        Me.lblCardRevenueVal.Name = "lblCardRevenueVal"
        Me.lblCardRevenueVal.Size = New System.Drawing.Size(110, 45)
        Me.lblCardRevenueVal.TabIndex = 1
        Me.lblCardRevenueVal.Text = "$1000"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.Controls.Add(Me.btnAddTournament)
        Me.pnlToolbar.Controls.Add(Me.cmbGameFilter)
        Me.pnlToolbar.Controls.Add(Me.cmbStatus)
        Me.pnlToolbar.Controls.Add(Me.txtSearch)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 90)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.pnlToolbar.Size = New System.Drawing.Size(1200, 70)
        Me.pnlToolbar.TabIndex = 4
        '
        'btnAddTournament
        '
        Me.btnAddTournament.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTournament.Animated = True
        Me.btnAddTournament.BorderRadius = 10
        Me.btnAddTournament.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTournament.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddTournament.ForeColor = System.Drawing.Color.Black
        Me.btnAddTournament.Location = New System.Drawing.Point(1010, 16)
        Me.btnAddTournament.Name = "btnAddTournament"
        Me.btnAddTournament.Size = New System.Drawing.Size(170, 40)
        Me.btnAddTournament.TabIndex = 3
        Me.btnAddTournament.Text = "+ Add Tournament"
        '
        'cmbGameFilter
        '
        Me.cmbGameFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbGameFilter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbGameFilter.BorderRadius = 10
        Me.cmbGameFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGameFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGameFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbGameFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbGameFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbGameFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGameFilter.ForeColor = System.Drawing.Color.White
        Me.cmbGameFilter.ItemHeight = 30
        Me.cmbGameFilter.Items.AddRange(New Object() {"All", "Fifa 26", "Fifa 24", "Rocket League", "Tekken"})
        Me.cmbGameFilter.Location = New System.Drawing.Point(440, 15)
        Me.cmbGameFilter.Name = "cmbGameFilter"
        Me.cmbGameFilter.Size = New System.Drawing.Size(150, 36)
        Me.cmbGameFilter.StartIndex = 0
        Me.cmbGameFilter.TabIndex = 2
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbStatus.BorderRadius = 10
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.White
        Me.cmbStatus.ItemHeight = 30
        Me.cmbStatus.Items.AddRange(New Object() {"All", "Upcoming", "Running", "Finished", "Cancelled"})
        Me.cmbStatus.Location = New System.Drawing.Point(280, 15)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(150, 36)
        Me.cmbStatus.StartIndex = 0
        Me.cmbStatus.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(20, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search tournaments..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(250, 40)
        Me.txtSearch.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblPageTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 90)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(20, 60)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(314, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Manage esports tournaments and player brackets"
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.White
        Me.lblPageTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(489, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "TOURNAMENT MANAGEMENT"
        '
        'tmrLiveTime
        '
        Me.tmrLiveTime.Enabled = True
        Me.tmrLiveTime.Interval = 1000
        '
        'tmrTournamentDuration
        '
        Me.tmrTournamentDuration.Enabled = True
        Me.tmrTournamentDuration.Interval = 1000
        '
        'frmTournamentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 742)
        Me.Controls.Add(Me.pnlMainContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTournamentManagement"
        Me.Text = "Tournament Management"
        Me.pnlMainContainer.ResumeLayout(False)
        Me.pnlGridContainer.ResumeLayout(False)
        CType(Me.dgvTournaments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsTournament.ResumeLayout(False)
        Me.pnlCardsContainer.ResumeLayout(False)
        Me.tlpCards.ResumeLayout(False)
        Me.cardActive.ResumeLayout(False)
        Me.cardActive.PerformLayout()
        Me.cardRunning.ResumeLayout(False)
        Me.cardRunning.PerformLayout()
        Me.cardPlayers.ResumeLayout(False)
        Me.cardPlayers.PerformLayout()
        Me.cardPrize.ResumeLayout(False)
        Me.cardPrize.PerformLayout()
        Me.cardRevenue.ResumeLayout(False)
        Me.cardRevenue.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMainContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents tmrLiveTime As System.Windows.Forms.Timer
    Friend WithEvents cmsTournament As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents tsmiStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRegister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiViewMatches As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiViewPlayers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiViewResults As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiViewWinner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiReopen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGenerateDraw As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrTournamentDuration As System.Windows.Forms.Timer

    Friend WithEvents tsmiShowDetails As ToolStripMenuItem
    Friend WithEvents pnlGridContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvTournaments As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlCardsContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tlpCards As TableLayoutPanel
    Friend WithEvents cardActive As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardActiveTitle As Label
    Friend WithEvents lblCardActiveVal As Label
    Friend WithEvents cardRunning As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardRunningTitle As Label
    Friend WithEvents lblCardRunningVal As Label
    Friend WithEvents cardPlayers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardPlayersTitle As Label
    Friend WithEvents lblCardPlayersVal As Label
    Friend WithEvents cardPrize As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardPrizeTitle As Label
    Friend WithEvents lblCardPrizeVal As Label
    Friend WithEvents cardRevenue As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardRevenueTitle As Label
    Friend WithEvents lblCardRevenueVal As Label
    Friend WithEvents pnlToolbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddTournament As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbGameFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
