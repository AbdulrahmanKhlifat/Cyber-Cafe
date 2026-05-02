Imports System.Data.SqlClient
Imports CyberCafeModels

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
                    If(String.IsNullOrEmpty(gameDTO.ImagePath), DBNull.Value, gameDTO.ImagePath)

                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        gameID = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

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
                                .ImagePath = If(reader("ImagePath") Is DBNull.Value, "", CType(reader("ImagePath"), String))
                            }

                        End If
                    End Using

                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Try
            End Using
        End Using

        Return Nothing
    End Function


    Public Shared Function GetAllGames() As List(Of GameDTO)

        Dim gamesList As New List(Of GameDTO)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)
            Dim query As String = "SELECT GameID, GameName, GameDescription FROM Games"

            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()

                            Dim game As New GameDTO With {
                            .GameID = Convert.ToInt32(reader("GameID")),
                            .GameName = reader("GameName").ToString(),
                            .ImagePath = If(reader("ImagePath") Is DBNull.Value, "", reader("ImagePath").ToString())
                        }

                            gamesList.Add(game)
                        End While
                    End Using

                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                End Try
            End Using
        End Using


        Return gamesList
    End Function
    Public Shared Function IsGameExists(gameName As String) As Boolean
        Dim isFound As Boolean = False
        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT 1 FROM Games WHERE GameName = @GameName"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@GameName", SqlDbType.NVarChar, 50).Value = gameName

                Try
                    conn.Open()
                    isFound = (cmd.ExecuteScalar() IsNot Nothing)
                Catch ex As Exception
                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using

        End Using
        Return isFound
    End Function
End Class