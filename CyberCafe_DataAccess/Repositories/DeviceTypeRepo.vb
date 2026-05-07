Imports System.Data.SqlClient
Imports CyberCafeModels


Public Class DeviceTypeRepo

    Public Shared Function GetAllDeviceTypes() As List(Of DeviceTypeDTO)
        Dim result As New List(Of DeviceTypeDTO)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
        "SELECT DeviceTypeID, DeviceTypeName, DeviceDescription, PricePerHour, ImagePath " &
        "FROM DeviceType " &
        "ORDER BY DeviceTypeName"

            Using cmd As New SqlCommand(query, conn)

                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim item As New DeviceTypeDTO With {
                            .DeviceTypeID = Convert.ToInt32(reader("DeviceTypeID")),
                            .DeviceTypeName = reader("DeviceTypeName").ToString(),
                            .DeviceDescription = reader("DeviceDescription").ToString(),
                            .PricePerHour = If(reader("PricePerHour") Is DBNull.Value, 0D, Convert.ToDecimal(reader("PricePerHour"))),
                            .ImagePath = If(reader("ImagePath") Is DBNull.Value, "", reader("ImagePath").ToString())
                        }

                            result.Add(item)

                        End While

                    End Using

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw

                End Try

            End Using

        End Using

        Return result

    End Function

    Public Shared Function GetDeviceTypeByID(deviceTypeID As Integer) As DeviceTypeDTO

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT DeviceTypeID, DeviceTypeName, DeviceDescription, ImagePath, PricePerHour
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
                                .DeviceTypeName = CType(reader("DeviceTypeName"), String)
                                .DeviceDescription = If(reader("DeviceDescription") Is DBNull.Value,
                                                       "", CType(reader("DeviceDescription"), String))
                                .ImagePath = If(reader("ImagePath") Is DBNull.Value,
                                                       "", CType(reader("ImagePath"), String))
                                .PricePerHour = If(reader("PricePerHour") Is DBNull.Value, 0D, Convert.ToDecimal(reader("PricePerHour")))
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

    Public Shared Function AddDeviceType(deviceType As DeviceTypeDTO) As Integer
        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "INSERT INTO DeviceType (DeviceTypeName, DeviceDescription, ImagePath, PricePerHour) 
                                   VALUES (@DeviceTypeName, @DeviceDescription, @ImagePath, @PricePerHour);
                                   SELECT SCOPE_IDENTITY();"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@DeviceTypeName", SqlDbType.NVarChar).Value = deviceType.DeviceTypeName

                cmd.Parameters.Add("@DeviceDescription", SqlDbType.NVarChar).Value =
                If(String.IsNullOrWhiteSpace(deviceType.DeviceDescription), DBNull.Value, deviceType.DeviceDescription)

                cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value =
                If(String.IsNullOrWhiteSpace(deviceType.ImagePath), DBNull.Value, deviceType.ImagePath)

                cmd.Parameters.Add("@PricePerHour", SqlDbType.Decimal).Value = deviceType.PricePerHour

                Try

                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    Return Convert.ToInt32(result)

                Catch ex As SqlException

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

                    Throw

                End Try

            End Using

        End Using

    End Function

    Public Shared Function UpdateDeviceType(deviceType As DeviceTypeDTO) As Boolean
        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "UPDATE DeviceType 
                                   SET DeviceTypeName = @DeviceTypeName, 
                                       DeviceDescription = @DeviceDescription, 
                                       ImagePath = @ImagePath,
                                       PricePerHour = @PricePerHour
                                   WHERE DeviceTypeID = @DeviceTypeID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@DeviceTypeID", SqlDbType.Int).Value = deviceType.DeviceTypeID

                cmd.Parameters.Add("@DeviceTypeName", SqlDbType.NVarChar).Value = deviceType.DeviceTypeName

                cmd.Parameters.Add("@DeviceDescription", SqlDbType.NVarChar).Value =
                    If(String.IsNullOrWhiteSpace(deviceType.DeviceDescription), DBNull.Value, deviceType.DeviceDescription)

                cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value =
                    If(String.IsNullOrWhiteSpace(deviceType.ImagePath), DBNull.Value, deviceType.ImagePath)

                cmd.Parameters.Add("@PricePerHour", SqlDbType.Decimal).Value = deviceType.PricePerHour

                Try

                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0

                Catch ex As SqlException

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw

                End Try

            End Using

        End Using

    End Function





End Class