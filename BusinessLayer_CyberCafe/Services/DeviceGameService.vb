Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class DeviceGameService

    Public Shared Function Assign(deviceID As Integer, gameID As Integer) As Boolean
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

    Public Shared Function GetGamesByDeviceID(deviceID As Integer) As List(Of GameDTO)

        If deviceID <= 0 Then
            Return Nothing
        End If

        Return DeviceGameRepo.GetGamesByDeviceID(deviceID)
    End Function

    Public Shared Function SetDeviceGames(deviceID As Integer, selectedGameIDs As List(Of Integer)) As Boolean
        If deviceID <= 0 Then Return False

        If selectedGameIDs Is Nothing Then
            Return False
        End If

        Return DeviceGameRepo.UpdateDeviceGames(deviceID, selectedGameIDs)
    End Function
End Class
