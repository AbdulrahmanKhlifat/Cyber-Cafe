Imports CyberCafeModels

Public Class ctrDeviceInfo

    Private ReadOnly ColorAvailable As Color = Color.FromArgb(0, 200, 160)
    Private ReadOnly ColorInUse As Color = Color.Red

    Public Property DeviceID As Integer

    Public Property Status As String
        Get
            Return lblStatus.Text
        End Get

        Set(value As String)
            lblStatus.Text = value
        End Set

    End Property

    Public Sub LoadData(deviceInfo As DeviceDTO)
        DeviceID = deviceInfo.DeviceID
        lblDeviceName.Text = deviceInfo.DeviceName
        lblDeviceType.Text = deviceInfo.DeviceTypeName
        lblStatus.Text = deviceInfo.Status.ToString()

        UpdateUI(deviceInfo.DeviceTypeName, deviceInfo.Status)
    End Sub

    Private Sub UpdateUI(typeName As String, status As enDeviceStatus)
        Dim isAvailable As Boolean = (status = enDeviceStatus.Available)

        Dim statusColor As Color = If(isAvailable, ColorAvailable, ColorInUse)
        pbStatusDot.FillColor = statusColor
        lblStatus.ForeColor = statusColor

        pbDeviceIcon.Image = GetDeviceImage(typeName, isAvailable)
    End Sub

    Private Function GetDeviceImage(typeName As String, isAvailable As Boolean) As Image
        Select Case typeName.ToUpper()
            Case "PC"
                Return If(isAvailable, My.Resources.images__1__removebg_preview, My.Resources.imac)
            Case "PS4", "PS5"
                Return If(isAvailable, My.Resources.games, My.Resources.games)
            Case Else
                Return My.Resources.imac
        End Select
    End Function

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property


    'Private Sub gnCard_MouseHover(sender As Object, e As EventArgs)
    '    gnCard.FillColor = Color.FromArgb(14, 17, 23)
    'End Sub

    'Private Sub gnCard_MouseLeave(sender As Object, e As EventArgs)
    '    gnCard.FillColor = Color.FromArgb(22, 30, 42)
    'End Sub


End Class