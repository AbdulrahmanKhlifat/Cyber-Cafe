Imports CyberCafeModels

Public Class BracketGeneratorLogic

    Private Shared ReadOnly _rand As New Random()

    Public Shared Function GenerateFirstRoundMatches(tournamentID As Integer, players As List(Of TournamentPlayerDTO)) As List(Of TournamentMatchDTO)

        Dim shuffledPlayers = players.OrderBy(Function(p) _rand.Next()).ToList()
        Dim paddedPlayers = PadPlayersToPowerOfTwo(shuffledPlayers)

        Dim matches As New List(Of TournamentMatchDTO)
        Dim matchOrder As Integer = 1

        For i As Integer = 0 To paddedPlayers.Count - 1 Step 2

            Dim p1 = paddedPlayers(i)
            Dim p2 = paddedPlayers(i + 1)

            Dim match As New TournamentMatchDTO With {
                .TournamentID = tournamentID,
                .RoundNumber = 1,
                .MatchOrder = matchOrder,
                .CreatedDate = DateTime.Now,
                .IsDeleted = False
            }

            If p1 IsNot Nothing Then

                match.Player1ID = p1.CustomerID

            End If

            If p2 IsNot Nothing Then

                match.Player2ID = p2.CustomerID

            End If

            If p1 IsNot Nothing AndAlso p2 Is Nothing Then

                match.WinnerPlayerID = p1.CustomerID
                match.MatchStatus = enMatchStatus.Finished

            ElseIf p2 IsNot Nothing AndAlso p1 Is Nothing Then

                match.WinnerPlayerID = p2.CustomerID
                match.MatchStatus = enMatchStatus.Finished

            Else

                match.MatchStatus = enMatchStatus.Upcoming

            End If

            matches.Add(match)
            matchOrder += 1

        Next

        Return matches
    End Function

    Public Shared Function GenerateNextRoundMatches(tournamentID As Integer, nextRoundNumber As Byte, winners As List(Of Integer)) As List(Of TournamentMatchDTO)

        Dim matches As New List(Of TournamentMatchDTO)
        Dim matchOrder As Integer = 1

        For i As Integer = 0 To winners.Count - 1 Step 2

            Dim match As New TournamentMatchDTO With {
                .TournamentID = tournamentID,
                .RoundNumber = nextRoundNumber,
                .MatchOrder = matchOrder,
                .CreatedDate = DateTime.Now,
                .IsDeleted = False
            }

            match.Player1ID = winners(i)

            If i + 1 < winners.Count Then

                match.Player2ID = winners(i + 1)
                match.MatchStatus = enMatchStatus.Upcoming

            Else

                match.WinnerPlayerID = winners(i)
                match.MatchStatus = enMatchStatus.Finished

            End If

            matches.Add(match)
            matchOrder += 1

        Next

        Return matches

    End Function

    Private Shared Function PadPlayersToPowerOfTwo(players As List(Of TournamentPlayerDTO)) As List(Of TournamentPlayerDTO)

        Dim count As Integer = players.Count
        Dim powerOfTwo As Integer = 1

        While powerOfTwo < count
            powerOfTwo *= 2
        End While

        Dim paddedList As New List(Of TournamentPlayerDTO)(players)


        While paddedList.Count < powerOfTwo

            paddedList.Add(Nothing)

        End While

        Return paddedList

    End Function

End Class
