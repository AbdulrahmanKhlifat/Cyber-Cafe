Imports System.Runtime.CompilerServices
Imports CyberCafeModels.CyberCafe.Models

Public Class frmDashboard
    Private _admin As AdminDTO

    Public Sub New(admin As AdminDTO)
        InitializeComponent()

        _admin = admin
    End Sub

    'This will be removed
    Public Sub New()
        InitializeComponent()

        _admin = Nothing
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClock.Start()
        pnlTopBar.EnableDragging()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss   ddd, MMM dd yyyy")
    End Sub

    Private Sub pnlTopBar_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopBar.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCloseWin_Click(sender As Object, e As EventArgs) Handles btnCloseWin.Click
        Me.Close()
    End Sub

    Private Sub btnDevices_Click(sender As Object, e As EventArgs) Handles btnDevices.Click
        pnlMain.Controls.Clear()
        Dim frm As New frmDevices()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()

    End Sub

    Private Sub pnlHome_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pnlNav_Paint(sender As Object, e As PaintEventArgs) Handles pnlNav.Paint

    End Sub

    Private Sub lblKpiSessTitle_Click(sender As Object, e As EventArgs) Handles lblKpiSessTitle.Click

    End Sub

    Private Sub btnCutomers_Click(sender As Object, e As EventArgs) Handles btnCutomers.Click
        pnlMain.Controls.Clear()
        Dim frm As New frmCustomers()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlMain.Controls.Clear()
        Dim frm As New frmSessions()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub
End Class