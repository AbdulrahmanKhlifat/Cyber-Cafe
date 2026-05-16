Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmResumeSession

    Private ReadOnly _sessionID As Integer
    Private _resumeInfo As ResumeSessionDTO

    Public Property SelectedNewDeviceID As Integer = -1

    Public Sub New(sessionID As Integer)

        InitializeComponent()

        DragHelper.EnableDragging(Me)

        _sessionID = sessionID

    End Sub

    Private Sub frmResumeSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            _resumeInfo = SessionService.GetResumeSessionDetails(_sessionID)

            If _resumeInfo Is Nothing Then
                UIHelper.ShowGunaMessage(
                "Unable to load session details.",
                "Error",
                MessageDialogIcon.Error
            )
                Me.Close()
                Return
            End If

            lblSessionID.Text = $"Session ID: {_resumeInfo.SessionID}"
            lblCustomerName.Text = $"Customer: {_resumeInfo.CustomerName}"
            lblCurrentDevice.Text = $"Current Device: {_resumeInfo.CurrentDeviceName}"
            lblDeviceType.Text = $"Device Type: {_resumeInfo.DeviceTypeName}"

            Dim remainingTimeSpan As TimeSpan =
            TimeSpan.FromSeconds(_resumeInfo.RemainingSeconds)

            lblRemainingTime.Text =
            $"Remaining Time: {CInt(remainingTimeSpan.TotalHours)}h {remainingTimeSpan.Minutes}m"

            LoadAvailableDevices()

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
            ex,
            Reflection.MethodBase.GetCurrentMethod().Name
        )

            UIHelper.ShowGunaMessage(
            "Error loading session details.",
            "Error",
            MessageDialogIcon.Error
        )

            Me.Close()

        End Try

    End Sub

    Private Sub LoadAvailableDevices()

        Try

            Dim allDevices = DeviceServices.GetAllDevicesList()

            Dim availableDevices =
            allDevices.
            Where(Function(d) d.DeviceTypeID = _resumeInfo.DeviceTypeID AndAlso
                              d.Status = enDeviceStatus.Available).
            ToList()

            cmbDevices.DataSource = Nothing
            cmbDevices.Items.Clear()

            If availableDevices.Count > 0 Then

                cmbDevices.DataSource = availableDevices
                cmbDevices.DisplayMember = "DeviceName"
                cmbDevices.ValueMember = "DeviceID"
                cmbDevices.SelectedIndex = -1

                btnResume.Enabled = False
                lblHelperText.Text = "Only compatible available devices are shown."
                lblHelperText.ForeColor = Color.FromArgb(139, 148, 158)

            Else

                btnResume.Enabled = False
                lblHelperText.Text = "No available compatible devices found."
                lblHelperText.ForeColor = Color.FromArgb(248, 81, 73)

            End If

        Catch ex As Exception

            UIHelper.ShowGunaMessage(
            $"Error loading devices: {ex.Message}",
            "Error",
            MessageDialogButtons.OK,
            MessageDialogIcon.Error
        )

        End Try

    End Sub

    Private Sub cmbDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDevices.SelectedIndexChanged

        btnResume.Enabled = cmbDevices.SelectedIndex >= 0 AndAlso cmbDevices.SelectedValue IsNot Nothing

    End Sub

    Private Sub btnResume_Click(
    sender As Object,
    e As EventArgs
) Handles btnResume.Click

        Try

            If cmbDevices.SelectedValue Is Nothing Then

                UIHelper.ShowGunaMessage(
                "Please select a device.",
                "Validation",
                MessageDialogIcon.Warning
            )

                Return

            End If

            Dim newDeviceID As Integer =
            Convert.ToInt32(
                cmbDevices.SelectedValue
            )

            Dim isResumed As Boolean =
            SessionService.ResumeSession(
                _sessionID,
                newDeviceID
            )

            If Not isResumed Then

                UIHelper.ShowGunaMessage(
                "Failed to resume session.",
                "Error",
                MessageDialogIcon.Error
            )

                Return

            End If

            SelectedNewDeviceID = newDeviceID

            UIHelper.ShowGunaMessage(
            "Session resumed successfully.",
            "Success",
            MessageDialogIcon.Information
        )

            Me.DialogResult = DialogResult.OK

            Me.Close()

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
            ex,
            Reflection.MethodBase.
            GetCurrentMethod().Name
        )

            UIHelper.ShowGunaMessage(
            ex.Message,
            "Error",
            MessageDialogIcon.Error
        )

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

End Class
