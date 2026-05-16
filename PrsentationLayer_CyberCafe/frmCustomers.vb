Imports BusinessLayer_CyberCafe
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms
Imports PrsentationLayer_CyberCafe.PresentationLayer_CyberCafe

Public Class frmCustomers

    Private _SelectedCustomerID As Integer = -1

    Private Sub btnCancelCustomer_Click(sender As Object, e As EventArgs) Handles btnCancelCustomer.Click
        pnlCustomerDetail.Visible = False
    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        ClearInputs()
        pnlCustomerDetail.Visible = True
    End Sub

    Private Sub RefreshCustomerDgv()

        dgvCustomers.DataSource = CustomerServices.GetAllCustomers()
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
                UIHelper.ShowGunaMessage("Failed to save data.", "Error", MessageDialogIcon.Error)
            End If
        Catch ex As Exception
            UIHelper.ShowGunaMessage(ex.Message, "Error", MessageDialogIcon.Error)
        End Try
    End Sub

    Private Function FillInputsToDTO() As CustomerDTO

        Return New CustomerDTO With {
        .UserID = _SelectedCustomerID,
        .Name = txtName.Text.Trim(),
        .Username = txtUserName.Text.Trim(),
        .Password = txtPassword.Text,
        .Phone = txtPhone.Text.Trim(),
        .Email = txtEmail.Text.Trim(),
        .CreatedAt = DateTime.Now,
        .CreatedByAdminID = LoggedInUser.CurrentUser?.UserID
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

        UIHelper.ShowGunaMessage("Data saved successfully!", "Success", MessageDialogIcon.Information)

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
            dt.DefaultView.RowFilter = String.Format("FullName LIKE '%{0}%' OR Phone LIKE '%{0}%' OR Username LIKE '%{0}%'", txtSearch.Text)
        End If

    End Sub
    Private Function IsValid() As Boolean

        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(txtUserName.Text) Then

            UIHelper.ShowGunaMessage("Please fill in required fields.", "Validation Error", MessageDialogIcon.Warning)
            Return False

        End If

        Return True
    End Function



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
            UIHelper.ShowGunaMessage("Customer not found.", "Error", MessageDialogIcon.Error)
            pnlCustomerDetail.Visible = False

        End If

    End Sub


    Private Sub tsUpdateCustomer_Click(sender As Object, e As EventArgs) Handles tsUpdateCustomer.Click

        If dgvCustomers.CurrentRow IsNot Nothing Then

            _SelectedCustomerID = CInt(dgvCustomers.CurrentRow.Cells("UserID").Value)
            pnlCustomerDetail.Visible = True
            LoadCustomerData()
            btnSaveCustomer.Text = "Update"

        End If

    End Sub

    Private Sub tsShowDetails_Click(sender As Object, e As EventArgs) Handles tsShowDetails.Click

        If dgvCustomers.CurrentRow IsNot Nothing Then

            Dim customerID As Integer = CInt(dgvCustomers.CurrentRow.Cells("UserID").Value)

            Using frm As New frmShowCustomerDetails(customerID)
                frm.ShowDialog()
            End Using

        End If

    End Sub



    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating



        If txtEmail.Text.Trim() = "" Then
            Return
        End If

        If Not ValidationHelper.ValidateEmail(txtEmail.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(txtEmail, "Invalid Email Address Format!")
        Else
            ErrorProvider1.SetError(txtEmail, "")
        End If

    End Sub
    Private Sub txtPhone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPhone.Validating



        If txtPhone.Text.Trim() = "" Then
            Return
        End If

        ' validate phone (as number)
        If Not ValidationHelper.IsNumber(txtPhone.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(txtPhone, "Invalid Phone Number!")
        Else
            ErrorProvider1.SetError(txtPhone, "")
        End If

    End Sub

    Private Sub tsAddCredit_Click(sender As Object, e As EventArgs) Handles tsAddCredit.Click

        If dgvCustomers.CurrentRow IsNot Nothing Then

            Dim customerID As Integer = CInt(dgvCustomers.CurrentRow.Cells("UserID").Value)

            Using frm As New frmAddDeductCustomerCredit(customerID, frmAddDeductCustomerCredit.enMode.Add)
                frm.ShowDialog()
            End Using

            LoadCustomerData()

        End If

    End Sub

    Private Sub tsDeductCredit_Click(sender As Object, e As EventArgs) Handles tsDeductCredit.Click

        If dgvCustomers.CurrentRow IsNot Nothing Then

            Dim customerID As Integer = CInt(dgvCustomers.CurrentRow.Cells("UserID").Value)

            Using frm As New frmAddDeductCustomerCredit(customerID, frmAddDeductCustomerCredit.enMode.Deduct)
                frm.ShowDialog()
            End Using

            LoadCustomerData()

        End If

    End Sub

    Private Sub cmsCustomer_Opening(
    sender As Object,
    e As System.ComponentModel.CancelEventArgs
) Handles cmsCustomer.Opening

        If dgvCustomers.SelectedRows.Count = 0 Then

            e.Cancel = True

            Return

        End If

        Dim selectedRow As DataGridViewRow =
        dgvCustomers.SelectedRows(0)

        Dim credit As Decimal = 0

        Decimal.TryParse(
        selectedRow.Cells("Credit").Value.ToString(),
        credit
    )

        tsDeductCredit.Visible = credit > 0

    End Sub

End Class