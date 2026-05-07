Imports CyberCafeModels

Public Class ctrDeviceInfo

    Private Shared ReadOnly ColorAvailable As Color = Color.FromArgb(0, 200, 160)
    Private Shared ReadOnly CyanHoverColor As Color = Color.FromArgb(35, 44, 51)
    Private Shared ReadOnly ColorInUse As Color = Color.Red








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



    Public Sub LoadData(deviceInfo As DeviceDTO)
        DeviceID = deviceInfo.DeviceID
        lblDeviceName.Text = deviceInfo.DeviceName
        lblDeviceType.Text = deviceInfo.DeviceTypeName
        lblStatus.Text = deviceInfo.Status.ToString()

        ImagePath = UIHelper.GetImagePath(deviceInfo.ImagePath)

        If ImagePath Is Nothing Then
            pbDeviceIcon.Image = My.Resources.PlayStationIcon
        Else
            pbDeviceIcon.Image = UIHelper.LoadImageUnlocked(ImagePath)
        End If

        UpdateUI(deviceInfo.DeviceTypeName, deviceInfo.Status)
    End Sub

    Private Sub UpdateUI(typeName As String, status As enDeviceStatus)
        Dim isAvailable As Boolean = (status = enDeviceStatus.Available)

        Dim statusColor As Color = If(isAvailable, ColorAvailable, ColorInUse)
        pbStatusDot.FillColor = statusColor
        lblStatus.ForeColor = statusColor
        pnlDevice.Cursor = Cursors.Hand

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