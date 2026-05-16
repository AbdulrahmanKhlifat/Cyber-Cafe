Imports CyberCafe_DataAccess.CyberCafe.DAL
Imports CyberCafeModels.CyberCafe.Models

Namespace CyberCafe.BusinessLayer
    Public Class UserServices

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
                loginResults.IsDeleted = True

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
            loginResults.IsDeleted = False
            Return loginResults

        End Function

        Public Shared Function LoadUser(userID As Integer, role As UserRoleType) As UserDTO

            Select Case role

                Case UserRoleType.Admin
                    Return AdminServices.Find(userID)

                Case UserRoleType.Customer
                    Return CustomerServices.Find(userID)

                Case Else
                    Return Nothing

            End Select

        End Function

        Public Shared Function GetUserNameByID(userID As Integer, role As UserRoleType) As String

            Dim user As UserDTO = LoadUser(userID, role)

            If user IsNot Nothing Then
                Return user.Username
            End If

            Return String.Empty

        End Function

    End Class

End Namespace