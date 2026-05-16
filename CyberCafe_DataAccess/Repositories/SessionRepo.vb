Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class SessionRepo

    Public Shared Function InsertSession(session As SessionDTO) As Integer

        Using con As New SqlConnection(DataAccessSettings.connectionString)

            con.Open()

            Using transaction = con.BeginTransaction()

                Try

                    Dim sessionID As Integer

                    Using cmd As New SqlCommand("
                    INSERT INTO Sessions
                    (
                        CreatedByAdminID,
                        CustomerID,
                        DeviceTypeID,
                        CurrentDeviceID,
                        SessionStatus,
                        RemainingSeconds,
                        SessionRatePerHour,
                        StartTime,
                        EndTime,
                        LastResumeTime,
                        SessionCost
                    )
                    VALUES
                    (
                        @CreatedByAdminID,
                        @CustomerID,
                        @DeviceTypeID,
                        @CurrentDeviceID,
                        @SessionStatus,
                        @RemainingSeconds,
                        @SessionRatePerHour,
                        @StartTime,
                        @EndTime,
                        @LastResumeTime,
                        @SessionCost
                    );

                    SELECT SCOPE_IDENTITY();
                ", con, transaction)

                        cmd.Parameters.Add("@CreatedByAdminID", SqlDbType.Int).Value =
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

                        cmd.Parameters.Add("@SessionCost", SqlDbType.Decimal).Value =
                        session.SessionCost

                        cmd.Parameters("@SessionCost").Precision = 10
                        cmd.Parameters("@SessionCost").Scale = 2

                        sessionID =
                        Convert.ToInt32(cmd.ExecuteScalar())

                    End Using


                    Dim deviceStatusUpdated As Boolean = DeviceRepo.UpdateDeviceStatus(session.CurrentDeviceID.Value, enDeviceStatus.InUse, transaction)

                    If Not deviceStatusUpdated Then
                        transaction.Rollback()
                        Throw New Exception("Failed to update device status.")
                    End If

                    Dim transactionInserted As Boolean = TransactionRepo.AddTransaction(New TransactionDTO With {
                        .CustomerID = session.CustomerID,
                        .ProcessedByAdminID = session.CreatedByAdminID,
                        .TransactionType = TransactionType.SessionStart,
                        .PaidAmount = session.SessionCost,
                        .TransactionDate = session.StartTime,
                        .SessionID = sessionID,
                        .TransactionNotes = "Session Start"
                    }, con, transaction) <> -1

                    If Not transactionInserted Then
                        transaction.Rollback()
                        Throw New Exception("Failed to insert transaction record.")
                    End If

                    transaction.Commit()

                    Return sessionID

                Catch

                    transaction.Rollback()

                    Throw

                End Try

            End Using

        End Using

    End Function

    Public Shared Function UpdateSessionStatus(sessionID As Integer, status As SessionStatus) As Boolean

        Dim isUpdated As Boolean = False

        Using conn As New SqlConnection(DataAccessSettings.connectionString)


            Dim query As String = "UPDATE Sessions SET SessionStatus=@SessionStatus 
                                   WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@SessionStatus", SqlDbType.TinyInt).Value = CByte(status)
                cmd.Parameters.Add("@SessionID", SqlDbType.Int).Value = sessionID

                conn.Open()

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                isUpdated = rowsAffected > 0

            End Using
        End Using

        Return isUpdated
    End Function

    Public Shared Function UpdateCurrentDevice(
    sessionID As Integer,
    currentDeviceID As Integer?
) As Boolean

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            Dim query As String =
        "UPDATE Sessions
         SET CurrentDeviceID = @CurrentDeviceID
         WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                "@CurrentDeviceID",
                SqlDbType.Int
            ).Value =
            If(currentDeviceID.HasValue,
               currentDeviceID.Value,
               DBNull.Value)

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

    Public Shared Function UpdateLastResumeTime(
    sessionID As Integer,
    lastResumeTime As DateTime
) As Boolean

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            Dim query As String =
        "UPDATE Sessions
         SET LastResumeTime = @LastResumeTime
         WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                "@LastResumeTime",
                SqlDbType.DateTime2
            ).Value = lastResumeTime

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

    Public Shared Function GetRuntimeSessions() As List(Of SessionDTO)

        Dim activeSessions As New List(Of SessionDTO)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT [SessionID]
                ,[CreatedByAdminID]
                ,[CustomerID]
                ,[DeviceTypeID]
                ,[CurrentDeviceID]
                ,[SessionStatus]
                ,[RemainingSeconds]
                ,[SessionRatePerHour]
                ,[StartTime]
                ,[EndTime]
                ,[LastResumeTime]
                ,[SessionCost]
            FROM Sessions
            WHERE SessionStatus in (@Active, @Paused)"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@Active", SqlDbType.TinyInt).Value = CByte(SessionStatus.Active)
                cmd.Parameters.Add("@Paused", SqlDbType.TinyInt).Value = CByte(SessionStatus.Paused)

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

    Public Shared Function GetSessionsByCustomerID(customerID As Integer) As List(Of SessionDTO)

        Dim activeSessions As New List(Of SessionDTO)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT [SessionID]
                ,[CreatedByAdminID]
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
            WHERE [CustomerID] = @CustomerID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID

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

    Public Shared Function GetSessionByID(sessionID As Integer) As SessionDTO

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            Dim query As String =
        "SELECT
            [SessionID],
            [CreatedByAdminIDID],
            [CustomerID],
            [DeviceTypeID],
            [CurrentDeviceID],
            [SessionStatus],
            [RemainingSeconds],
            [SessionRatePerHour],
            [StartTime],
            [EndTime],
            [LastResumeTime]
         FROM Sessions
         WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                "@SessionID",
                SqlDbType.Int
            ).Value = sessionID

                conn.Open()

                Using reader As SqlDataReader =
                cmd.ExecuteReader()

                    If reader.Read() Then

                        Return MapSession(reader)

                    End If

                End Using

            End Using

        End Using

        Return Nothing

    End Function

    Public Shared Function GetCurrentSessionByDeviceID(
    deviceID As Integer
) As DataTable

        If deviceID <= 0 Then
            Throw New ArgumentException("Invalid DeviceID.")
        End If

        Dim dt As New DataTable()

        Const query As String =
            "
            SELECT
                s.SessionID,
                u.FullName AS CustomerName,
                s.StartTime,
                s.RemainingSeconds,

                CASE s.SessionStatus
                    WHEN 0 THEN 'Active'
                    WHEN 1 THEN 'Paused'
                    WHEN 2 THEN 'Ended'
                END AS SessionStatus

            FROM Sessions s

            INNER JOIN Users u
                ON s.CustomerID = u.UserID

            WHERE s.CurrentDeviceID = @DeviceID
            AND s.SessionStatus IN (0, 1)
            "

        Using connection As New SqlConnection(DataAccessSettings.connectionString),
          command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@DeviceID", deviceID)

            connection.Open()

            Using reader As SqlDataReader = command.ExecuteReader()

                dt.Load(reader)

            End Using

        End Using

        Return dt

    End Function

    Public Shared Function GetSessionStatus(sessionID As Integer) As SessionStatus

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            Dim query As String =
        "SELECT SessionStatus
         FROM Sessions
         WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                "@SessionID",
                SqlDbType.Int
            ).Value = sessionID

                conn.Open()

                Dim result As Object =
                cmd.ExecuteScalar()

                If result Is Nothing Then

                    Throw New Exception(
                    "Session was not found."
                )

                End If

                Return CType(
                Convert.ToByte(result),
                SessionStatus
            )

            End Using

        End Using

    End Function


    Public Shared Function GetDeviceSessionKPI(
    deviceID As Integer
) As DeviceSessionKPI

        If deviceID <= 0 Then
            Throw New ArgumentException(
            "Invalid DeviceID."
        )
        End If

        Dim kpi As New DeviceSessionKPI()

        Const query As String =
    "
    SELECT
        ISNULL(SUM(SessionCost), 0) AS TotalRevenue,

        ISNULL(
            SUM(
                DATEDIFF(
                    SECOND,
                    StartTime,
                    EndTime
                )
            ) / 3600.0,
            0
        ) AS TotalHours,

        COUNT(*) AS SessionCount

    FROM Sessions

    WHERE CurrentDeviceID = @DeviceID
    AND SessionStatus = 2
    "

        Using connection As New SqlConnection(
        DataAccessSettings.connectionString
    ),
    command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue(
            "@DeviceID",
            deviceID
        )

            connection.Open()

            Using reader As SqlDataReader =
            command.ExecuteReader()

                If reader.Read() Then

                    kpi.TotalRevenue =
                    Convert.ToDecimal(
                        reader("TotalRevenue")
                    )

                    kpi.TotalHours =
                    Convert.ToDouble(
                        reader("TotalHours")
                    )

                    kpi.SessionCount =
                    Convert.ToInt32(
                        reader("SessionCount")
                    )

                End If

            End Using

        End Using

        Return kpi

    End Function

    Public Shared Function IsSessionExists(sessionID As Integer) As Boolean

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            Dim query As String =
        "SELECT 1
         FROM Sessions
         WHERE SessionID = @SessionID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add(
                "@SessionID",
                SqlDbType.Int
            ).Value = sessionID

                conn.Open()

                Dim result As Object =
                cmd.ExecuteScalar()

                Return result IsNot Nothing

            End Using

        End Using

    End Function

    Private Shared Function MapSession(reader As SqlDataReader) As SessionDTO

        Dim session As New SessionDTO()

        session.SessionID =
            Convert.ToInt32(reader("SessionID"))

        session.CreatedByAdminID =
            Convert.ToInt32(reader("CreatedByAdminID"))

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

        session.SessionCost = Convert.ToDecimal(reader("SessionCost"))

        Return session

    End Function

    'Persistence Methods
    Public Shared Function MarkSessionEnded(
    sessionID As Integer,
    endTime As DateTime,
    deviceID As Integer
) As Boolean

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID.")
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    Const query As String =
                    "UPDATE Sessions
                     SET
                        SessionStatus = @SessionStatus,
                        RemainingSeconds = 0,
                        EndTime = @EndTime
                     WHERE SessionID = @SessionID"

                    Dim rowsAffected As Integer

                    Using cmd As New SqlCommand(
                    query,
                    conn,
                    transaction)

                        cmd.Parameters.Add(
                        "@SessionStatus",
                        SqlDbType.TinyInt).Value =
                        CByte(SessionStatus.Ended)

                        cmd.Parameters.Add(
                        "@EndTime",
                        SqlDbType.DateTime2).Value =
                        endTime

                        cmd.Parameters.Add(
                        "@SessionID",
                        SqlDbType.Int).Value =
                        sessionID

                        rowsAffected =
                        cmd.ExecuteNonQuery()

                    End Using

                    DeviceRepo.UpdateDeviceStatus(
                    deviceID,
                    enDeviceStatus.Available,
                    transaction)

                    transaction.Commit()

                    Return rowsAffected > 0

                Catch

                    transaction.Rollback()

                    Throw

                End Try

            End Using

        End Using

    End Function

    Public Shared Function PauseSession(
    sessionID As Integer,
    remainingSeconds As Integer,
    deviceID As Integer
) As Boolean

        If remainingSeconds < 0 Then
            Throw New ArgumentException(
            "RemainingSeconds cannot be negative.")
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    Const query As String =
                    "UPDATE Sessions
                     SET
                        SessionStatus = @SessionStatus,
                        RemainingSeconds = @RemainingSeconds
                     WHERE SessionID = @SessionID"

                    Dim rowsAffected As Integer

                    Using cmd As New SqlCommand(
                    query,
                    conn,
                    transaction)

                        cmd.Parameters.Add(
                        "@SessionStatus",
                        SqlDbType.TinyInt).Value =
                        CByte(SessionStatus.Paused)

                        cmd.Parameters.Add(
                        "@RemainingSeconds",
                        SqlDbType.Int).Value =
                        remainingSeconds

                        cmd.Parameters.Add(
                        "@SessionID",
                        SqlDbType.Int).Value =
                        sessionID

                        rowsAffected =
                        cmd.ExecuteNonQuery()

                    End Using

                    DeviceRepo.UpdateDeviceStatus(
                    deviceID,
                    enDeviceStatus.Available,
                    transaction)

                    transaction.Commit()

                    Return rowsAffected > 0

                Catch

                    transaction.Rollback()

                    Throw

                End Try

            End Using

        End Using

    End Function

    Public Shared Function ResumeSession(
    sessionID As Integer,
    lastResumeTime As DateTime,
    deviceID As Integer
) As Boolean

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    Const query As String =
                    "UPDATE Sessions
                     SET
                        SessionStatus = @SessionStatus,
                        LastResumeTime = @LastResumeTime,
                        CurrentDeviceID = @DeviceID
                     WHERE SessionID = @SessionID"

                    Dim rowsAffected As Integer

                    Using cmd As New SqlCommand(
                    query,
                    conn,
                    transaction)

                        cmd.Parameters.Add(
                        "@SessionStatus",
                        SqlDbType.TinyInt).Value =
                        CByte(SessionStatus.Active)

                        cmd.Parameters.Add(
                        "@LastResumeTime",
                        SqlDbType.DateTime2).Value =
                        lastResumeTime

                        cmd.Parameters.Add(
                        "@DeviceID",
                        SqlDbType.Int).Value =
                        deviceID

                        cmd.Parameters.Add(
                        "@SessionID",
                        SqlDbType.Int).Value =
                        sessionID

                        rowsAffected =
                        cmd.ExecuteNonQuery()

                    End Using

                    DeviceRepo.UpdateDeviceStatus(
                    deviceID,
                    enDeviceStatus.InUse,
                    transaction)

                    transaction.Commit()

                    Return rowsAffected > 0

                Catch

                    transaction.Rollback()

                    Throw

                End Try

            End Using

        End Using

    End Function


    Public Shared Function GetActiveSessionsView() As DataTable

        Dim dt As New DataTable()

        Dim query As String =
        "SELECT 
         Sessions.SessionID AS [Session ID],Users.Name AS [Customer],Devices.DeviceName AS [Device],DeviceType.DeviceTypeName AS [Device Type],
     
         CASE Sessions.SessionStatus
             WHEN 0 THEN 'Active'
             WHEN 1 THEN 'Paused'
             WHEN 2 THEN 'Ended'
             ELSE 'Unknown'
         END AS [Status],
     
         CONVERT(VARCHAR,DATEADD(SECOND, Sessions.RemainingSeconds, 0),108) AS [Remaining Time],
     
         FORMAT(Sessions.StartTime,'hh:mm tt') AS [Start Time],
     
         CONCAT('$',CAST(Sessions.SessionCost AS DECIMAL(10,2))) AS [Cost]
     
         FROM Sessions
     
         JOIN Users
         ON Sessions.CustomerID = Users.UserID
         
         LEFT JOIN Devices
         ON Sessions.CurrentDeviceID = Devices.DeviceID
         
         JOIN DeviceType
         ON Sessions.DeviceTypeID = DeviceType.DeviceTypeID
         
         WHERE Sessions.SessionStatus = 0 AND Sessions.RemainingSeconds > 0"

        Using con As New SqlConnection(DataAccessSettings.connectionString)

            Using cmd As New SqlCommand(query, con)

                con.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    dt.Load(reader)

                End Using

            End Using

        End Using

        Return dt

    End Function


    Public Shared Function GetPausedSessionsView() As DataTable

        Dim dt As New DataTable()

        Dim query As String =
        "SELECT 
        Sessions.SessionID AS [Session ID],Users.Name AS [Customer],Devices.DeviceName AS [Device],DeviceType.DeviceTypeName AS [Device Type],

        FORMAT(Sessions.StartTime, 'hh:mm tt') AS [Start Time],

        CONVERT(VARCHAR,DATEADD(SECOND, Sessions.RemainingSeconds, 0),108) AS [Remaining Time],
        CONCAT('$',CAST(Sessions.SessionCost AS DECIMAL(10,2))) AS [Cost]

        FROM Sessions
        
        JOIN Users ON Sessions.CustomerID = Users.UserID
        
        Left join Devices ON Sessions.CurrentDeviceID = Devices.DeviceID
        
        JOIN DeviceType ON Sessions.DeviceTypeID = DeviceType.DeviceTypeID
        
        WHERE Sessions.SessionStatus = 1 AND Sessions.RemainingSeconds > 0"

        Using con As New SqlConnection(DataAccessSettings.connectionString)

            Using cmd As New SqlCommand(query, con)

                con.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    dt.Load(reader)

                End Using

            End Using

        End Using

        Return dt

    End Function

    Public Shared Function GetSessionsHistoryView() As DataTable

        Dim dt As New DataTable()

        Dim query As String =
        "SELECT 
        Sessions.SessionID AS [Session ID],Users.Name AS [Customer],Devices.DeviceName AS [Device],DeviceType.DeviceTypeName AS [Device Type],

        FORMAT(Sessions.StartTime, 'hh:mm tt') AS [Start Time],

        FORMAT(Sessions.EndTime, 'hh:mm tt') AS [End Time],

        CONVERT(VARCHAR,DATEADD(SECOND,DATEDIFF(SECOND,Sessions.StartTime,Sessions.EndTime),0), 108) AS [Duration],

        CONCAT('$',CAST(Sessions.SessionCost AS DECIMAL(10,2))) AS [Cost]

        FROM Sessions
        
        JOIN Users ON Sessions.CustomerID = Users.UserID
        
        JOIN Devices ON Sessions.CurrentDeviceID = Devices.DeviceID
        
        JOIN DeviceType ON Sessions.DeviceTypeID = DeviceType.DeviceTypeID
        
        WHERE Sessions.EndTime IS NOT NULL"

        Using con As New SqlConnection(DataAccessSettings.connectionString)

            Using cmd As New SqlCommand(query, con)

                con.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    dt.Load(reader)

                End Using

            End Using

        End Using

        Return dt

    End Function

End Class
