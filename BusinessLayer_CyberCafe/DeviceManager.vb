Imports CyberCafe_DataAccess
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class DeviceManager

    Public Shared Function AddDevice(dto As DeviceDTO) As Boolean
        Dim deviceID = DeviceRepo.AddNewDevice(dto)
        Return deviceID <> -1
    End Function

    Public Shared Function UpdateDevice(dto As DeviceDTO) As Boolean
        Return DeviceRepo.UpdateDevice(dto)
    End Function

    Public Shared Function Find(deviceID As Integer) As DeviceDTO
        Return DeviceRepo.GetDeviceInfoByID(deviceID)
    End Function

    Public Shared Function GetAllDevices() As DataTable
        Return DeviceRepo.GetAllDevices()
    End Function

    Public Shared Function UpdateStatus(deviceID As Integer, newStatus As enDeviceStatus) As Boolean
        Dim device As DeviceDTO = Find(deviceID)
        If device IsNot Nothing Then
            device.Status = newStatus
            Return DeviceRepo.UpdateDevice(device)
        End If
        Return False
    End Function

End Class