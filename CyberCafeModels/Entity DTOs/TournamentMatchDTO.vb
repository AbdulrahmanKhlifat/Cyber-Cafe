Public Class TournamentMatchDTO

    Public Property MatchID As Integer

    Public Property TournamentID As Integer

    Public Property RoundNumber As Byte

    Public Property MatchOrder As Integer

    Public Property Player1ID As Nullable(Of Integer)

    Public Property Player2ID As Nullable(Of Integer)

    Public Property Player1Name As String

    Public Property Player2Name As String

    Public Property Player1Score As Nullable(Of Byte)

    Public Property Player2Score As Nullable(Of Byte)

    Public Property WinnerPlayerID As Nullable(Of Integer)

    Public Property MatchStatus As enMatchStatus

    Public Property ScheduledTime As Nullable(Of DateTime)

    Public Property CreatedDate As DateTime

    Public Property IsDeleted As Boolean

End Class
