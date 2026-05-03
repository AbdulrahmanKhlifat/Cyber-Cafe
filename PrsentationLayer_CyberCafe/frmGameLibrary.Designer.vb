<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameLibrary
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddGame = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.flpGames = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmsGameMenu = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.tsiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.pnlTop.SuspendLayout()
        Me.cmsGameMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnAddGame)
        Me.pnlTop.Controls.Add(Me.txtSearch)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1341, 61)
        Me.pnlTop.TabIndex = 0
        '
        'btnAddGame
        '
        Me.btnAddGame.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddGame.BorderRadius = 6
        Me.btnAddGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddGame.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddGame.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnAddGame.ForeColor = System.Drawing.Color.White
        Me.btnAddGame.Location = New System.Drawing.Point(1144, 15)
        Me.btnAddGame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddGame.Name = "btnAddGame"
        Me.btnAddGame.Size = New System.Drawing.Size(171, 32)
        Me.btnAddGame.TabIndex = 1
        Me.btnAddGame.Text = "+ Add New Game"
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtSearch.BorderRadius = 6
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(15, 15)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtSearch.PlaceholderText = "Search games..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(262, 32)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextOffset = New System.Drawing.Point(5, 0)
        '
        'flpGames
        '
        Me.flpGames.AutoScroll = True
        Me.flpGames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpGames.Location = New System.Drawing.Point(0, 61)
        Me.flpGames.Margin = New System.Windows.Forms.Padding(2)
        Me.flpGames.Name = "flpGames"
        Me.flpGames.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.flpGames.Size = New System.Drawing.Size(1341, 654)
        Me.flpGames.TabIndex = 1
        '
        'cmsGameMenu
        '
        Me.cmsGameMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmsGameMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsGameMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiEdit, Me.tsiDelete})
        Me.cmsGameMenu.Name = "cmsGameMenu"
        Me.cmsGameMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.cmsGameMenu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmsGameMenu.RenderStyle.ColorTable = Nothing
        Me.cmsGameMenu.RenderStyle.RoundedEdges = True
        Me.cmsGameMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.cmsGameMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.cmsGameMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.cmsGameMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.cmsGameMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cmsGameMenu.Size = New System.Drawing.Size(132, 56)
        '
        'tsiEdit
        '
        Me.tsiEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsiEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tsiEdit.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.pen__1_
        Me.tsiEdit.Name = "tsiEdit"
        Me.tsiEdit.Size = New System.Drawing.Size(131, 26)
        Me.tsiEdit.Text = "Edit"
        '
        'tsiDelete
        '
        Me.tsiDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsiDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.tsiDelete.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.delete
        Me.tsiDelete.Name = "tsiDelete"
        Me.tsiDelete.Size = New System.Drawing.Size(131, 26)
        Me.tsiDelete.Text = "Delete"
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.BindingContainer = Me.flpGames
        Me.Guna2VScrollBar1.BorderRadius = 10
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(1323, 61)
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.ScrollbarSize = 18
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(18, 654)
        Me.Guna2VScrollBar1.TabIndex = 0
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        '
        'frmGameLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 715)
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Controls.Add(Me.flpGames)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmGameLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Library"
        Me.pnlTop.ResumeLayout(False)
        Me.cmsGameMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddGame As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpGames As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmsGameMenu As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents tsiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsiDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
End Class
