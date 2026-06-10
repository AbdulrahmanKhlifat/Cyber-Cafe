Public Class TournamentDTO

    Public Property TournamentID As Integer

    Public Property TournamentName As String

    Public Property GameID As Integer

    Public Property GameName As String

    Public Property TournamentTime As DateTime

    Public Property ExpectedEndTime As DateTime

    Public Property EntryFee As Decimal

    Public Property PrizeAmount As Decimal

    Public Property MaxPlayers As Short

    Public ReadOnly Property CurrentPlayers As Short

    Public Property TournamentStatus As enTournamentStatus

    Public Property CreatedByAdminID As Integer

    Public Property CreatedDate As DateTime

    Public Property IsDeleted As Boolean

End Class