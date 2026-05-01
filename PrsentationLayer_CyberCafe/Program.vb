Imports BusinessLayer_CyberCafe
Imports CyberCafeModels.CyberCafe.Models

Module Program

    <STAThread>
    Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)


        'Using frm As New frmDashboard()
        '    Application.Run(frm)
        'End Using
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
                            New frmDashboard(admin)
                        )

                    Case UserRoleType.Customer

                        Dim customer As CustomerDTO =
                            CType(LoggedInUser.CurrentUser,
                                  CustomerDTO)

                        Application.Run(
                            New frmCustomerMain(customer)
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