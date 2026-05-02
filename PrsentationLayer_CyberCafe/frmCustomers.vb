Imports BusinessLayer_CyberCafe
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms

Public Class frmCustomers

    Private _SelectedCustomerID As Integer = -1


    Private Sub btnCancelCustomer_Click(sender As Object, e As EventArgs) Handles btnCancelCustomer.Click
        pnlCustomerDetail.Visible = False
    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        ClearInputs()
        pnlCustomerDetail.Visible = True
    End Sub


    Private Function GetDummyCustomers() As DataTable
        Dim dt As New DataTable()

        ' تعريف الأعمدة بنفس أسماء أعمدة قاعدة البيانات عندك
        dt.Columns.Add("CustomerID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("Password", GetType(String))
        dt.Columns.Add("Phone", GetType(String))

        ' إضافة أسطر وهمية
        dt.Rows.Add(1, "أحمد محمد", "ahmed99", "123", "0791234567")
        dt.Rows.Add(2, "سارة علي", "sara_pro", "pass", "0787654321")
        dt.Rows.Add(3, "عمر خالد", "omar_gamer", "omar", "0770001122")
        dt.Rows.Add(4, "ليان محمود", "layan_cafe", "123", "0795554433")
        dt.Rows.Add(5, "زيد حسن", "zeid_king", "king", "0781112233")

        Return dt
    End Function

    Private Sub RefreshCustomerDgv()

        dgvCustomers.DataSource = GetDummyCustomers() 'CustomerServices.GetAllCustomers()
    End Sub
    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCustomerDgv()
    End Sub

    Private Sub btnAddCustomer_DoubleClick(sender As Object, e As EventArgs) Handles btnAddCustomer.DoubleClick
        pnlCustomerDetail.Visible = Not pnlCustomerDetail.Visible
    End Sub
    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click

        If Not IsValid() Then
            Exit Sub
        End If

        Dim customerDTO = FillInputsToDTO()

        Try
            If SaveCustomer(customerDTO) Then
                HandleSuccess()
            Else
                _ShowGunaMessage("Failed to save data.", "Error", MessageDialogIcon.Error)
            End If
        Catch ex As Exception
            _ShowGunaMessage(ex.Message, "Error", MessageDialogIcon.Error)
        End Try
    End Sub

    Private Function FillInputsToDTO() As CustomerDTO
        Return New CustomerDTO With {
        .UserID = _SelectedCustomerID,
        .Name = txtName.Text.Trim(),
        .Username = txtUserName.Text.Trim(),
        .Password = txtPassword.Text,
        .Phone = txtPhone.Text.Trim(),
        .Email = txtEmail.Text.Trim()
    }
    End Function

    Private Function SaveCustomer(dto As CustomerDTO) As Boolean

        If _SelectedCustomerID = -1 Then
            Return CustomerServices.AddCustomer(dto)
        Else
            Return CustomerServices.UpdateCustomer(dto)
        End If

    End Function

    Private Sub HandleSuccess()
        _ShowGunaMessage("Data saved successfully!", "Success", MessageDialogIcon.Information)
        RefreshCustomerDgv()
        ResetUIState()
    End Sub

    Private Sub ResetUIState()
        ClearInputs()
        _SelectedCustomerID = -1
        pnlCustomerDetail.Visible = False
        btnSaveCustomer.Text = "Save"
    End Sub
    Private Sub ClearInputs()
        txtName.Clear()
        txtUserName.Clear()
        txtPassword.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim dt As DataTable = DirectCast(dgvCustomers.DataSource, DataTable)

        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter = String.Format("Name LIKE '%{0}%' OR Phone LIKE '%{0}%' OR Username LIKE '%{0}%'", txtSearch.Text)
        End If

    End Sub
    Private Function IsValid() As Boolean

        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(txtUserName.Text) Then

            _ShowGunaMessage("Please fill in required fields (Name & Username).", "Validation Error", MessageDialogIcon.Warning)
            Return False

        End If

        Return True
    End Function


    Private Sub _ShowGunaMessage(message As String, caption As String, icon As MessageDialogIcon)

        Dim guna As New Guna2MessageDialog With {
            .Caption = caption,
            .Text = message,
            .Parent = System.Windows.Forms.Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = icon,
            .Buttons = MessageDialogButtons.OK
        }
        guna.Show()

    End Sub

    Private Sub LoadCustomerData()

        If _SelectedCustomerID = -1 Then
            Return
        End If

        Dim customer = CustomerServices.Find(_SelectedCustomerID)

        If customer IsNot Nothing Then
            txtName.Text = customer.Name
            txtUserName.Text = customer.Username
            txtPhone.Text = customer.Phone
            txtEmail.Text = customer.Email

        Else
            _ShowGunaMessage("Customer not found.", "Error", MessageDialogIcon.Error)
            pnlCustomerDetail.Visible = False

        End If

    End Sub


    Private Sub tsUpdateCustomer_Click(sender As Object, e As EventArgs) Handles tsUpdateCustomer.Click

        If dgvCustomers.CurrentRow IsNot Nothing Then
            _SelectedCustomerID = CInt(dgvCustomers.CurrentRow.Cells("CustomerID").Value)
            pnlCustomerDetail.Visible = True
            LoadCustomerData()
            btnSaveCustomer.Text = "Update"
        End If

    End Sub

    Private Sub tsShowDetails_Click(sender As Object, e As EventArgs) Handles tsShowDetails.Click

        If dgvCustomers.CurrentRow IsNot Nothing Then
            Dim customerID As Integer = CInt(dgvCustomers.CurrentRow.Cells("CustomerID").Value)
            Dim frm As New frmShowCustomerDetails(customerID)
            frm.ShowDialog()
        End If

    End Sub

End Class