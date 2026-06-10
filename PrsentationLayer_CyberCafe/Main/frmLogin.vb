Imports System.IO
Imports BusinessLayer_CyberCafe
Imports BusinessLayer_CyberCafe.CyberCafe.BusinessLayer
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms

Public Class frmLogin
    Private Const LOGIN_TRIES_LIMIT As Integer = 5
    Private _loginTries As Integer = LOGIN_TRIES_LIMIT
    Const RELATIVE_FILE_PATH As String = "LocalSession.txt"

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlBrand.EnableDragging()
        pnlLoginCard.EnableDragging()

        'Clicking Enter triggers the btnLogin event
        Me.AcceptButton = btnLogin

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

    Private Sub _HandleFailedLogin(loginResults As LoginResultDTO)
        _loginTries -= 1

        txtPassword.Clear()
        txtUsername.Clear()
        txtUsername.Focus()

        If loginResults.IsDeleted Then
            MessageBox.Show(
                loginResults.Message & " Please Conatct Your Admin",
                "Unauthorized Access",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            Application.Exit()
        End If

        lblTries.Text = loginResults.Message & Environment.NewLine & "   Number of Tries Left: " & _loginTries.ToString() & " Left"

        If _loginTries = 0 Then


            UIHelper.ShowGunaMessage("You have been blocked for 24 hours" & vbCrLf & "Contact your admin", "Too Many Failed Attempts", MessageDialogIcon.Error)
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

        _loginTries = LOGIN_TRIES_LIMIT

        If chkRememberMe.Checked Then
            _StoreLocalSession()
        Else
            _ClearFile()
        End If

        Close()
    End Sub



    Private  Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If areTextBoxesEmpty() Then
            UIHelper.ShowGunaMessage("Please Enter Your Username and Password First!", "Invalid Credential", MessageDialogIcon.Warning)
            Return
        End If

        Dim loginResult As LoginResultDTO = UserServices.AuthenticateUser(txtUsername.Text, txtPassword.Text)

        If Not loginResult.IsAuthenticated Then
            _HandleFailedLogin(loginResult)
            Return
        End If

        LoggedInUser.CurrentUser = UserServices.LoadUser(loginResult.UserID, loginResult.Role)

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
