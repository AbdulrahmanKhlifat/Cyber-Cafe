Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models


Public Class frmCustomerMain


    Private ReadOnly _SessionID As Integer

    Private _SessionDto As ActiveSession

    Private _LastButtonClicked As Button

    Private WithEvents tmrSessionRefresh As New Timer()


    Public Sub New(activeSession As ActiveSession)

        InitializeComponent()

        _SessionID = activeSession.SessionID

        _SessionDto = activeSession

    End Sub

    Private Sub tmrSessionRefresh_Tick(sender As Object, e As EventArgs) Handles tmrSessionRefresh.Tick

        RefreshRemainingTime()

    End Sub

    Private Sub RefreshCustomerCredit()

        If _SessionDto Is Nothing Then
            Return
        End If

        Dim creditBalance As Decimal = CustomerServices.GetCustomerCreditBalance(_SessionDto.CustomerID)

        lblCredit.Text =
        $"🧾 Credit: { creditBalance:0.00}$"

    End Sub

    Private Sub RefreshRemainingTime()

        If _SessionDto Is Nothing Then
            Return
        End If

        Dim remaining As TimeSpan =
        TimeSpan.FromSeconds(
            _SessionDto.RemainingSeconds
        )

        lblClock.Text =
        $"Session Remaining: {remaining:hh\:mm\:ss}"

        Select Case _SessionDto.RemainingSeconds

            Case <= 300 ' 5 minutes

                lblClock.ForeColor =
                Color.FromArgb(255, 80, 80)

            Case <= 600 ' 10 minutes

                lblClock.ForeColor =
                Color.Gold

            Case Else

                lblClock.ForeColor =
                Color.FromArgb(0, 220, 160)

        End Select

    End Sub

    Private Sub frmCustomerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChangeForm(New frmGameLauncher(_SessionDto))
        _UpdateButtonColor(btnGameLauncher)

        tmrSessionRefresh.Interval = 1000
        tmrSessionRefresh.Start()

        Try

            RefreshCustomerCredit()

            _SessionDto = ActiveSessionsManager.GetSession(_SessionID)


        Catch ex As Exception

            If _SessionDto Is Nothing OrElse _SessionDto.Status <> SessionStatus.Active Then
                UIHelper.ShowGunaMessage("You Currently Have No Active Session.", "Error", Guna.UI2.WinForms.MessageDialogIcon.Information)
                Me.Close()
                Return
            End If

            UIHelper.ShowGunaMessage(
                "An error occurred while refreshing session data. Please try again later.",
                "Error",
                Guna.UI2.WinForms.MessageDialogIcon.Error
            )

            ErrorLogger.LogErrorToFile(ex, MethodBase.GetCurrentMethod().Name)

        End Try

        Me.CenterToParent()
        pnlTopBar.EnableDragging()

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

        Dim frm As New frmCustomerCart(
        _SessionDto.CustomerID,
        _SessionDto.SessionID
    )

        AddHandler frm.PurchaseCompleted,
        Sub()

            RefreshCustomerCredit()

        End Sub

        ChangeForm(frm)

        _UpdateButtonColor(btnCart)

    End Sub

    Private Sub btnCloseWin_Click(sender As Object, e As EventArgs) Handles btnCloseWin.Click
        Me.Close()
    End Sub

    Private Sub btnGameLauncher_Click(sender As Object, e As EventArgs) Handles btnGameLauncher.Click
        ChangeForm(New frmGameLauncher(_SessionDto))
        _UpdateButtonColor(btnGameLauncher)
    End Sub

    Private Sub frmCustomerMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        tmrSessionRefresh.Stop()

    End Sub
    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click



        Using frmShowCustomerDetails As New frmShowCustomerDetails(_SessionDto.CustomerID)
            frmShowCustomerDetails.ShowDialog()
        End Using

    End Sub


End Class