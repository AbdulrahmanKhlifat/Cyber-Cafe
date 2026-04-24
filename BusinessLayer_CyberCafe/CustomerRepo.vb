Imports CyberCafeModels.CyberCafe.Models

Public Class CustomerRepo
    Public Shared Function GetCustomerByUserID(userID As Integer) As CustomerDTO
        Dim customerDTO As CustomerDTO = New CustomerDTO
        customerDTO.RoleType = UserRoleType.Customer
        'call data access here

        Return customerDTO
    End Function
End Class
