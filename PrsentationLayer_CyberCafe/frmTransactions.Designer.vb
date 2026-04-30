<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactions
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
        Me.pnlFilter = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlTotalRev = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblTitleRev = New System.Windows.Forms.Label()
        Me.pnlTotalTrans = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTransNum = New System.Windows.Forms.Label()
        Me.lblTransTitle = New System.Windows.Forms.Label()
        Me.pnlPenPay = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblPenPayNum = New System.Windows.Forms.Label()
        Me.lblPayTItle = New System.Windows.Forms.Label()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvTrans = New System.Windows.Forms.DataGridView()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cboStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlFilter.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlTotalRev.SuspendLayout()
        Me.pnlTotalTrans.SuspendLayout()
        Me.pnlPenPay.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlFilter.Controls.Add(Me.dtpFrom)
        Me.pnlFilter.Controls.Add(Me.dtpTo)
        Me.pnlFilter.Controls.Add(Me.cboStatus)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlFilter.Location = New System.Drawing.Point(0, 165)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1341, 69)
        Me.pnlFilter.TabIndex = 7
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.pnlTotalRev)
        Me.pnlTop.Controls.Add(Me.pnlTotalTrans)
        Me.pnlTop.Controls.Add(Me.pnlPenPay)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 63)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1341, 102)
        Me.pnlTop.TabIndex = 6
        '
        'pnlTotalRev
        '
        Me.pnlTotalRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlTotalRev.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTotalRev.BorderRadius = 12
        Me.pnlTotalRev.BorderThickness = 1
        Me.pnlTotalRev.Controls.Add(Me.lblMoney)
        Me.pnlTotalRev.Controls.Add(Me.lblTitleRev)
        Me.pnlTotalRev.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlTotalRev.Location = New System.Drawing.Point(23, 15)
        Me.pnlTotalRev.Name = "pnlTotalRev"
        Me.pnlTotalRev.Size = New System.Drawing.Size(297, 79)
        Me.pnlTotalRev.TabIndex = 0
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblMoney.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblMoney.Location = New System.Drawing.Point(17, 11)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(106, 28)
        Me.lblMoney.TabIndex = 0
        Me.lblMoney.Text = "$1,245.00"
        '
        'lblTitleRev
        '
        Me.lblTitleRev.AutoSize = True
        Me.lblTitleRev.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleRev.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleRev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblTitleRev.Location = New System.Drawing.Point(17, 39)
        Me.lblTitleRev.Name = "lblTitleRev"
        Me.lblTitleRev.Size = New System.Drawing.Size(222, 28)
        Me.lblTitleRev.TabIndex = 1
        Me.lblTitleRev.Text = "Total Revenue (Today)"
        '
        'pnlTotalTrans
        '
        Me.pnlTotalTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlTotalTrans.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlTotalTrans.BorderRadius = 12
        Me.pnlTotalTrans.BorderThickness = 1
        Me.pnlTotalTrans.Controls.Add(Me.lblTransNum)
        Me.pnlTotalTrans.Controls.Add(Me.lblTransTitle)
        Me.pnlTotalTrans.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlTotalTrans.Location = New System.Drawing.Point(343, 14)
        Me.pnlTotalTrans.Name = "pnlTotalTrans"
        Me.pnlTotalTrans.Size = New System.Drawing.Size(297, 79)
        Me.pnlTotalTrans.TabIndex = 1
        '
        'lblTransNum
        '
        Me.lblTransNum.AutoSize = True
        Me.lblTransNum.BackColor = System.Drawing.Color.Transparent
        Me.lblTransNum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTransNum.Location = New System.Drawing.Point(17, 11)
        Me.lblTransNum.Name = "lblTransNum"
        Me.lblTransNum.Size = New System.Drawing.Size(36, 28)
        Me.lblTransNum.TabIndex = 0
        Me.lblTransNum.Text = "42"
        '
        'lblTransTitle
        '
        Me.lblTransTitle.AutoSize = True
        Me.lblTransTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTransTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblTransTitle.Location = New System.Drawing.Point(17, 39)
        Me.lblTransTitle.Name = "lblTransTitle"
        Me.lblTransTitle.Size = New System.Drawing.Size(206, 28)
        Me.lblTransTitle.TabIndex = 1
        Me.lblTransTitle.Text = "Transactions (Today)"
        '
        'pnlPenPay
        '
        Me.pnlPenPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlPenPay.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlPenPay.BorderRadius = 12
        Me.pnlPenPay.BorderThickness = 1
        Me.pnlPenPay.Controls.Add(Me.lblPenPayNum)
        Me.pnlPenPay.Controls.Add(Me.lblPayTItle)
        Me.pnlPenPay.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlPenPay.Location = New System.Drawing.Point(663, 14)
        Me.pnlPenPay.Name = "pnlPenPay"
        Me.pnlPenPay.Size = New System.Drawing.Size(297, 79)
        Me.pnlPenPay.TabIndex = 2
        '
        'lblPenPayNum
        '
        Me.lblPenPayNum.AutoSize = True
        Me.lblPenPayNum.BackColor = System.Drawing.Color.Transparent
        Me.lblPenPayNum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenPayNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPenPayNum.Location = New System.Drawing.Point(17, 11)
        Me.lblPenPayNum.Name = "lblPenPayNum"
        Me.lblPenPayNum.Size = New System.Drawing.Size(24, 28)
        Me.lblPenPayNum.TabIndex = 0
        Me.lblPenPayNum.Text = "3"
        '
        'lblPayTItle
        '
        Me.lblPayTItle.AutoSize = True
        Me.lblPayTItle.BackColor = System.Drawing.Color.Transparent
        Me.lblPayTItle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayTItle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPayTItle.Location = New System.Drawing.Point(17, 39)
        Me.lblPayTItle.Name = "lblPayTItle"
        Me.lblPayTItle.Size = New System.Drawing.Size(186, 28)
        Me.lblPayTItle.TabIndex = 1
        Me.lblPayTItle.Text = "Pending Payments"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1341, 63)
        Me.pnlHeader.TabIndex = 5
        '
        'dgvTrans
        '
        Me.dgvTrans.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrans.Location = New System.Drawing.Point(0, 234)
        Me.dgvTrans.Name = "dgvTrans"
        Me.dgvTrans.RowHeadersWidth = 51
        Me.dgvTrans.RowTemplate.Height = 24
        Me.dgvTrans.Size = New System.Drawing.Size(1341, 487)
        Me.dgvTrans.TabIndex = 8
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderRadius = 8
        Me.dtpFrom.Checked = True
        Me.dtpFrom.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFrom.ForeColor = System.Drawing.Color.White
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFrom.Location = New System.Drawing.Point(18, 9)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(206, 43)
        Me.dtpFrom.TabIndex = 5
        Me.dtpFrom.Value = New Date(2026, 4, 16, 12, 13, 57, 24)
        '
        'dtpTo
        '
        Me.dtpTo.BorderRadius = 8
        Me.dtpTo.Checked = True
        Me.dtpTo.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTo.ForeColor = System.Drawing.Color.White
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTo.Location = New System.Drawing.Point(235, 9)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(206, 43)
        Me.dtpTo.TabIndex = 6
        Me.dtpTo.Value = New Date(2026, 4, 16, 12, 13, 57, 40)
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboStatus.BorderRadius = 8
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboStatus.ForeColor = System.Drawing.Color.White
        Me.cboStatus.ItemHeight = 30
        Me.cboStatus.Items.AddRange(New Object() {"All Statuses", "Paid", "Pending", "Cancelled"})
        Me.cboStatus.Location = New System.Drawing.Point(456, 10)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(159, 36)
        Me.cboStatus.TabIndex = 7
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(17, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(292, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "💳  Transactions & Billing"
        '
        'frmTransactions
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 721)
        Me.Controls.Add(Me.dgvTrans)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransactions"
        Me.Text = "frmTransactions"
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTotalRev.ResumeLayout(False)
        Me.pnlTotalRev.PerformLayout()
        Me.pnlTotalTrans.ResumeLayout(False)
        Me.pnlTotalTrans.PerformLayout()
        Me.pnlPenPay.ResumeLayout(False)
        Me.pnlPenPay.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlFilter As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlTop As Panel
    Private WithEvents pnlTotalRev As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblMoney As Label
    Private WithEvents lblTitleRev As Label
    Private WithEvents pnlTotalTrans As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblTransNum As Label
    Private WithEvents lblTransTitle As Label
    Private WithEvents pnlPenPay As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblPenPayNum As Label
    Private WithEvents lblPayTItle As Label
    Private WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvTrans As DataGridView
    Private WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents cboStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents lblTitle As Label
End Class
