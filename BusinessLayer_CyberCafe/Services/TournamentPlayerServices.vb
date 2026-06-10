Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class TournamentPlayersServices

    Public Shared Function RegisterPlayer(tournamentID As Integer, customerID As Integer, adminID As Integer) As Boolean

        Dim tournament = TournamentServices.Find(tournamentID)


        If customerID <= 0 Then
            Throw New ArgumentException("Invalid customer ID.")
        End If

        If adminID <= 0 Then
            Throw New ArgumentException("Invalid admin ID.")
        End If

        If tournament Is Nothing Then
            Throw New InvalidOperationException("Tournament not found.")
        End If

        If tournament.TournamentStatus <> enTournamentStatus.Upcoming Then
            Throw New InvalidOperationException("Registration is closed.")
        End If

        If TournamentPlayersRepo.IsPlayerRegistered(tournamentID, customerID) Then

            Throw New InvalidOperationException("Player already registered.")

        End If

        Dim registeredPlayers As Integer = TournamentPlayersRepo.GetRegisteredPlayersCount(tournamentID)

        If registeredPlayers >= tournament.MaxPlayers Then

            Throw New InvalidOperationException("Tournament is full.")

        End If

        Return TournamentPlayersRepo.RegisterPlayerTransaction(tournamentID, customerID, adminID, tournament.EntryFee)

    End Function

    Public Shared Function GetTournamentPlayers(tournamentID As Integer) As DataTable

        If tournamentID <= 0 Then

            Throw New ArgumentException("Invalid tournament ID.")

        End If

        Return TournamentPlayersRepo.GetTournamentPlayers(tournamentID)

    End Function

    Public Shared Function RemovePlayer(tournamentPlayerID As Integer) As Boolean

        If tournamentPlayerID <= 0 Then

            Throw New ArgumentException("Invalid Player ID.")

        End If

        Return TournamentPlayersRepo.RemovePlayer(tournamentPlayerID)

    End Function

    Public Shared Function SelectWinner(tournamentID As Integer, customerID As Integer) As Boolean

        If tournamentID <= 0 Then

            Throw New ArgumentException("Invalid tournament ID.")

        End If

        If customerID <= 0 Then

            Throw New ArgumentException("Invalid customer ID.")

        End If

        Return TournamentPlayersRepo.SelectWinner(tournamentID, customerID)

    End Function

End Class