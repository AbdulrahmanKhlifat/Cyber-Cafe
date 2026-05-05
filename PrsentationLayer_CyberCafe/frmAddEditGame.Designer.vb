<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditGame
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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtGameName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.pbGameImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPlatforms = New System.Windows.Forms.Label()
        Me.flpPlatforms = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGameID = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbGameImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblGameID)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(375, 49)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(147, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add/Edit Game"
        '
        'txtGameName
        '
        Me.txtGameName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtGameName.BorderRadius = 6
        Me.txtGameName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGameName.DefaultText = ""
        Me.txtGameName.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtGameName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.txtGameName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGameName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtGameName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.txtGameName.Location = New System.Drawing.Point(20, 86)
        Me.txtGameName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGameName.Name = "txtGameName"
        Me.txtGameName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.txtGameName.PlaceholderText = "Enter game name..."
        Me.txtGameName.SelectedText = ""
        Me.txtGameName.Size = New System.Drawing.Size(336, 32)
        Me.txtGameName.TabIndex = 1
        '
        'lblGameName
        '
        Me.lblGameName.AutoSize = True
        Me.lblGameName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblGameName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblGameName.Location = New System.Drawing.Point(16, 65)
        Me.lblGameName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(86, 19)
        Me.lblGameName.TabIndex = 2
        Me.lblGameName.Text = "Game Name"
        '
        'pbGameImage
        '
        Me.pbGameImage.BackColor = System.Drawing.Color.Transparent
        Me.pbGameImage.BorderRadius = 6
        Me.pbGameImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbGameImage.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pbGameImage.ImageRotate = 0!
        Me.pbGameImage.Location = New System.Drawing.Point(20, 132)
        Me.pbGameImage.Margin = New System.Windows.Forms.Padding(2)
        Me.pbGameImage.Name = "pbGameImage"
        Me.pbGameImage.Size = New System.Drawing.Size(113, 147)
        Me.pbGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGameImage.TabIndex = 3
        Me.pbGameImage.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BorderRadius = 6
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(20, 283)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(112, 28)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse Image"
        '
        'lblPlatforms
        '
        Me.lblPlatforms.AutoSize = True
        Me.lblPlatforms.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblPlatforms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPlatforms.Location = New System.Drawing.Point(148, 132)
        Me.lblPlatforms.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlatforms.Name = "lblPlatforms"
        Me.lblPlatforms.Size = New System.Drawing.Size(138, 19)
        Me.lblPlatforms.TabIndex = 5
        Me.lblPlatforms.Text = "Supported Platforms"
        '
        'flpPlatforms
        '
        Me.flpPlatforms.Location = New System.Drawing.Point(152, 153)
        Me.flpPlatforms.Margin = New System.Windows.Forms.Padding(2)
        Me.flpPlatforms.Name = "flpPlatforms"
        Me.flpPlatforms.Size = New System.Drawing.Size(204, 158)
        Me.flpPlatforms.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 6
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(190, 341)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 37)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(280, 341)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 37)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(213, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Game ID:"
        '
        'lblGameID
        '
        Me.lblGameID.AutoSize = True
        Me.lblGameID.BackColor = System.Drawing.Color.Transparent
        Me.lblGameID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblGameID.Location = New System.Drawing.Point(292, 16)
        Me.lblGameID.Name = "lblGameID"
        Me.lblGameID.Size = New System.Drawing.Size(31, 21)
        Me.lblGameID.TabIndex = 10
        Me.lblGameID.Text = "???"
        '
        'frmAddEditGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(375, 406)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.flpPlatforms)
        Me.Controls.Add(Me.lblPlatforms)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.pbGameImage)
        Me.Controls.Add(Me.lblGameName)
        Me.Controls.Add(Me.txtGameName)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddEditGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddEditGame"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.pbGameImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtGameName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGameName As System.Windows.Forms.Label
    Friend WithEvents pbGameImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPlatforms As System.Windows.Forms.Label
    Friend WithEvents flpPlatforms As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGameID As Label
End Class
