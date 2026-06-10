Imports System.Web.UI.WebControls
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmStartSession

    Private Device As DeviceDTO
    Public Sub New(deviceID As Integer)
        InitializeComponent()

        Device = DeviceServices.Find(deviceID)

    End Sub

    Private Sub frmStartSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDeviceDetails()
        LoadTopCustomers()

    End Sub

    Private Sub LoadDeviceDetails()

        If Device IsNot Nothing Then

            txtDeviceName.Text = $"{Device.DeviceName} (ID: {Device.DeviceID})"

        Else

            UIHelper.ShowGunaMessage("Failed to fetch device details.", "Error", MessageBoxIcon.Error)
            Me.Close()

        End If
    End Sub

    Private Sub LoadTopCustomers()
        Dim topCustomers = CustomerServices.GetTop10Customers()

        cmbCustomers.DisplayMember = "Name"
        cmbCustomers.ValueMember = "UserID"
        cmbCustomers.DataSource = topCustomers

        cmbCustomers.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        cmbCustomers.SelectedIndex = -1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function FillSessionObject() As SessionDTO

        Dim session As New SessionDTO()
        session.CustomerID = Convert.ToInt32(cmbCustomers.SelectedValue)
        session.CurrentDeviceID = Device.DeviceID
        session.CreatedByAdminID = LoggedInUser.CurrentUser.UserID
        session.DeviceTypeID = Device.DeviceTypeID
        session.RemainingSeconds = Convert.ToInt32(txtSeconds.Text)
        session.SessionRatePerHour = Device.PricePerHour
        session.SessionCost = (Convert.ToDecimal(txtSeconds.Text) / 3600D) * Device.PricePerHour

        Return session

    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If cmbCustomers.SelectedIndex = -1 Then
            UIHelper.ShowGunaMessage("Please select a customer", "Validation Error", MessageBoxIcon.Warning)
            Return
        End If

        Dim session As SessionDTO = FillSessionObject()

        Try

            SessionService.StartSession(session)

        Catch ex As Exception
            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            UIHelper.ShowGunaMessage("Failed to start session: " & ex.Message, "Error", MessageBoxIcon.Error)
        End Try

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


End Class
