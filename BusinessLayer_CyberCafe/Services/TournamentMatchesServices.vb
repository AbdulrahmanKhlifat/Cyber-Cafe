Imports CyberCafeModels
Imports CyberCafe_DataAccess

Public Class TournamentMatchesServices


    Public Shared Function GenerateDraw(tournamentID As Integer) As Boolean

        Try

            Dim tournament = TournamentServices.Find(tournamentID)


            Dim players = TournamentPlayersRepo.GetTournamentPlayersList(tournamentID)

            ValidateTournamentPlayers(players, tournament)

            Dim initialMatches = BracketGeneratorLogic.GenerateFirstRoundMatches(tournamentID, players)

            Return TournamentMatchesRepo.SaveDrawTransaction(tournamentID, initialMatches, enTournamentStatus.DrawGenerated)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function



    Public Shared Function GetTournamentMatches(tournamentID As Integer) As DataTable

        Try

            Return TournamentMatchesRepo.GetTournamentMatches(tournamentID)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function

    Public Shared Function GetTournamentMatchesList(tournamentID As Integer) As List(Of TournamentMatchDTO)
        Try

            Return TournamentMatchesRepo.GetTournamentMatchesList(tournamentID)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            Throw

        End Try

    End Function


    Public Shared Function UpdateMatchResult(matchResult As MatchResultDTO) As Boolean

        Try

            Return TournamentMatchesRepo.UpdateMatchResult(matchResult)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function



    Public Shared Function HasTournamentDraw(tournamentID As Integer) As Boolean

        Try

            Return TournamentMatchesRepo.HasTournamentDraw(tournamentID)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function

    Public Shared Function DeleteTournamentDraw(tournamentID As Integer) As Boolean

        Try

            Return TournamentMatchesRepo.DeleteTournamentDraw(tournamentID)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function



    Private Shared Sub ValidateTournamentPlayers(players As List(Of TournamentPlayerDTO), tournament As TournamentDTO)


        Dim minimumPlayers As Integer = tournament.MaxPlayers \ 2

        If players Is Nothing OrElse players.Count < minimumPlayers Then

            Throw New Exception($"Minimum of {minimumPlayers} players required to generate draw!")

        End If

    End Sub





    Public Shared Function GetMatchByID(matchID As Integer) As TournamentMatchDTO

        Dim match = TournamentMatchesRepo.GetMatchByID(matchID)

        If match Is Nothing Then
            Return Nothing
        End If

        Return match

    End Function

    Public Shared Function SaveMatchResult(matchResultDto As MatchResultDTO) As Boolean

        Try

            Dim match = GetMatchByID(matchResultDto.MatchID)

            If match Is Nothing Then

                Throw New Exception("Match not found!")

            End If



            If Not match.Player1ID.HasValue OrElse Not match.Player2ID.HasValue Then

                Throw New InvalidOperationException("This match is a BYE and is resolved automatically. It cannot have a manual result.")

            End If

            If matchResultDto.Score1 = matchResultDto.Score2 Then

                Throw New Exception("Ties are not allowed. One player must win!")

            End If


            Dim player1ID As Integer = match.Player1ID.Value

            Dim player2ID As Integer = match.Player2ID.Value

            Dim tournamentID As Integer = match.TournamentID

            Dim roundNumber As Byte = match.RoundNumber


            Dim winnerPlayerID As Integer = If(matchResultDto.Score1 > matchResultDto.Score2, player1ID, player2ID)


            matchResultDto.WinnerID = winnerPlayerID

            Dim advancement = ComputeRoundAdvancement(tournamentID, roundNumber, matchResultDto.MatchID, winnerPlayerID)

            TournamentPlayersRepo.SelectWinner(tournamentID, winnerPlayerID)

            Return TournamentMatchesRepo.SaveMatchResultAndAdvanceTransaction(
                matchResultDto,
                tournamentID,
                advancement.NextRoundMatches,
                advancement.FinalWinnerCustomerID)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function


    Private Class RoundAdvancementResult
        Public Property NextRoundMatches As List(Of TournamentMatchDTO)
        Public Property FinalWinnerCustomerID As Integer?
    End Class

    ''' <summary>
    ''' Looks at the OTHER already-finished matches in the same round (the current
    ''' match's result is passed in directly since it hasn't been saved yet) and
    ''' decides whether the round is complete, and if so, whether the tournament
    ''' is finished or a new round needs to be generated. Pure decision logic —
    ''' no writes happen here.
    ''' </summary>
    Private Shared Function ComputeRoundAdvancement(tournamentID As Integer, currentRound As Byte, currentMatchID As Integer, currentMatchWinnerID As Integer) As RoundAdvancementResult

        Dim result As New RoundAdvancementResult()

        Dim dtMatches As DataTable = TournamentMatchesRepo.GetMatchesByRound(tournamentID, currentRound)

        If dtMatches Is Nothing OrElse dtMatches.Rows.Count = 0 Then
            Return result
        End If

        Dim winners As New List(Of Integer)()

        For Each row As DataRow In dtMatches.Rows

            Dim rowMatchID As Integer = CInt(row("MatchID"))

            If rowMatchID = currentMatchID Then

                ' This is the match being saved right now — use the winner we just computed,
                ' since the DB row doesn't reflect it yet.
                winners.Add(currentMatchWinnerID)
                Continue For

            End If

            Dim status As Byte = CByte(row("MatchStatus"))

            If status <> CByte(enMatchStatus.Finished) Then

                ' Round isn't complete yet — nothing to do.
                Return result

            End If

            If Not IsDBNull(row("WinnerPlayerID")) Then

                winners.Add(CInt(row("WinnerPlayerID")))

            End If

        Next

        If winners.Count = 1 Then

            result.FinalWinnerCustomerID = winners(0)

        ElseIf winners.Count > 1 Then

            Dim nextRound As Byte = CByte(currentRound + 1)
            result.NextRoundMatches = BracketGeneratorLogic.GenerateNextRoundMatches(tournamentID, nextRound, winners)

        End If

        Return result

    End Function



    Public Shared Function GetTournamentResults(tournamentID As Integer) As DataTable

        Try

            Return TournamentMatchesRepo.GetTournamentResults(tournamentID)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function



    Public Shared Function GetTournamentWinner(tournamentID As Integer) As DataRow

        Try

            Dim dt As DataTable = TournamentMatchesRepo.GetTournamentWinner(tournamentID)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                Return dt.Rows(0)

            End If

            Return Nothing

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function


End Class