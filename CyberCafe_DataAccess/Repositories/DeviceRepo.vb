Imports System.Data.SqlClient
Imports CyberCafeModels


Public Class DeviceRepo

    Public Shared Function AddNewDevice(dto As DeviceDTO) As Integer

        Dim deviceID As Integer = -1

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "INSERT INTO Devices (DeviceName,DeviceTypeID, Status) 
                                   VALUES (@DeviceName,@DeviceTypeID, @Status);
                                   SELECT SCOPE_IDENTITY();"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@DeviceName", SqlDbType.NVarChar).Value = dto.DeviceName
                cmd.Parameters.Add("@DeviceTypeID", SqlDbType.Int).Value = dto.DeviceTypeID
                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = dto.Status

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
                                   WHERE DeviceID = @ID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceName", SqlDbType.NVarChar).Value = dto.DeviceName
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = dto.DeviceID
                cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = dto.DeviceTypeID
                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = dto.Status
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

            Dim query As String = "SELECT d.DeviceID, d.DeviceName, d.DeviceTypeID, t.DeviceTypeName,t.ImagePath, " &
                     "d.Status " &
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

            Dim query As String = "SELECT D.*, DT.DeviceTypeName, DT.ImagePath, DT.PricePerHour " &
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
                            .Status = DirectCast(CInt(reader("Status")), enDeviceStatus),
                            .ImagePath = If(reader("ImagePath") Is DBNull.Value, "", reader("ImagePath").ToString()),
                            .PricePerHour = If(reader("PricePerHour") Is DBNull.Value, 0D, CDec(reader("PricePerHour")))
                        }
                        End If
                    End Using
                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw
                End Try
            End Using
        End Using

        Return device
    End Function

    Public Shared Function GetAllDevicesList() As List(Of DeviceDTO)
        Dim list As New List(Of DeviceDTO)()

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT d.DeviceID, d.DeviceName, d.DeviceTypeID, t.DeviceTypeName,t.ImagePath, 
                                  d.Status 
                                  FROM Devices d 
                                  JOIN DeviceType t ON d.DeviceTypeID = t.DeviceTypeID
                                  Where d.IsDeleted = 0"

            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()
                            list.Add(New DeviceDTO With {
                                .DeviceID = Convert.ToInt32(reader("DeviceID")),
                                .DeviceName = reader("DeviceName").ToString(),
                                .DeviceTypeName = reader("DeviceTypeName").ToString(),
                                .Status = CType(CByte(reader("Status")), enDeviceStatus),
                                .ImagePath = If(reader("ImagePath") Is DBNull.Value, "", reader("ImagePath").ToString())
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

    Public Shared Function GetDeviceIdsByGameName(searchText As String) As List(Of Integer)
        Dim deviceIds As New List(Of Integer)()


        Dim query As String = "SELECT DISTINCT D.DeviceID FROM Devices D 
                          INNER JOIN DeviceGames DG ON D.DeviceID = DG.DeviceID 
                          INNER JOIN Games G ON DG.GameID = G.GameID 
                          WHERE G.GameName LIKE @Search and D.IsDeleted = 0"

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@Search", SqlDbType.NVarChar).Value = "%" & searchText.Trim() & "%"

                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            deviceIds.Add(Convert.ToInt32(reader("DeviceID")))
                        End While
                    End Using
                Catch ex As Exception
                    Debug.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return deviceIds
    End Function

    Public Shared Function SoftDeleteDevice(deviceID As Integer) As Boolean

        Dim query As String =
            "UPDATE Devices
             SET IsDeleted = 1
             WHERE DeviceID = @DeviceID"

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@DeviceID", deviceID)

                conn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function

    Public Shared Function IsDeviceExists(deviceID As Integer?) As Boolean

        If deviceID Is Nothing Then
            Throw New ArgumentNullException(NameOf(deviceID))
        End If

        Const query As String =
        "SELECT 1 FROM Devices WHERE DeviceID = @DeviceID"

        Using connection As New SqlConnection(DataAccessSettings.connectionString),
          command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@DeviceID", deviceID)

            connection.Open()

            Return command.ExecuteScalar() IsNot Nothing

        End Using

    End Function

    Public Shared Function IsDeviceOccupied(
    deviceID As Integer
) As Boolean

        If deviceID <= 0 Then
            Throw New ArgumentException(
            "Invalid DeviceID."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            Dim query As String =
        "SELECT 1
         FROM Sessions
         WHERE
            CurrentDeviceID = @DeviceID
            AND SessionStatus = @SessionStatus"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                "@DeviceID",
                SqlDbType.Int
            ).Value = deviceID

                cmd.Parameters.Add(
                "@SessionStatus",
                SqlDbType.TinyInt
            ).Value =
            CByte(SessionStatus.Active)

                conn.Open()

                Dim result As Object =
                cmd.ExecuteScalar()

                Return result IsNot Nothing

            End Using

        End Using

    End Function

    Public Shared Function DoesDeviceMatchType(
    deviceID As Integer,
    deviceTypeID As Integer
) As Boolean

        If deviceID <= 0 Then
            Throw New ArgumentException(
                "Invalid DeviceID."
            )
        End If

        If deviceTypeID <= 0 Then
            Throw New ArgumentException(
                "Invalid DeviceTypeID."
            )
        End If

        Using conn As New SqlConnection(
            DataAccessSettings.connectionString
        )

            Dim query As String =
            "SELECT 1
         FROM Devices
         WHERE
            DeviceID = @DeviceID
            AND DeviceTypeID = @DeviceTypeID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                    "@DeviceID",
                    SqlDbType.Int
                ).Value = deviceID

                cmd.Parameters.Add(
                    "@DeviceTypeID",
                    SqlDbType.Int
                ).Value = deviceTypeID

                conn.Open()

                Dim result As Object =
                    cmd.ExecuteScalar()

                Return result IsNot Nothing

            End Using

        End Using

    End Function

End Class