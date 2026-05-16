Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms

Module Program

    <STAThread>
    Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)



        If Environment.OSVersion.Version.Major >= 6 Then
            SetProcessDPIAware()
        End If

        Do

            Using frmLogin As New frmLogin()

                Dim result As DialogResult =
                frmLogin.ShowDialog()

                ' User closed login or cancelled
                If result <> DialogResult.OK Then
                    Exit Do
                End If

                ' Ensure user exists
                If LoggedInUser.CurrentUser Is Nothing Then
                    Exit Do
                End If

                Select Case LoggedInUser.CurrentUser.RoleType

                    Case UserRoleType.Admin

                        Dim admin As AdminDTO =
                        CType(LoggedInUser.CurrentUser,
                        AdminDTO)

                        Application.Run(
                        New frmAdminMain(admin)
                        )

                    Case UserRoleType.Customer

                        Dim customer As CustomerDTO = CType(LoggedInUser.CurrentUser, CustomerDTO)

                        'This is for Demo purposes, in a real application you would likely have a more complex main form for customers

                        SessionService.Initialize()

                        Dim activeSession As ActiveSession =
                            ActiveSessionsManager.
                            GetAllSessions().
                            FirstOrDefault(
                                Function(s)
                                    Return s.CustomerID = customer.UserID AndAlso
                                           s.Status = SessionStatus.Active
                                End Function
                            )

                        If activeSession Is Nothing Then
                            Using tempForm As New Form

                                tempForm.StartPosition =
                                FormStartPosition.CenterScreen

                                tempForm.Size = New Size(0, 0)

                                tempForm.ShowInTaskbar = False

                                tempForm.Opacity = 0

                                tempForm.Show()

                                Dim guna As New Guna2MessageDialog With {
                                    .Caption = "Error",
                                    .Text = "You currently have no active session.",
                                    .Style = MessageDialogStyle.Dark,
                                    .Icon = MessageDialogIcon.Information,
                                    .Buttons = MessageDialogButtons.OK,
                                    .Parent = tempForm
                                }

                                guna.Show()

                            End Using

                            Exit Do
                        End If

                        Application.Run(
                        New frmCustomerMain(activeSession)
                        )

                    Case Else

                        Exit Do

                End Select

            End Using
        Loop While LoggedInUser.CurrentUser Is Nothing

    End Sub

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Function SetProcessDPIAware() As Boolean
    End Function
End Module