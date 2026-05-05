Imports System.Data.SqlClient
Imports CyberCafe_DataAccess
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class GameServices


    Public Shared Function AddGame(game As GameDTO) As Integer

        If game Is Nothing Then
            Throw New ArgumentNullException(NameOf(game))
        End If

        If String.IsNullOrWhiteSpace(game.GameName) Then
            Throw New ArgumentException("Game name is required")
        End If

        Try
            Return GameRepo.AddGame(game)

        Catch ex As SqlException

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            If ex.Number = 2601 OrElse ex.Number = 2627 Then
                Throw New InvalidOperationException("Game already exists")
            Else
                Throw
            End If

        End Try

    End Function

    Private Shared Sub ValidateDeviceTypeRemoval(game As GameDTO)

        Dim installedDeviceTypes =
        DeviceGameRepo.GetUsedDeviceTypesWhereGameInstalled(game.GameID)

        'Dim installedDeviceTypes As List(Of DeviceTypeDTO) = DeviceGameRepo.GetUsedDeviceTypesWhereGameInstalled(game.GameID)

        'Dim newDeviceTypesSet As New HashSet(Of Integer)(game.SupportedDevices)

        'Dim conflictingPlatforms As New List(Of String)

        'For Each installed In installedDeviceTypes

        '    If Not newDeviceTypesSet.Contains(installed.DeviceTypeID) Then

        '        conflictingPlatforms.Add(installed.DeviceTypeName)

        '    End If

        'Next

        Dim newDeviceTypesSet As New HashSet(Of Integer)(game.SupportedDevices)

        Dim conflictingPlatforms =
        installedDeviceTypes.
        Where(Function(dt) Not newDeviceTypesSet.Contains(dt.DeviceTypeID)).
        Select(Function(dt) dt.DeviceTypeName).
        ToList()

        If conflictingPlatforms.Count > 0 Then

            Dim platformsText = String.Join(Environment.NewLine, conflictingPlatforms)

            Dim message =
        "Cannot update game platforms." & Environment.NewLine &
        "The game is currently installed on the following platforms:" & Environment.NewLine &
        Environment.NewLine & platformsText & Environment.NewLine & Environment.NewLine &
        "Please remove the game from those devices first."

            Throw New InvalidOperationException(message)

        End If

    End Sub

    Public Shared Function UpdateGame(game As GameDTO) As Boolean

        If game Is Nothing Then
            Throw New ArgumentNullException(NameOf(game))
        End If

        If String.IsNullOrWhiteSpace(game.GameName) Then
            Throw New ArgumentException("Game name is required")
        End If

        ValidateDeviceTypeRemoval(game)

        Try

            Return GameRepo.UpdateGame(game)

        Catch ex As SqlException
            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            If ex.Number = 2601 OrElse ex.Number = 2627 Then
                Throw New InvalidOperationException("Game already exists")
            Else
                Throw
            End If
        End Try
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

    Public Shared Function GetImageFileName(GameID As Integer) As String

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
            Throw New Exception("Game does not exist")
        End If

        If GameRepo.IsGameAssignedToDevices(gameID) Then
            Throw New Exception("Could not Delete Game, Game is assigned to at least one device")
        End If

        Return GameRepo.DeleteGame(gameID)

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

End Class