Imports CyberCafe_DataAccess
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class DeviceTypeServices
    Public Shared Function GetAllDeviceTypes() As DataTable
        Return DeviceTypeRepo.GetAllDeviceTypes()
    End Function

    Public Shared Function Find(deviceTypeID As Integer) As DeviceTypeDTO
        Return DeviceTypeRepo.GetDeviceTypeByID(deviceTypeID)
    End Function

    Public Shared Function SaveDeviceType(deviceType As DeviceTypeDTO) As Boolean
        If deviceType Is Nothing Then
            Return False
        End If
        Return DeviceTypeRepo.AddDeviceType(deviceType)
    End Function

End Class