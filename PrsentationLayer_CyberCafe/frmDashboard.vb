Imports System.Runtime.CompilerServices

Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClock.Start()
        pnlTopBar.EnableDragging()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss   ddd, MMM dd yyyy")
    End Sub

    Private Sub pnlTopBar_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopBar.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

    End Sub

    Private Sub btnCloseWin_Click(sender As Object, e As EventArgs) Handles btnCloseWin.Click
        Me.Close()
    End Sub
End Class