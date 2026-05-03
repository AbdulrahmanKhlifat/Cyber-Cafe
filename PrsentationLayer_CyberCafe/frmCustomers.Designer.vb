<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomers
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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFilter = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlCustomerDetail = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDetailTitle = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtUserName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSaveCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvCustomers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmsCustomer = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.tsShowDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsUpdateCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlCustomerDetail.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCustomer.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnAddCustomer)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 48)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1341, 56)
        Me.pnlHeader.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(17, 15)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(292, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🧑  Customers Management"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCustomer.BorderRadius = 8
        Me.btnAddCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.White
        Me.btnAddCustomer.Location = New System.Drawing.Point(1159, 13)
        Me.btnAddCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(165, 33)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "+  Add Customer"
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1341, 48)
        Me.pnlFilter.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(17, 7)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "🔍  Search by name, phone or email..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(308, 35)
        Me.txtSearch.TabIndex = 0
        '
        'pnlCustomerDetail
        '
        Me.pnlCustomerDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCustomerDetail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlCustomerDetail.BorderThickness = 1
        Me.pnlCustomerDetail.Controls.Add(Me.Label1)
        Me.pnlCustomerDetail.Controls.Add(Me.txtEmail)
        Me.pnlCustomerDetail.Controls.Add(Me.lblPassword)
        Me.pnlCustomerDetail.Controls.Add(Me.txtPassword)
        Me.pnlCustomerDetail.Controls.Add(Me.lblDetailTitle)
        Me.pnlCustomerDetail.Controls.Add(Me.pnlDivider)
        Me.pnlCustomerDetail.Controls.Add(Me.lblFirstName)
        Me.pnlCustomerDetail.Controls.Add(Me.txtName)
        Me.pnlCustomerDetail.Controls.Add(Me.lblLastName)
        Me.pnlCustomerDetail.Controls.Add(Me.txtUserName)
        Me.pnlCustomerDetail.Controls.Add(Me.lblPhone)
        Me.pnlCustomerDetail.Controls.Add(Me.txtPhone)
        Me.pnlCustomerDetail.Controls.Add(Me.btnSaveCustomer)
        Me.pnlCustomerDetail.Controls.Add(Me.btnDeleteCustomer)
        Me.pnlCustomerDetail.Controls.Add(Me.btnCancelCustomer)
        Me.pnlCustomerDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlCustomerDetail.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCustomerDetail.Location = New System.Drawing.Point(1015, 104)
        Me.pnlCustomerDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCustomerDetail.Name = "pnlCustomerDetail"
        Me.pnlCustomerDetail.Size = New System.Drawing.Size(326, 611)
        Me.pnlCustomerDetail.TabIndex = 2
        Me.pnlCustomerDetail.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 314)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtEmail.BorderRadius = 8
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(15, 332)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(294, 35)
        Me.txtEmail.TabIndex = 11
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(13, 178)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(172, 15)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPassword.BorderRadius = 8
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(13, 196)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(294, 35)
        Me.txtPassword.TabIndex = 9
        '
        'lblDetailTitle
        '
        Me.lblDetailTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDetailTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblDetailTitle.Location = New System.Drawing.Point(13, 13)
        Me.lblDetailTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetailTitle.Name = "lblDetailTitle"
        Me.lblDetailTitle.Size = New System.Drawing.Size(300, 26)
        Me.lblDetailTitle.TabIndex = 0
        Me.lblDetailTitle.Text = "Customer Details"
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDivider.Location = New System.Drawing.Point(0, 46)
        Me.pnlDivider.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(326, 1)
        Me.pnlDivider.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(13, 56)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(172, 15)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtName.BorderRadius = 8
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(13, 75)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(294, 35)
        Me.txtName.TabIndex = 0
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(13, 118)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(172, 15)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Username"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUserName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtUserName.BorderRadius = 8
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.DefaultText = ""
        Me.txtUserName.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtUserName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtUserName.Location = New System.Drawing.Point(13, 136)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PlaceholderText = ""
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.Size = New System.Drawing.Size(294, 35)
        Me.txtUserName.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(14, 240)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(172, 15)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPhone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPhone.BorderRadius = 8
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.DefaultText = ""
        Me.txtPhone.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(14, 258)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PlaceholderText = ""
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.Size = New System.Drawing.Size(294, 35)
        Me.txtPhone.TabIndex = 2
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSaveCustomer.BorderRadius = 8
        Me.btnSaveCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSaveCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveCustomer.ForeColor = System.Drawing.Color.White
        Me.btnSaveCustomer.Location = New System.Drawing.Point(15, 401)
        Me.btnSaveCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(300, 37)
        Me.btnSaveCustomer.TabIndex = 6
        Me.btnSaveCustomer.Text = "Save Changes"
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteCustomer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDeleteCustomer.BorderRadius = 8
        Me.btnDeleteCustomer.FillColor = System.Drawing.Color.DimGray
        Me.btnDeleteCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDeleteCustomer.ForeColor = System.Drawing.Color.White
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(15, 450)
        Me.btnDeleteCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(142, 35)
        Me.btnDeleteCustomer.TabIndex = 7
        Me.btnDeleteCustomer.Text = "Clear"
        '
        'btnCancelCustomer
        '
        Me.btnCancelCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancelCustomer.BorderRadius = 8
        Me.btnCancelCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancelCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancelCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnCancelCustomer.Location = New System.Drawing.Point(172, 450)
        Me.btnCancelCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelCustomer.Name = "btnCancelCustomer"
        Me.btnCancelCustomer.Size = New System.Drawing.Size(142, 35)
        Me.btnCancelCustomer.TabIndex = 8
        Me.btnCancelCustomer.Text = "Cancel"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.dgvCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomers.ColumnHeadersHeight = 45
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCustomers.ContextMenuStrip = Me.cmsCustomer
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dgvCustomers.Location = New System.Drawing.Point(0, 104)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowTemplate.Height = 45
        Me.dgvCustomers.Size = New System.Drawing.Size(1015, 611)
        Me.dgvCustomers.TabIndex = 5
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCustomers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCustomers.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvCustomers.ThemeStyle.ReadOnly = True
        Me.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCustomers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.RowsStyle.Height = 45
        Me.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmsCustomer
        '
        Me.cmsCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmsCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.cmsCustomer.ForeColor = System.Drawing.Color.White
        Me.cmsCustomer.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsShowDetails, Me.tsUpdateCustomer})
        Me.cmsCustomer.Name = "DeviceContextMenu"
        Me.cmsCustomer.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.cmsCustomer.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmsCustomer.RenderStyle.ColorTable = Nothing
        Me.cmsCustomer.RenderStyle.RoundedEdges = True
        Me.cmsCustomer.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmsCustomer.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.cmsCustomer.RenderStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.cmsCustomer.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.cmsCustomer.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Me.cmsCustomer.Size = New System.Drawing.Size(217, 56)
        '
        'tsShowDetails
        '
        Me.tsShowDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsShowDetails.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.info_40dp_E3E3E3_FILL0_wght400_GRAD0_opsz40
        Me.tsShowDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsShowDetails.Name = "tsShowDetails"
        Me.tsShowDetails.Size = New System.Drawing.Size(216, 26)
        Me.tsShowDetails.Text = "Show Details"
        '
        'tsUpdateCustomer
        '
        Me.tsUpdateCustomer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdateCustomer.Image = Global.PrsentationLayer_CyberCafe.My.Resources.Resources.edit_user
        Me.tsUpdateCustomer.Name = "tsUpdateCustomer"
        Me.tsUpdateCustomer.Size = New System.Drawing.Size(216, 26)
        Me.tsUpdateCustomer.Text = "Update Customer"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 715)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.pnlCustomerDetail)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFilter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCustomers"
        Me.Text = "frmCustomers"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlCustomerDetail.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCustomer.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblTitle As Label
    Private WithEvents btnAddCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlFilter As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents pnlCustomerDetail As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblDetailTitle As Label
    Private WithEvents pnlDivider As Panel
    Private WithEvents lblFirstName As Label
    Private WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblLastName As Label
    Private WithEvents txtUserName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblPhone As Label
    Private WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnSaveCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnDeleteCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnCancelCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents lblPassword As Label
    Private WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvCustomers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmsCustomer As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents tsShowDetails As ToolStripMenuItem
    Friend WithEvents tsUpdateCustomer As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
