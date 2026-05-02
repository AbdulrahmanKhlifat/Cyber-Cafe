Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmShowDeviceDetails

    Dim _device As DeviceDTO
    Public Sub New(deviceID As Integer)

        InitializeComponent()

        _device = DeviceServices.Find(deviceID)
        LoadDeviceDetails(_device)
    End Sub

    Public Sub LoadDeviceDetails(device As DeviceDTO)

        If device Is Nothing Then
            _ShowGunaMessage("Device not found!", "Error", MessageDialogIcon.Error)
            Return
        End If

        lblDeviceName.Text = device.DeviceName
        Dim isAvailable As Boolean = True
        If isAvailable Then
            lblStatus.Text = "Available"
            lblStatus.ForeColor = Color.LightGray
            pbStatusDot.FillColor = Color.LimeGreen
        Else
            lblStatus.Text = "In Use"
            lblStatus.ForeColor = Color.DarkGray
            pbStatusDot.FillColor = Color.Crimson
        End If

        pbDeviceIcon.Image = My.Resources._771247 'I'm not handeled with icons yet, so using a placeholder 

        lblRevenueValue.Text = "$125.50"
        lblTimeValue.Text = "14 Hrs"
        lblSessionsValue.Text = "8"


        'I suggest to keep it +تقعدش تعيط like this for now, since we don't have real data to show. 
        lblIPValue.Text = "192.168.1." & (100 + device.DeviceID).ToString()
        lblMACValue.Text = "00:1A:2B:3C:4D:" & device.DeviceID.ToString("X2")

        Dim deviceType As String = If(device.DeviceTypeName, "").ToUpper()

        Select Case deviceType
            Case "PC"
                lblCPUValue.Text = "Intel Core i5-11400F"
                lblRAMValue.Text = "16 GB DDR4"
            Case "PS5"
                lblCPUValue.Text = "Custom Zen 2"
                lblRAMValue.Text = "16 GB GDDR6"
            Case Else
                lblCPUValue.Text = "N/A"
                lblRAMValue.Text = "N/A"
        End Select


        SetupActiveSessionsGrid()
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