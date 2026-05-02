Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class GameRepo

    Public Shared Function AddGame(gameDTO As GameDTO) As Integer

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim transaction As SqlTransaction = Nothing

            Try

                conn.Open()

                transaction = conn.BeginTransaction()

                Dim gameID As Integer =
                        InsertGame(gameDTO, conn, transaction)

                If gameID <= 0 Then

                    transaction.Rollback()
                    Return -1

                End If

                Dim success As Boolean =
                        InsertGameDeviceType(
                            gameID,
                            gameDTO.SupportedDevices,
                            conn,
                            transaction)

                If Not success Then

                    transaction.Rollback()
                    Return -1

                End If

                transaction.Commit()

                Return gameID

            Catch ex As Exception

                If transaction IsNot Nothing Then
                    transaction.Rollback()
                End If

                ErrorLogger.LogErrorToFile(
                        ex,
                        Reflection.MethodBase.GetCurrentMethod().Name)

                Return -1

            End Try

        End Using

    End Function

    Private Shared Function InsertGameDeviceType(
        gameID As Integer,
        deviceTypeIDs As List(Of Integer),
        conn As SqlConnection,
        transaction As SqlTransaction) As Boolean

        If deviceTypeIDs Is Nothing OrElse
           deviceTypeIDs.Count = 0 Then

            Return False

        End If

        Try

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

                bulk.DestinationTableName = "GameDeviceType"

                bulk.ColumnMappings.Add(
                    "GameID",
                    "GameID")

                bulk.ColumnMappings.Add(
                    "DeviceTypeID",
                    "DeviceTypeID")

                bulk.WriteToServer(table)

            End Using

            Return True

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
                ex,
                System.Reflection.MethodBase.GetCurrentMethod().Name)

            Return False

        End Try

    End Function

    Private Shared Function InsertGame(
        gameDTO As GameDTO,
        conn As SqlConnection,
        transaction As SqlTransaction) As Integer

        Dim gameID As Integer = 0

        Dim query As String =
            "INSERT INTO Games
             (GameName, ImagePath)
             VALUES
             (@GameName, @ImagePath);
             SELECT SCOPE_IDENTITY();"

        Using cmd As New SqlCommand(
            query,
            conn,
            transaction)

            cmd.Parameters.Add(
                "@GameName",
                SqlDbType.NVarChar).
                Value = gameDTO.GameName

            cmd.Parameters.Add(
                "@ImagePath",
                SqlDbType.NVarChar,
                255).
                Value =
                If(String.IsNullOrWhiteSpace(gameDTO.ImagePath),
                    DBNull.Value,
                    gameDTO.ImagePath)

            Dim result =
                cmd.ExecuteScalar()

            If result IsNot Nothing Then

                gameID =
                    Convert.ToInt32(result)

            End If

        End Using

        Return gameID

    End Function

    Public Shared Function GetGameByID(
        gameID As Integer) As GameDTO

        Using conn As New SqlConnection(
            DataAccessSettings.connectionString)

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

                Try

                    conn.Open()

                    Using reader As SqlDataReader =
                        cmd.ExecuteReader()

                        If reader.Read() Then

                            Return New GameDTO() With {
                                .gameID =
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
                                        "",
                                        CType(
                                            reader("ImagePath"),
                                            String))
                            }

                        End If

                    End Using

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(
                        ex,
                        System.Reflection.MethodBase.
                        GetCurrentMethod().Name)

                End Try

            End Using

        End Using

        Return Nothing

    End Function


    Public Shared Function GetAllGames() As DataTable
        Dim dt As New DataTable()

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


                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()

                            conn.Open()
                            dt.Load(cmd.ExecuteReader())
                            dt.Load(
                        cmd.ExecuteReader())

                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                    System.Reflection.MethodBase.
                        GetCurrentMethod().Name)

                End Try

            End Using

        End Using


        Return gamesList
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

End Class