Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class TournamentServices

    Public Shared Function ValidateTournamentRegistration(customerID As Integer, requiredFee As Decimal) As RegistrationValidationResultDTO

        Dim result As New RegistrationValidationResultDTO()

        Dim customer = CustomerServices.Find(customerID)

        If customer Is Nothing Then

            result.IsValid = False
            result.Message = "Customer not found."

            Return result

        End If

        result.CustomerID = customer.UserID
        result.CustomerName = customer.Username

        Dim balance = CustomerServices.GetCustomerCreditBalance(customer.UserID)

        result.Balance = balance

        If balance >= requiredFee Then

            result.IsValid = True
            result.Message = "Sufficient balance. Ready to register."

        Else

            result.IsValid = False
            result.Message = "Insufficient balance! Please add funds."

        End If

        Return result

    End Function


    Public Shared Sub ValidateTournamentDTO(dto As TournamentDTO)

        If dto Is Nothing Then
            Throw New ArgumentNullException(NameOf(dto))
        End If


        If dto.TournamentName Is Nothing OrElse String.IsNullOrWhiteSpace(dto.TournamentName) Then
            Throw New ArgumentException("Tournament name cannot be empty")
        End If

        If dto.GameID <= 0 Then
            Throw New ArgumentException("Invalid GameID")
        End If

        If dto.EntryFee < 0 Then
            Throw New ArgumentException("Entry fee cannot be negative")
        End If

        If dto.PrizeAmount <= 0 Then
            Throw New ArgumentException("Prize amount must be greater than zero")
        End If

        If dto.MaxPlayers <= 1 Then
            Throw New ArgumentException("Max players must be greater than 1")
        End If

        If dto.TournamentTime <= DateTime.Now Then
            Throw New ArgumentException("Tournament time must be in the future")
        End If

    End Sub


    Public Shared Function Find(tournamentID As Integer) As TournamentDTO

        If tournamentID <= 0 Then
            Return Nothing
        End If

        Return TournamentRepo.GetTournamentByID(tournamentID)

    End Function

    Public Shared Function AddTournament(dto As TournamentDTO) As Boolean

        ValidateTournamentDTO(dto)

        Dim tournamentID As Integer = TournamentRepo.AddNewTournament(dto)

        Return tournamentID <> -1

    End Function

    Public Shared Function UpdateTournament(dto As TournamentDTO) As Boolean

        If dto Is Nothing Then
            Return False
        End If

        If dto.TournamentID <= 0 Then
            Return False
        End If

        Return TournamentRepo.UpdateTournament(dto)

    End Function

    Public Shared Function GetAllTournaments() As DataTable

        Return TournamentRepo.GetAllTournaments()

    End Function

    Public Shared Function UpdateTournamentStatus(tournamentID As Integer, status As enTournamentStatus) As Boolean

        If tournamentID <= 0 Then
            Return False
        End If

        If Not enTournamentStatus.IsDefined(GetType(enTournamentStatus), status) Then
            Return False
        End If

        Return TournamentRepo.UpdateTournamentStatus(tournamentID, CByte(status))

    End Function

    Public Shared Sub SoftDeleteTournament(tournamentID As Integer)

        If tournamentID <= 0 Then
            Throw New ArgumentException("Invalid TournamentID")

        End If

        Dim isDeleted As Boolean =
            TournamentRepo.SoftDeleteTournament(tournamentID)

        If Not isDeleted Then

            Throw New Exception("Tournament was not deleted")

        End If

    End Sub

End Class