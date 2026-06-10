Imports CyberCafeModels
Imports CyberCafe_DataAccess

Public Class TournamentMatchesServices


    Public Shared Function GenerateDraw(tournamentID As Integer) As Boolean

        Try

            Dim tournament = TournamentServices.Find(tournamentID)

            ValidateTournamentPlayers(tournamentID, tournament)

            Dim players = TournamentPlayersRepo.GetTournamentPlayersList(tournamentID)

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



    Private Shared Sub ValidateTournamentPlayers(tournamentID As Integer, tournament As TournamentDTO)

        Dim players = TournamentPlayersRepo.GetTournamentPlayersList(tournamentID)

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


            If matchResultDto.Score1 = matchResultDto.Score2 Then

                Throw New Exception("Ties are not allowed. One player must win!")

            End If


            Dim player1ID As Integer = match.Player1ID

            Dim player2ID As Integer = match.Player2ID

            Dim tournamentID As Integer = match.TournamentID

            Dim roundNumber As Byte = match.RoundNumber


            Dim winnerPlayerID As Integer = If(matchResultDto.Score1 > matchResultDto.Score2, player1ID, player2ID)

            matchResultDto.WinnerID = winnerPlayerID

            Dim success As Boolean = TournamentMatchesRepo.UpdateMatchResult(matchResultDto)


            If success Then

                ProcessRoundAdvancement(tournamentID, roundNumber)

            End If


            Return success

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function


    Private Shared Sub ProcessRoundAdvancement(tournamentID As Integer, currentRound As Byte)

        Try

            Dim dtMatches As DataTable = TournamentMatchesRepo.GetMatchesByRound(tournamentID, currentRound)

            If dtMatches Is Nothing OrElse dtMatches.Rows.Count = 0 Then
                Return
            End If


            For Each row As DataRow In dtMatches.Rows

                Dim status As Byte = CByte(row("MatchStatus"))

                If status <> CByte(enMatchStatus.Finished) Then

                    Return

                End If

            Next


            Dim winners As New List(Of Integer)()

            For Each row As DataRow In dtMatches.Rows

                If Not IsDBNull(row("WinnerPlayerID")) Then

                    winners.Add(CInt(row("WinnerPlayerID")))

                End If

            Next


            If winners.Count = 1 Then

                Dim finalWinnerID As Integer = winners(0)

                TournamentServices.UpdateTournamentStatus(tournamentID, enTournamentStatus.Finished)

                TournamentPlayersServices.SelectWinner(tournamentID, finalWinnerID)

            ElseIf winners.Count > 1 Then

                Dim nextRound As Byte = CByte(currentRound + 1)
                Dim nextRoundMatches = BracketGeneratorLogic.GenerateNextRoundMatches(tournamentID, nextRound, winners)

                TournamentMatchesRepo.SaveNextRoundMatchesTransaction(nextRoundMatches)

            End If


        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Sub



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