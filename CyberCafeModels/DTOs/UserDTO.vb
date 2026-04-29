Namespace CyberCafe.Models
    Public Class UserDTO
        Public Sub New(userid As Integer?, name As String, username As String, password As String, roletype As Byte, email As String, phone As String, isDeleted As Boolean)
            Me.UserID = userid
            Me.Name = name
            Me.Username = username
            Me.Password = password
            Me.RoleType = roletype
            Me.IsDeleted = isDeleted
            Me.Email = email
            Me.Phone = phone
        End Sub

        Public Sub New()

        End Sub

        Public Property UserID As Integer?
        Public Property Name As String
        Public Property Username As String
        Public Property Password As String
        Public Property RoleType As UserRoleType
        Public Property IsDeleted As Boolean
        Public Property Email As String
        Public Property Phone As String

    End Class
End Namespace