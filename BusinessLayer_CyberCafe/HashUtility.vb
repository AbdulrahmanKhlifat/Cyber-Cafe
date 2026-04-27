Imports System.Security.Cryptography
Imports System.Text

Public Class HashUtility

    'Friend Shared Function ComputeHash(input As String) As String
    '    Using sha256Hash As SHA256 = SHA256.Create()
    '        Dim bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

    '        Dim builder As StringBuilder = New StringBuilder()
    '        For i = 0 To bytes.Length - 1
    '            builder.Append(bytes(i).ToString("x2"))
    '        Next
    '        Return builder.ToString()
    '    End Using
    'End Function

    Friend Shared Function ComputeHash(password As String) As String

        Return BCrypt.Net.BCrypt.HashPassword(password, workFactor:=12)

    End Function

    Public Shared Function VerifyPassword(
        password As String,
        storedHash As String) As Boolean

        Return BCrypt.Net.BCrypt.Verify(
            password,
            storedHash)

    End Function


End Class
