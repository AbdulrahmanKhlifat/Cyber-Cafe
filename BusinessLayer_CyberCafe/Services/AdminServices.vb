Imports CyberCafeModels.CyberCafe.Models
Imports CyberCafe_DataAccess

Public Class AdminServices
    Public Shared Function AddAdmin(adminDTO As AdminDTO) As Boolean

        If AdminRepo.IsUsernameTaken(adminDTO.Username) Then
            Throw New Exception("Username already exists.")
        End If

        adminDTO.Password = HashUtility.ComputeHash(adminDTO.Password)

        Dim userID = AdminRepo.AddAdmin(adminDTO)

        Return userID <> -1
    End Function

    Public Shared Function UpdateAdmin(adminDTO As AdminDTO) As Boolean
        Dim existingAdmin = AdminRepo.GetAdminInfoByID(adminDTO.UserID)

        If existingAdmin Is Nothing Then Return False

        If Not Equals(existingAdmin.Username, adminDTO.Username) _
            AndAlso AdminRepo.IsUsernameTaken(adminDTO.Username) Then

            Throw New Exception("Username already exists")

        End If

        If Not String.IsNullOrEmpty(adminDTO.Password) Then

            adminDTO.Password = HashUtility.ComputeHash(adminDTO.Password)

        Else

            adminDTO.Password = existingAdmin.Password

        End If

        Return AdminRepo.UpdateAdmin(adminDTO)

    End Function

    Public Shared Function Find(userID As Integer) As AdminDTO

        Return AdminRepo.GetAdminInfoByID(userID)

    End Function

    Public Shared Function DeleteAdmin(userID As Integer) As Boolean

        Dim isDeleted As Boolean = AdminRepo.DeleteAdmin(userID)

        If Not isDeleted Then
            Throw New InvalidOperationException("Admin Does not exist!")
        End If

        Return True
    End Function

    Public Function IsUserExist(userID As Integer) As Boolean
        Return AdminRepo.IsAdminExistsByID(userID)
    End Function

    Public Function VerifyPassword(userID As Integer, password As String) As Boolean
        Dim admin = AdminRepo.GetAdminInfoByID(userID)

        If admin Is Nothing Then Throw New Exception("Admin Doesn not Exist!")

        If String.IsNullOrEmpty(password) Then
            Return False
        End If

        Return HashUtility.VerifyPassword(password, admin.Password)
    End Function

End Class
