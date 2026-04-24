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

    End Class
End Namespace