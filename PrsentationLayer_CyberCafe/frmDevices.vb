Public Class frmDevices


    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDevices()
    End Sub

    Private Sub LoadDevices()
        FlowLayoutPaneldev.SuspendLayout()
        For Each ctrl As Control In FlowLayoutPaneldev.Controls
            ctrl.Dispose()
        Next
        FlowLayoutPaneldev.Controls.Clear()
        For i As Integer = 1 To 5
            Dim card As New ctrShowDeviceInfo()
            card.Margin = New Padding(10)

            Dim deviceType As String = If(i Mod 2 = 0, "PC", "PS")
            card.LoadTestData("Device #" & i, deviceType, "In Use")
            card.CheckStatusDot("In Use")

            FlowLayoutPaneldev.Controls.Add(card)
        Next

        ' 4. استئناف الرسم
        FlowLayoutPaneldev.ResumeLayout()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        pnlDeviceDetail.Visible = True
    End Sub
    Private Sub ClearDeviceDetail()
        txtDeviceName.Text = ""
        cboDeviceType.SelectedIndex = -1
    End Sub
    Private Sub btnCancelDevice_Click(sender As Object, e As EventArgs) Handles btnCancelDevice.Click
        pnlDeviceDetail.Visible = False
        ClearDeviceDetail()
    End Sub

    Private Sub btnClearDeviceInfo_Click(sender As Object, e As EventArgs) Handles btnDeleteDevice.Click
        ClearDeviceDetail()
    End Sub
End Class