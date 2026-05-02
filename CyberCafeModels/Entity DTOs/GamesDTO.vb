Public Class GameDTO
    Public Property GameID As Integer
    Public Property GameName As String
    Public Property ImagePath As String

    Public SupportedDevices As List(Of Integer)

    Public Sub New()
        SupportedDevices = New List(Of Integer)()
    End Sub

End Class