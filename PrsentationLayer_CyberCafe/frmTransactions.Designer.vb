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
        Me.dgvTrans = New System.Windows.Forms.DataGridView()
        Me.pnlDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtAdmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransactionType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoidTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTotal = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblServiceCharge = New System.Windows.Forms.Label()
        Me.txtCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblDetailsTitle = New System.Windows.Forms.Label()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblTransTitle = New System.Windows.Forms.Label()
        Me.lblTransNum = New System.Windows.Forms.Label()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ScrollBar = New Guna.UI2.WinForms.Guna2VScrollBar()
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTrans
        '
        Me.dgvTrans.AllowUserToAddRows = False
        Me.dgvTrans.AllowUserToDeleteRows = False
        Me.dgvTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTrans.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrans.Location = New System.Drawing.Point(0, 266)
        Me.dgvTrans.Name = "dgvTrans"
        Me.dgvTrans.ReadOnly = True
        Me.dgvTrans.RowHeadersWidth = 51
        Me.dgvTrans.RowTemplate.Height = 24
        Me.dgvTrans.Size = New System.Drawing.Size(1003, 428)
        Me.dgvTrans.TabIndex = 8
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlDetails.Controls.Add(Me.txtAdmin)
        Me.pnlDetails.Controls.Add(Me.Label2)
        Me.pnlDetails.Controls.Add(Me.txtTransactionType)
        Me.pnlDetails.Controls.Add(Me.Label1)
        Me.pnlDetails.Controls.Add(Me.btnVoidTransaction)
        Me.pnlDetails.Controls.Add(Me.pnlTotal)
        Me.pnlDetails.Controls.Add(Me.txtAmount)
        Me.pnlDetails.Controls.Add(Me.lblServiceCharge)
        Me.pnlDetails.Controls.Add(Me.txtCustomerName)
        Me.pnlDetails.Controls.Add(Me.lblCustomerName)
        Me.pnlDetails.Controls.Add(Me.lblDetailsTitle)
        Me.pnlDetails.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlDetails.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlDetails.Location = New System.Drawing.Point(1003, 266)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(338, 428)
        Me.pnlDetails.TabIndex = 9
        '
        'txtAdmin
        '
        Me.txtAdmin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtAdmin.BorderRadius = 4
        Me.txtAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdmin.DefaultText = "Admin Name"
        Me.txtAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdmin.ForeColor = System.Drawing.Color.White
        Me.txtAdmin.Location = New System.Drawing.Point(151, 128)
        Me.txtAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.PlaceholderText = ""
        Me.txtAdmin.ReadOnly = True
        Me.txtAdmin.SelectedText = ""
        Me.txtAdmin.Size = New System.Drawing.Size(175, 30)
        Me.txtAdmin.TabIndex = 22
        Me.txtAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(14, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Processed By Admin:"
        '
        'txtTransactionType
        '
        Me.txtTransactionType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtTransactionType.BorderRadius = 4
        Me.txtTransactionType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransactionType.DefaultText = "Session Start"
        Me.txtTransactionType.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtTransactionType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTransactionType.ForeColor = System.Drawing.Color.White
        Me.txtTransactionType.Location = New System.Drawing.Point(151, 243)
        Me.txtTransactionType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTransactionType.Name = "txtTransactionType"
        Me.txtTransactionType.PlaceholderText = ""
        Me.txtTransactionType.ReadOnly = True
        Me.txtTransactionType.SelectedText = ""
        Me.txtTransactionType.Size = New System.Drawing.Size(175, 30)
        Me.txtTransactionType.TabIndex = 20
        Me.txtTransactionType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(12, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Transaction Type:"
        '
        'btnVoidTransaction
        '
        Me.btnVoidTransaction.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnVoidTransaction.BorderRadius = 5
        Me.btnVoidTransaction.BorderThickness = 1
        Me.btnVoidTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoidTransaction.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnVoidTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVoidTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnVoidTransaction.Location = New System.Drawing.Point(17, 363)
        Me.btnVoidTransaction.Name = "btnVoidTransaction"
        Me.btnVoidTransaction.Size = New System.Drawing.Size(300, 35)
        Me.btnVoidTransaction.TabIndex = 18
        Me.btnVoidTransaction.Text = "Void Transaction"
        '
        'pnlTotal
        '
        Me.pnlTotal.BorderRadius = 4
        Me.pnlTotal.Controls.Add(Me.lblTotal)
        Me.pnlTotal.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlTotal.Location = New System.Drawing.Point(17, 294)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(300, 45)
        Me.pnlTotal.TabIndex = 15
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(0, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(300, 45)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Transaction Reference ID: ??"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmount
        '
        Me.txtAmount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtAmount.BorderRadius = 4
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = "$25.00"
        Me.txtAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAmount.ForeColor = System.Drawing.Color.White
        Me.txtAmount.Location = New System.Drawing.Point(151, 184)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderText = ""
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.Size = New System.Drawing.Size(175, 30)
        Me.txtAmount.TabIndex = 10
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblServiceCharge
        '
        Me.lblServiceCharge.AutoSize = True
        Me.lblServiceCharge.BackColor = System.Drawing.Color.Transparent
        Me.lblServiceCharge.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharge.ForeColor = System.Drawing.Color.LightGray
        Me.lblServiceCharge.Location = New System.Drawing.Point(12, 189)
        Me.lblServiceCharge.Name = "lblServiceCharge"
        Me.lblServiceCharge.Size = New System.Drawing.Size(98, 17)
        Me.lblServiceCharge.TabIndex = 9
        Me.lblServiceCharge.Text = "Service Charge:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtCustomerName.BorderRadius = 4
        Me.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerName.DefaultText = "Customer Name"
        Me.txtCustomerName.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomerName.ForeColor = System.Drawing.Color.White
        Me.txtCustomerName.Location = New System.Drawing.Point(151, 62)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.PlaceholderText = ""
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.SelectedText = ""
        Me.txtCustomerName.Size = New System.Drawing.Size(175, 30)
        Me.txtCustomerName.TabIndex = 4
        Me.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomerName.Location = New System.Drawing.Point(14, 68)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(106, 17)
        Me.lblCustomerName.TabIndex = 3
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'lblDetailsTitle
        '
        Me.lblDetailsTitle.AutoSize = True
        Me.lblDetailsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDetailsTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetailsTitle.ForeColor = System.Drawing.Color.White
        Me.lblDetailsTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblDetailsTitle.Name = "lblDetailsTitle"
        Me.lblDetailsTitle.Size = New System.Drawing.Size(192, 21)
        Me.lblDetailsTitle.TabIndex = 0
        Me.lblDetailsTitle.Text = "TRANSACTION DETAILS:"
        '
        'dtpTo
        '
        Me.dtpTo.BorderRadius = 8
        Me.dtpTo.Checked = True
        Me.dtpTo.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTo.ForeColor = System.Drawing.Color.White
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTo.Location = New System.Drawing.Point(422, 24)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(206, 43)
        Me.dtpTo.TabIndex = 6
        Me.dtpTo.Value = New Date(2026, 4, 16, 12, 13, 57, 40)
        '
        'lblTransTitle
        '
        Me.lblTransTitle.AutoSize = True
        Me.lblTransTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTransTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblTransTitle.Location = New System.Drawing.Point(84, 10)
        Me.lblTransTitle.Name = "lblTransTitle"
        Me.lblTransTitle.Size = New System.Drawing.Size(204, 30)
        Me.lblTransTitle.TabIndex = 1
        Me.lblTransTitle.Text = "Transactions Today:"
        '
        'lblTransNum
        '
        Me.lblTransNum.AutoSize = True
        Me.lblTransNum.BackColor = System.Drawing.Color.Transparent
        Me.lblTransNum.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTransNum.Location = New System.Drawing.Point(84, 44)
        Me.lblTransNum.Name = "lblTransNum"
        Me.lblTransNum.Size = New System.Drawing.Size(56, 45)
        Me.lblTransNum.TabIndex = 0
        Me.lblTransNum.Text = "42"
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderRadius = 8
        Me.dtpFrom.Checked = True
        Me.dtpFrom.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFrom.ForeColor = System.Drawing.Color.White
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFrom.Location = New System.Drawing.Point(698, 24)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(206, 43)
        Me.dtpFrom.TabIndex = 5
        Me.dtpFrom.Value = New Date(2026, 4, 16, 12, 13, 57, 24)
        '
        'cmb
        '
        Me.cmb.BackColor = System.Drawing.Color.Transparent
        Me.cmb.BorderRadius = 8
        Me.cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmb.FocusedColor = System.Drawing.Color.Empty
        Me.cmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb.ForeColor = System.Drawing.Color.White
        Me.cmb.ItemHeight = 30
        Me.cmb.Items.AddRange(New Object() {"All Types", "AddCredit", "SessionStart", "SessionSnackPurchase", "WalkInPurchase"})
        Me.cmb.Location = New System.Drawing.Point(155, 29)
        Me.cmb.Name = "cmb"
        Me.cmb.Size = New System.Drawing.Size(159, 36)
        Me.cmb.StartIndex = 0
        Me.cmb.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(341, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(13, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Filter By Type:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblMoney.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblMoney.Location = New System.Drawing.Point(116, 42)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(164, 45)
        Me.lblMoney.TabIndex = 0
        Me.lblMoney.Text = "$1,245.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(649, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To:"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.Label5)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.cmb)
        Me.pnlTop.Controls.Add(Me.dtpFrom)
        Me.pnlTop.Controls.Add(Me.dtpTo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 164)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1341, 102)
        Me.pnlTop.TabIndex = 6
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1341, 164)
        Me.Guna2Panel1.TabIndex = 10
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Guna2CustomGradientPanel2.BorderRadius = 12
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label7)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lblMoney)
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(17, 48)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(636, 98)
        Me.Guna2CustomGradientPanel2.TabIndex = 12
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.money_bills_solid
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(30, 25)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(61, 49)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 3
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(107, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 30)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Revenue Today:"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Guna2CustomGradientPanel1.BorderRadius = 12
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblTransNum)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblTransTitle)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(686, 48)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(643, 98)
        Me.Guna2CustomGradientPanel1.TabIndex = 11
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.list_solid
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(17, 25)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(61, 49)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Daily Business Summary:"
        '
        'ScrollBar
        '
        Me.ScrollBar.BindingContainer = Me.dgvTrans
        Me.ScrollBar.BorderRadius = 10
        Me.ScrollBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ScrollBar.HighlightOnWheel = True
        Me.ScrollBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ScrollBar.InUpdate = False
        Me.ScrollBar.LargeChange = 528
        Me.ScrollBar.Location = New System.Drawing.Point(984, 267)
        Me.ScrollBar.Margin = New System.Windows.Forms.Padding(1)
        Me.ScrollBar.Maximum = 566
        Me.ScrollBar.Minimum = 1
        Me.ScrollBar.Name = "ScrollBar"
        Me.ScrollBar.ScrollbarSize = 18
        Me.ScrollBar.Size = New System.Drawing.Size(18, 426)
        Me.ScrollBar.TabIndex = 11
        Me.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset
        Me.ScrollBar.Value = 1
        '
        'frmTransactions
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 694)
        Me.Controls.Add(Me.ScrollBar)
        Me.Controls.Add(Me.dgvTrans)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransactions"
        Me.Text = "frmTransactions"
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvTrans As DataGridView
    Friend WithEvents pnlDetails As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblServiceCharge As Label
    Friend WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnlTotal As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnVoidTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDetailsTitle As Label
    Friend WithEvents txtTransactionType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAdmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents lblTransNum As Label
    Private WithEvents lblTransTitle As Label
    Private WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents cmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents lblMoney As Label
    Friend WithEvents Label5 As Label
    Private WithEvents pnlTop As Panel
    Private WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents Label6 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents Label7 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ScrollBar As Guna.UI2.WinForms.Guna2VScrollBar
End Class