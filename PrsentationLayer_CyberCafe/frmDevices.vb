Public Class frmDevices
    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pnlFilter_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        pnlDeviceDetail.Visible = True
    End Sub
    Private Sub ClearDeviceDetail()
        txtDeviceName.Text = ""
        cboDeviceType.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
    End Sub
    Private Sub btnCancelDevice_Click(sender As Object, e As EventArgs) Handles btnCancelDevice.Click
        pnlDeviceDetail.Visible = False
        ClearDeviceDetail()
    End Sub

    Private Sub btnDeleteDevice_Click(sender As Object, e As EventArgs) Handles btnDeleteDevice.Click
        ClearDeviceDetail()
    End Sub

    Private Sub pnlFilter_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlFilter.Paint

    End Sub
End Class