Imports System.Data.SqlClient
Imports CyberCafe_DataAccess
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class DeviceTypeServices
    Public Shared Function GetAllDeviceTypes() As List(Of DeviceTypeDTO)
        Return DeviceTypeRepo.GetAllDeviceTypes()
    End Function

    Public Shared Function Find(deviceTypeID As Integer) As DeviceTypeDTO
        Return DeviceTypeRepo.GetDeviceTypeByID(deviceTypeID)
    End Function

    Public Shared Function Add(deviceType As DeviceTypeDTO) As Boolean
        If deviceType Is Nothing Then
            Return False
        End If

        Try
            Return DeviceTypeRepo.AddDeviceType(deviceType)

        Catch ex As SqlException

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            If ex.Number = 2601 OrElse ex.Number = 2627 Then
                Throw New InvalidOperationException("Platform already exists")

            Else
                Throw
            End If

        End Try

    End Function

    Public Shared Function Update(deviceType As DeviceTypeDTO) As Boolean
        If deviceType Is Nothing Then
            Return False
        End If

        Try
            Return DeviceTypeRepo.UpdateDeviceType(deviceType)

        Catch ex As SqlException
            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            If ex.Number = 2601 OrElse ex.Number = 2627 Then
                Throw New InvalidOperationException("Platform name already exists")
            Else
                Throw
            End If
        End Try
    End Function
    Public Shared Function GetDeviceInfoByID(deviceID As Integer) As DeviceDTO
        Return DeviceRepo.GetDeviceInfoByID(deviceID)
    End Function
End Class
