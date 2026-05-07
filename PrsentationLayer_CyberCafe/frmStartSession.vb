Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmStartSession

    Private _DeviceID As Integer

    Public Sub New(deviceID As Integer)
        InitializeComponent()
        _DeviceID = deviceID
    End Sub

    Private Sub frmStartSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDeviceDetails()
        LoadTopCustomers()

    End Sub

    Private Sub LoadDeviceDetails()

        Dim device = DeviceTypeServices.GetDeviceInfoByID(_DeviceID)

        If device IsNot Nothing Then

            txtDeviceName.Text = $"{device.DeviceName} (ID: {device.DeviceID})"

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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmbCustomers.SelectedIndex = -1 Then
            UIHelper.ShowGunaMessage("Please select a customer", "Validation Error", MessageBoxIcon.Warning)
            Return
        End If

        UIHelper.ShowGunaMessage("Session starting ", "Info", MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


End Class
