Imports CyberCafeModels
Imports BusinessLayer_CyberCafe

Public Class frmResumeSession

    Private _sessionID As Integer
    Private _deviceTypeID As Integer
    Private _remainingSeconds As Integer
    Private _customerName As String
    Private _currentDeviceName As String
    Private _deviceTypeName As String

    Public Property SelectedNewDeviceID As Integer = -1

    Public Sub New(sessionID As Integer, deviceTypeID As Integer, remainingSeconds As Integer, customerName As String, currentDeviceName As String, deviceTypeName As String)
        InitializeComponent()

        _sessionID = sessionID
        _deviceTypeID = deviceTypeID
        _remainingSeconds = remainingSeconds
        _customerName = customerName
        _currentDeviceName = currentDeviceName
        _deviceTypeName = deviceTypeName
    End Sub

    Private Sub frmResumeSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblSessionID.Text = $"Session ID: {_sessionID}"
        lblCustomerName.Text = $"Customer: {_customerName}"
        lblCurrentDevice.Text = $"Current Device: {_currentDeviceName}"
        lblDeviceType.Text = $"Device Type: {_deviceTypeName}"

        Dim remainingTimeSpan = TimeSpan.FromSeconds(_remainingSeconds)
        lblRemainingTime.Text = $"Remaining Time: {remainingTimeSpan.Hours}h {remainingTimeSpan.Minutes}m"

        LoadAvailableDevices()

    End Sub

    Private Sub LoadAvailableDevices()
        Try

            Dim allDevices = DeviceServices.GetAllDevicesList()
            Dim availableDevices = allDevices.Where(Function(d) d.DeviceTypeID = _deviceTypeID AndAlso d.Status = enDeviceStatus.Available).ToList()

            cmbDevices.DataSource = Nothing
            cmbDevices.Items.Clear()

            If availableDevices.Count > 0 Then

                cmbDevices.DataSource = availableDevices
                cmbDevices.DisplayMember = "DeviceName"
                cmbDevices.ValueMember = "DeviceID"
                cmbDevices.SelectedIndex = -1
                btnResume.Enabled = False
                lblHelperText.Text = "Only devices matching the session platform are displayed."
                lblHelperText.ForeColor = Color.FromArgb(139, 148, 158)

            Else

                btnResume.Enabled = False
                lblHelperText.Text = "No available compatible devices found."
                lblHelperText.ForeColor = Color.FromArgb(248, 81, 73)

            End If

        Catch ex As Exception

            UIHelper.ShowGunaMessage($"Error loading devices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub cmbDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDevices.SelectedIndexChanged

        If cmbDevices.SelectedIndex >= 0 AndAlso cmbDevices.SelectedValue IsNot Nothing Then

            btnResume.Enabled = True

        Else

            btnResume.Enabled = False

        End If
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click

        If cmbDevices.SelectedValue IsNot Nothing Then

            SelectedNewDeviceID = Convert.ToInt32(cmbDevices.SelectedValue)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

End Class
