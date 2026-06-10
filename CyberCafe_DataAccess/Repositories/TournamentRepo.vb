Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class TournamentRepo


    Public Shared Function GetTournamentByID(tournamentID As Integer) As TournamentDTO

        Dim tournament As TournamentDTO = Nothing

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT 
                T.TournamentID,
                T.TournamentName,
                T.GameID,
                G.GameName,
                T.TournamentTime,
                T.EntryFee,
                T.PrizeAmount,
                T.MaxPlayers,
                T.TournamentStatus,
                T.CreatedByAdminID,
                T.CreatedDate
            FROM Tournaments T
            INNER JOIN Games G
                ON T.GameID = G.GameID
            WHERE T.TournamentID = @TournamentID and IsDeleted = 0"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                Try

                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            tournament = New TournamentDTO With {
                            .TournamentID = CInt(reader("TournamentID")),
                            .TournamentName = reader("TournamentName").ToString(),
                            .GameID = CInt(reader("GameID")),
                            .GameName = reader("GameName").ToString(),
                            .TournamentTime = CDate(reader("TournamentTime")),
                            .EntryFee = CDec(reader("EntryFee")),
                            .PrizeAmount = CDec(reader("PrizeAmount")),
                            .MaxPlayers = CShort(reader("MaxPlayers")),
                            .TournamentStatus = CByte(reader("TournamentStatus")),
                            .CreatedByAdminID = CInt(reader("CreatedByAdminID")),
                            .CreatedDate = CDate(reader("CreatedDate"))
                        }

                        End If

                    End Using

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

                    Throw

                End Try

            End Using

        End Using

        Return tournament

    End Function


    Public Shared Function AddNewTournament(dto As TournamentDTO) As Integer

        Dim tournamentID As Integer = -1

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "INSERT INTO Tournaments
            (
                TournamentName,
                GameID,
                TournamentTime,
                EntryFee,
                PrizeAmount,
                MaxPlayers,
                TournamentStatus,
                CreatedByAdminID,
                CreatedDate,
                IsDeleted,
                ExpectedEndTime
            )
            VALUES
            (
                @TournamentName,
                @GameID,
                @TournamentTime,
                @EntryFee,
                @PrizeAmount,
                @MaxPlayers,
                @TournamentStatus,
                @CreatedByAdminID,
                @CreatedDate,
                @IsDeleted,
                @ExpectedEndTime
            );

            SELECT SCOPE_IDENTITY();"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentName", SqlDbType.NVarChar, 100).Value = dto.TournamentName
                cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = dto.GameID
                cmd.Parameters.Add("@TournamentTime", SqlDbType.DateTime).Value = dto.TournamentTime

                If dto.ExpectedEndTime > New DateTime(1753, 1, 1) Then

                    cmd.Parameters.Add("@ExpectedEndTime", SqlDbType.DateTime).Value = dto.ExpectedEndTime

                Else

                    cmd.Parameters.Add("@ExpectedEndTime", SqlDbType.DateTime).Value =
                    dto.TournamentTime.AddHours(4)

                End If

                cmd.Parameters.Add("@EntryFee", SqlDbType.Decimal).Value = dto.EntryFee
                cmd.Parameters.Add("@PrizeAmount", SqlDbType.Decimal).Value = dto.PrizeAmount
                cmd.Parameters.Add("@MaxPlayers", SqlDbType.SmallInt).Value = dto.MaxPlayers
                cmd.Parameters.Add("@TournamentStatus", SqlDbType.TinyInt).Value = dto.TournamentStatus
                cmd.Parameters.Add("@CreatedByAdminID", SqlDbType.Int).Value = dto.CreatedByAdminID
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now
                cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = False

                Try

                    conn.Open()

                    tournamentID = Convert.ToInt32(cmd.ExecuteScalar())

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw

                End Try

            End Using

        End Using

        Return tournamentID

    End Function

    Public Shared Function UpdateTournament(dto As TournamentDTO) As Boolean

        Dim rowsAffected As Integer = 0

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
                "UPDATE Tournaments
                 SET
                    TournamentName = @TournamentName,
                    GameID = @GameID,
                    TournamentTime = @TournamentTime,
                    ExpectedEndTime = @ExpectedEndTime,
                    EntryFee = @EntryFee,
                    PrizeAmount = @PrizeAmount,
                    MaxPlayers = @MaxPlayers,
                    TournamentStatus = @TournamentStatus
                 Where TournamentID = @TournamentID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = dto.TournamentID
                cmd.Parameters.Add("@TournamentName", SqlDbType.NVarChar, 100).Value = dto.TournamentName
                cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = dto.GameID
                cmd.Parameters.Add("@TournamentTime", SqlDbType.DateTime).Value = dto.TournamentTime
                cmd.Parameters.Add("@ExpectedEndTime", SqlDbType.DateTime).Value = dto.ExpectedEndTime
                cmd.Parameters.Add("@EntryFee", SqlDbType.Decimal).Value = dto.EntryFee
                cmd.Parameters.Add("@PrizeAmount", SqlDbType.Decimal).Value = dto.PrizeAmount
                cmd.Parameters.Add("@MaxPlayers", SqlDbType.SmallInt).Value = dto.MaxPlayers
                cmd.Parameters.Add("@TournamentStatus", SqlDbType.TinyInt).Value = dto.TournamentStatus

                Try

                    conn.Open()

                    rowsAffected = cmd.ExecuteNonQuery()

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw

                End Try

            End Using

        End Using

        Return rowsAffected > 0

    End Function



    Public Shared Function GetAllTournaments() As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(
            DataAccessSettings.connectionString)

            Dim query As String =
                "select t.TournamentID,t.TournamentName,G.GameName,t.TournamentTime,t.MaxPlayers,t.PrizeAmount,
                 t.TournamentStatus,t.ExpectedEndTime,t.EntryFee,

                 CASE t.TournamentStatus
                    WHEN 0 THEN 'Upcoming'
                    WHEN 1 THEN 'Registration Closed'
                    WHEN 2 THEN 'Draw Generated'
                    WHEN 3 THEN 'Running'
                    WHEN 4 THEN 'Finished'
                    WHEN 5 THEN 'Cancelled'
                 END AS TournamentStatusText

                 From tournaments t
                 INNER JOIN Games g on t.GameID=g.GameID"

            Using cmd As New SqlCommand(query, conn)

                Try

                    conn.Open()

                    dt.Load(cmd.ExecuteReader())

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw

                End Try

            End Using

        End Using

        Return dt

    End Function

    Public Shared Function UpdateTournamentStatus(tournamentID As Integer, status As Byte) As Boolean

        Dim rowsAffected As Integer = 0

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
                "UPDATE Tournaments
                 SET TournamentStatus = @TournamentStatus
                 WHERE TournamentID = @TournamentID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                cmd.Parameters.Add("@TournamentStatus", SqlDbType.TinyInt).Value = status

                Try

                    conn.Open()

                    rowsAffected = cmd.ExecuteNonQuery()

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw

                End Try

            End Using

        End Using

        Return rowsAffected > 0

    End Function

    Public Shared Function SoftDeleteTournament(tournamentID As Integer) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
                "UPDATE Tournaments
                 SET IsDeleted = 1
                 WHERE TournamentID = @TournamentID"

            Using cmd As New SqlCommand(query, conn)

                Try

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()

                    Return cmd.ExecuteNonQuery() > 0

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Throw

                End Try

            End Using

        End Using

    End Function

End Class