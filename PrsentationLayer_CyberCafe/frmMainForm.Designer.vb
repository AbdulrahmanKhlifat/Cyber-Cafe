<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Me.tbllay = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCustomers = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCustIcon = New System.Windows.Forms.Label()
        Me.lblCustNum = New System.Windows.Forms.Label()
        Me.lblCustTitle = New System.Windows.Forms.Label()
        Me.pnlDevices = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDevIcon = New System.Windows.Forms.Label()
        Me.lblDevNum = New System.Windows.Forms.Label()
        Me.lblDevTitle = New System.Windows.Forms.Label()
        Me.pnlKpiSessions = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblSessIcon = New System.Windows.Forms.Label()
        Me.lblSessNum = New System.Windows.Forms.Label()
        Me.lblSessTitle = New System.Windows.Forms.Label()
        Me.pnlRevenue = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblRevIcon = New System.Windows.Forms.Label()
        Me.lblRevNum = New System.Windows.Forms.Label()
        Me.lblRevTitle = New System.Windows.Forms.Label()
        Me.lblHomeSubtitle = New System.Windows.Forms.Label()
        Me.lblHomeGreeting = New System.Windows.Forms.Label()
        Me.tbllay.SuspendLayout()
        Me.pnlCustomers.SuspendLayout()
        Me.pnlDevices.SuspendLayout()
        Me.pnlKpiSessions.SuspendLayout()
        Me.pnlRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbllay
        '
        Me.tbllay.BackColor = System.Drawing.Color.Transparent
        Me.tbllay.ColumnCount = 4
        Me.tbllay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tbllay.Controls.Add(Me.pnlCustomers, 0, 0)
        Me.tbllay.Controls.Add(Me.pnlDevices, 1, 0)
        Me.tbllay.Controls.Add(Me.pnlKpiSessions, 2, 0)
        Me.tbllay.Controls.Add(Me.pnlRevenue, 3, 0)
        Me.tbllay.Location = New System.Drawing.Point(42, 225)
        Me.tbllay.Name = "tbllay"
        Me.tbllay.RowCount = 1
        Me.tbllay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbllay.Size = New System.Drawing.Size(1274, 160)
        Me.tbllay.TabIndex = 8
        '
        'pnlCustomers
        '
        Me.pnlCustomers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlCustomers.BorderRadius = 12
        Me.pnlCustomers.BorderThickness = 1
        Me.pnlCustomers.Controls.Add(Me.lblCustIcon)
        Me.pnlCustomers.Controls.Add(Me.lblCustNum)
        Me.pnlCustomers.Controls.Add(Me.lblCustTitle)
        Me.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomers.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCustomers.Location = New System.Drawing.Point(9, 9)
        Me.pnlCustomers.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlCustomers.Name = "pnlCustomers"
        Me.pnlCustomers.Size = New System.Drawing.Size(300, 142)
        Me.pnlCustomers.TabIndex = 0
        '
        'lblCustIcon
        '
        Me.lblCustIcon.AutoSize = True
        Me.lblCustIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblCustIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblCustIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblCustIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblCustIcon.Name = "lblCustIcon"
        Me.lblCustIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblCustIcon.TabIndex = 0
        Me.lblCustIcon.Text = "👥"
        '
        'lblCustNum
        '
        Me.lblCustNum.AutoSize = True
        Me.lblCustNum.BackColor = System.Drawing.Color.Transparent
        Me.lblCustNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblCustNum.Location = New System.Drawing.Point(17, 51)
        Me.lblCustNum.Name = "lblCustNum"
        Me.lblCustNum.Size = New System.Drawing.Size(116, 50)
        Me.lblCustNum.TabIndex = 1
        Me.lblCustNum.Text = "1,247"
        '
        'lblCustTitle
        '
        Me.lblCustTitle.AutoSize = True
        Me.lblCustTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCustTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCustTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCustTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblCustTitle.Name = "lblCustTitle"
        Me.lblCustTitle.Size = New System.Drawing.Size(115, 20)
        Me.lblCustTitle.TabIndex = 2
        Me.lblCustTitle.Text = "Total Customers"
        '
        'pnlDevices
        '
        Me.pnlDevices.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDevices.BorderRadius = 12
        Me.pnlDevices.BorderThickness = 1
        Me.pnlDevices.Controls.Add(Me.lblDevIcon)
        Me.pnlDevices.Controls.Add(Me.lblDevNum)
        Me.pnlDevices.Controls.Add(Me.lblDevTitle)
        Me.pnlDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDevices.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlDevices.Location = New System.Drawing.Point(327, 9)
        Me.pnlDevices.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlDevices.Name = "pnlDevices"
        Me.pnlDevices.Size = New System.Drawing.Size(300, 142)
        Me.pnlDevices.TabIndex = 1
        '
        'lblDevIcon
        '
        Me.lblDevIcon.AutoSize = True
        Me.lblDevIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblDevIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblDevIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblDevIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblDevIcon.Name = "lblDevIcon"
        Me.lblDevIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblDevIcon.TabIndex = 0
        Me.lblDevIcon.Text = "🖥"
        '
        'lblDevNum
        '
        Me.lblDevNum.AutoSize = True
        Me.lblDevNum.BackColor = System.Drawing.Color.Transparent
        Me.lblDevNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblDevNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblDevNum.Location = New System.Drawing.Point(17, 51)
        Me.lblDevNum.Name = "lblDevNum"
        Me.lblDevNum.Size = New System.Drawing.Size(142, 50)
        Me.lblDevNum.TabIndex = 1
        Me.lblDevNum.Text = "18 / 25"
        '
        'lblDevTitle
        '
        Me.lblDevTitle.AutoSize = True
        Me.lblDevTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDevTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblDevTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblDevTitle.Name = "lblDevTitle"
        Me.lblDevTitle.Size = New System.Drawing.Size(105, 20)
        Me.lblDevTitle.TabIndex = 2
        Me.lblDevTitle.Text = "Active Devices"
        '
        'pnlKpiSessions
        '
        Me.pnlKpiSessions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlKpiSessions.BorderRadius = 12
        Me.pnlKpiSessions.BorderThickness = 1
        Me.pnlKpiSessions.Controls.Add(Me.lblSessIcon)
        Me.pnlKpiSessions.Controls.Add(Me.lblSessNum)
        Me.pnlKpiSessions.Controls.Add(Me.lblSessTitle)
        Me.pnlKpiSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKpiSessions.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlKpiSessions.Location = New System.Drawing.Point(645, 9)
        Me.pnlKpiSessions.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlKpiSessions.Name = "pnlKpiSessions"
        Me.pnlKpiSessions.Size = New System.Drawing.Size(300, 142)
        Me.pnlKpiSessions.TabIndex = 2
        '
        'lblSessIcon
        '
        Me.lblSessIcon.AutoSize = True
        Me.lblSessIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblSessIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblSessIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblSessIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblSessIcon.Name = "lblSessIcon"
        Me.lblSessIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblSessIcon.TabIndex = 0
        Me.lblSessIcon.Text = "⏱"
        '
        'lblSessNum
        '
        Me.lblSessNum.AutoSize = True
        Me.lblSessNum.BackColor = System.Drawing.Color.Transparent
        Me.lblSessNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblSessNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblSessNum.Location = New System.Drawing.Point(17, 51)
        Me.lblSessNum.Name = "lblSessNum"
        Me.lblSessNum.Size = New System.Drawing.Size(43, 50)
        Me.lblSessNum.TabIndex = 1
        Me.lblSessNum.Text = "5"
        '
        'lblSessTitle
        '
        Me.lblSessTitle.AutoSize = True
        Me.lblSessTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSessTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSessTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblSessTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblSessTitle.Name = "lblSessTitle"
        Me.lblSessTitle.Size = New System.Drawing.Size(109, 20)
        Me.lblSessTitle.TabIndex = 2
        Me.lblSessTitle.Text = "Active Sessions"
        '
        'pnlRevenue
        '
        Me.pnlRevenue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlRevenue.BorderRadius = 12
        Me.pnlRevenue.BorderThickness = 1
        Me.pnlRevenue.Controls.Add(Me.lblRevIcon)
        Me.pnlRevenue.Controls.Add(Me.lblRevNum)
        Me.pnlRevenue.Controls.Add(Me.lblRevTitle)
        Me.pnlRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRevenue.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlRevenue.Location = New System.Drawing.Point(963, 9)
        Me.pnlRevenue.Margin = New System.Windows.Forms.Padding(9)
        Me.pnlRevenue.Name = "pnlRevenue"
        Me.pnlRevenue.Size = New System.Drawing.Size(302, 142)
        Me.pnlRevenue.TabIndex = 3
        '
        'lblRevIcon
        '
        Me.lblRevIcon.AutoSize = True
        Me.lblRevIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblRevIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!)
        Me.lblRevIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblRevIcon.Location = New System.Drawing.Point(17, 13)
        Me.lblRevIcon.Name = "lblRevIcon"
        Me.lblRevIcon.Size = New System.Drawing.Size(58, 40)
        Me.lblRevIcon.TabIndex = 0
        Me.lblRevIcon.Text = "💰"
        '
        'lblRevNum
        '
        Me.lblRevNum.AutoSize = True
        Me.lblRevNum.BackColor = System.Drawing.Color.Transparent
        Me.lblRevNum.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblRevNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblRevNum.Location = New System.Drawing.Point(17, 51)
        Me.lblRevNum.Name = "lblRevNum"
        Me.lblRevNum.Size = New System.Drawing.Size(106, 50)
        Me.lblRevNum.TabIndex = 1
        Me.lblRevNum.Text = "$284"
        '
        'lblRevTitle
        '
        Me.lblRevTitle.AutoSize = True
        Me.lblRevTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblRevTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblRevTitle.Location = New System.Drawing.Point(17, 101)
        Me.lblRevTitle.Name = "lblRevTitle"
        Me.lblRevTitle.Size = New System.Drawing.Size(118, 20)
        Me.lblRevTitle.TabIndex = 2
        Me.lblRevTitle.Text = "Today's Revenue"
        '
        'lblHomeSubtitle
        '
        Me.lblHomeSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeSubtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblHomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblHomeSubtitle.Location = New System.Drawing.Point(42, 161)
        Me.lblHomeSubtitle.Name = "lblHomeSubtitle"
        Me.lblHomeSubtitle.Size = New System.Drawing.Size(691, 28)
        Me.lblHomeSubtitle.TabIndex = 9
        Me.lblHomeSubtitle.Text = "Here's what's happening at your cyber café today."
        '
        'lblHomeGreeting
        '
        Me.lblHomeGreeting.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeGreeting.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblHomeGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblHomeGreeting.Location = New System.Drawing.Point(43, 58)
        Me.lblHomeGreeting.Name = "lblHomeGreeting"
        Me.lblHomeGreeting.Size = New System.Drawing.Size(654, 51)
        Me.lblHomeGreeting.TabIndex = 10
        Me.lblHomeGreeting.Text = "👋  Good Morning, Administrator!"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1393, 652)
        Me.Controls.Add(Me.tbllay)
        Me.Controls.Add(Me.lblHomeSubtitle)
        Me.Controls.Add(Me.lblHomeGreeting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainForm"
        Me.Text = "frmMainForm"
        Me.tbllay.ResumeLayout(False)
        Me.pnlCustomers.ResumeLayout(False)
        Me.pnlCustomers.PerformLayout()
        Me.pnlDevices.ResumeLayout(False)
        Me.pnlDevices.PerformLayout()
        Me.pnlKpiSessions.ResumeLayout(False)
        Me.pnlKpiSessions.PerformLayout()
        Me.pnlRevenue.ResumeLayout(False)
        Me.pnlRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tbllay As TableLayoutPanel
    Private WithEvents pnlCustomers As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblCustIcon As Label
    Private WithEvents lblCustNum As Label
    Private WithEvents lblCustTitle As Label
    Private WithEvents pnlDevices As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblDevIcon As Label
    Private WithEvents lblDevNum As Label
    Private WithEvents lblDevTitle As Label
    Private WithEvents pnlKpiSessions As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblSessIcon As Label
    Private WithEvents lblSessNum As Label
    Private WithEvents lblSessTitle As Label
    Private WithEvents pnlRevenue As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblRevIcon As Label
    Private WithEvents lblRevNum As Label
    Private WithEvents lblRevTitle As Label
    Private WithEvents lblHomeSubtitle As Label
    Private WithEvents lblHomeGreeting As Label
End Class
