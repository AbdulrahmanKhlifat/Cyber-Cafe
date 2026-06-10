<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManagePlatforms
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddPlatform = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvPlatforms = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmsPlatforms = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.tsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlTop.SuspendLayout()
        CType(Me.dgvPlatforms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPlatforms.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(800, 60)
        Me.pnlTop.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(752, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 36)
        Me.btnClose.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(175, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Manage Platforms"
        '
        'btnAddPlatform
        '
        Me.btnAddPlatform.BorderRadius = 8
        Me.btnAddPlatform.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddPlatform.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPlatform.ForeColor = System.Drawing.Color.White
        Me.btnAddPlatform.Location = New System.Drawing.Point(620, 75)
        Me.btnAddPlatform.Name = "btnAddPlatform"
        Me.btnAddPlatform.Size = New System.Drawing.Size(160, 45)
        Me.btnAddPlatform.TabIndex = 1
        Me.btnAddPlatform.Text = "+ Add New"
        '
        'dgvPlatforms
        '
        Me.dgvPlatforms.AllowUserToAddRows = False
        Me.dgvPlatforms.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPlatforms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPlatforms.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlatforms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPlatforms.ColumnHeadersHeight = 40
        Me.dgvPlatforms.ContextMenuStrip = Me.cmsPlatforms
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPlatforms.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPlatforms.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvPlatforms.Location = New System.Drawing.Point(20, 135)
        Me.dgvPlatforms.MultiSelect = False
        Me.dgvPlatforms.Name = "dgvPlatforms"
        Me.dgvPlatforms.ReadOnly = True
        Me.dgvPlatforms.RowHeadersVisible = False
        Me.dgvPlatforms.RowTemplate.Height = 35
        Me.dgvPlatforms.Size = New System.Drawing.Size(760, 345)
        Me.dgvPlatforms.TabIndex = 2
        Me.dgvPlatforms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty
        Me.dgvPlatforms.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPlatforms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPlatforms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPlatforms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPlatforms.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvPlatforms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvPlatforms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvPlatforms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPlatforms.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.dgvPlatforms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPlatforms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPlatforms.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvPlatforms.ThemeStyle.ReadOnly = True
        Me.dgvPlatforms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPlatforms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPlatforms.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPlatforms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPlatforms.ThemeStyle.RowsStyle.Height = 35
        Me.dgvPlatforms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPlatforms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmsPlatforms
        '
        Me.cmsPlatforms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsEdit})
        Me.cmsPlatforms.Name = "cmsPlatforms"
        Me.cmsPlatforms.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsPlatforms.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmsPlatforms.RenderStyle.ColorTable = Nothing
        Me.cmsPlatforms.RenderStyle.RoundedEdges = True
        Me.cmsPlatforms.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.cmsPlatforms.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsPlatforms.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.cmsPlatforms.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.cmsPlatforms.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cmsPlatforms.Size = New System.Drawing.Size(95, 26)
        '
        'tsEdit
        '
        Me.tsEdit.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.pen__1_
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(94, 22)
        Me.tsEdit.Text = "Edit"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'frmManagePlatforms
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.dgvPlatforms)
        Me.Controls.Add(Me.btnAddPlatform)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManagePlatforms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Platforms"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgvPlatforms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPlatforms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAddPlatform As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvPlatforms As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmsPlatforms As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents tsEdit As ToolStripMenuItem
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
End Class
