Imports CyberCafe_DataAccess
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class DeviceTypeManager
    Public Shared Function GetAllDeviceTypes() As DataTable
        Return DeviceTypeRepo.GetAllDeviceTypes()
    End Function

    Public Shared Function Find(deviceTypeID As Integer) As DeviceTypeDTO
        Return DeviceTypeRepo.GetDeviceTypeByID(deviceTypeID)
    End Function

End Class