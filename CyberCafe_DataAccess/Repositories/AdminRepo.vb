Imports System.Data.SqlClient
Imports System.Reflection
Imports CyberCafe_DataAccess.CyberCafe.DAL
Imports CyberCafeModels.CyberCafe.Models


Public Class AdminRepo
    Public Shared Function AddAdmin(admin As AdminDTO) As Integer
        Dim userID As Integer = -1

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

            Dim tran As SqlTransaction = Nothing

            Try

                conn.Open()

                tran = conn.BeginTransaction()

                Dim InsertUserCommand As String = "INSERT INTO Users
                (Name, Username, PasswordHash, RoleType, Email, Phone, IsDeleted)
                VALUES
                (@Name, @Username, @PasswordHash, 1, @Email, @Phone, @IsDeleted);
                SELECT SCOPE_IDENTITY();"

                Using cmd As SqlCommand = New SqlCommand(InsertUserCommand, conn, tran)
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = admin.Name
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 20).Value = admin.Username
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 255).Value = admin.Password
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 255).Value = admin.Email
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = admin.Phone
                    cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = admin.IsDeleted

                    Dim results As Object = cmd.ExecuteScalar()
                    userID = Convert.ToInt32(results)
                End Using

                Dim InsertAdminCommand As String = "INSERT INTO Admins
                (UserID, HireDate)
                VALUES(@UserID, @HireDate);"

                Using cmd As SqlCommand = New SqlCommand(InsertAdminCommand, conn, tran)
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userID
                    cmd.Parameters.Add("@HireDate", SqlDbType.Date).Value = admin.HireDate

                    cmd.ExecuteNonQuery()
                End Using

                tran.Commit()

                Return userID

            Catch ex As Exception

                CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                'Check if transaction started before attempting rollback
                If tran IsNot Nothing Then
                    Try
                        tran.Rollback()
                    Catch rollbackEx As Exception
                        ' In case the connection completely dropped
                    End Try
                End If

                'failure
                Return -1
            End Try
        End Using
    End Function

    Public Shared Function UpdateAdmin(admin As AdminDTO) As Boolean
        Dim isUpdated As Boolean = False

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

            Dim tran As SqlTransaction = Nothing

            Try
                conn.Open()
                tran = conn.BeginTransaction()

                Dim UpdateUserCommand As String = "UPDATE Users 
                SET Name = @Name, 
                    Username = @Username, 
                    PasswordHash = @PasswordHash, 
                    Email = @Email, 
                    Phone = @Phone, 
                    IsDeleted = @IsDeleted
                WHERE UserID = @UserID;"

                Using cmd As SqlCommand = New SqlCommand(UpdateUserCommand, conn, tran)

                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = admin.UserID
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = admin.Name
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 20).Value = admin.Username
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 255).Value = admin.Password
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 255).Value = admin.Email
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = admin.Phone
                    cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = admin.IsDeleted

                    cmd.ExecuteNonQuery()
                End Using

                Dim UpdateAdminCommand As String = "UPDATE Admins 
                SET HireDate = @HireDate 
                WHERE UserID = @UserID;"

                Using cmd As SqlCommand = New SqlCommand(UpdateAdminCommand, conn, tran)
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = admin.UserID
                    cmd.Parameters.Add("@HireDate", SqlDbType.Date).Value = admin.HireDate

                    cmd.ExecuteNonQuery()
                End Using

                tran.Commit()
                isUpdated = True

            Catch ex As Exception

                CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                'Rollback safely on failure
                If tran IsNot Nothing Then
                    Try
                        tran.Rollback()
                    Catch rollbackEx As Exception
                        ' In case the connection completely dropped
                    End Try
                End If

                isUpdated = False
            End Try
        End Using

        Return isUpdated
    End Function

    Public Shared Function DeleteAdmin(userID As Integer) As Boolean
        Return UserRepo.DeleteUser(userID)
    End Function

    Public Shared Function GetAllActiveAdmins() As DataTable
        Dim dt As DataTable = New DataTable()

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT 
                                    u.UserID, 
                                    u.Name, 
                                    u.Username, 
                                    u.Email, 
                                    u.Phone, 
                                    a.HireDate
                               FROM Admins a
                               INNER JOIN Users u ON a.UserID = u.UserID
                               WHERE u.IsDeleted = 0;"

            Using cmd As SqlCommand = New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            dt.Load(reader)
                        End If

                    End Using

                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, MethodBase.GetCurrentMethod().Name)

                    Return Nothing
                End Try
            End Using
        End Using

        Return dt
    End Function

    Public Shared Function GetAllAdmins() As DataTable
        Dim dt As DataTable = New DataTable()

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT 
                                    u.UserID, 
                                    u.Name, 
                                    u.Username, 
                                    u.Email, 
                                    u.Phone, 
                                    a.HireDate
                               FROM Admins a
                               INNER JOIN Users u ON a.UserID = u.UserID;"

            Using cmd As SqlCommand = New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            dt.Load(reader)
                        End If

                    End Using

                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                    Return Nothing

                End Try
            End Using
        End Using

        Return dt
    End Function

    Public Shared Function GetAdminInfoByID(userID As Integer) As AdminDTO

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "Select u.UserID, u.Name, u.Username,
            u.Email, u.Phone, u.PasswordHash,
            u.RoleType, u.IsDeleted,
            a.HireDate
            from Users u
            Inner join Admins a 
            On a.UserID = u.UserID
            Where U.UserID = @UserID and IsDeleted = 0;"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userID

                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader

                        If reader.Read() Then

                            Dim admin As New AdminDTO
                            With admin
                                .UserID = userID
                                .Name = CType(reader("Name"), String)
                                .Username = CType(reader("Username"), String)
                                .Email = CType(reader("Email"), String)
                                .Phone = CType(reader("Phone"), String)
                                .Password = CType(reader("PasswordHash"), String)
                                .IsDeleted = CType(reader("IsDeleted"), Boolean)
                                .HireDate = CType(reader("HireDate"), Date)
                                .RoleType = CType(reader("RoleType"), UserRoleType)
                            End With

                            Return admin

                        End If

                    End Using

                Catch ex As Exception

                    CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                    Return Nothing
                End Try

            End Using
        End Using
        Return Nothing
    End Function

    Public Shared Function IsAdminExistsByID(UserID As Integer) As Boolean
        Return UserRepo.IsUserExistsByID(UserID)
    End Function

    Public Shared Function IsUsernameTaken(username As String) As Boolean
        Return UserRepo.IsUsernameTaken(username)
    End Function
End Class
