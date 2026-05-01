Imports System.Data.SqlClient
Imports CyberCafeModels


Public Class DeviceRepo

    Public Shared Function AddNewDevice(dto As DeviceDTO) As Integer

        Dim deviceID As Integer = -1

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "INSERT INTO Devices (DeviceName,DeviceTypeID, Status, PricePerHour) 
                                   VALUES (@DeviceName,@DeviceTypeID, @Status, @PricePerHour);
                                   SELECT SCOPE_IDENTITY();"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@DeviceName", SqlDbType.NVarChar).Value = dto.DeviceName
                cmd.Parameters.Add("@DeviceTypeID", SqlDbType.Int).Value = dto.DeviceTypeID
                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = dto.Status
                cmd.Parameters.Add("@PricePerHour", SqlDbType.Decimal).Value = dto.PricePerHour

                Try
                    conn.Open()
                    deviceID = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using
        End Using
        Return deviceID
    End Function



    Public Shared Function UpdateDevice(dto As DeviceDTO) As Boolean
        Dim rowsAffected As Integer = 0
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "UPDATE Devices SET DeviceName=@DeviceName, DeviceTypeID = @TypeID, Status = @Status, 
                                   PricePerHour = @Price WHERE DeviceID = @ID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceName", SqlDbType.NVarChar).Value = dto.DeviceName
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = dto.DeviceID
                cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = dto.DeviceTypeID
                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = dto.Status
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = dto.PricePerHour
                Try
                    conn.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using
        End Using
        Return rowsAffected > 0
    End Function

    Public Shared Function UpdateDeviceStatus(deviceID As Integer, newStatus As Integer) As Boolean
        Dim rowsAffected As Integer = 0

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "UPDATE Devices SET Status = @NewStatus WHERE DeviceID = @DeviceID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID
                cmd.Parameters.Add("@NewStatus", SqlDbType.Int).Value = newStatus

                Try
                    conn.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using
        End Using


        Return rowsAffected > 0
    End Function
    Public Shared Function GetAllDevices() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT d.DeviceID, d.DeviceName, d.DeviceTypeID, t.DeviceTypeName, " &
                     "d.Status, d.PricePerHour " &
                     "FROM Devices d " &
                     "JOIN DeviceType t ON d.DeviceTypeID = t.DeviceTypeID"
            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()
                    dt.Load(cmd.ExecuteReader())
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function GetDeviceInfoByID(deviceID As Integer) As DeviceDTO
        Dim device As DeviceDTO = Nothing

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT D.*, DT.DeviceTypeName " &
            "FROM Devices D " &
            "LEFT JOIN DeviceType DT ON D.DeviceTypeID = DT.DeviceTypeID " &
            "WHERE D.DeviceID = @DeviceID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID

                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            device = New DeviceDTO() With {
                           .deviceID = CInt(reader("DeviceID")),
                           .DeviceName = If(reader("DeviceName") Is DBNull.Value, "", reader("DeviceName").ToString()),
                           .DeviceTypeID = CInt(reader("DeviceTypeID")),
                           .DeviceTypeName = If(reader("DeviceTypeName") Is DBNull.Value, "Unknown", reader("DeviceTypeName").ToString()),
                           .PricePerHour = CDec(reader("PricePerHour")),
                           .Status = DirectCast(CInt(reader("Status")), enDeviceStatus)
                         }
                        End If

                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Try
            End Using
        End Using

        Return Nothing

    End Function

    Public Shared Function GetAllDevicesList() As List(Of DeviceDTO)
        Dim list As New List(Of DeviceDTO)()

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT d.DeviceID, d.DeviceName, d.DeviceTypeID, t.DeviceTypeName, " &
                                  "d.Status, d.PricePerHour " &
                                  "FROM Devices d " &
                                  "JOIN DeviceType t ON d.DeviceTypeID = t.DeviceTypeID"

            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()
                            list.Add(New DeviceDTO With {
                                .DeviceID = Convert.ToInt32(reader("DeviceID")),
                                .DeviceName = reader("DeviceName").ToString(),
                                .DeviceTypeName = reader("DeviceTypeName").ToString(),
                                .Status = CType(CByte(reader("Status")), enDeviceStatus)
                        })
                        End While
                    End Using

                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Try
            End Using
        End Using

        Return list
    End Function
End Class