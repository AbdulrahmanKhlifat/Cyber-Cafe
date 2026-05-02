Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmShowDeviceDetails

    Dim _device As DeviceDTO
    Public Sub New(deviceID As Integer)

        InitializeComponent()

        _device = DeviceServices.Find(deviceID)
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
        lblDeviceName.Text = _device.DeviceName
        lblDeviceName.ForeColor = Color.FromArgb(0, 251, 255)
        If games IsNot Nothing Then

            Dim panelWidth = flpDeviceGames.ClientSize.Width
            Dim cardWidth = (panelWidth \ 3) - 15

            For Each game In games

                Dim card As New ctrGameCard()
                card.LoadGameData(game.GameID, game.GameName, "", Nothing)

                card.Width = cardWidth
                card.Height = 180

                flpDeviceGames.Controls.Add(card)

            Next

        End If

        flpDeviceGames.ResumeLayout()

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
    Private Sub _ShowGunaMessage(message As String, caption As String, icon As MessageDialogIcon)

        Dim guna As New Guna2MessageDialog With {
            .Caption = caption,
            .Text = message,
            .Parent = System.Windows.Forms.Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = icon,
            .Buttons = MessageDialogButtons.OK
        }

        guna.Show()
    End Sub


End Class