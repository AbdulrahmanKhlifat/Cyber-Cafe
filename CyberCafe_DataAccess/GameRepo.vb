Imports System.Data.SqlClient
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class GameRepo
    Public Shared Function AddNewGame(gameDTO As GameDTO) As Integer
        Dim gameID As Integer = -1
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "INSERT INTO Games (GameName, GameDescription) 
                                   VALUES (@GameName, @GameDescription);
                                   SELECT SCOPE_IDENTITY();"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@GameName", SqlDbType.NVarChar, 50).Value = gameDTO.GameName
                cmd.Parameters.Add("@GameDescription", SqlDbType.NVarChar, 200).Value =
                    If(String.IsNullOrEmpty(gameDTO.GameDescription), DBNull.Value, gameDTO.GameDescription)

                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        gameID = Convert.ToInt32(result)
                    End If
                Catch ex As Exception

                End Try
            End Using
        End Using
        Return gameID
    End Function


    Public Shared Function GetGameByID(gameID As Integer) As GameDTO
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT GameID, GameName, GameDescription FROM Games WHERE GameID = @GameID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = gameID
                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New GameDTO() With {
                                .GameID = CType(reader("GameID"), Integer),
                                .GameName = CType(reader("GameName"), String),
                                .GameDescription = If(reader("GameDescription") Is DBNull.Value, "", CType(reader("GameDescription"), String))
                            }
                        End If
                    End Using
                Catch ex As Exception
                End Try
            End Using
        End Using
        Return Nothing
    End Function


    Public Shared Function GetAllGames() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT GameID, GameName, GameDescription FROM Games"
            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()
                    dt.Load(cmd.ExecuteReader())
                Catch ex As Exception
                End Try
            End Using
        End Using
        Return dt
    End Function
    Public Shared Function IsGameExists(gameName As String) As Boolean
        Dim Isexists As Boolean = False
        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT 1 FROM Games WHERE GameName = @GameName"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@GameName", SqlDbType.NVarChar, 50).Value = gameName
                Try
                    conn.Open()
                    Isexists = (cmd.ExecuteScalar() IsNot Nothing)
                Catch ex As Exception
                End Try
            End Using
        End Using
        Return Isexists
    End Function
End Class