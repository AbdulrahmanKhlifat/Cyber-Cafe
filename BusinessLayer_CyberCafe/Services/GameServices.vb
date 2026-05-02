Imports CyberCafe_DataAccess
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class GameServices


    Public Shared Function AddGame(gameDTO As GameDTO) As Boolean
        If gameDTO Is Nothing Then
            Return False
        End If

        If GameRepo.IsGameExists(gameDTO.GameName) Then
            Throw New Exception("Game already Exists")
        End If

        Dim newID = GameRepo.AddGame(gameDTO)
        Return newID <> -1
    End Function

    Public Shared Function Find(gameID As Integer) As GameDTO
        If gameID <= 0 Then
            Return Nothing
        End If

        Return GameRepo.GetGameByID(gameID)
    End Function

    Public Shared Function GetAllGames() As List(Of GameDTO)
        Return GameRepo.GetAllGames()
    End Function

End Class