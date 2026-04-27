Imports System.IO
Imports BusinessLayer_CyberCafe
Imports BusinessLayer_CyberCafe.CyberCafe.BusinessLayer
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms

Public Class frmLogin
    Private _loginTries As Integer = 5
    Const RELATIVE_FILE_PATH As String = "LocalSession.txt"

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBrand.EnableDragging()
        pnlLoginCard.EnableDragging()
        _LoadCredentialsFromFile()
    End Sub

    Private Sub _LoadCredentialsFromFile()

        If File.Exists(RELATIVE_FILE_PATH) Then

            Dim lines() As String = File.ReadAllLines(RELATIVE_FILE_PATH)

            If lines.Length >= 2 Then

                Dim username As String = lines(0)
                Dim password As String = lines(1)

                chkRememberMe.Checked = True

                txtUsername.Text = username
                txtPassword.Text = password

            End If

        End If

    End Sub

    Private Function areTextBoxesEmpty() As Boolean
        Return String.IsNullOrEmpty(txtPassword.Text) OrElse String.IsNullOrEmpty(txtUsername.Text)
    End Function

    Private Sub _HandleFailedLogin()
        _loginTries -= 1

        txtPassword.Clear()
        txtUsername.Clear()
        txtUsername.Focus()

        lblTries.Text = "Wrong Username or Password" & vbCrLf & "   Number of Tries Left: " & _loginTries.ToString() & " Left"

        If _loginTries = 0 Then


            _ShowGunaMessage("You have been blocked for 24 hours" & vbCrLf & "Contact your admin", "Too Many Failed Attempts", MessageDialogIcon.Error)
            Application.Exit()
            Return

        End If

        lblTries.Visible = True

    End Sub

    Private Sub _StoreLocalSession()
        Dim content = txtUsername.Text + vbNewLine + txtPassword.Text

        File.WriteAllText(RELATIVE_FILE_PATH, content)
    End Sub

    Private Sub _ClearFile()
        File.WriteAllText(RELATIVE_FILE_PATH, String.Empty)
    End Sub

    Private Sub _HandleSuccessfulLogin()
        DialogResult = DialogResult.OK

        _loginTries = 5

        If chkRememberMe.Checked Then
            _StoreLocalSession()
        Else
            _ClearFile()
        End If



        Close()
    End Sub

    Private Sub _ShowGunaMessage(message As String, caption As String, icon As MessageDialogIcon)
        Dim guna As New Guna2MessageDialog With {
            .Caption = caption,
            .Text = message,
            .Parent = System.Windows.Forms.Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = icon,
            .Buttons = MessageDialogButtons.OK
        }
        guna.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Dim frm As New frmDashboard()
        'frm.ShowDialog()
        If areTextBoxesEmpty() Then
            _ShowGunaMessage("Please Enter Your Username and Password First!", "Invalid Credential", MessageDialogIcon.Warning)
            Return
        End If

        Dim loginResult As LoginResultDTO = UserManager.AuthenticateUser(txtUsername.Text, txtPassword.Text)

        If loginResult.UserID Is Nothing Then
            _HandleFailedLogin()
            Return
        End If

        If loginResult.IsDeleted Then
            _ShowGunaMessage("Cannot login. User is deleted. Please contact your admin.", "Unauthorized Access", MessageDialogIcon.Error)
            Application.Exit()
            Return
        End If

        LoggedInUser.CurrentUser = UserManager.LoadUser(loginResult)

        _HandleSuccessfulLogin()
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.BackColor = ColorTranslator.FromHtml("#374151")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = ColorTranslator.FromHtml("#1F2937")
    End Sub

End Class
