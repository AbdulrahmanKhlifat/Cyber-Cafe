Imports System.ComponentModel
Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class SessionRepo

    Public Shared Function InsertSession(session As SessionDTO) As Integer

        Using con As New SqlConnection(DataAccessSettings.connectionString),
          cmd As New SqlCommand("
            INSERT INTO Sessions
            (
                CreatedByAdmin,
                CustomerID,
                DeviceTypeID,
                CurrentDeviceID,
                SessionStatus,
                RemainingSeconds,
                SessionRatePerHour,
                StartTime,
                EndTime,
                LastResumeTime
            )
            VALUES
            (
                @CreatedByAdmin,
                @CustomerID,
                @DeviceTypeID,
                @CurrentDeviceID,
                @SessionStatus,
                @RemainingSeconds,
                @SessionRatePerHour,
                @StartTime,
                @EndTime,
                @LastResumeTime
            );

            SELECT SCOPE_IDENTITY();
          ", con)

            cmd.Parameters.Add("@CreatedByAdmin", SqlDbType.Int).Value =
            session.CreatedByAdminID

            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value =
            session.CustomerID

            cmd.Parameters.Add("@DeviceTypeID", SqlDbType.Int).Value =
            session.DeviceTypeID

            cmd.Parameters.Add("@CurrentDeviceID", SqlDbType.Int).Value =
            If(session.CurrentDeviceID.HasValue,
               session.CurrentDeviceID.Value,
               DBNull.Value)

            cmd.Parameters.Add("@SessionStatus", SqlDbType.TinyInt).Value =
            CByte(session.SessionStatus)

            cmd.Parameters.Add("@RemainingSeconds", SqlDbType.Int).Value =
            session.RemainingSeconds

            cmd.Parameters.Add("@SessionRatePerHour", SqlDbType.Decimal).Value =
            session.SessionRatePerHour

            cmd.Parameters("@SessionRatePerHour").Precision = 5
            cmd.Parameters("@SessionRatePerHour").Scale = 2

            cmd.Parameters.Add("@StartTime", SqlDbType.DateTime2).Value =
            session.StartTime

            cmd.Parameters.Add("@EndTime", SqlDbType.DateTime2).Value =
            If(session.EndTime.HasValue,
               session.EndTime.Value,
               DBNull.Value)

            cmd.Parameters.Add("@LastResumeTime", SqlDbType.DateTime2).Value =
            session.LastResumeTime

            con.Open()

            Return Convert.ToInt32(cmd.ExecuteScalar())

        End Using

    End Function

    Public Shared Function UpdateSessionStatus(session As SessionDTO) As Boolean

        Dim isUpdated As Boolean = False

        Using conn As New SqlConnection(DataAccessSettings.connectionString)


            Dim query As String = "UPDATE Sessions SET SessionStatus=@SessionStatus 
                                   WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@SessionStatus", SqlDbType.TinyInt).Value = session.SessionStatus
                cmd.Parameters.Add("@SessionID", SqlDbType.Int).Value = session.SessionID

                conn.Open()

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                isUpdated = rowsAffected > 0

            End Using
        End Using

        Return isUpdated
    End Function

    Public Shared Function GetActiveSessions() As List(Of SessionDTO)

        Dim activeSessions As New List(Of SessionDTO)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT [SessionID]
                ,[CreatedByAdmin]
                ,[CustomerID]
                ,[DeviceTypeID]
                ,[CurrentDeviceID]
                ,[SessionStatus]
                ,[RemainingSeconds]
                ,[SessionRatePerHour]
                ,[StartTime]
                ,[EndTime]
                ,[LastResumeTime]
            FROM Sessions
            WHERE SessionStatus = @Status"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = CByte(SessionStatus.Active)

                conn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()

                        activeSessions.Add(MapSession(reader))

                    End While

                End Using

            End Using

        End Using

        Return activeSessions

    End Function

    Public Shared Function UpdateRemainingSeconds(sessionID As Integer, remainingSeconds As Integer) As Boolean

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            Dim query As String =
        "UPDATE Sessions
         SET RemainingSeconds = @RemainingSeconds
         WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                "@RemainingSeconds",
                SqlDbType.Int
            ).Value = remainingSeconds

                cmd.Parameters.Add(
                "@SessionID",
                SqlDbType.Int
            ).Value = sessionID

                conn.Open()

                Dim rowsAffected As Integer =
                cmd.ExecuteNonQuery()

                Return rowsAffected > 0

            End Using

        End Using

    End Function

    Private Shared Function MapSession(reader As SqlDataReader) As SessionDTO

        Dim session As New SessionDTO()

        session.SessionID =
            Convert.ToInt32(reader("SessionID"))

        session.CreatedByAdminID =
            Convert.ToInt32(reader("CreatedByAdmin"))

        session.CustomerID =
            Convert.ToInt32(reader("CustomerID"))

        session.DeviceTypeID =
            Convert.ToInt32(reader("DeviceTypeID"))

        session.CurrentDeviceID =
            If(IsDBNull(reader("CurrentDeviceID")),
               CType(Nothing, Integer?),
               Convert.ToInt32(reader("CurrentDeviceID")))

        session.SessionStatus =
            CType(Convert.ToByte(reader("SessionStatus")),
                  SessionStatus)

        session.RemainingSeconds =
            Convert.ToInt32(reader("RemainingSeconds"))

        session.SessionRatePerHour =
            Convert.ToDecimal(reader("SessionRatePerHour"))

        session.StartTime =
            Convert.ToDateTime(reader("StartTime"))

        session.EndTime =
            If(IsDBNull(reader("EndTime")),
               CType(Nothing, DateTime?),
               Convert.ToDateTime(reader("EndTime")))

        session.LastResumeTime =
            If(IsDBNull(reader("LastResumeTime")),
               CType(Nothing, DateTime?),
               Convert.ToDateTime(reader("LastResumeTime")))

        Return session

    End Function

End Class
