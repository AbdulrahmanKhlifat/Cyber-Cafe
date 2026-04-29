Imports System.Data.SqlClient
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
                Catch

                End Try
            End Using
        End Using
        Return rowsAffected > 0
    End Function

    Public Shared Function GetGamesByDeviceID(deviceID As Integer) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT g.GameID, g.GameName, g.GameDescription 
                                   FROM Games g
                                   INNER JOIN DeviceGames dg ON g.GameID = dg.GameID
                                   WHERE dg.DeviceID = @DeviceID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@DeviceID", SqlDbType.Int).Value = deviceID
                Try
                    conn.Open()
                    dt.Load(cmd.ExecuteReader())
                Catch

                End Try
            End Using
        End Using
        Return dt
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
                Catch

                End Try
            End Using
        End Using
        Return rowsAffected > 0
    End Function

End Class