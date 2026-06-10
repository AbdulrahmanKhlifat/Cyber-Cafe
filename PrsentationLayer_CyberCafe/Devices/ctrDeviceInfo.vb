Imports System.Reflection
Imports System.Web.UI.WebControls
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class ctrDeviceInfo

    Private Shared ReadOnly CyanHoverColor As Color = Color.FromArgb(35, 44, 51)
    Private Shared ReadOnly ColorAvailable As Color = Color.FromArgb(0, 200, 160)
    Private Shared ReadOnly ColorInUse As Color = Color.Orange
    Private Shared ReadOnly ColorMaintenance As Color = Color.Crimson

    Private _IsSubscribedToTicks As Boolean = False


    Public Property Status As String
        Get
            Return lblStatus.Text
        End Get

        Set(value As String)
            lblStatus.Text = value
        End Set

    End Property

    Public Property DeviceID As Integer

    Private ImagePath As String

    Public Property Device As DeviceDTO

    Public Sub New(d As DeviceDTO)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        AddHandler SessionService.SessionStarted,
            AddressOf OnSessionStart

        AddHandler SessionService.SessionResumed,
            AddressOf OnSessionResume

        AddHandler SessionService.SessionPaused,
            AddressOf OnSessionPause

        AddHandler SessionService.SessionEnded,
            AddressOf OnSessionEnd

        DeviceID = d.DeviceID
        Device = d

        Dim activeSession As ActiveSession = ActiveSessionsManager.GetActiveSessionByDeviceID(DeviceID)

        If activeSession IsNot Nothing Then

            Device.Status = enDeviceStatus.InUse

            SubscribeToTicks()

        End If

        RefreshData()
    End Sub

    Private Sub OnSessionEnd(session As ActiveSession)

        If session.DeviceID <> DeviceID Then
            Return
        End If

        UnsubscribeFromTicks()

        Device.Status = enDeviceStatus.Available

        UpdateStatusUI()

    End Sub

    Private Sub OnSessionPause(session As ActiveSession)

        If session.DeviceID <> DeviceID Then
            Return
        End If

        UnsubscribeFromTicks()

        Device.Status = enDeviceStatus.Available

        UpdateStatusUI()

    End Sub

    Private Sub OnSessionTicked(session As ActiveSession)

        If session.DeviceID <> DeviceID Then
            Return
        End If

        If InvokeRequired Then

            Invoke(Sub()
                       lblRemainingTime.Text =
                       TimeSpan.FromSeconds(session.RemainingSeconds).
                       ToString("hh\:mm\:ss")
                   End Sub)

            Return

        End If

        lblRemainingTime.Text =
        TimeSpan.FromSeconds(session.RemainingSeconds).
        ToString("hh\:mm\:ss")

    End Sub

    Private Sub OnSessionStart(session As ActiveSession)

        If session.DeviceID <> DeviceID Then
            Return
        End If

        SubscribeToTicks()

        Device.Status = enDeviceStatus.InUse

        UpdateStatusUI()

    End Sub

    Private Sub OnSessionResume(session As ActiveSession)

        If session.DeviceID <> DeviceID Then
            Return
        End If

        Device.Status = enDeviceStatus.InUse

        SubscribeToTicks()

        UpdateStatusUI()

    End Sub

    Private Sub SubscribeToTicks()

        If _IsSubscribedToTicks Then
            Return
        End If

        AddHandler SessionService.SessionTicked,
            AddressOf OnSessionTicked

        _IsSubscribedToTicks = True

    End Sub

    Private Sub UnsubscribeFromTicks()

        If Not _IsSubscribedToTicks Then
            Return
        End If

        RemoveHandler SessionService.SessionTicked,
        AddressOf OnSessionTicked

        _IsSubscribedToTicks = False

        If InvokeRequired Then

            Invoke(Sub()
                       lblRemainingTime.Visible = False
                       lblRemainingTimeHeader.Visible = False
                   End Sub)

            Return

        End If

        lblRemainingTime.Visible = False
        lblRemainingTimeHeader.Visible = False

    End Sub

    Public Sub RefreshData()
        DeviceID = Device.DeviceID
        lblDeviceName.Text = Device.DeviceName
        lblDeviceType.Text = Device.DeviceTypeName

        lblDeviceType.Tag = Device.DeviceTypeID

        ImagePath = UIHelper.GetImagePath(Device.ImagePath)

        Try

            pbDeviceIcon.Image = UIHelper.LoadImageUnlocked(ImagePath)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, MethodBase.GetCurrentMethod().Name)

            pbDeviceIcon.Image = My.Resources.PlayStationIcon

        End Try

        UpdateStatusUI()

    End Sub

    Public Sub UpdateStatusUI()

        If InvokeRequired Then

            Invoke(Sub()
                       UpdateStatusUI()
                   End Sub)

            Return

        End If

        lblStatus.Text = Device.Status.ToString()

        Dim statusColor As Color

        Select Case Device.Status

            Case enDeviceStatus.Available
                statusColor = ColorAvailable

            Case enDeviceStatus.InUse
                statusColor = ColorInUse
                lblStatus.Text = "In Use"

            Case enDeviceStatus.Maintenance
                statusColor = ColorMaintenance

            Case Else
                statusColor = Color.Gray

        End Select

        lblRemainingTime.Visible =
        (Device.Status = enDeviceStatus.InUse)

        lblRemainingTimeHeader.Visible =
        (Device.Status = enDeviceStatus.InUse)

        pbStatusDot.FillColor = statusColor
        lblStatus.ForeColor = statusColor

    End Sub


    Private Sub pnlDevice_MouseEnter(sender As Object, e As EventArgs) Handles pnlDevice.MouseEnter, pbDeviceIcon.MouseEnter, lblStatus.MouseEnter, lblDeviceName.MouseEnter

        lblDeviceName.ForeColor = CyanHoverColor

    End Sub


    Private Sub pnlDevice_MouseLeave(sender As Object, e As EventArgs) Handles pnlDevice.MouseLeave, pbDeviceIcon.MouseLeave, lblStatus.MouseLeave, lblDeviceName.MouseLeave

        Dim mousePos = pnlDevice.PointToClient(Control.MousePosition)

        If Not pnlDevice.ClientRectangle.Contains(mousePos) Then

            lblDeviceName.ForeColor = Color.White
        End If

    End Sub

End Class