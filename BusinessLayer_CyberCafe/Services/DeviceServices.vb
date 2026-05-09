Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class DeviceServices

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


    Public Shared Function GetDevicesByGameName(gameName As String) As List(Of Integer)

        Return DeviceRepo.GetDeviceIdsByGameName(gameName)

    End Function

    Public Shared Function GetAllDevices() As DataTable

        Return DeviceRepo.GetAllDevices()

    End Function

    Public Shared Function UpdateStatus(deviceID As Integer, newStatus As enDeviceStatus) As Boolean
        If deviceID <= 0 Then Return False

        Return DeviceRepo.UpdateDeviceStatus(deviceID, CInt(newStatus))
    End Function

    Public Shared Function GetAllDevicesList() As List(Of DeviceDTO)
        Return DeviceRepo.GetAllDevicesList()
    End Function

    Public Shared Sub SoftDeleteDevice(deviceID As Integer)

        If deviceID <= 0 Then
            Throw New ArgumentException("Invalid DeviceID")
        End If

        'Has active Session throw exception

        Dim isDeleted As Boolean =
            DeviceRepo.SoftDeleteDevice(deviceID)

        If Not isDeleted Then
            Throw New Exception("Device was not deleted")
        End If

    End Sub

    Public Shared Function GetDeviceStatus(deviceID As Integer) As enDeviceStatus

        If deviceID <= 0 Then
            Throw New ArgumentException("Invalid DeviceID")
        End If

        Try

            Return CType(DeviceRepo.GetDeviceStatus(deviceID), enDeviceStatus)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function

End Class