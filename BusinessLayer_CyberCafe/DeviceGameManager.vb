Imports CyberCafe_DataAccess

Public Class DeviceGameManager

    Public Shared Function AddGameToDevice(deviceID As Integer, gameID As Integer) As Boolean
        If deviceID <= 0 OrElse gameID <= 0 Then
            Return False
        End If

        If DeviceGameRepo.IsGameExistInDevice(deviceID, gameID) Then
            Return False
        End If

        Return DeviceGameRepo.AddGameToDevice(deviceID, gameID)
    End Function

    Public Shared Function RemoveGameFromDevice(deviceID As Integer, gameID As Integer) As Boolean
        If deviceID <= 0 OrElse gameID <= 0 Then
            Return False
        End If
        Return DeviceGameRepo.RemoveGameFromDevice(deviceID, gameID)
    End Function
    Public Shared Function GetGamesByDeviceID(deviceID As Integer) As DataTable
        If deviceID <= 0 Then
            Return New DataTable()
        End If
        Return DeviceGameRepo.GetGamesByDeviceID(deviceID)
    End Function

    Public Shared Function GetAllDeviceGames(deviceID As Integer) As DataTable
        Return DeviceGameRepo.GetGamesByDeviceID(deviceID)
    End Function

    Public Shared Function UpdateDeviceGames(deviceID As Integer, selectedGameIDs As List(Of Integer)) As Boolean
        If deviceID <= 0 Then Return False

        If selectedGameIDs Is Nothing Then
            Return False
        End If

        Return DeviceGameRepo.UpdateDeviceGamesWithTransaction(deviceID, selectedGameIDs)
    End Function
End Class
