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

                End Try
            End Using

        End Using

        Return dt

    End Function

    Public Shared Function GetDeviceTypeByID(deviceTypeID As Integer) As DeviceTypeDTO
        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT DeviceTypeID, DeviceName, DeviceDescription 
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
                            End With

                            Return deviceType

                        End If

                    End Using

                Catch ex As Exception

                End Try

            End Using
        End Using

        Return Nothing
    End Function

End Class