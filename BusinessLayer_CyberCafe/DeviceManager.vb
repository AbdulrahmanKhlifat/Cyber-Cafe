Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class DeviceManager

    Public Shared Function AddDevice(dto As DeviceDTO) As Boolean
        If dto Is Nothing OrElse String.IsNullOrWhiteSpace(dto.DeviceName) Then
            Return False
        End If

        Dim deviceID = DeviceRepo.AddNewDevice(dto)
        Return deviceID <> -1
    End Function

    Public Shared Function UpdateDevice(dto As DeviceDTO) As Boolean
        If dto Is Nothing OrElse dto.DeviceID <= 0 Then Return False
        Return DeviceRepo.UpdateDevice(dto)
    End Function

    Public Shared Function Find(deviceID As Integer) As DeviceDTO
        If deviceID <= 0 Then Return Nothing
        Return DeviceRepo.GetDeviceInfoByID(deviceID)
    End Function

    Public Shared Function GetAllDevices() As DataTable
        Return DeviceRepo.GetAllDevices()
    End Function

    Public Shared Function UpdateStatus(deviceID As Integer, newStatus As enDeviceStatus) As Boolean
        If deviceID <= 0 Then Return False

        Return DeviceRepo.UpdateDeviceStatus(deviceID, CInt(newStatus))
    End Function

End Class