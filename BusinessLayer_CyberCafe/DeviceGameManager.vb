Imports CyberCafe_DataAccess

Public Class DeviceGameManager

    Public Shared Function AddGameToDevice(deviceID As Integer, gameID As Integer) As Boolean
        Return DeviceGameRepo.AddGameToDevice(deviceID, gameID)
    End Function

    Public Shared Function RemoveGameFromDevice(deviceID As Integer, gameID As Integer) As Boolean
        Return DeviceGameRepo.RemoveGameFromDevice(deviceID, gameID)
    End Function
    Public Shared Function GetGamesByDeviceID(deviceID As Integer) As DataTable
        Return DeviceGameRepo.GetGamesByDeviceID(deviceID)
    End Function

    Public Shared Function GetAllDeviceGames(deviceID As Integer) As DataTable
        Return DeviceGameRepo.GetGamesByDeviceID(deviceID)
    End Function

    Public Shared Function UpdateDeviceGames(deviceID As Integer, selectedGameIDs As List(Of Integer)) As Boolean

        DeviceGameRepo.RemoveAllGamesFromDevice(deviceID)
        For Each gameID In selectedGameIDs
            If Not DeviceGameRepo.AddGameToDevice(deviceID, gameID) Then
                Return False
            End If
        Next
        Return True
    End Function
End Class
