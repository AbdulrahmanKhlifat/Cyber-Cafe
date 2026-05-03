Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmShowDeviceDetails

    Dim _device As DeviceDTO
    Public Sub New(deviceID As Integer)

        InitializeComponent()
        DragHelper.EnableDragging(Me)
        _device = DeviceServices.Find(deviceID)
    End Sub

    Private Sub HandleDeviceImage(Type As Integer)

        Select Case Type

            Case enDeviceType.PC
                pbDeviceIcon.Image = My.Resources.PC

            Case enDeviceType.PS5
                pbDeviceIcon.Image = My.Resources.PS5_icon

            Case enDeviceType.VirtualReality
                pbDeviceIcon.Image = My.Resources.VR_icon

            Case Else
                pbDeviceIcon.Image = My.Resources.PlayStationIcon

        End Select

    End Sub
    Private Sub frmShowDeviceDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeviceGames()
    End Sub
    Private Sub LoadDeviceGames()

        flpDeviceGames.SuspendLayout()
        flpDeviceGames.Controls.Clear()
        If _device Is Nothing Then
            MessageBox.Show("Device is NULL")
            Return
        End If
        Dim games = DeviceGameService.GetGamesByDeviceID(_device.DeviceID)
        HandleDeviceImage(_device.DeviceTypeID)
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
        dgvActiveSessions.Columns.Add("SessionID", "Session ID")
        dgvActiveSessions.Columns.Add("Customer", "Customer")
        dgvActiveSessions.Columns.Add("StartTime", "Start Time")
        dgvActiveSessions.Columns.Add("Duration", "Duration")

        dgvActiveSessions.Rows.Add("S-1001", "John Doe", "10:30 AM", "01:15:00")
        dgvActiveSessions.Rows.Add("S-1002", "Guest", "11:45 AM", "00:45:00")
    End Sub


End Class