Imports BusinessLayer_CyberCafe

Public Class frmCustomers


    Private Sub btnCancelCustomer_Click(sender As Object, e As EventArgs) Handles btnCancelCustomer.Click
        pnlCustomerDetail.Visible = False
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        pnlCustomerDetail.Visible = True
    End Sub

    Private Sub RefreshCustomerDgv()
        dgvCustomers.DataSource = CustomerServices.GetAllCustomers()
    End Sub
    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCustomerDgv()
    End Sub


End Class