Imports System.Data.SqlClient
Imports CyberCafeModels


Public Class DeviceTypeRepo

    Public Shared Function GetAllDeviceTypes() As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT DeviceTypeID, DeviceTypeName, DeviceDescription FROM DeviceType"

            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            dt.Load(reader)
                        End If

                    End Using

                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using

        End Using

        Return dt

    End Function

    Public Shared Function GetDeviceTypeByID(deviceTypeID As Integer) As DeviceTypeDTO
        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT DeviceTypeID, DeviceName, DeviceDescription, ImagePath 
                                   FROM DeviceType 
                                   WHERE DeviceTypeID = @DeviceTypeID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceTypeID", SqlDbType.Int).Value = deviceTypeID

                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            Dim deviceType As New DeviceTypeDTO()
                            With deviceType
                                .DeviceTypeID = CType(reader("DeviceTypeID"), Integer)
                                .DeviceName = CType(reader("DeviceName"), String)
                                .DeviceDescription = If(reader("DeviceDescription") Is DBNull.Value,
                                                       "", CType(reader("DeviceDescription"), String))
                                .ImagePath = If(reader("ImagePath") Is DBNull.Value,
                                                       "", CType(reader("ImagePath"), String))
                            End With

                            Return deviceType

                        End If

                    End Using

                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try

            End Using
        End Using

        Return Nothing
    End Function

    Public Shared Function AddDeviceType(deviceType As DeviceTypeDTO) As Boolean
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "INSERT INTO DeviceType (DeviceTypeName, DeviceDescription, ImagePath) 
                                   VALUES (@DeviceTypeName, @DeviceDescription, @ImagePath)"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceTypeName", SqlDbType.NVarChar).Value = deviceType.DeviceName

                If String.IsNullOrWhiteSpace(deviceType.DeviceDescription) Then
                    cmd.Parameters.Add("@DeviceDescription", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@DeviceDescription", SqlDbType.NVarChar).Value = deviceType.DeviceDescription
                End If

                If String.IsNullOrWhiteSpace(deviceType.ImagePath) Then
                    cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = deviceType.ImagePath
                End If
                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    Return False
                End Try
            End Using
        End Using
    End Function

End Class