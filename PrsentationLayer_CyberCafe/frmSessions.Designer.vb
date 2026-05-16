<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSessions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tmrDuration = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.tabPageActive = New System.Windows.Forms.TabPage()
        Me.dgvActiveSessions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tabSessions = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tabPageHistory = New System.Windows.Forms.TabPage()
        Me.dgvSessionsHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tabPausedSessions = New System.Windows.Forms.TabPage()
        Me.dgvPausedSessions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnFilterHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.cboHistoryCustomer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmsResumeSession = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.pnlHeader.SuspendLayout()
        Me.tabPageActive.SuspendLayout()
        CType(Me.dgvActiveSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSessions.SuspendLayout()
        Me.tabPageHistory.SuspendLayout()
        CType(Me.dgvSessionsHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPausedSessions.SuspendLayout()
        CType(Me.dgvPausedSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrDuration
        '
        Me.tmrDuration.Enabled = True
        Me.tmrDuration.Interval = 60000
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(17, 15)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(257, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "⏱  Sessions Management"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1341, 56)
        Me.pnlHeader.TabIndex = 3
        '
        'tabPageActive
        '
        Me.tabPageActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.tabPageActive.Controls.Add(Me.dgvActiveSessions)
        Me.tabPageActive.Location = New System.Drawing.Point(4, 44)
        Me.tabPageActive.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageActive.Name = "tabPageActive"
        Me.tabPageActive.Size = New System.Drawing.Size(1333, 617)
        Me.tabPageActive.TabIndex = 0
        Me.tabPageActive.Text = "Active Sessions"
        '
        'dgvActiveSessions
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvActiveSessions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvActiveSessions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActiveSessions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvActiveSessions.ColumnHeadersHeight = 42
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActiveSessions.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvActiveSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActiveSessions.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvActiveSessions.Location = New System.Drawing.Point(0, 0)
        Me.dgvActiveSessions.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvActiveSessions.Name = "dgvActiveSessions"
        Me.dgvActiveSessions.ReadOnly = True
        Me.dgvActiveSessions.RowHeadersVisible = False
        Me.dgvActiveSessions.RowHeadersWidth = 51
        Me.dgvActiveSessions.RowTemplate.Height = 40
        Me.dgvActiveSessions.Size = New System.Drawing.Size(1333, 617)
        Me.dgvActiveSessions.TabIndex = 0
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvActiveSessions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvActiveSessions.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvActiveSessions.ThemeStyle.HeaderStyle.Height = 42
        Me.dgvActiveSessions.ThemeStyle.ReadOnly = True
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.Height = 40
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgvActiveSessions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tabSessions
        '
        Me.tabSessions.Controls.Add(Me.tabPageActive)
        Me.tabSessions.Controls.Add(Me.tabPageHistory)
        Me.tabSessions.Controls.Add(Me.tabPausedSessions)
        Me.tabSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSessions.ItemSize = New System.Drawing.Size(180, 40)
        Me.tabSessions.Location = New System.Drawing.Point(0, 56)
        Me.tabSessions.Margin = New System.Windows.Forms.Padding(2)
        Me.tabSessions.Name = "tabSessions"
        Me.tabSessions.SelectedIndex = 0
        Me.tabSessions.Size = New System.Drawing.Size(1341, 665)
        Me.tabSessions.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tabSessions.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSessions.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabSessions.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tabSessions.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tabSessions.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tabSessions.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabSessions.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabSessions.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.tabSessions.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tabSessions.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tabSessions.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.tabSessions.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabSessions.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.tabSessions.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabSessions.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.tabSessions.TabIndex = 2
        Me.tabSessions.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tabSessions.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'tabPageHistory
        '
        Me.tabPageHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.tabPageHistory.Controls.Add(Me.dgvSessionsHistory)
        Me.tabPageHistory.Location = New System.Drawing.Point(4, 44)
        Me.tabPageHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPageHistory.Name = "tabPageHistory"
        Me.tabPageHistory.Size = New System.Drawing.Size(1333, 617)
        Me.tabPageHistory.TabIndex = 1
        Me.tabPageHistory.Text = "Session History"
        '
        'dgvSessionsHistory
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvSessionsHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvSessionsHistory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionsHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvSessionsHistory.ColumnHeadersHeight = 42
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSessionsHistory.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvSessionsHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSessionsHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSessionsHistory.Location = New System.Drawing.Point(0, 0)
        Me.dgvSessionsHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSessionsHistory.Name = "dgvSessionsHistory"
        Me.dgvSessionsHistory.ReadOnly = True
        Me.dgvSessionsHistory.RowHeadersVisible = False
        Me.dgvSessionsHistory.RowHeadersWidth = 51
        Me.dgvSessionsHistory.RowTemplate.Height = 40
        Me.dgvSessionsHistory.Size = New System.Drawing.Size(1333, 617)
        Me.dgvSessionsHistory.TabIndex = 0
        Me.dgvSessionsHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSessionsHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSessionsHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSessionsHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSessionsHistory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSessionsHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSessionsHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSessionsHistory.ThemeStyle.HeaderStyle.Height = 42
        Me.dgvSessionsHistory.ThemeStyle.ReadOnly = True
        Me.dgvSessionsHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSessionsHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSessionsHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.RowsStyle.Height = 40
        Me.dgvSessionsHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgvSessionsHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'tabPausedSessions
        '
        Me.tabPausedSessions.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.tabPausedSessions.Controls.Add(Me.dgvPausedSessions)
        Me.tabPausedSessions.Location = New System.Drawing.Point(4, 44)
        Me.tabPausedSessions.Name = "tabPausedSessions"
        Me.tabPausedSessions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPausedSessions.Size = New System.Drawing.Size(1333, 617)
        Me.tabPausedSessions.TabIndex = 2
        Me.tabPausedSessions.Text = "Paused Sessions"
        '
        'dgvPausedSessions
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvPausedSessions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvPausedSessions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPausedSessions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvPausedSessions.ColumnHeadersHeight = 42
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPausedSessions.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvPausedSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPausedSessions.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPausedSessions.Location = New System.Drawing.Point(3, 3)
        Me.dgvPausedSessions.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPausedSessions.Name = "dgvPausedSessions"
        Me.dgvPausedSessions.ReadOnly = True
        Me.dgvPausedSessions.RowHeadersVisible = False
        Me.dgvPausedSessions.RowHeadersWidth = 51
        Me.dgvPausedSessions.RowTemplate.Height = 40
        Me.dgvPausedSessions.Size = New System.Drawing.Size(1327, 611)
        Me.dgvPausedSessions.TabIndex = 1
        Me.dgvPausedSessions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPausedSessions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPausedSessions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPausedSessions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPausedSessions.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPausedSessions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPausedSessions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPausedSessions.ThemeStyle.HeaderStyle.Height = 42
        Me.dgvPausedSessions.ThemeStyle.ReadOnly = True
        Me.dgvPausedSessions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPausedSessions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPausedSessions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.RowsStyle.Height = 40
        Me.dgvPausedSessions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgvPausedSessions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnFilterHistory
        '
        Me.btnFilterHistory.BorderRadius = 8
        Me.btnFilterHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnFilterHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFilterHistory.ForeColor = System.Drawing.Color.White
        Me.btnFilterHistory.Location = New System.Drawing.Point(583, 17)
        Me.btnFilterHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilterHistory.Name = "btnFilterHistory"
        Me.btnFilterHistory.Size = New System.Drawing.Size(86, 31)
        Me.btnFilterHistory.TabIndex = 3
        '
        'cboHistoryCustomer
        '
        Me.cboHistoryCustomer.BackColor = System.Drawing.Color.Transparent
        Me.cboHistoryCustomer.BorderRadius = 8
        Me.cboHistoryCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboHistoryCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHistoryCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboHistoryCustomer.FocusedColor = System.Drawing.Color.Empty
        Me.cboHistoryCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboHistoryCustomer.ForeColor = System.Drawing.Color.White
        Me.cboHistoryCustomer.ItemHeight = 30
        Me.cboHistoryCustomer.Location = New System.Drawing.Point(394, 17)
        Me.cboHistoryCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.cboHistoryCustomer.Name = "cboHistoryCustomer"
        Me.cboHistoryCustomer.Size = New System.Drawing.Size(172, 36)
        Me.cboHistoryCustomer.TabIndex = 2
        '
        'dtpTo
        '
        Me.dtpTo.BorderRadius = 8
        Me.dtpTo.Checked = True
        Me.dtpTo.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTo.ForeColor = System.Drawing.Color.White
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTo.Location = New System.Drawing.Point(206, 17)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(172, 31)
        Me.dtpTo.TabIndex = 1
        Me.dtpTo.Value = New Date(2026, 4, 16, 12, 0, 59, 748)
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderRadius = 8
        Me.dtpFrom.Checked = True
        Me.dtpFrom.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFrom.ForeColor = System.Drawing.Color.White
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFrom.Location = New System.Drawing.Point(17, 17)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(172, 31)
        Me.dtpFrom.TabIndex = 0
        Me.dtpFrom.Value = New Date(2026, 4, 16, 12, 0, 59, 721)
        '
        'cmsPausedSessions
        '
        Me.cmsResumeSession.Name = "Guna2ContextMenuStrip1"
        Me.cmsResumeSession.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsResumeSession.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmsResumeSession.RenderStyle.ColorTable = Nothing
        Me.cmsResumeSession.RenderStyle.RoundedEdges = True
        Me.cmsResumeSession.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.cmsResumeSession.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsResumeSession.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.cmsResumeSession.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.cmsResumeSession.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cmsResumeSession.Size = New System.Drawing.Size(181, 26)
        '
        'frmSessions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 721)
        Me.Controls.Add(Me.tabSessions)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSessions"
        Me.Text = "frmSessions"
        Me.pnlHeader.ResumeLayout(False)
        Me.tabPageActive.ResumeLayout(False)
        CType(Me.dgvActiveSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSessions.ResumeLayout(False)
        Me.tabPageHistory.ResumeLayout(False)
        CType(Me.dgvSessionsHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPausedSessions.ResumeLayout(False)
        CType(Me.dgvPausedSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tmrDuration As Timer
    Private WithEvents lblTitle As Label
    Private WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tabPageActive As TabPage
    Private WithEvents dgvActiveSessions As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents tabSessions As Guna.UI2.WinForms.Guna2TabControl
    Private WithEvents tabPageHistory As TabPage
    Private WithEvents dgvSessionsHistory As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents btnFilterHistory As Guna.UI2.WinForms.Guna2Button
    Private WithEvents cboHistoryCustomer As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tabPausedSessions As TabPage
    Private WithEvents dgvPausedSessions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmsResumeSession As Guna.UI2.WinForms.Guna2ContextMenuStrip
End Class
