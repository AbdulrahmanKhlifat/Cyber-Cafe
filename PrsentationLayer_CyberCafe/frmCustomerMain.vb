Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class frmCustomerMain


    Private ReadOnly _SessionID As Integer

    Private _SessionDto As ActiveSession

    Private _LastButtonClicked As Button

    Public Sub New(activeSession As ActiveSession)

        InitializeComponent()

        _SessionID = activeSession.SessionID

    End Sub
    Private Sub frmCustomerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            _SessionDto = ActiveSessionsManager.GetSession(_SessionID)

        Catch ex As Exception

            If _SessionDto Is Nothing OrElse _SessionDto.Status <> SessionStatus.Active Then
                UIHelper.ShowGunaMessage("You Currently Have No Active Session.", "Error", Guna.UI2.WinForms.MessageDialogIcon.Information)
                Me.Close()
                Return
            End If

        End Try

        Me.CenterToParent()
        pnlTopBar.EnableDragging()

        lblClock.Text = DateTime.Now.ToString("HH:mm:ss   ddd, MMM dd yyyy")
    End Sub
    Private Sub _UpdateButtonColor(btn As Button)


        If _LastButtonClicked IsNot Nothing Then
            _LastButtonClicked.BackColor = Color.FromArgb(28, 33, 40)
            _LastButtonClicked.ForeColor = Color.FromArgb(148, 163, 184)
        End If


        btn.BackColor = Color.FromArgb(0, 200, 160)
        btn.ForeColor = Color.FromArgb(15, 23, 42)


        _LastButtonClicked = btn

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

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click

        ChangeForm(New frmCustomerCart(_SessionDto.CustomerID, _SessionDto.SessionID))
        _UpdateButtonColor(btnCart)

    End Sub

    Private Sub btnCloseWin_Click(sender As Object, e As EventArgs) Handles btnCloseWin.Click
        Me.Close()
    End Sub

End Class