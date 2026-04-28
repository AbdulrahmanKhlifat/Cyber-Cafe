Imports System.Runtime.CompilerServices
Imports CyberCafeModels.CyberCafe.Models

Public Class frmDashboard
    Private _admin As AdminDTO

    Private _LastButtonClicked As Button

    Public Sub New() 'admin As AdminDTO)
        InitializeComponent()
        _LastButtonClicked = New Button()
        '_admin = admin
    End Sub

    Private Sub _UpdateButtonColor(btn As Button)
        _LastButtonClicked.BackColor = Color.FromArgb(28, 33, 40)
        _LastButtonClicked = btn
        btn.BackColor = Color.FromArgb(0, 200, 160)
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClock.Start()
        pnlTopBar.EnableDragging()
        DisplayForm(New frmMainForm())
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss   ddd, MMM dd yyyy")
    End Sub

    Private Sub btnCloseWin_Click(sender As Object, e As EventArgs) Handles btnCloseWin.Click
        Me.Close()
    End Sub
    Private Sub DisplayForm(ByRef childForm As Form)
        pnlMain.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(childForm)
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnDevices_Click(sender As Object, e As EventArgs) Handles btnDevices.Click
        DisplayForm(New frmDevices())
    End Sub
    Private Sub btnCutomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        DisplayForm(New frmCustomers())
    End Sub
    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        DisplayForm(New frmTransactions())
    End Sub
    Private Sub btnSessions_Click(sender As Object, e As EventArgs) Handles btnSessions.Click
        DisplayForm(New frmSessions())
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        DisplayForm(New frmMainForm())
    End Sub
End Class