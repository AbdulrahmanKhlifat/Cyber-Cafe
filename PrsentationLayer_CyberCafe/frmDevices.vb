Public Class frmDevices
    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        FlowLayoutPaneldev.FlowDirection = FlowDirection.LeftToRight
        FlowLayoutPaneldev.WrapContents = True
        FlowLayoutPaneldev.AutoScroll = True

        FlowLayoutPaneldev.SuspendLayout()
        FlowLayoutPaneldev.Controls.Clear()

        For i As Integer = 1 To 12
            Dim card As New ctrShowDeviceInfo()


            card.Margin = New Padding(10)
            Dim deviceType As String = If(i Mod 2 = 0, "PC", "PS")
            card.LoadTestData("Device #" & i, deviceType, "In Use")
            card.CheckStatusDot("In Use")

            FlowLayoutPaneldev.Controls.Add(card)
        Next

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

    Private Sub btnDeleteDevice_Click(sender As Object, e As EventArgs) Handles btnDeleteDevice.Click
        ClearDeviceDetail()
    End Sub

    Private Sub pnlFilter_Paint(sender As Object, e As PaintEventArgs) Handles pnlFilter.Paint

    End Sub
End Class