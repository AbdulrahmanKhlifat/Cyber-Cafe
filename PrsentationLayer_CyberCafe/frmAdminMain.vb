Imports System.Runtime.CompilerServices
Imports CyberCafeModels.CyberCafe.Models

Public Class frmAdminMain

    Private _admin As AdminDTO

    Private _LastButtonClicked As Button

    Public Sub New(admin As AdminDTO)

        InitializeComponent()
        _LastButtonClicked = New Button()
        _admin = admin
        _UpdateButtonColor(btnDashboard)
    End Sub

    Private Sub _UpdateButtonColor(btn As Button)

        ' 1. Reset the previously clicked button (Only if it exists to prevent a crash)
        If _LastButtonClicked IsNot Nothing Then
            _LastButtonClicked.BackColor = Color.FromArgb(28, 33, 40)
            _LastButtonClicked.ForeColor = Color.FromArgb(148, 163, 184) ' Slate Gray Text
        End If

        ' 2. Highlight the newly clicked button
        btn.BackColor = Color.FromArgb(0, 200, 160)
        btn.ForeColor = Color.FromArgb(15, 23, 42) ' Dark Slate Text for contrast

        ' 3. Update the tracker
        _LastButtonClicked = btn

    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tmrClock.Start()
        pnlTopBar.EnableDragging()
        ChangeForm(New frmDashboard())
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
        ChangeForm(New frmDashboard())
        _UpdateButtonColor(btnDashboard)

    End Sub

    Private Sub btnMinWin_Click(sender As Object, e As EventArgs) Handles btnMinWin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeForm(New frmGameLibrary)
        _UpdateButtonColor(Button1)
    End Sub
End Class