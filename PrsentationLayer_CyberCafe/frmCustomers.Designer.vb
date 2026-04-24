<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFilter = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvCustomers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlCustomerDetail = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDetailTitle = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSaveCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomerDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.dgvCustomers)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnAddCustomer)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 59)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1393, 69)
        Me.pnlHeader.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(23, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(389, 32)
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
        Me.btnAddCustomer.Location = New System.Drawing.Point(1188, 16)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(183, 41)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "+  Add Customer"
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Controls.Add(Me.btnSearch)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1393, 59)
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
        Me.txtSearch.Location = New System.Drawing.Point(23, 9)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "🔍  Search by name, phone or email..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(411, 43)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 8
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(446, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 43)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgvCustomers.ColumnHeadersHeight = 42
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle30
        Me.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvCustomers.Location = New System.Drawing.Point(4, 74)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowHeadersWidth = 51
        Me.dgvCustomers.RowTemplate.Height = 40
        Me.dgvCustomers.Size = New System.Drawing.Size(1371, 518)
        Me.dgvCustomers.TabIndex = 1
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCustomers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomers.ThemeStyle.HeaderStyle.Height = 42
        Me.dgvCustomers.ThemeStyle.ReadOnly = True
        Me.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCustomers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.RowsStyle.Height = 40
        Me.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'pnlCustomerDetail
        '
        Me.pnlCustomerDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCustomerDetail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlCustomerDetail.BorderThickness = 1
        Me.pnlCustomerDetail.Controls.Add(Me.Label1)
        Me.pnlCustomerDetail.Controls.Add(Me.Guna2TextBox1)
        Me.pnlCustomerDetail.Controls.Add(Me.lblDetailTitle)
        Me.pnlCustomerDetail.Controls.Add(Me.pnlDivider)
        Me.pnlCustomerDetail.Controls.Add(Me.lblFirstName)
        Me.pnlCustomerDetail.Controls.Add(Me.txtFirstName)
        Me.pnlCustomerDetail.Controls.Add(Me.lblLastName)
        Me.pnlCustomerDetail.Controls.Add(Me.txtLastName)
        Me.pnlCustomerDetail.Controls.Add(Me.lblPhone)
        Me.pnlCustomerDetail.Controls.Add(Me.txtPhone)
        Me.pnlCustomerDetail.Controls.Add(Me.btnSaveCustomer)
        Me.pnlCustomerDetail.Controls.Add(Me.btnDeleteCustomer)
        Me.pnlCustomerDetail.Controls.Add(Me.btnCancelCustomer)
        Me.pnlCustomerDetail.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCustomerDetail.Location = New System.Drawing.Point(959, 131)
        Me.pnlCustomerDetail.Name = "pnlCustomerDetail"
        Me.pnlCustomerDetail.Size = New System.Drawing.Size(435, 522)
        Me.pnlCustomerDetail.TabIndex = 2
        Me.pnlCustomerDetail.Visible = False
        '
        'lblDetailTitle
        '
        Me.lblDetailTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDetailTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblDetailTitle.Location = New System.Drawing.Point(17, 16)
        Me.lblDetailTitle.Name = "lblDetailTitle"
        Me.lblDetailTitle.Size = New System.Drawing.Size(400, 32)
        Me.lblDetailTitle.TabIndex = 0
        Me.lblDetailTitle.Text = "Customer Details"
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlDivider.Location = New System.Drawing.Point(0, 57)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(434, 1)
        Me.pnlDivider.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(17, 69)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(229, 19)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "NAME"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtFirstName.BorderRadius = 8
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(17, 92)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(400, 43)
        Me.txtFirstName.TabIndex = 0
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(17, 145)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(229, 19)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Username"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtLastName.BorderRadius = 8
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(17, 167)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(400, 43)
        Me.txtLastName.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(18, 295)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(229, 19)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "PHONE"
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
        Me.txtPhone.Location = New System.Drawing.Point(18, 317)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PlaceholderText = ""
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.Size = New System.Drawing.Size(400, 43)
        Me.txtPhone.TabIndex = 2
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSaveCustomer.BorderRadius = 8
        Me.btnSaveCustomer.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSaveCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveCustomer.ForeColor = System.Drawing.Color.White
        Me.btnSaveCustomer.Location = New System.Drawing.Point(17, 397)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(400, 45)
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
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(17, 458)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(190, 43)
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
        Me.btnCancelCustomer.Location = New System.Drawing.Point(227, 458)
        Me.btnCancelCustomer.Name = "btnCancelCustomer"
        Me.btnCancelCustomer.Size = New System.Drawing.Size(190, 43)
        Me.btnCancelCustomer.TabIndex = 8
        Me.btnCancelCustomer.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PASSWORD"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 8
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(17, 241)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(400, 43)
        Me.Guna2TextBox1.TabIndex = 9
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1393, 652)
        Me.Controls.Add(Me.pnlCustomerDetail)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFilter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomers"
        Me.Text = "frmCustomers"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomerDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblTitle As Label
    Private WithEvents btnAddCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlFilter As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Private WithEvents dgvCustomers As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents pnlCustomerDetail As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblDetailTitle As Label
    Private WithEvents pnlDivider As Panel
    Private WithEvents lblFirstName As Label
    Private WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblLastName As Label
    Private WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents lblPhone As Label
    Private WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnSaveCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnDeleteCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnCancelCustomer As Guna.UI2.WinForms.Guna2Button
    Private WithEvents Label1 As Label
    Private WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
