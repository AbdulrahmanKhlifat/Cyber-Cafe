Imports CyberCafe_DataAccess.CyberCafe.DAL
Imports CyberCafeModels.CyberCafe.Models

Namespace CyberCafe.BusinessLayer
    Public Class UserManager

        Public Shared Function AuthenticateUser(username As String, password As String) As LoginResultDTO
            Dim user As UserDTO = UserRepo.GetLoginInfoByUsername(username)

            Dim loginResults As New LoginResultDTO

            If user Is Nothing Then
                loginResults.IsAuthenticated = False
                loginResults.Message = "Invalid username or password"

                Return loginResults
            End If

            If user.IsDeleted Then

                loginResults.IsAuthenticated = False
                loginResults.Message = "Account is disabled"

                Return loginResults
            End If

            If Not HashUtility.VerifyPassword(password, user.Password) Then

                loginResults.IsAuthenticated = False
                loginResults.Message = "Invalid username or password"

                Return loginResults
            End If

            loginResults.IsAuthenticated = True
            loginResults.UserID = user.UserID
            loginResults.Role = user.RoleType

            Return loginResults

        End Function

        Public Shared Function LoadUser(userID As Integer, role As UserRoleType) As UserDTO

            Select Case role

                Case UserRoleType.Admin
                    Return AdminManager.Find(userID)

                Case UserRoleType.Customer
                    Return CustomerManager.Find(userID)

                Case Else
                    Return Nothing

            End Select

        End Function

    End Class
End Namespace