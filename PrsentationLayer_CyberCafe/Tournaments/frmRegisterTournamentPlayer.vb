Imports Guna.UI2.WinForms
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class frmRegisterTournamentPlayer

    Private _requiredFee As Decimal
    Private _customerID As Integer = -1
    Private _tournamentID As Integer

    Private _isLoading As Boolean = False

    Public Sub New(requiredFee As Decimal, TournamentID As Integer)

        InitializeComponent()
        _requiredFee = requiredFee
        _tournamentID = TournamentID
        lblEntryFee.Text = $"Required Entry Fee: ${requiredFee:F2}"

    End Sub

    Private Sub frmRegisterTournamentPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTopCustomers()

    End Sub


    Private Sub LoadTopCustomers(Optional search As String = "")

        _isLoading = True

        Dim topCustomers = CustomerServices.GetTop10Customers(search, _tournamentID)

        cmbCustomers.DataSource = topCustomers
        cmbCustomers.DisplayMember = "Name"
        cmbCustomers.ValueMember = "UserID"


        cmbCustomers.AutoCompleteMode = AutoCompleteMode.None

        cmbCustomers.SelectedIndex = -1
        _isLoading = False
    End Sub


    Private Sub cmbCustomers_TextUpdate(sender As Object, e As EventArgs) Handles cmbCustomers.TextUpdate
        Dim searchText As String = cmbCustomers.Text


        If searchText.Length >= 2 OrElse searchText.Length = 0 Then

            _isLoading = True


            Dim topCustomers = CustomerServices.GetTop10Customers(searchText, _tournamentID)

            cmbCustomers.DataSource = Nothing
            cmbCustomers.DataSource = topCustomers
            cmbCustomers.DisplayMember = "Name"
            cmbCustomers.ValueMember = "UserID"


            cmbCustomers.Text = searchText
            cmbCustomers.SelectionStart = searchText.Length


            cmbCustomers.DroppedDown = True

            _isLoading = False

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub cmbCustomers_SelectedIndexChanged() Handles cmbCustomers.SelectedIndexChanged

        If _isLoading Then
            Return
        End If


        If cmbCustomers.SelectedIndex = -1 Then

            ResetCustomerDetails("Please select a customer.")
            Return

        End If

        Dim customerID As Integer = CInt(cmbCustomers.SelectedValue)

        Try

            Dim result = TournamentServices.ValidateTournamentRegistration(customerID, _requiredFee)

            If result.CustomerID = 0 Then

                ResetCustomerDetails(result.Message)
                Return

            End If

            _customerID = result.CustomerID

            lblCustomerName.Text = $"Customer: {result.CustomerName}"

            lblWalletBalance.Text = $"Wallet Balance: ${result.Balance:F2}"

            lblStatus.Text = result.Message

            If result.IsValid Then

                lblStatus.ForeColor = Color.FromArgb(0, 200, 83)

            Else

                lblStatus.ForeColor = Color.FromArgb(255, 49, 49)

            End If

            btnConfirm.Enabled = result.IsValid

        Catch ex As Exception

            ResetCustomerDetails("Error finding customer.")

        End Try

    End Sub

    Private Sub ResetCustomerDetails(statusMsg As String)

        _customerID = -1
        lblCustomerName.Text = "Customer: ---"
        lblWalletBalance.Text = "Wallet Balance: $0.00"
        lblStatus.Text = statusMsg
        lblStatus.ForeColor = Color.FromArgb(255, 49, 49) ' Red
        btnConfirm.Enabled = False

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If _customerID <> -1 Then

            Try


                If TournamentPlayersServices.RegisterPlayer(_tournamentID, _customerID, LoggedInUser.CurrentUser.UserID) Then

                    UIHelper.ShowGunaMessage($"Player registered successfully!", "Success", MessageBoxIcon.Information)

                    Me.DialogResult = DialogResult.OK
                    Me.Close()

                Else

                    UIHelper.ShowGunaMessage("Failed to register player.", "Error", MessageBoxIcon.Error)

                End If

            Catch ex As Exception

                UIHelper.ShowGunaMessage($"Failed to process registration: {ex.Message}", "Error", MessageBoxIcon.Error)

            End Try

        End If

    End Sub

End Class
