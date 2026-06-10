Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports System.Reflection
Public Class frmDashboard

    Private deviceToolTip As New ToolTip()

    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler SessionService.SessionStarted,
            AddressOf RefreshDashboard

        AddHandler SessionService.SessionResumed,
            AddressOf RefreshDashboard

        AddHandler SessionService.SessionPaused,
            AddressOf RefreshDashboard

        AddHandler SessionService.SessionEnded,
            AddressOf RefreshDashboard

        EnableDoubleBuffering(FlowLayoutPanel1)


        RefreshDashboard()
    End Sub

    Private Sub LoadDeviceGrid()

        FlowLayoutPanel1.Controls.Clear()

        Dim deviceList As List(Of DeviceDTO) = DeviceServices.GetAllDevicesList()

        For Each device As DeviceDTO In deviceList

            Dim btn As New Guna.UI2.WinForms.Guna2Button()

            btn.Name = "DeviceBtn_" & device.DeviceID
            btn.Size = New Size(50, 50)
            btn.Margin = New Padding(5)
            btn.BorderRadius = 10
            btn.Text = ""
            btn.Cursor = Cursors.Hand

            Select Case device.Status

                Case enDeviceStatus.Available
                    btn.FillColor = Color.MediumSeaGreen

                Case enDeviceStatus.InUse
                    btn.FillColor = Color.Orange

                Case enDeviceStatus.Maintenance
                    btn.FillColor = Color.Crimson

                Case Else
                    btn.FillColor = Color.Gray

            End Select

            btn.Tag = device.DeviceID

            deviceToolTip.SetToolTip(btn,
            $"{device.DeviceName} ({device.DeviceTypeName})")

            AddHandler btn.Click, AddressOf DeviceButton_Click

            FlowLayoutPanel1.Controls.Add(btn)

        Next

    End Sub

    Private Sub LoadDashboardKpis()

        Try

            Dim kpis As DashboardKpiDTO =
            DashboardServices.GetDashboardKpis()

            If kpis Is Nothing Then
                Exit Sub
            End If

            ' Total Customers
            lblCustNum.Text =
        kpis.TotalCustomers.ToString("N0")

            ' Devices (In Use / Total)
            lblDevNum.Text =
        $"{kpis.AvailableDevices} / {kpis.TotalDevices}"

            ' Active Sessions
            lblSessNum.Text =
        kpis.ActiveSessions.ToString("N0")

            ' Today's Revenue
            lblRevNum.Text =
        kpis.TodayRevenue.ToString("C0")

            'Progress bar
            If kpis.TotalDevices >= 0 Then

                pbDevicesInUse.Value = (kpis.ActiveSessions / kpis.TotalDevices) * 100

            End If
        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
        ex,
        System.Reflection.MethodBase.
        GetCurrentMethod().Name
    )

        End Try

    End Sub

    Private Sub RefreshDashboard()

        If Me.InvokeRequired Then
            Me.Invoke(Sub() RefreshDashboard())
            Return
        End If

        LoadDeviceGrid()
        LoadDashboardKpis()

    End Sub

    Private Sub DeviceButton_Click(sender As Object, e As EventArgs)
        Dim clickedBtn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        Dim deviceId As Integer = Convert.ToInt32(clickedBtn.Tag)

        Using frm As frmShowDeviceDetails = New frmShowDeviceDetails(deviceId)
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub EnableDoubleBuffering(control As Control)

        Dim prop As PropertyInfo =
            GetType(Control).GetProperty(
                "DoubleBuffered",
                BindingFlags.NonPublic Or BindingFlags.Instance)

        prop.SetValue(control, True, Nothing)

    End Sub

End Class