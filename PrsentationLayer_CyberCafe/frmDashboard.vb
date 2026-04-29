Imports System.Runtime.CompilerServices
Imports CyberCafeModels.CyberCafe.Models

Public Class frmDashboard
    Private _admin As AdminDTO

    Private _LastButtonClicked As Button

    Public Sub New(admin As AdminDTO)
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
        ChangeForm(New frmMainForm())
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss   ddd, MMM dd yyyy")
    End Sub

    Private Sub btnCloseWin_Click(sender As Object, e As EventArgs) Handles btnCloseWin.Click
        Me.Close()
    End Sub

    Private Sub ChangeForm(frm As Form)
        If pnlMain.Controls.Count > 0 Then
            pnlMain.Controls.RemoveAt(0)
        End If

        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        pnlMain.Controls.Add(frm)

        frm.Show()
    End Sub
    Private Sub btnDevices_Click(sender As Object, e As EventArgs) Handles btnDevices.Click
        ChangeForm(New frmDevices())
        _UpdateButtonColor(btnDevices)
    End Sub
    Private Sub btnCutomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ChangeForm(New frmCustomers())
        _UpdateButtonColor(btnCustomers)

    End Sub
    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        ChangeForm(New frmTransactions())
        _UpdateButtonColor(btnTransactions)

    End Sub
    Private Sub btnSessions_Click(sender As Object, e As EventArgs) Handles btnSessions.Click
        ChangeForm(New frmSessions())
        _UpdateButtonColor(btnSessions)

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ChangeForm(New frmMainForm())
        _UpdateButtonColor(btnDashboard)

    End Sub

End Class