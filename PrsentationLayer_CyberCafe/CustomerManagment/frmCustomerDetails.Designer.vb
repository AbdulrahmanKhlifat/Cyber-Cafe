<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowCustomerDetails
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblUsernameHeader = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.flpStats = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCardCredit = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCreditValue = New System.Windows.Forms.Label()
        Me.lblCreditTitle = New System.Windows.Forms.Label()
        Me.pnlCardHours = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblHoursValue = New System.Windows.Forms.Label()
        Me.lblHoursTitle = New System.Windows.Forms.Label()
        Me.pnlCardJoined = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblJoinedDate = New System.Windows.Forms.Label()
        Me.lblJoinedTitle = New System.Windows.Forms.Label()
        Me.TabControlMain = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tabDetails = New System.Windows.Forms.TabPage()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblPhoneTitle = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblEmailTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserTitle = New System.Windows.Forms.Label()
        Me.lblFullNameValue = New System.Windows.Forms.Label()
        Me.lblFullNameTitle = New System.Windows.Forms.Label()
        Me.tabActivity = New System.Windows.Forms.TabPage()
        Me.dgvRecentSessions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.flpStats.SuspendLayout()
        Me.pnlCardCredit.SuspendLayout()
        Me.pnlCardHours.SuspendLayout()
        Me.pnlCardJoined.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        Me.tabActivity.SuspendLayout()
        CType(Me.dgvRecentSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Transparent
        Me.pnlHeader.Controls.Add(Me.lblCustomerName)
        Me.pnlHeader.Controls.Add(Me.lblUsernameHeader)
        Me.pnlHeader.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(800, 100)
        Me.pnlHeader.TabIndex = 0
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(23, 23)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(155, 25)
        Me.lblCustomerName.TabIndex = 1
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblUsernameHeader
        '
        Me.lblUsernameHeader.AutoSize = True
        Me.lblUsernameHeader.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUsernameHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblUsernameHeader.Location = New System.Drawing.Point(24, 51)
        Me.lblUsernameHeader.Name = "lblUsernameHeader"
        Me.lblUsernameHeader.Size = New System.Drawing.Size(82, 19)
        Me.lblUsernameHeader.TabIndex = 2
        Me.lblUsernameHeader.Text = "@username"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Maroon
        Me.Guna2ControlBox1.BorderRadius = 5
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(759, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(37, 31)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'flpStats
        '
        Me.flpStats.Controls.Add(Me.pnlCardCredit)
        Me.flpStats.Controls.Add(Me.pnlCardHours)
        Me.flpStats.Controls.Add(Me.pnlCardJoined)
        Me.flpStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpStats.Location = New System.Drawing.Point(0, 100)
        Me.flpStats.Name = "flpStats"
        Me.flpStats.Padding = New System.Windows.Forms.Padding(15, 15, 15, 0)
        Me.flpStats.Size = New System.Drawing.Size(800, 115)
        Me.flpStats.TabIndex = 1
        '
        'pnlCardCredit
        '
        Me.pnlCardCredit.BorderRadius = 10
        Me.pnlCardCredit.Controls.Add(Me.lblCreditValue)
        Me.pnlCardCredit.Controls.Add(Me.lblCreditTitle)
        Me.pnlCardCredit.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCardCredit.Location = New System.Drawing.Point(18, 18)
        Me.pnlCardCredit.Name = "pnlCardCredit"
        Me.pnlCardCredit.Size = New System.Drawing.Size(240, 80)
        Me.pnlCardCredit.TabIndex = 0
        '
        'lblCreditValue
        '
        Me.lblCreditValue.AutoSize = True
        Me.lblCreditValue.BackColor = System.Drawing.Color.Transparent
        Me.lblCreditValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblCreditValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblCreditValue.Location = New System.Drawing.Point(15, 35)
        Me.lblCreditValue.Name = "lblCreditValue"
        Me.lblCreditValue.Size = New System.Drawing.Size(71, 30)
        Me.lblCreditValue.TabIndex = 1
        Me.lblCreditValue.Text = "$0.00"
        '
        'lblCreditTitle
        '
        Me.lblCreditTitle.AutoSize = True
        Me.lblCreditTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCreditTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCreditTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblCreditTitle.Location = New System.Drawing.Point(17, 15)
        Me.lblCreditTitle.Name = "lblCreditTitle"
        Me.lblCreditTitle.Size = New System.Drawing.Size(82, 15)
        Me.lblCreditTitle.TabIndex = 0
        Me.lblCreditTitle.Text = "Current Credit"
        '
        'pnlCardHours
        '
        Me.pnlCardHours.BorderRadius = 10
        Me.pnlCardHours.Controls.Add(Me.lblHoursValue)
        Me.pnlCardHours.Controls.Add(Me.lblHoursTitle)
        Me.pnlCardHours.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCardHours.Location = New System.Drawing.Point(264, 18)
        Me.pnlCardHours.Name = "pnlCardHours"
        Me.pnlCardHours.Size = New System.Drawing.Size(240, 80)
        Me.pnlCardHours.TabIndex = 1
        '
        'lblHoursValue
        '
        Me.lblHoursValue.AutoSize = True
        Me.lblHoursValue.BackColor = System.Drawing.Color.Transparent
        Me.lblHoursValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHoursValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblHoursValue.Location = New System.Drawing.Point(15, 35)
        Me.lblHoursValue.Name = "lblHoursValue"
        Me.lblHoursValue.Size = New System.Drawing.Size(68, 30)
        Me.lblHoursValue.TabIndex = 1
        Me.lblHoursValue.Text = "0 Hrs"
        '
        'lblHoursTitle
        '
        Me.lblHoursTitle.AutoSize = True
        Me.lblHoursTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHoursTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHoursTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblHoursTitle.Location = New System.Drawing.Point(17, 15)
        Me.lblHoursTitle.Name = "lblHoursTitle"
        Me.lblHoursTitle.Size = New System.Drawing.Size(68, 15)
        Me.lblHoursTitle.TabIndex = 0
        Me.lblHoursTitle.Text = "Total Hours"
        '
        'pnlCardJoined
        '
        Me.pnlCardJoined.BorderRadius = 10
        Me.pnlCardJoined.Controls.Add(Me.lblJoinedDate)
        Me.pnlCardJoined.Controls.Add(Me.lblJoinedTitle)
        Me.pnlCardJoined.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pnlCardJoined.Location = New System.Drawing.Point(510, 18)
        Me.pnlCardJoined.Name = "pnlCardJoined"
        Me.pnlCardJoined.Size = New System.Drawing.Size(240, 80)
        Me.pnlCardJoined.TabIndex = 2
        '
        'lblJoinedDate
        '
        Me.lblJoinedDate.AutoSize = True
        Me.lblJoinedDate.BackColor = System.Drawing.Color.Transparent
        Me.lblJoinedDate.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblJoinedDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblJoinedDate.Location = New System.Drawing.Point(15, 38)
        Me.lblJoinedDate.Name = "lblJoinedDate"
        Me.lblJoinedDate.Size = New System.Drawing.Size(116, 25)
        Me.lblJoinedDate.TabIndex = 1
        Me.lblJoinedDate.Text = "Jan 01, 2024"
        '
        'lblJoinedTitle
        '
        Me.lblJoinedTitle.AutoSize = True
        Me.lblJoinedTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblJoinedTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblJoinedTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblJoinedTitle.Location = New System.Drawing.Point(17, 15)
        Me.lblJoinedTitle.Name = "lblJoinedTitle"
        Me.lblJoinedTitle.Size = New System.Drawing.Size(83, 15)
        Me.lblJoinedTitle.TabIndex = 0
        Me.lblJoinedTitle.Text = "Member Since"
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.tabDetails)
        Me.TabControlMain.Controls.Add(Me.tabActivity)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControlMain.Location = New System.Drawing.Point(0, 215)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(800, 385)
        Me.TabControlMain.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlMain.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabControlMain.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlMain.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControlMain.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabControlMain.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlMain.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabControlMain.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlMain.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.TabControlMain.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabControlMain.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlMain.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabControlMain.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlMain.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControlMain.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TabControlMain.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabControlMain.TabIndex = 2
        Me.TabControlMain.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TabControlMain.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'tabDetails
        '
        Me.tabDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.tabDetails.Controls.Add(Me.lblPhone)
        Me.tabDetails.Controls.Add(Me.lblPhoneTitle)
        Me.tabDetails.Controls.Add(Me.lblEmail)
        Me.tabDetails.Controls.Add(Me.lblEmailTitle)
        Me.tabDetails.Controls.Add(Me.lblUsername)
        Me.tabDetails.Controls.Add(Me.lblUserTitle)
        Me.tabDetails.Controls.Add(Me.lblFullNameValue)
        Me.tabDetails.Controls.Add(Me.lblFullNameTitle)
        Me.tabDetails.Location = New System.Drawing.Point(4, 44)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Padding = New System.Windows.Forms.Padding(30)
        Me.tabDetails.Size = New System.Drawing.Size(792, 337)
        Me.tabDetails.TabIndex = 0
        Me.tabDetails.Text = "Personal Info"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblPhone.ForeColor = System.Drawing.Color.White
        Me.lblPhone.Location = New System.Drawing.Point(30, 245)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(87, 20)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "0780361967"
        '
        'lblPhoneTitle
        '
        Me.lblPhoneTitle.AutoSize = True
        Me.lblPhoneTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPhoneTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblPhoneTitle.Location = New System.Drawing.Point(30, 220)
        Me.lblPhoneTitle.Name = "lblPhoneTitle"
        Me.lblPhoneTitle.Size = New System.Drawing.Size(102, 19)
        Me.lblPhoneTitle.TabIndex = 6
        Me.lblPhoneTitle.Text = "Phone Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(30, 180)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(156, 20)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "customer@email.com"
        '
        'lblEmailTitle
        '
        Me.lblEmailTitle.AutoSize = True
        Me.lblEmailTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmailTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblEmailTitle.Location = New System.Drawing.Point(30, 155)
        Me.lblEmailTitle.Name = "lblEmailTitle"
        Me.lblEmailTitle.Size = New System.Drawing.Size(94, 19)
        Me.lblEmailTitle.TabIndex = 4
        Me.lblEmailTitle.Text = "Email Address"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(30, 115)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(76, 20)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "username"
        '
        'lblUserTitle
        '
        Me.lblUserTitle.AutoSize = True
        Me.lblUserTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUserTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblUserTitle.Location = New System.Drawing.Point(30, 90)
        Me.lblUserTitle.Name = "lblUserTitle"
        Me.lblUserTitle.Size = New System.Drawing.Size(71, 19)
        Me.lblUserTitle.TabIndex = 2
        Me.lblUserTitle.Text = "Username"
        '
        'lblFullNameValue
        '
        Me.lblFullNameValue.AutoSize = True
        Me.lblFullNameValue.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.lblFullNameValue.ForeColor = System.Drawing.Color.White
        Me.lblFullNameValue.Location = New System.Drawing.Point(30, 50)
        Me.lblFullNameValue.Name = "lblFullNameValue"
        Me.lblFullNameValue.Size = New System.Drawing.Size(83, 20)
        Me.lblFullNameValue.TabIndex = 1
        Me.lblFullNameValue.Text = "Full Name "
        '
        'lblFullNameTitle
        '
        Me.lblFullNameTitle.AutoSize = True
        Me.lblFullNameTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFullNameTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblFullNameTitle.Location = New System.Drawing.Point(30, 25)
        Me.lblFullNameTitle.Name = "lblFullNameTitle"
        Me.lblFullNameTitle.Size = New System.Drawing.Size(70, 19)
        Me.lblFullNameTitle.TabIndex = 0
        Me.lblFullNameTitle.Text = "Full Name"
        '
        'tabActivity
        '
        Me.tabActivity.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.tabActivity.Controls.Add(Me.dgvRecentSessions)
        Me.tabActivity.Location = New System.Drawing.Point(4, 44)
        Me.tabActivity.Name = "tabActivity"
        Me.tabActivity.Padding = New System.Windows.Forms.Padding(15)
        Me.tabActivity.Size = New System.Drawing.Size(792, 337)
        Me.tabActivity.TabIndex = 1
        Me.tabActivity.Text = "Activity Log"
        '
        'dgvRecentSessions
        '
        Me.dgvRecentSessions.AllowUserToAddRows = False
        Me.dgvRecentSessions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvRecentSessions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRecentSessions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentSessions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecentSessions.ColumnHeadersHeight = 35
        Me.dgvRecentSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecentSessions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecentSessions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecentSessions.GridColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvRecentSessions.Location = New System.Drawing.Point(15, 15)
        Me.dgvRecentSessions.Name = "dgvRecentSessions"
        Me.dgvRecentSessions.ReadOnly = True
        Me.dgvRecentSessions.RowHeadersVisible = False
        Me.dgvRecentSessions.Size = New System.Drawing.Size(762, 307)
        Me.dgvRecentSessions.TabIndex = 0
        Me.dgvRecentSessions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvRecentSessions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRecentSessions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRecentSessions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRecentSessions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRecentSessions.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvRecentSessions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvRecentSessions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvRecentSessions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecentSessions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvRecentSessions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecentSessions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRecentSessions.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvRecentSessions.ThemeStyle.ReadOnly = True
        Me.dgvRecentSessions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.dgvRecentSessions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecentSessions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dgvRecentSessions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvRecentSessions.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRecentSessions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.dgvRecentSessions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'frmShowCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.flpStats)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmShowCustomerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Details"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.flpStats.ResumeLayout(False)
        Me.pnlCardCredit.ResumeLayout(False)
        Me.pnlCardCredit.PerformLayout()
        Me.pnlCardHours.ResumeLayout(False)
        Me.pnlCardHours.PerformLayout()
        Me.pnlCardJoined.ResumeLayout(False)
        Me.pnlCardJoined.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.tabDetails.ResumeLayout(False)
        Me.tabDetails.PerformLayout()
        Me.tabActivity.ResumeLayout(False)
        CType(Me.dgvRecentSessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblUsernameHeader As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents flpStats As FlowLayoutPanel
    Friend WithEvents pnlCardCredit As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCreditValue As Label
    Friend WithEvents lblCreditTitle As Label
    Friend WithEvents pnlCardHours As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHoursValue As Label
    Friend WithEvents lblHoursTitle As Label
    Friend WithEvents pnlCardJoined As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblJoinedDate As Label
    Friend WithEvents lblJoinedTitle As Label
    Friend WithEvents TabControlMain As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabDetails As TabPage
    Friend WithEvents tabActivity As TabPage
    Friend WithEvents lblFullNameValue As Label
    Friend WithEvents lblFullNameTitle As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblPhoneTitle As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEmailTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblUserTitle As Label
    Friend WithEvents dgvRecentSessions As Guna.UI2.WinForms.Guna2DataGridView
End Class
