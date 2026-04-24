Imports CyberCafeModels.CyberCafe.Models

Public Class AdminRepo
    Public Shared Function GetAdminByUserID(userID As Integer) As AdminDTO
        Dim adminDTO As AdminDTO = New AdminDTO
        adminDTO.RoleType = UserRoleType.Admin
        'call data access here

        Return adminDTO
    End Function

End Class
