Imports CyberCafeModels

Public Class ctrDeviceInfo

    Private Shared ReadOnly ColorAvailable As Color = Color.FromArgb(0, 200, 160)
    Private Shared ReadOnly ColorInUse As Color = Color.Red

    Public Property DeviceID As Integer

    Public Property Status As String
        Get
            Return lblStatus.Text
        End Get

        Set(value As String)
            lblStatus.Text = value
        End Set

    End Property

    Private Shared ReadOnly ImgPCAvailable As Image = My.Resources.images__1__removebg_preview
    Private Shared ReadOnly ImgPCInUse As Image = My.Resources.imac
    Private Shared ReadOnly ImgConsole As Image = My.Resources.games

    Private Function GetDeviceImage(typeName As String, isAvailable As Boolean) As Image
        Select Case typeName.ToUpper()
            Case "PC"
                Return If(isAvailable, ImgPCAvailable, ImgPCInUse)
            Case "PS4", "PS5", "XBOX"
                Return ImgConsole ' Same icon for both states based on your code
            Case Else
                Return ImgPCInUse
        End Select
    End Function

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

End Class