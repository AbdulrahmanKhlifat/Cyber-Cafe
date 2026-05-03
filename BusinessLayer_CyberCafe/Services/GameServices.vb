Imports CyberCafe_DataAccess
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class GameServices


    Public Shared Function AddGame(game As GameDTO) As Boolean
        If game Is Nothing Then
            Return False
        End If

        If GameRepo.IsGameExists(game.GameName) Then
            Throw New Exception("Game already Exists")
        End If

        Dim newID = GameRepo.AddGame(game)
        Return newID <> -1
    End Function

    Public Shared Function UpdateGame(game As GameDTO) As Boolean

        If game Is Nothing Then
            Return False
        End If

        If Not GameRepo.IsGameExists(game.GameID) Then
            Throw New Exception("Game Does not Exists")
        End If

        Return GameRepo.UpdateGame(game)
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

    Public Shared Function GetGamesForDeviceUpdate(deviceID As Integer, deviceTypeID As Integer) As List(Of GameSelectionDTO)

        Return GameRepo.GetGamesForDeviceUpdate(deviceID, deviceTypeID)

    End Function

    Public Shared Function GetImagePath(GameID As Integer) As String
        If GameID <= 0 Then
            Return Nothing
        End If
        If Not GameRepo.IsGameExists(GameID) Then
            Throw New Exception("Game Does not Exists")
        End If
        Return GameRepo.GetImagePathByGameID(GameID)
    End Function

    Public Shared Function DeleteGame(gameID As Integer) As Boolean
        If gameID <= 0 Then
            Return False
        End If
        If Not GameRepo.IsGameExists(gameID) Then
            Throw New Exception("Game Does not Exists")
        End If
        Return GameRepo.DeleteGame(gameID)
    End Function

End Class