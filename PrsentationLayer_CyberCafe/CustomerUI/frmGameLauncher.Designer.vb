<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameLauncher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.flpDeviceGames = New System.Windows.Forms.FlowLayoutPanel()
        Me.ScrollBar = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.txtSearch)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1300, 61)
        Me.pnlTop.TabIndex = 1
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
        'flpDeviceGames
        '
        Me.flpDeviceGames.AutoScroll = True
        Me.flpDeviceGames.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.flpDeviceGames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpDeviceGames.Location = New System.Drawing.Point(0, 61)
        Me.flpDeviceGames.Margin = New System.Windows.Forms.Padding(0)
        Me.flpDeviceGames.Name = "flpDeviceGames"
        Me.flpDeviceGames.Padding = New System.Windows.Forms.Padding(15)
        Me.flpDeviceGames.Size = New System.Drawing.Size(1300, 528)
        Me.flpDeviceGames.TabIndex = 3
        '
        'ScrollBar
        '
        Me.ScrollBar.BindingContainer = Me.flpDeviceGames
        Me.ScrollBar.BorderRadius = 10
        Me.ScrollBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ScrollBar.HighlightOnWheel = True
        Me.ScrollBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ScrollBar.InUpdate = False
        Me.ScrollBar.LargeChange = 528
        Me.ScrollBar.Location = New System.Drawing.Point(1282, 61)
        Me.ScrollBar.Margin = New System.Windows.Forms.Padding(1)
        Me.ScrollBar.Maximum = 566
        Me.ScrollBar.Name = "ScrollBar"
        Me.ScrollBar.ScrollbarSize = 18
        Me.ScrollBar.Size = New System.Drawing.Size(18, 528)
        Me.ScrollBar.SmallChange = 5
        Me.ScrollBar.TabIndex = 2
        Me.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset
        '
        'frmGameLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 589)
        Me.Controls.Add(Me.ScrollBar)
        Me.Controls.Add(Me.flpDeviceGames)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGameLauncher"
        Me.Text = "frmGameLauncher"
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents flpDeviceGames As FlowLayoutPanel
    Friend WithEvents ScrollBar As Guna.UI2.WinForms.Guna2VScrollBar
End Class
