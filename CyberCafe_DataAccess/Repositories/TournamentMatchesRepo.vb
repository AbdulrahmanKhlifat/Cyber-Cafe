Imports System.Data.SqlClient
Imports CyberCafeModels
Imports CyberCafe_DataAccess.Helpers

Public Class TournamentMatchesRepo



    Public Shared Function CreateMatch(match As TournamentMatchDTO) As Integer

        Dim matchID As Integer = -1

        Const query As String =
            "INSERT INTO TournamentMatches
            (
                TournamentID,
                RoundNumber,
                MatchOrder,
                Player1ID,
                Player2ID,
                Player1Score,
                Player2Score,
                WinnerPlayerID,
                MatchStatus,
                ScheduledTime,
                CreatedDate,
                IsDeleted
            )
            VALUES
            (
                @TournamentID,
                @RoundNumber,
                @MatchOrder,
                @Player1ID,
                @Player2ID,
                @Player1Score,
                @Player2Score,
                @WinnerPlayerID,
                @MatchStatus,
                @ScheduledTime,
                @CreatedDate,
                @IsDeleted
            );
            SELECT SCOPE_IDENTITY();"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    AddMatchParameters(cmd, match)

                    conn.Open()
                    matchID = Convert.ToInt32(cmd.ExecuteScalar())

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

        Return matchID

    End Function


    Public Shared Function GetTournamentMatches(tournamentID As Integer) As DataTable

        Dim dt As New DataTable()

        Const query As String =
          "SELECT
             M.MatchID,
             M.TournamentID,
             M.RoundNumber,
             M.MatchOrder,
             M.Player1ID,
             M.Player2ID,
             COALESCE(U1.Name, 'TBD') AS Player1Name,
             COALESCE(U2.Name, 'TBD') AS Player2Name,
             M.Player1Score,
             M.Player2Score,
             M.WinnerPlayerID,
             M.MatchStatus,
             M.ScheduledTime
          FROM TournamentMatches M
          LEFT JOIN TournamentPlayers TP1 ON M.Player1ID = TP1.TournamentPlayerID
          LEFT JOIN Users U1 ON TP1.CustomerID = U1.UserID
          LEFT JOIN TournamentPlayers TP2 ON M.Player2ID = TP2.TournamentPlayerID
          LEFT JOIN Users U2 ON TP2.CustomerID = U2.UserID
          WHERE M.TournamentID = @TournamentID
            AND M.IsDeleted = 0
          ORDER BY M.RoundNumber, M.MatchOrder;"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()

                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

        Return dt

    End Function

    Public Shared Function GetTournamentMatchesList(tournamentID As Integer) As List(Of TournamentMatchDTO)

        Dim matchesList As New List(Of TournamentMatchDTO)()

        Const query As String =
         "SELECT
             M.MatchID,
             M.TournamentID,
             M.RoundNumber,
             M.MatchOrder,
             M.Player1ID,
             M.Player2ID,
             COALESCE(U1.Name, 'TBD') AS Player1Name,
             COALESCE(U2.Name, 'TBD') AS Player2Name,
             M.Player1Score,
             M.Player2Score,
             M.WinnerPlayerID,
             M.MatchStatus,
             M.ScheduledTime
          FROM TournamentMatches M
          LEFT JOIN TournamentPlayers TP1 ON M.Player1ID = TP1.TournamentPlayerID
          LEFT JOIN Users U1 ON TP1.CustomerID = U1.UserID
          LEFT JOIN TournamentPlayers TP2 ON M.Player2ID = TP2.TournamentPlayerID
          LEFT JOIN Users U2 ON TP2.CustomerID = U2.UserID
          WHERE M.TournamentID = @TournamentID
            AND M.IsDeleted = 0
          ORDER BY M.RoundNumber, M.MatchOrder;"
        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()

                    Using reader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim dto As New TournamentMatchDTO With {
                                .MatchID = CInt(reader("MatchID")),
                                .TournamentID = CInt(reader("TournamentID")),
                                .RoundNumber = CByte(reader("RoundNumber")),
                                .MatchOrder = CInt(reader("MatchOrder")),
                                .Player1Name = reader("Player1Name").ToString(),
                                .Player2Name = reader("Player2Name").ToString(),
                                .MatchStatus = CType(CByte(reader("MatchStatus")), enMatchStatus),
                                .ScheduledTime = reader.GetNullableDateTime("ScheduledTime"),
                                .Player1ID = reader.GetNullableInt("Player1ID"),
                                .Player2ID = reader.GetNullableInt("Player2ID"),
                                .Player1Score = reader.GetNullableByte("Player1Score"),
                                .Player2Score = reader.GetNullableByte("Player2Score"),
                                .WinnerPlayerID = reader.GetNullableInt("WinnerPlayerID")
                            }

                            matchesList.Add(dto)

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

        Return matchesList

    End Function

    Public Shared Function GetMatchByID(matchID As Integer) As TournamentMatchDTO

        Const query As String =
        "Select
            M.MatchID,
            M.TournamentID,
            M.RoundNumber,
            M.MatchOrder,
            M.Player1ID,
            M.Player2ID,
            COALESCE(U1.Name, 'TBD') AS Player1Name,
            COALESCE(U2.Name, 'TBD') AS Player2Name,
            M.Player1Score,
            M.Player2Score,
            M.WinnerPlayerID,
            M.MatchStatus,
            M.ScheduledTime,
            M.CreatedDate
         From TournamentMatches M
         Left Join TournamentPlayers TP1
             On M.Player1ID = TP1.TournamentPlayerID
         Left Join Users U1
             On TP1.CustomerID = U1.UserID
         Left Join TournamentPlayers TP2
             On M.Player2ID = TP2.TournamentPlayerID
         Left Join Users U2
             On TP2.CustomerID = U2.UserID
         WHERE M.MatchID = @MatchID
          And M.IsDeleted = 0;"
        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@MatchID", SqlDbType.Int).Value = matchID

                    conn.Open()
                    Using reader = cmd.ExecuteReader()

                        If reader.Read() Then

                            Dim dto As New TournamentMatchDTO With {
                                .MatchID = CInt(reader("MatchID")),
                                .TournamentID = CInt(reader("TournamentID")),
                                .RoundNumber = CByte(reader("RoundNumber")),
                                .MatchOrder = CInt(reader("MatchOrder")),
                                .Player1Name = reader("Player1Name").ToString(),
                                .Player2Name = reader("Player2Name").ToString(),
                                .MatchStatus = CType(CByte(reader("MatchStatus")), enMatchStatus),
                                .ScheduledTime = reader.GetNullableDateTime("ScheduledTime"),
                                .CreatedDate = Convert.ToDateTime(reader("CreatedDate")),
                                .Player1ID = reader.GetNullableInt("Player1ID"),
                                .Player2ID = reader.GetNullableInt("Player2ID"),
                                .Player1Score = reader.GetNullableByte("Player1Score"),
                                .Player2Score = reader.GetNullableByte("Player2Score"),
                                .WinnerPlayerID = reader.GetNullableInt("WinnerPlayerID")
                            }

                            Return dto

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

        Return Nothing

    End Function

    Public Shared Function GetMatchesByRound(tournamentID As Integer, roundNumber As Byte) As DataTable

        Dim dt As New DataTable()

        Const query As String =
            "SELECT
                MatchID, TournamentID, RoundNumber, MatchOrder,
                Player1ID, Player2ID,
                Player1Score, Player2Score,
                WinnerPlayerID, MatchStatus
             FROM TournamentMatches
             WHERE TournamentID = @TournamentID
               AND RoundNumber  = @RoundNumber
               AND IsDeleted    = 0
             ORDER BY MatchOrder"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                    cmd.Parameters.Add("@RoundNumber", SqlDbType.TinyInt).Value = roundNumber

                    conn.Open()
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

        Return dt

    End Function

    Public Shared Function GetTournamentResults(tournamentID As Integer) As DataTable

        Dim dt As New DataTable()

        Const query As String =
            "SELECT
    M.RoundNumber,
    M.MatchOrder,
    COALESCE(U1.Name, 'TBD') AS Player1Name,
    COALESCE(U2.Name, 'BYE') AS Player2Name,
    M.Player1Score,
    M.Player2Score,
    COALESCE(UW.Name, '-') AS WinnerName,
    CASE M.MatchStatus
        WHEN 0 THEN 'Upcoming'
        WHEN 1 THEN 'Running'
        WHEN 2 THEN 'Finished'
        WHEN 3 THEN 'Cancelled'
        ELSE 'Unknown'
    END AS MatchStatusText
FROM TournamentMatches M

LEFT JOIN TournamentPlayers TP1
    ON M.Player1ID = TP1.TournamentPlayerID
LEFT JOIN Users U1
    ON TP1.CustomerID = U1.UserID

LEFT JOIN TournamentPlayers TP2
    ON M.Player2ID = TP2.TournamentPlayerID
LEFT JOIN Users U2
    ON TP2.CustomerID = U2.UserID

LEFT JOIN TournamentPlayers TPW
    ON M.WinnerPlayerID = TPW.TournamentPlayerID
LEFT JOIN Users UW
    ON TPW.CustomerID = UW.UserID

WHERE M.TournamentID = @TournamentID
  AND M.IsDeleted = 0

ORDER BY M.RoundNumber, M.MatchOrder;"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()

                    Using reader = cmd.ExecuteReader()

                        dt.Load(reader)

                    End Using

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

        Return dt

    End Function

    Public Shared Function GetTournamentWinner(tournamentID As Integer) As DataTable

        Dim dt As New DataTable()

        Const query As String =
            "SELECT
                U.Name AS WinnerName,
                T.TournamentName,
                TP.RegistrationDate,
                T.TournamentTime  AS DateFinished
             FROM TournamentPlayers TP
             INNER JOIN Users       U  ON TP.CustomerID  = U.UserID
             INNER JOIN Tournaments T  ON TP.TournamentID = T.TournamentID
             WHERE TP.TournamentID = @TournamentID
               AND TP.IsWinner     = 1
               AND TP.IsDeleted    = 0"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()
                    Using reader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

        Return dt

    End Function

    Public Shared Function HasTournamentDraw(tournamentID As Integer) As Boolean

        Const query As String =
            "SELECT COUNT(1)
             FROM TournamentMatches
             WHERE TournamentID = @TournamentID
               AND IsDeleted    = 0"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            Throw

        End Try

    End Function

    Public Shared Function GetMaxRound(tournamentID As Integer) As Integer

        Const query As String =
            "SELECT ISNULL(MAX(RoundNumber), 0)
             FROM TournamentMatches
             WHERE TournamentID = @TournamentID AND IsDeleted= 0"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()
                    Return Convert.ToInt32(cmd.ExecuteScalar())

                End Using

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)


        End Try

    End Function


    ''' <summary>
    ''' Atomically updates a match result AND applies the round-advancement outcome
    ''' (either generating next-round matches, or closing the tournament with a winner)
    ''' in a single database transaction. This guarantees the match score can never be
    ''' saved while the advancement step fails, which would otherwise leave the
    ''' tournament stuck in an inconsistent state.
    ''' </summary>
    ''' <param name="advancementMatches">Next round matches to insert, or Nothing/empty if not applicable.</param>
    ''' <param name="finalWinnerCustomerID">Set when this result decides the tournament winner, else Nothing.</param>
    Public Shared Function SaveMatchResultAndAdvanceTransaction(
        matchResult As MatchResultDTO,
        tournamentID As Integer,
        advancementMatches As List(Of TournamentMatchDTO),
        finalWinnerCustomerID As Integer?) As Boolean

        Const updateMatchQuery As String =
            "UPDATE TournamentMatches
             SET
                Player1Score   = @Player1Score,
                Player2Score   = @Player2Score,
                WinnerPlayerID = @WinnerPlayerID,
                MatchStatus    = @MatchStatus
             WHERE MatchID   = @MatchID
               AND IsDeleted = 0"

        Const updateTournamentStatusQuery As String =
            "UPDATE Tournaments SET TournamentStatus = @Status WHERE TournamentID = @TournamentID"

        Const updateWinnerQuery As String =
            "UPDATE TournamentPlayers
             SET IsWinner = 1
             WHERE TournamentID = @TournamentID AND CustomerID = @CustomerID"

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    Using cmd As New SqlCommand(updateMatchQuery, conn, transaction)

                        cmd.Parameters.Add("@MatchID", SqlDbType.Int).Value = matchResult.MatchID
                        cmd.Parameters.Add("@Player1Score", SqlDbType.TinyInt).Value = matchResult.Score1
                        cmd.Parameters.Add("@Player2Score", SqlDbType.TinyInt).Value = matchResult.Score2
                        cmd.Parameters.Add("@WinnerPlayerID", SqlDbType.Int).Value = matchResult.WinnerID
                        cmd.Parameters.Add("@MatchStatus", SqlDbType.TinyInt).Value = CByte(enMatchStatus.Finished)

                        Dim rowsAffected = cmd.ExecuteNonQuery()

                        If rowsAffected = 0 Then

                            Throw New Exception($"Match #{matchResult.MatchID} could not be updated (not found or already deleted).")

                        End If

                    End Using

                    If finalWinnerCustomerID.HasValue Then

                        Using cmdStatus As New SqlCommand(updateTournamentStatusQuery, conn, transaction)
                            cmdStatus.Parameters.Add("@Status", SqlDbType.TinyInt).Value = CByte(enTournamentStatus.Finished)
                            cmdStatus.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                            cmdStatus.ExecuteNonQuery()
                        End Using

                        Using cmdWinner As New SqlCommand(updateWinnerQuery, conn, transaction)
                            cmdWinner.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                            cmdWinner.Parameters.Add("@CustomerID", SqlDbType.Int).Value = finalWinnerCustomerID.Value
                            cmdWinner.ExecuteNonQuery()
                        End Using

                    ElseIf advancementMatches IsNot Nothing AndAlso advancementMatches.Count > 0 Then

                        Dim dtMatches = _ConvertMatchesToDataTable(advancementMatches)
                        _BulkInsertMatches(dtMatches, conn, transaction)

                    End If

                    transaction.Commit()

                    Return True

                Catch ex As Exception

                    transaction.Rollback()

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)



                End Try

            End Using

        End Using

    End Function

    Public Shared Function UpdateMatchResult(matchResult As MatchResultDTO) As Boolean

        Const query As String =
            "UPDATE TournamentMatches
             SET
                Player1Score   = @Player1Score,
                Player2Score   = @Player2Score,
                WinnerPlayerID = @WinnerPlayerID,
                MatchStatus    = @MatchStatus
             WHERE MatchID   = @MatchID
               AND IsDeleted = 0"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)
                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@MatchID", SqlDbType.Int).Value = matchResult.MatchID
                    cmd.Parameters.Add("@Player1Score", SqlDbType.TinyInt).Value = matchResult.Score1
                    cmd.Parameters.Add("@Player2Score", SqlDbType.TinyInt).Value = matchResult.Score2
                    cmd.Parameters.Add("@WinnerPlayerID", SqlDbType.Int).Value = matchResult.WinnerID
                    cmd.Parameters.Add("@MatchStatus", SqlDbType.TinyInt).Value = CByte(enMatchStatus.Finished)

                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0

                End Using
            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            Throw

        End Try

    End Function

    Public Shared Function DeleteTournamentDraw(tournamentID As Integer) As Boolean

        Const query As String =
            "UPDATE TournamentMatches
             SET IsDeleted = 1
             WHERE TournamentID = @TournamentID
               AND IsDeleted    = 0"

        Try

            Using conn As New SqlConnection(DataAccessSettings.connectionString)
                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0

                End Using
            End Using

        Catch ex As Exception
            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            Throw
        End Try

    End Function



    Public Shared Function SaveDrawTransaction(tournamentID As Integer, matches As List(Of TournamentMatchDTO), newStatus As enTournamentStatus) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    Const deleteQuery As String = "UPDATE TournamentMatches SET IsDeleted = 1 WHERE TournamentID = @TournamentID AND IsDeleted = 0"
                    Using cmdDelete As New SqlCommand(deleteQuery, conn, transaction)
                        cmdDelete.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                        cmdDelete.ExecuteNonQuery()
                    End Using


                    Dim dtMatches = _ConvertMatchesToDataTable(matches)
                    _BulkInsertMatches(dtMatches, conn, transaction)


                    Const updateStatusQuery As String = "UPDATE Tournaments SET TournamentStatus = @Status WHERE TournamentID = @TournamentID"
                    Using cmdStatus As New SqlCommand(updateStatusQuery, conn, transaction)
                        cmdStatus.Parameters.Add("@Status", SqlDbType.TinyInt).Value = newStatus
                        cmdStatus.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                        cmdStatus.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    Return True

                Catch ex As Exception

                    transaction.Rollback()

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Return False

                End Try

            End Using

        End Using

    End Function

    Public Shared Function SaveNextRoundMatchesTransaction(matches As List(Of TournamentMatchDTO)) As Boolean

        If matches Is Nothing OrElse matches.Count = 0 Then
            Return False
        End If

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    Dim dtMatches = _ConvertMatchesToDataTable(matches)
                    _BulkInsertMatches(dtMatches, conn, transaction)

                    transaction.Commit()
                    Return True

                Catch ex As Exception

                    transaction.Rollback()

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                    Return False

                End Try

            End Using

        End Using

    End Function

    Private Shared Sub _BulkInsertMatches(matchesTable As DataTable, conn As SqlConnection, transaction As SqlTransaction)

        Using bulk As New SqlBulkCopy(conn, SqlBulkCopyOptions.Default, transaction)

            bulk.DestinationTableName = "TournamentMatches"

            For Each col As DataColumn In matchesTable.Columns
                bulk.ColumnMappings.Add(col.ColumnName, col.ColumnName)
            Next

            bulk.WriteToServer(matchesTable)

        End Using

    End Sub

    Private Shared Function _ConvertMatchesToDataTable(matches As List(Of TournamentMatchDTO)) As DataTable

        Dim dt As New DataTable()

        dt.Columns.Add("TournamentID", GetType(Integer))
        dt.Columns.Add("RoundNumber", GetType(Byte))
        dt.Columns.Add("MatchOrder", GetType(Integer))
        dt.Columns.Add("Player1ID", GetType(Integer))
        dt.Columns.Add("Player2ID", GetType(Integer))
        dt.Columns.Add("WinnerPlayerID", GetType(Integer))
        dt.Columns.Add("MatchStatus", GetType(Byte))
        dt.Columns.Add("ScheduledTime", GetType(DateTime))
        dt.Columns.Add("CreatedDate", GetType(DateTime))
        dt.Columns.Add("IsDeleted", GetType(Boolean))

        For Each m In matches

            Dim row = dt.NewRow()
            row("TournamentID") = m.TournamentID
            row("RoundNumber") = m.RoundNumber
            row("MatchOrder") = m.MatchOrder
            row("Player1ID") = If(m.Player1ID.HasValue, m.Player1ID.Value, DBNull.Value)
            row("Player2ID") = If(m.Player2ID.HasValue, m.Player2ID.Value, DBNull.Value)
            row("WinnerPlayerID") = If(m.WinnerPlayerID.HasValue, m.WinnerPlayerID.Value, DBNull.Value)
            row("MatchStatus") = CByte(m.MatchStatus)
            row("ScheduledTime") = If(m.ScheduledTime.HasValue, m.ScheduledTime.Value, DBNull.Value)
            row("CreatedDate") = m.CreatedDate
            row("IsDeleted") = m.IsDeleted
            dt.Rows.Add(row)

        Next

        Return dt

    End Function


    Private Shared Sub AddMatchParameters(cmd As SqlCommand, match As TournamentMatchDTO)

        cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = match.TournamentID
        cmd.Parameters.Add("@RoundNumber", SqlDbType.TinyInt).Value = match.RoundNumber
        cmd.Parameters.Add("@MatchOrder", SqlDbType.Int).Value = match.MatchOrder

        AddNullableParameter(cmd, "@Player1ID", SqlDbType.Int, match.Player1ID)
        AddNullableParameter(cmd, "@Player2ID", SqlDbType.Int, match.Player2ID)
        AddNullableParameter(cmd, "@Player1Score", SqlDbType.TinyInt, match.Player1Score)
        AddNullableParameter(cmd, "@Player2Score", SqlDbType.TinyInt, match.Player2Score)
        AddNullableParameter(cmd, "@WinnerPlayerID", SqlDbType.Int, match.WinnerPlayerID)
        AddNullableParameter(cmd, "@ScheduledTime", SqlDbType.DateTime, match.ScheduledTime)

        cmd.Parameters.Add("@MatchStatus", SqlDbType.TinyInt).Value = CByte(match.MatchStatus)
        cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now
        cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = match.IsDeleted

    End Sub

    Private Shared Sub AddNullableParameter(cmd As SqlCommand, parameterName As String, dbType As SqlDbType, value As Object)

        cmd.Parameters.Add(parameterName, dbType).Value = If(value Is Nothing, DBNull.Value, value)

    End Sub

End Class