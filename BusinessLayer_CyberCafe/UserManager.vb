Imports System.Security.Cryptography
Imports System.Text
Imports CyberCafe_DataAccess.CyberCafe.DAL
Imports CyberCafeModels.CyberCafe.Models

Namespace CyberCafe.BusinessLayer
    Public Class UserManager

        Private Shared Function ComputeHash(input As String) As String
            Using sha256Hash As SHA256 = SHA256.Create()
                Dim bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

                Dim builder As StringBuilder = New StringBuilder()
                For i = 0 To bytes.Length - 1
                    builder.Append(bytes(i).ToString("x2"))
                Next
                Return builder.ToString()
            End Using
        End Function

        Public Shared Function AuthenticateUser(username As String, password As String) As LoginResultDTO
            Dim passwordHash As String = ComputeHash(password)

            Dim loginResults As LoginResultDTO = UserRepo.CheckCredentials(username, passwordHash)

            Return loginResults

        End Function


        Public Shared Function LoadUser(loginResult As LoginResultDTO) As UserDTO

            Select Case loginResult.Role

                Case UserRoleType.Admin
                    Return AdminRepo.GetAdminByUserID(
                        loginResult.UserID)

                Case UserRoleType.Customer
                    Return CustomerRepo.GetCustomerByUserID(
                        loginResult.UserID)

                Case Else
                    Return Nothing

            End Select

        End Function

    End Class
End Namespace