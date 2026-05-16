Imports BusinessLayer_CyberCafe
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms

Public Class frmShowCustomerDetails

    Private _CustomerID As Integer
    Private _Customer As CustomerDTO

    Public Sub New(customerID As Integer)
        InitializeComponent()
        _CustomerID = customerID
    End Sub

    Private Sub frmShowCustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    Private Sub LoadCustomerData()
        Try
            _Customer = CustomerServices.Find(_CustomerID)

            If _Customer IsNot Nothing Then
                DisplayCustomerInfo()
            Else
                UIHelper.ShowGunaMessage("Customer not found.", "Error", MessageDialogIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            UIHelper.ShowGunaMessage("Error loading data: " & ex.Message, "Error", MessageDialogIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub DisplayCustomerInfo()

        lblCustomerName.Text = _Customer.Name
        lblUsernameHeader.Text = "@" & _Customer.Username

        lblCreditValue.Text = String.Format("{0:C}", _Customer.Credit)
        lblHoursValue.Text = _Customer.TotalHoursRes.ToString() & " Hrs"
        lblJoinedDate.Text = _Customer.CreatedAt.ToString("MMM dd, yyyy")
        lblFullNameValue.Text = _Customer.Name
        lblUsername.Text = _Customer.Username
        lblEmail.Text = If(String.IsNullOrEmpty(_Customer.Email), "N/A", _Customer.Email)
        lblPhone.Text = If(String.IsNullOrEmpty(_Customer.Phone), "N/A", _Customer.Phone)


        LoadRecentActivity()
    End Sub

    Private Sub LoadRecentActivity()

        '''''''''''''''''''''''''''''''''

    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


End Class
