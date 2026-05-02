Imports System.Data.SqlClient
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class DeviceGameRepo

    Public Shared Function AddGameToDevice(deviceID As Integer, gameID As Integer) As Boolean
        Dim rowsAffected As Integer = 0
        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "INSERT INTO DeviceGames (DeviceID, GameID) VALUES (@DeviceID, @GameID)"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID
                cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = gameID

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


    Public Shared Function RemoveGameFromDevice(deviceID As Integer, gameID As Integer) As Boolean
        Dim rowsAffected As Integer = 0
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "DELETE FROM DeviceGames WHERE DeviceID = @DeviceID AND GameID = @GameID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID
                cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = gameID

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
    Public Shared Function UpdateDeviceGames(deviceID As Integer, gameIDs As List(Of Integer)) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)


            Dim transaction As SqlTransaction = Nothing

            Try
                conn.Open()
                transaction = conn.BeginTransaction()
                Dim deleteQuery As String = "DELETE FROM DeviceGames WHERE DeviceID = @DeviceID"
                Using deleteCmd As New SqlCommand(deleteQuery, conn, transaction)

                    deleteCmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID
                    deleteCmd.ExecuteNonQuery()

                End Using


                ' Create table for bulk insert
                Dim table As New DataTable()

                table.Columns.Add("DeviceID", GetType(Integer))
                table.Columns.Add("GameID", GetType(Integer))

                For Each gameID In gameIDs

                    If gameID > 0 Then
                        table.Rows.Add(deviceID, gameID)
                    End If

                Next


                ' Bulk insert
                Using bulk As New SqlBulkCopy(
                conn,
                SqlBulkCopyOptions.Default,
                transaction)

                    bulk.DestinationTableName = "DeviceGames"

                    bulk.ColumnMappings.Add("DeviceID", "DeviceID")
                    bulk.ColumnMappings.Add("GameID", "GameID")

                    bulk.WriteToServer(table)

                End Using

                transaction.Commit()

                Return True

            Catch ex As Exception

                CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                transaction.Rollback()

                Return False

            End Try

        End Using


    End Function
    Public Shared Function IsGameExistInDevice(deviceID As Integer, gameID As Integer) As Boolean
        Dim isFound As Boolean = False

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT 1 FROM DeviceGames WHERE DeviceID = @DeviceID AND GameID = @GameID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID
                cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = gameID

                Try
                    conn.Open()

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        isFound = True
                    End If
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using
        End Using

        Return isFound
    End Function

    Public Shared Function GetGamesByDeviceID(deviceID As Integer) As List(Of GameDTO)

        Dim games As New List(Of GameDTO)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT g.GameID,
                    g.GameName,
                    g.ImagePath
             FROM Games g
             INNER JOIN DeviceGames dg
                 ON g.GameID = dg.GameID
             WHERE dg.DeviceID = @DeviceID"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID

                Try

                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim game As New GameDTO()

                            game.GameID =
                            CType(reader("GameID"), Integer)

                            game.GameName =
                            CType(reader("GameName"), String)

                            game.ImagePath =
                            If(
                                reader("ImagePath") Is DBNull.Value,
                                Nothing,
                                CType(reader("ImagePath"), String))

                            games.Add(game)

                        End While

                    End Using

                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(
                    ex,
                    System.Reflection.MethodBase.
                    GetCurrentMethod().Name)

                End Try

            End Using

        End Using

        Return games

    End Function


    Public Shared Function RemoveAllGamesFromDevice(deviceID As Integer) As Boolean
        Dim rowsAffected As Integer = 0

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "DELETE FROM DeviceGames WHERE DeviceID = @DeviceID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID

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

End Class