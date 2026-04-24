Namespace CyberCafe.Models
    Public Class CustomerDTO
        Inherits UserDTO
        'Public Sub New(userid As Integer?, Name As String, Username As String, Password As String, email As String, phone As String, createdat As Date, credit As Decimal, totalhoursres As Integer, is)
        '    MyBase.New(userid, Name, Username, Password, 0, email, phone, IsActive)
        '    Me.CreatedAt = createdat
        '    Me.Credit = credit
        '    Me.TotalHoursRes = totalhoursres
        'End Sub

        Public Sub New()

        End Sub

        Public Property CreatedAt As Date
        Public Property Credit As Decimal
        Public Property TotalHoursRes As Integer
    End Class
End Namespace