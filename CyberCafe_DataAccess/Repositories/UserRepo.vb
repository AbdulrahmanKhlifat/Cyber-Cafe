Imports System.Data.SqlClient
Imports CyberCafeModels.CyberCafe.Models

Namespace CyberCafe.DAL
    Public Class UserRepo

        Public Shared Function GetLoginInfoByUsername(username As String) As UserDTO
            Dim userDTO As New UserDTO

            Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

                Dim query As String = "Select Users.UserID,
                Users.RoleType, Users.IsDeleted,
                Users.PasswordHash From Users
                Where Users.Username = @username"

                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 20).Value = username

                    Try
                        conn.Open()

                        Using reader As SqlDataReader = cmd.ExecuteReader()

                            If reader.Read() Then

                                userDTO.UserID = CType(reader("UserID"), Integer)
                                userDTO.RoleType = CType(reader("RoleType"), UserRoleType)
                                userDTO.IsDeleted = CType(reader("IsDeleted"), Boolean)
                                userDTO.Password = CType(reader("PasswordHash"), String)
                            Else

                                userDTO = Nothing
                            End If

                        End Using

                    Catch ex As Exception

                        CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                        userDTO = Nothing
                    End Try

                End Using

            End Using

            Return userDTO

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
                Dim query = "Select Found = 1 From Users WHERE UserID = @UserID and IsDeleted = 0"

                Using cmd As SqlCommand = New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", userID)

                    Try
                        conn.Open()
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            isFound = reader.HasRows
                        End Using

                    Catch ex As Exception

                        CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

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

                    Catch ex As Exception
                        CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    End Try
                End Using
            End Using
            Return isFound
        End Function
    End Class
End Namespace