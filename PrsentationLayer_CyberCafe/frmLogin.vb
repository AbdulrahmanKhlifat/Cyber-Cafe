Public Class frmLogin
    Private Sub lblSubtitle_Click(sender As Object, e As EventArgs) Handles lblSubtitle.Click

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBrand.EnableDragging()
        pnlLoginCard.EnableDragging()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frm As New frmDashboard()
        frm.ShowDialog()

    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.BackColor = ColorTranslator.FromHtml("#374151")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = ColorTranslator.FromHtml("#1F2937")
    End Sub

    Private Sub pnlLoginCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlLoginCard.Paint

    End Sub
End Class
