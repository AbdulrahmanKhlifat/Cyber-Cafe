Imports BusinessLayer_CyberCafe
Imports BusinessLayer_CyberCafe.CyberCafe.BusinessLayer
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms

Public Class frmShowDeviceDetails

    Private _clickedRowIndex As Integer = -1

    Private WithEvents tmrSessionRefresh As New Timer()

    Dim _device As DeviceDTO

    Public Sub New(deviceID As Integer)

        InitializeComponent()
        DragHelper.EnableDragging(Me)

        _device = DeviceServices.Find(deviceID)

    End Sub

    Private Sub frmShowDeviceDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupActiveSessionsGrid()

        LoadDeviceGames()

        LoadCurrentSession()

        LoadDeviceKPIs()

        LoadDeviceStatus()

        tmrSessionRefresh.Interval = 1000
        tmrSessionRefresh.Start()


    End Sub

    Private Sub LoadDeviceStatus()

        Select Case _device.Status

            Case enDeviceStatus.Available
                lblStatus.Text = "Available"
                lblStatus.ForeColor = Color.MediumSeaGreen
                pbStatusDot.FillColor = Color.MediumSeaGreen

            Case enDeviceStatus.InUse
                lblStatus.Text = "In Use"
                lblStatus.ForeColor = Color.Orange
                pbStatusDot.FillColor = Color.Orange

            Case enDeviceStatus.Maintenance
                lblStatus.Text = "Maintenance"
                lblStatus.ForeColor = Color.Crimson
                pbStatusDot.FillColor = Color.Crimson

            Case Else
                lblStatus.Text = "Unknown"
                lblStatus.ForeColor = Color.LightGray
                pbStatusDot.FillColor = Color.LightGray

        End Select
    End Sub

    Private Sub tmrSessionRefresh_Tick(sender As Object, e As EventArgs) Handles tmrSessionRefresh.Tick

        RefreshRemainingTime()

    End Sub

    Private Sub RefreshRemainingTime()

        Dim activeSession =
        ActiveSessionsManager.GetAllSessions().
        FirstOrDefault(
            Function(s)
                Return s.CurrentDeviceID.GetValueOrDefault() =
                       _device.DeviceID _
                AndAlso
                       s.Status = SessionStatus.Active
            End Function
        )

        Dim activeRow As DataGridViewRow = Nothing

        For Each row As DataGridViewRow
        In dgvActiveSessions.Rows

            If row.Cells("Status").Value?.
            ToString().ToLower() = "active" Then

                activeRow = row
                Exit For

            End If

        Next

        If activeRow Is Nothing Then
            Return
        End If

        If activeSession Is Nothing Then

            Dim pausedSession =
        ActiveSessionsManager.GetAllSessions().
        FirstOrDefault(
            Function(s)
                Return s.CurrentDeviceID.GetValueOrDefault() =
                       _device.DeviceID _
                AndAlso
                       s.Status = SessionStatus.Paused
            End Function
        )

            If pausedSession IsNot Nothing Then

                activeRow.Cells("Status").Value = "Paused"

                activeRow.Cells("Status").Style.ForeColor =
            Color.Goldenrod

                activeRow.Cells("Status").Style.SelectionForeColor =
            Color.Goldenrod

                Return

            End If

            dgvActiveSessions.Rows.Remove(activeRow)

            lblStatus.Text = "Available"
            lblStatus.ForeColor = Color.MediumSeaGreen
            pbStatusDot.FillColor = Color.MediumSeaGreen

            Return

        End If

        activeRow.Cells("RemainingTime").Value =
        TimeSpan.FromSeconds(
            activeSession.RemainingSeconds
        ).ToString("hh\:mm\:ss")

    End Sub

    Private Sub LoadDeviceKPIs()

        Try

            Dim kpi =
            SessionService.GetDeviceSessionKPI(
                _device.DeviceID
            )

            lblRevenueValue.Text =
            kpi.TotalRevenue.ToString("C2")

            lblSessionsValue.Text =
            kpi.SessionCount.ToString()

            Dim totalTime As TimeSpan =
            TimeSpan.FromHours(
                kpi.TotalHours
            )

            lblTimeValue.Text =
            $"{totalTime.Hours} Hrs {totalTime.Minutes} Min"

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
            ex,
            Reflection.MethodBase.
            GetCurrentMethod().Name
        )

            UIHelper.ShowGunaMessage(
            "Failed to load device statistics.",
            "Error",
            MessageDialogIcon.Error
        )

        End Try

    End Sub

    Private Sub HandleDeviceImage()

        Try

            pbDeviceIcon.Image = UIHelper.LoadImageUnlocked(UIHelper.GetImagePath(_device.ImagePath))

        Catch ex As Exception

            pbDeviceIcon.Image = My.Resources.PC

        End Try

    End Sub

    Private Sub LoadDeviceGames()

        flpDeviceGames.SuspendLayout()
        flpDeviceGames.Controls.Clear()

        If _device Is Nothing Then
            MessageBox.Show("Device is NULL")
            Return
        End If

        Dim games = DeviceGameService.GetGamesByDeviceID(_device.DeviceID)

        HandleDeviceImage()

        lblDeviceName.Text = _device.DeviceName
        lblDeviceName.ForeColor = Color.FromArgb(0, 251, 255)

        If games IsNot Nothing Then


            For Each game In games

                Dim card As New ctrGameCard()
                card.LoadGameData(game)
                card.DisableCheckBox()
                flpDeviceGames.Controls.Add(card)

            Next

        End If

        flpDeviceGames.ResumeLayout()
        Me.ScrollBar.BindingContainer = Nothing
        Me.ScrollBar.BindingContainer = Me.flpDeviceGames
    End Sub

    Private Sub SetupActiveSessionsGrid()

        dgvActiveSessions.Columns.Clear()

        dgvActiveSessions.Columns.Add(
        "SessionID",
        "Session ID"
    )

        dgvActiveSessions.Columns.Add(
        "Customer",
        "Customer"
    )

        dgvActiveSessions.Columns.Add(
        "StartTime",
        "Start Time"
    )

        dgvActiveSessions.Columns.Add(
        "RemainingTime",
        "Remaining Time"
    )

        dgvActiveSessions.Columns.Add(
        "Status",
        "Status"
    )

        dgvActiveSessions.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub LoadCurrentSession()

        If Me.InvokeRequired Then

            Me.Invoke(Sub() LoadCurrentSession())

            Return

        End If

        dgvActiveSessions.Rows.Clear()

        Dim sessions = ActiveSessionsManager.GetAllSessions()

        Dim deviceSessions =
            sessions.Where(
                Function(s)
                    Return s.CurrentDeviceID.GetValueOrDefault() =
                           _device.DeviceID
                End Function
            ).ToList()

        If deviceSessions.Count = 0 Then
            Return
        End If

        For Each session In deviceSessions

            Dim customerUsername =
        UserServices.GetUserNameByID(
            session.CustomerID,
            UserRoleType.Customer
        )

            Dim status As String = String.Empty
            Dim statusColor As Color

            Select Case session.Status

                Case SessionStatus.Active

                    status = "Active"

                    statusColor =
                Color.FromArgb(0, 220, 160)

                Case SessionStatus.Paused

                    status = "Paused"

                    statusColor =
                Color.Goldenrod

                Case SessionStatus.Ended

                    status = "Ended"

                    statusColor =
                Color.LightGray

            End Select

            Dim rowIndex As Integer =
        dgvActiveSessions.Rows.Add(
            session.SessionID,
            customerUsername,
            session.LastResumeTime.ToString("hh:mm tt"),
            TimeSpan.FromSeconds(
                session.RemainingSeconds
            ).ToString("hh\:mm\:ss"),
            status
        )

            dgvActiveSessions.Rows(rowIndex).
        Cells("Status").Style.ForeColor =
            statusColor

            dgvActiveSessions.Rows(rowIndex).
        Cells("Status").Style.SelectionForeColor =
            statusColor

        Next

    End Sub

    Private Sub frmShowDeviceDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        tmrSessionRefresh.Stop()

    End Sub

    Private Sub cmsPauseResumeSession_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsPauseResumeSession.Opening

        If _clickedRowIndex = -1 Then

            e.Cancel = True
            Return

        End If

        Dim status As String =
        dgvActiveSessions.Rows(_clickedRowIndex).
        Cells("Status").Value.ToString().ToLower()

        tsPauseSession.Visible = False
        tsResumeSession.Visible = False

        Select Case status

            Case "active"

                tsPauseSession.Visible = True

            Case "paused"

                tsResumeSession.Visible = True

            Case Else

                e.Cancel = True

        End Select

    End Sub

    Private Sub dgvActiveSessions_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvActiveSessions.CellMouseDown

        _clickedRowIndex = -1

        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then

            _clickedRowIndex = e.RowIndex

            dgvActiveSessions.ClearSelection()

            dgvActiveSessions.Rows(e.RowIndex).Selected = True

            dgvActiveSessions.CurrentCell =
            dgvActiveSessions.Rows(e.RowIndex).
            Cells(e.ColumnIndex)

        End If

    End Sub

    Private Sub tsResumeSession_Click(sender As Object, e As EventArgs) Handles tsResumeSession.Click

        If dgvActiveSessions.SelectedRows.Count = 0 Then

            UIHelper.ShowGunaMessage(
            "Please select a session.",
            "Validation",
            MessageDialogIcon.Warning
        )

            Return

        End If


        Dim selectedRow As DataGridViewRow = dgvActiveSessions.SelectedRows(0)

        If selectedRow.Cells("SessionID").Value Is Nothing Then

            UIHelper.ShowGunaMessage(
            "Invalid session selection.",
            "Error",
            MessageDialogIcon.Error
        )

            Return

        End If


        Dim sessionID As Integer

        If Not Integer.TryParse(selectedRow.Cells("SessionID").Value.ToString(), sessionID) Then

            UIHelper.ShowGunaMessage("Invalid Session ID.", "Error", MessageDialogIcon.Error)

            Return

        End If

        Try

            Using frm As New frmResumeSession(sessionID)
                If frm.ShowDialog() = DialogResult.OK Then
                    LoadCurrentSession()
                End If
            End Using

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

    Private Sub tsPauseSession_Click(sender As Object, e As EventArgs) Handles tsPauseSession.Click

        If dgvActiveSessions.SelectedRows.Count = 0 Then

            UIHelper.ShowGunaMessage("Please select a session.", "Validation", MessageDialogIcon.Warning)

            Return

        End If

        Dim selectedRow As DataGridViewRow =
        dgvActiveSessions.SelectedRows(0)

        If selectedRow.Cells("SessionID").Value Is Nothing Then

            UIHelper.ShowGunaMessage(
            "Invalid session selection.",
            "Error",
            MessageDialogIcon.Error
        )

            Return

        End If

        Dim sessionID As Integer

        If Not Integer.TryParse(
        selectedRow.Cells("SessionID").Value.ToString(),
        sessionID
    ) Then

            UIHelper.ShowGunaMessage(
            "Invalid Session ID.",
            "Error",
            MessageDialogIcon.Error
        )

            Return

        End If

        Try

            Dim isPaused As Boolean =
            SessionService.PauseSession(sessionID)

            If isPaused Then

                UIHelper.ShowGunaMessage(
                "Session paused successfully.",
                "Success",
                MessageDialogIcon.Information
            )

            End If

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


End Class