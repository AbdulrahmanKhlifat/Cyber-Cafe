Imports System.Runtime.CompilerServices
Imports CyberCafeModels.CyberCafe.Models

Public Class frmDashboard
    Private _admin As AdminDTO

    Private _LastButtonClicked As Button

    Public Sub New(admin As AdminDTO)
        InitializeComponent()
        _LastButtonClicked = New Button()
        _admin = admin
    End Sub

    Private Sub _UpdateButtonColor(btn As Button)
        _LastButtonClicked.BackColor = Color.FromArgb(28, 33, 40)
        _LastButtonClicked = btn
        btn.BackColor = Color.FromArgb(0, 200, 160)
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClock.Start()
        pnlTopBar.EnableDragging()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss   ddd, MMM dd yyyy")
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
        _UpdateButtonColor(btnDevices)
    End Sub

    Private Sub btnCutomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        pnlMain.Controls.Clear()
        Dim frm As New frmCustomers()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
        _UpdateButtonColor(btnCustomers)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSessions.Click
        pnlMain.Controls.Clear()
        Dim frm As New frmSessions()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlMain.Controls.Clear()
        Dim frm As New frmMainForm()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        pnlMain.Controls.Clear()
        Dim frm As New frmTransactions()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub
End Class