Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class TournamentPlayersRepo

    Public Shared Function RegisterPlayerTransaction(tournamentID As Integer, customerID As Integer, adminID As Integer, entryFee As Decimal) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            conn.Open()

            Using transaction = conn.BeginTransaction()

                Try

                    If Not CustomerRepo.DeductCredits(customerID, entryFee, conn, transaction) Then

                        Throw New Exception("Insufficient balance.")

                    End If

                    Dim transactionDto As New TransactionDTO With {
                   .ProcessedByAdminID = adminID,
                   .TransactionType = TransactionType.TournamentEntryFee,
                   .PaidAmount = entryFee,
                   .TransactionDate = DateTime.Now,
                   .TransactionNotes = $"Tournament Registration #{tournamentID}",
                   .IsDeleted = False
                   }

                    RegisterFinancialTransaction(transactionDto, conn, transaction)

                    InsertTournamentPlayer(tournamentID, customerID, adminID, conn, transaction)


                    UpdateTournamentStatusIfFull(tournamentID, conn, transaction)

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

    Private Shared Sub RegisterFinancialTransaction(transdto As TransactionDTO, conn As SqlConnection, trans As SqlTransaction)

        Dim transactionID = TransactionRepo.AddTransaction(transdto, conn, trans)

        If transactionID <= 0 Then

            Throw New Exception("Failed to create financial transaction.")

        End If

    End Sub

    Private Shared Sub InsertTournamentPlayer(tournamentID As Integer, customerID As Integer, adminID As Integer, conn As SqlConnection, transaction As SqlTransaction)

        Dim query As String =
        "INSERT INTO TournamentPlayers
        (
            TournamentID,
            CustomerID,
            RegisteredByAdminID,
            RegistrationDate,
            IsWinner,
            IsDeleted
        )
        VALUES
        (
            @TournamentID,
            @CustomerID,
            @AdminID,
            GETDATE(),
            0,
            0
        )"

        Using cmd As New SqlCommand(query, conn, transaction)

            cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID
            cmd.Parameters.Add("@AdminID", SqlDbType.Int).Value = adminID

            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Shared Function IsPlayerRegistered(tournamentID As Integer, customerID As Integer) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT COUNT(1)
             FROM TournamentPlayers
             WHERE TournamentID = @TournamentID
             AND CustomerID = @CustomerID
             AND IsDeleted = 0"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID

                Try

                    conn.Open()

                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

                    Return False

                End Try

            End Using

        End Using

    End Function

    Public Shared Function GetRegisteredPlayersCount(tournamentID As Integer) As Integer

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT COUNT(*)
             FROM TournamentPlayers
             WHERE TournamentID = @TournamentID
             AND IsDeleted = 0"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                Try

                    conn.Open()

                    Return Convert.ToInt32(cmd.ExecuteScalar())

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(
                    ex,
                    Reflection.MethodBase.GetCurrentMethod().Name)

                    Return 0

                End Try

            End Using

        End Using

    End Function


    Private Shared Sub UpdateTournamentStatusIfFull(tournamentID As Integer, conn As SqlConnection, transaction As SqlTransaction)

        Dim currentPlayers As Integer

        Dim countQuery As String =
        "SELECT COUNT(*)
         FROM TournamentPlayers
         WHERE TournamentID = @TournamentID
         AND IsDeleted = 0"

        Using countCmd As New SqlCommand(countQuery, conn, transaction)

            countCmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

            currentPlayers = Convert.ToInt32(countCmd.ExecuteScalar())

        End Using

        Dim maxPlayers As Integer

        Dim tournamentQuery As String =
        "SELECT MaxPlayers
         FROM Tournaments
         WHERE TournamentID = @TournamentID"

        Using cmd As New SqlCommand(tournamentQuery, conn, transaction)

            cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

            maxPlayers = Convert.ToInt32(cmd.ExecuteScalar())

        End Using

        If currentPlayers < maxPlayers Then

            Return

        End If

        Dim updateQuery As String =
        "UPDATE Tournaments
         SET TournamentStatus = @Status
         WHERE TournamentID = @TournamentID"

        Using updateCmd As New SqlCommand(updateQuery, conn, transaction)

            updateCmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

            updateCmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = CByte(enTournamentStatus.RegistrationClosed)

            updateCmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Shared Function GetTournamentPlayers(
        tournamentID As Integer
    ) As DataTable

        Dim dt As New DataTable()

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
                "SELECT
                 TP.TournamentPlayerID,
                 U.UserID,
                 U.Name AS PlayerName,
                 TP.RegistrationDate
              FROM TournamentPlayers TP
              INNER JOIN Users U
                 ON TP.CustomerID = U.UserID
              WHERE
                 TP.TournamentID = @TournamentID
                 AND TP.IsDeleted = 0"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                Try

                    conn.Open()

                    dt.Load(cmd.ExecuteReader())

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

                End Try

            End Using

        End Using

        Return dt

    End Function

    Public Shared Function RemovePlayer(PlayerID As Integer) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
                "UPDATE TournamentPlayers
                 SET IsDeleted = 1
                 WHERE TournamentPlayerID = @TournamentPlayerID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentPlayerID", SqlDbType.Int).Value = PlayerID

                conn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function

    Public Shared Function SelectWinner(tournamentID As Integer, customerID As Integer) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
                "UPDATE TournamentPlayers
                 SET IsWinner = 1
                 WHERE
                    TournamentID = @TournamentID
                    AND CustomerID = @CustomerID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID

                conn.Open()

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function

    Public Shared Function GetTournamentPlayersList(tournamentID As Integer) As List(Of TournamentPlayerDTO)

        Dim players As New List(Of TournamentPlayerDTO)()

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
                "SELECT TournamentPlayerID, TournamentID, CustomerID, RegisteredByAdminID, RegistrationDate, IsWinner, IsDeleted
                 FROM TournamentPlayers
                 WHERE TournamentID = @TournamentID AND IsDeleted = 0"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@TournamentID", SqlDbType.Int).Value = tournamentID

                Try

                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim player As New TournamentPlayerDTO With {
                                .TournamentPlayerID = CInt(reader("TournamentPlayerID")),
                                .TournamentID = CInt(reader("TournamentID")),
                                .CustomerID = CInt(reader("CustomerID")),
                                .RegisteredByUserID = CInt(reader("RegisteredByAdminID")),
                                .RegistrationDate = CDate(reader("RegistrationDate")),
                                .IsWinner = CBool(reader("IsWinner")),
                                .IsDeleted = CBool(reader("IsDeleted"))
                            }

                            players.Add(player)

                        End While

                    End Using

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

                End Try

            End Using

        End Using

        Return players

    End Function

End Class