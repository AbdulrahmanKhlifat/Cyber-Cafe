Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class GameRepo

    Public Shared Function AddGame(gameDTO As GameDTO) As Integer

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            ' If the server is down the exception is bubbled up to the BLL
            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    Dim gameID As Integer =
                    InsertGame(gameDTO, conn, transaction)

                    InsertGameDeviceType(
                    gameID,
                    gameDTO.SupportedDevices,
                    conn,
                    transaction)

                    transaction.Commit()

                    Return gameID

                Catch ex As Exception

                    transaction.Rollback()

                    ErrorLogger.LogErrorToFile(
                    ex,
                    Reflection.MethodBase.GetCurrentMethod().Name)

                    Throw

                End Try

            End Using

        End Using

    End Function

    Private Shared Sub InsertGameDeviceType(
        gameID As Integer,
        deviceTypeIDs As List(Of Integer),
        conn As SqlConnection,
        transaction As SqlTransaction)

        If deviceTypeIDs Is Nothing OrElse deviceTypeIDs.Count = 0 Then
            Throw New ArgumentException("Game must have at least one device type")
        End If

        Dim table As New DataTable()

        table.Columns.Add("GameID", GetType(Integer))
        table.Columns.Add("DeviceTypeID", GetType(Integer))

        For Each deviceTypeID In deviceTypeIDs

            If deviceTypeID > 0 Then

                table.Rows.Add(gameID, deviceTypeID)

            End If

        Next

        Using bulk As New SqlBulkCopy(
                conn,
                SqlBulkCopyOptions.Default,
                transaction)

            bulk.DestinationTableName = "GamesDeviceTypes"

            bulk.ColumnMappings.Add(
                    "GameID",
                    "GameID")

            bulk.ColumnMappings.Add(
                    "DeviceTypeID",
                    "DeviceTypeID")

            bulk.WriteToServer(table)

        End Using
    End Sub

    Private Shared Function InsertGame(
    gameDTO As GameDTO,
    conn As SqlConnection,
    transaction As SqlTransaction) As Integer

        Dim query As String =
        "INSERT INTO Games (GameName, ImagePath)
         VALUES (@GameName, @ImagePath);
         SELECT SCOPE_IDENTITY();"

        Using cmd As New SqlCommand(query, conn, transaction)

            cmd.Parameters.Add("@GameName", SqlDbType.NVarChar).Value = gameDTO.GameName

            cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 255).Value =
            If(String.IsNullOrWhiteSpace(gameDTO.ImagePath),
               DBNull.Value,
               gameDTO.ImagePath)

            Dim result = cmd.ExecuteScalar()

            If result Is Nothing Then
                Throw New Exception("Failed to retrieve inserted GameID")
            End If

            Return Convert.ToInt32(result)

        End Using

    End Function

    Public Shared Function UpdateGame(
    gameDTO As GameDTO) As Boolean

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    UpdateGameRecord(
                        gameDTO,
                        conn,
                        transaction)

                    ReplaceGameDeviceTypes(
                        gameDTO.GameID,
                        gameDTO.SupportedDevices,
                        conn,
                        transaction)

                    transaction.Commit()

                    Return True

                Catch ex As Exception

                    transaction.Rollback()

                    ErrorLogger.LogErrorToFile(
                    ex,
                    Reflection.MethodBase.
                    GetCurrentMethod().Name)

                    Throw

                End Try

            End Using
        End Using
    End Function

    Private Shared Sub UpdateGameRecord(
    gameDTO As GameDTO,
    conn As SqlConnection,
    transaction As SqlTransaction)

        Dim query As String =
        "UPDATE Games
             SET GameName = @GameName,
                 ImagePath = @ImagePath
             WHERE GameID = @GameID"

        Using cmd As New SqlCommand(
        query,
        conn,
        transaction)

            cmd.Parameters.Add(
            "@GameID",
            SqlDbType.Int).
            Value = gameDTO.GameID

            cmd.Parameters.Add(
            "@GameName",
            SqlDbType.NVarChar).
            Value = gameDTO.GameName

            cmd.Parameters.Add(
            "@ImagePath",
            SqlDbType.NVarChar,
            255).
            Value =
            If(String.IsNullOrWhiteSpace(
                    gameDTO.ImagePath),
               DBNull.Value,
               gameDTO.ImagePath)

            cmd.ExecuteNonQuery()


        End Using

    End Sub

    Private Shared Sub ReplaceGameDeviceTypes(
    gameID As Integer,
    deviceTypeIDs As List(Of Integer),
    conn As SqlConnection,
    transaction As SqlTransaction)

        If deviceTypeIDs Is Nothing OrElse deviceTypeIDs.Count = 0 Then
            Throw New ArgumentException("Game must have at least one device type")
        End If


        'Delete old mappings

        Dim deleteQuery As String =
            "DELETE FROM GamesDeviceTypes
             WHERE GameID = @GameID"

        Using cmd As New SqlCommand(
            deleteQuery,
            conn,
            transaction)

            cmd.Parameters.Add(
                "@GameID",
                SqlDbType.Int).
                Value = gameID

            cmd.ExecuteNonQuery()

        End Using

        'Bulk insert new mappings

        Dim table As New DataTable()

        table.Columns.Add(
            "GameID",
            GetType(Integer))

        table.Columns.Add(
            "DeviceTypeID",
            GetType(Integer))

        For Each deviceTypeID
            In deviceTypeIDs

            If deviceTypeID > 0 Then

                table.Rows.Add(
                    gameID,
                    deviceTypeID)

            End If

        Next

        Using bulk As New SqlBulkCopy(
            conn,
            SqlBulkCopyOptions.Default,
            transaction)

            bulk.DestinationTableName =
                "GamesDeviceTypes"

            bulk.ColumnMappings.Add(
                "GameID",
                "GameID")

            bulk.ColumnMappings.Add(
                "DeviceTypeID",
                "DeviceTypeID")

            bulk.WriteToServer(table)

        End Using

    End Sub

    Public Shared Function GetGameByID(
    gameID As Integer) As GameDTO

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            Dim game As GameDTO = Nothing

            Try

                conn.Open()

                ' Step 1 — Get Game

                Dim query As String =
                "SELECT GameID,
                        GameName,
                        ImagePath
                 FROM Games
                 WHERE GameID = @GameID"

                Using cmd As New SqlCommand(
                query,
                conn)

                    cmd.Parameters.Add(
                    "@GameID",
                    SqlDbType.Int).
                    Value = gameID

                    Using reader As SqlDataReader =
                    cmd.ExecuteReader()

                        If reader.Read() Then

                            game = New GameDTO() With {
                            .GameID =
                                CType(
                                    reader("GameID"),
                                    Integer),
                            .GameName =
                                CType(
                                    reader("GameName"),
                                    String),
                            .ImagePath =
                                If(
                                    reader("ImagePath") Is DBNull.Value,
                                    Nothing,
                                    CType(
                                        reader("ImagePath"),
                                        String)),
                            .SupportedDevices =
                                New List(Of Integer)
                        }

                        End If

                    End Using

                End Using

                If game Is Nothing Then
                    Return Nothing
                End If

                ' Step 2 — Get Supported Devices

                Dim deviceQuery As String =
                "SELECT DeviceTypeID
                 FROM GamesDeviceTypes
                 WHERE GameID = @GameID"

                Using cmd As New SqlCommand(
                deviceQuery,
                conn)

                    cmd.Parameters.Add(
                    "@GameID",
                    SqlDbType.Int).
                    Value = gameID

                    Using reader As SqlDataReader =
                    cmd.ExecuteReader()

                        While reader.Read()

                            game.SupportedDevices.Add(
                            CType(
                                reader("DeviceTypeID"),
                                Integer))

                        End While

                    End Using

                End Using

            Catch ex As Exception

                ErrorLogger.LogErrorToFile(
                ex,
                Reflection.MethodBase.
                GetCurrentMethod().Name)

            End Try

            Return game

        End Using

    End Function

    Public Shared Function GetAllGames() As List(Of GameDTO)

        Dim games As New List(Of GameDTO)

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT GameID,
                    GameName,
                    ImagePath
             FROM Games"

            Using cmd As New SqlCommand(
            query,
            conn)

                Try

                    conn.Open()

                    Using reader As SqlDataReader =
                    cmd.ExecuteReader()

                        While reader.Read()

                            Dim game As New GameDTO()

                            game.GameID =
                            Convert.ToInt32(
                                reader("GameID"))

                            game.GameName =
                            reader("GameName").
                            ToString()

                            If reader("ImagePath") IsNot DBNull.Value Then
                                game.ImagePath =
                                reader("ImagePath").
                                ToString()
                            End If

                            games.Add(game)

                        End While

                    End Using

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(
                    ex,
                    System.Reflection.MethodBase.
                    GetCurrentMethod().Name)

                End Try

            End Using

        End Using

        Return games

    End Function

    Public Shared Function IsGameExists(
        gameName As String) As Boolean

        Dim isFound As Boolean = False

        Using conn As New SqlConnection(
            DataAccessSettings.connectionString)

            Dim query As String =
                "SELECT 1
                 FROM Games
                 WHERE GameName = @GameName"

            Using cmd As New SqlCommand(
                query,
                conn)

                cmd.Parameters.Add(
                    "@GameName",
                    SqlDbType.NVarChar,
                    50).
                    Value = gameName

                Try

                    conn.Open()

                    isFound =
                        (cmd.ExecuteScalar() IsNot Nothing)

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(
                        ex,
                        System.Reflection.MethodBase.
                        GetCurrentMethod().Name)

                End Try

            End Using

        End Using

        Return isFound

    End Function

    Public Shared Function IsGameExists(
    gameID As Integer) As Boolean

        Dim isFound As Boolean = False

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT 1
             FROM Games
             WHERE GameID = @GameID"

            Using cmd As New SqlCommand(
            query,
            conn)

                cmd.Parameters.Add(
                "@GameID",
                SqlDbType.Int).
                Value = gameID

                Try

                    conn.Open()

                    isFound =
                    (cmd.ExecuteScalar() IsNot Nothing)

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(
                    ex,
                    Reflection.MethodBase.
                    GetCurrentMethod().Name)

                End Try

            End Using

        End Using

        Return isFound

    End Function

    Public Shared Function GetGamesForDeviceUpdate(deviceID As Integer, deviceTypeID As Integer) As List(Of GameSelectionDTO)

        Dim games As New List(Of GameSelectionDTO)

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String =
            "SELECT 
                g.GameID,
                g.GameName,
                g.ImagePath,
                CASE 
                    WHEN dg.GameID IS NOT NULL THEN 1
                    ELSE 0
                END AS Found
             FROM Games g
             INNER JOIN GamesDeviceTypes gdt
                 ON gdt.GameID = g.GameID
                AND gdt.DeviceTypeID = @DeviceTypeID
             LEFT JOIN DeviceGames dg
                 ON dg.GameID = g.GameID
                AND dg.DeviceID = @DeviceID
             ORDER BY g.GameName;"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@DeviceID", deviceID)
                    cmd.Parameters.AddWithValue("@DeviceTypeID", deviceTypeID)

                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim game As New GameSelectionDTO()

                            game.GameID = Convert.ToInt32(reader("GameID"))
                            game.GameName = reader("GameName").ToString()
                            game.ImagePath = reader("ImagePath").ToString()

                            game.Exists = CBool(reader("Found"))

                            games.Add(game)

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
                        ex,
                        System.Reflection.MethodBase.
                        GetCurrentMethod().Name)

            Return Nothing
        End Try

        Return games

    End Function
    Public Shared Function IsGameAssignedToDevices(gameID As Integer) As Boolean

        Dim isAssigned As Boolean = False

        Dim query As String = "SELECT TOP 1 1 FROM DeviceGames WHERE GameID = @GameID"

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@GameID", gameID)

                Try
                    conn.Open()

                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then

                        isAssigned = True

                    End If

                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Try

            End Using

        End Using

        Return isAssigned

    End Function

    Public Shared Function GetImagePathByGameID(gameID As Integer) As String
        Dim imageName As String = ""

        Dim query As String = "SELECT ImagePath FROM Games WHERE GameID = @GameID"

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@GameID", gameID)

                Try

                    conn.Open()
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        imageName = result.ToString()
                    End If
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    Return Nothing
                End Try
            End Using
        End Using

        If Not String.IsNullOrEmpty(imageName) Then
            Return imageName
        End If

        Return Nothing
    End Function
    Public Shared Function DeleteGame(gameID As Integer) As Boolean

        Dim isDeleted As Boolean = False
        Dim query As String = "Delete From Games WHERE GameID = @GameID"


        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@GameID", gameID)

                Try
                    conn.Open()

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    isDeleted = (rowsAffected > 0)

                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Try

            End Using

        End Using

        Return isDeleted
    End Function


End Class