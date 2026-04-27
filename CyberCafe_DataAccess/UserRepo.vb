Imports System.Data.SqlClient
Imports CyberCafeModels.CyberCafe.Models

Namespace CyberCafe.DAL
    Public Class UserRepo

        Public Shared Function CheckCredentials(username As String, passwordHash As String) As LoginResultDTO
            Dim results As New LoginResultDTO With {
                .UserID = Nothing,
                .Role = UserRoleType.None,
                .IsDeleted = False
                }

            Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String = "Select Users.UserID, Users.RoleType,Users.IsDeleted From Users
                                        Where Users.Username = @username
                                        AND Users.PasswordHash = @passwordHash"

                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 20).Value = username
                    cmd.Parameters.Add("@passwordHash", SqlDbType.NVarChar, 255).Value = passwordHash

                    Try
                        conn.Open()

                        Using reader As SqlDataReader = cmd.ExecuteReader()

                            If reader.Read() Then

                                results.UserID = CType(reader("UserID"), Integer)
                                results.Role = CType(reader("RoleType"), UserRoleType)
                                results.IsDeleted = CType(reader("IsDeleted"), Boolean)
                            Else
                                results.UserID = Nothing
                                results.Role = UserRoleType.None
                                results.IsDeleted = False
                            End If

                        End Using

                    Catch ex As Exception
                        results.UserID = Nothing
                        results.Role = UserRoleType.None
                        results.IsDeleted = True
                    End Try

                End Using

            End Using

            Return results

        End Function

        Public Shared Function DeleteUser(userID As Integer) As Boolean
            Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)
                Dim query As String = "UPDATE Users SET IsDeleted = 1 WHERE UserID = @UserID;"

                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userID

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    Return (rowsAffected > 0)
                End Using
            End Using
        End Function

        Public Shared Function IsUserExistsByID(userID As Integer) As Boolean
            Dim isFound = False

            Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)
                Dim query = "Select Found = 1 From Users WHERE UserID = @UserID"

                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", userID)

                    Try
                        conn.Open()
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            isFound = reader.HasRows
                        End Using

                    Catch
                        isFound = False
                    End Try
                End Using
            End Using
            Return isFound
        End Function

        Public Shared Function IsUsernameTaken(username As String) As Boolean
            Dim isFound = False
            Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)
                Dim query = "Select Found = 1 From Users WHERE Username = @username"

                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)

                    Try
                        conn.Open()
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            isFound = reader.HasRows
                        End Using

                    Catch
                        isFound = False
                    End Try
                End Using
            End Using
            Return isFound
        End Function
    End Class
End Namespace