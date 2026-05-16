Imports System.Data.SqlClient
Imports CyberCafe_DataAccess.CyberCafe.DAL
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models

Public Class CustomerRepo
    Public Shared Function AddCustomer(customer As CustomerDTO) As Integer
        Dim userID As Integer = -1

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

            Dim tran As SqlTransaction = Nothing

            Try

                conn.Open()

                tran = conn.BeginTransaction()

                ' Note: RoleType is set to 2 for Customers, assuming 1 is for Admins.
                Dim InsertUserCommand As String = "INSERT INTO Users
                (Name, Username, PasswordHash, RoleType, Email, Phone, IsDeleted)
                VALUES
                (@Name, @Username, @PasswordHash, 2, @Email, @Phone, @IsDeleted);
                SELECT SCOPE_IDENTITY();"

                Using cmd As SqlCommand = New SqlCommand(InsertUserCommand, conn, tran)
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = customer.Name
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 20).Value = customer.Username
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 255).Value = customer.Password
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 255).Value = customer.Email
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = customer.Phone
                    cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = customer.IsDeleted

                    Dim results As Object = cmd.ExecuteScalar()
                    userID = Convert.ToInt32(results)
                End Using

                Dim InsertCustomerCommand As String = "INSERT INTO Customers
                (UserID, CreatedAt, Credit, TotalHoursRes, CreatedByAdminID)
                VALUES(@UserID, @CreatedAt, @Credit, @TotalHoursRes, @CreatedByAdminID);"

                Using cmd As SqlCommand = New SqlCommand(InsertCustomerCommand, conn, tran)
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userID
                    cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = DateTime.Now()
                    cmd.Parameters.Add("@Credit", SqlDbType.Decimal).Value = customer.Credit
                    cmd.Parameters.Add("@TotalHoursRes", SqlDbType.Int).Value = customer.TotalHoursRes
                    cmd.Parameters.Add("@CreatedByAdminID", SqlDbType.Int).Value = customer.CreatedByAdminID

                    cmd.ExecuteNonQuery()
                End Using

                tran.Commit()

                Return userID

            Catch ex As Exception : CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
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

    Public Shared Function UpdateCustomer(customer As CustomerDTO) As Boolean
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

                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = customer.UserID
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = customer.Name
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 20).Value = customer.Username
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 255).Value = customer.Password
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 255).Value = customer.Email
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = customer.Phone
                    cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = customer.IsDeleted

                    cmd.ExecuteNonQuery()
                End Using

                Dim UpdateCustomerCommand As String = "UPDATE Customers 
                SET CreatedAt = @CreatedAt,
                    Credit = @Credit,
                    TotalHoursRes = @TotalHoursRes,
                    CreatedByAdminID = @CreatedByAdminID
                WHERE UserID = @UserID;"

                Using cmd As SqlCommand = New SqlCommand(UpdateCustomerCommand, conn, tran)
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = customer.UserID
                    cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = customer.CreatedAt
                    cmd.Parameters.Add("@Credit", SqlDbType.Decimal).Value = customer.Credit
                    cmd.Parameters.Add("@TotalHoursRes", SqlDbType.Int).Value = customer.TotalHoursRes
                    cmd.Parameters.Add("@CreatedByAdminID", SqlDbType.Int).Value = customer.CreatedByAdminID

                    cmd.ExecuteNonQuery()
                End Using

                tran.Commit()
                isUpdated = True

            Catch ex As Exception : CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
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

    Public Shared Function DeleteCustomer(userID As Integer) As Boolean
        Return UserRepo.DeleteUser(userID)
    End Function

    Public Shared Function AddCredits(
    customerID As Integer,
    amount As Decimal,
    processedByAdminID As Integer
) As Boolean

        If customerID <= 0 Then
            Throw New Exception("Invalid customer ID.")
        End If

        If amount <= 0 Then
            Throw New Exception(
            "Amount must be greater than zero."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            conn.Open()

            Using trans As SqlTransaction =
            conn.BeginTransaction()

                Try

                    Dim query As String =
                "UPDATE Customers
                 SET Credit = Credit + @Amount
                 WHERE UserID = @UserID"

                    Using cmd As New SqlCommand(
                    query,
                    conn,
                    trans
                )

                        cmd.Parameters.Add(
                        "@Amount",
                        SqlDbType.Decimal
                    ).Value = amount

                        cmd.Parameters.Add(
                        "@UserID",
                        SqlDbType.Int
                    ).Value = customerID

                        Dim rowsAffected As Integer =
                        cmd.ExecuteNonQuery()

                        If rowsAffected = 0 Then

                            Throw New Exception(
                            "Customer not found or failed to add credits."
                        )

                        End If

                    End Using

                    Dim transactionDto As New TransactionDTO()

                    With transactionDto
                        .ProcessedByAdminID = processedByAdminID

                        .TransactionType =
                        CInt(TransactionType.AddCredit)

                        .PaidAmount = amount

                        .TransactionDate =
                        DateTime.Now

                        .TransactionNotes =
                        "Customer credit added."

                        .CustomerID = customerID

                        .SessionID = Nothing

                        .IsDeleted = False

                    End With

                    Dim transactionID As Integer =
                    TransactionRepo.AddTransaction(
                        transactionDto,
                        conn,
                        trans
                    )

                    If transactionID <= 0 Then

                        Throw New Exception(
                        "Failed to create transaction."
                    )

                    End If

                    trans.Commit()

                    Return True

                Catch ex As Exception

                    trans.Rollback()

                    ErrorLogger.LogErrorToFile(
                    ex,
                    Reflection.MethodBase.
                    GetCurrentMethod().Name
                )

                    Throw

                End Try

            End Using

        End Using

    End Function

    Public Shared Function DeductCredits(customerID As Integer, amount As Decimal, conn As SqlConnection, trans As SqlTransaction) As Boolean

        Dim rowsAffected As Integer = 0

        Try

            Dim query As String = "UPDATE Customers 
                                  SET Credit = Credit - @Amount WHERE UserID = @UserID AND Credit >= @Amount"

            Using cmd As New SqlCommand(query, conn, trans)

                cmd.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount

                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = customerID

                rowsAffected = cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

        Return rowsAffected > 0

    End Function

    Public Shared Function DeductCredits(
    customerID As Integer,
    amount As Decimal,
    processedByAdminID As Integer
) As Boolean

        If customerID <= 0 Then
            Throw New Exception("Invalid customer ID.")
        End If

        If amount <= 0 Then
            Throw New Exception(
            "Amount must be greater than zero."
        )
        End If

        Using conn As New SqlConnection(
        DataAccessSettings.connectionString
    )

            conn.Open()

            Using trans As SqlTransaction =
            conn.BeginTransaction()

                Try

                    Dim query As String =
                "UPDATE Customers
                 SET Credit = Credit - @Amount
                 WHERE UserID = @UserID
                 AND Credit >= @Amount"

                    Using cmd As New SqlCommand(
                    query,
                    conn,
                    trans
                )

                        cmd.Parameters.Add(
                        "@Amount",
                        SqlDbType.Decimal
                    ).Value = amount

                        cmd.Parameters.Add(
                        "@UserID",
                        SqlDbType.Int
                    ).Value = customerID

                        Dim rowsAffected As Integer =
                        cmd.ExecuteNonQuery()

                        If rowsAffected = 0 Then

                            Throw New Exception(
                            "Insufficient credit or customer not found."
                        )

                        End If

                    End Using

                    Dim transactionDto As New TransactionDTO()

                    With transactionDto

                        .ProcessedByAdminID =
                        processedByAdminID

                        .TransactionType =
                        CInt(TransactionType.DeductCredit)

                        .PaidAmount = amount

                        .TransactionDate =
                        DateTime.Now

                        .TransactionNotes =
                        "Customer credit deducted."

                        .CustomerID = customerID

                        .SessionID = Nothing

                        .IsDeleted = False

                    End With

                    Dim transactionID As Integer =
                    TransactionRepo.AddTransaction(
                        transactionDto,
                        conn,
                        trans
                    )

                    If transactionID <= 0 Then

                        Throw New Exception(
                        "Failed to create transaction."
                    )

                    End If

                    trans.Commit()

                    Return True

                Catch ex As Exception

                    trans.Rollback()

                    ErrorLogger.LogErrorToFile(
                    ex,
                    Reflection.MethodBase.
                    GetCurrentMethod().Name
                )

                    Throw

                End Try

            End Using

        End Using

    End Function

    Public Shared Function GetCustomerCredits(customerID As Integer, conn As SqlConnection, trans As SqlTransaction) As Decimal

        Dim credits As Decimal = 0

        Try

            Dim query As String = "SELECT Credit
                                  FROM Customers WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, conn, trans)

                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = customerID

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then

                    credits = Convert.ToDecimal(result)

                End If

            End Using

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

        Return credits

    End Function


    Public Shared Function GetAllActiveCustomers() As DataTable
        Dim dt As DataTable = New DataTable()

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT 
                                    u.UserID, 
                                    u.Name as FullName, 
                                    u.Username, 
                                    u.Email, 
                                    u.Phone, 
                                    c.CreatedAt,
                                    c.Credit
                               FROM Customers c
                               INNER JOIN Users u ON c.UserID = u.UserID
                               WHERE u.IsDeleted = 0;"

            Using cmd As SqlCommand = New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            dt.Load(reader)
                        End If

                    End Using

                Catch ex As Exception : CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using
        End Using

        Return dt
    End Function

    Public Shared Function GetAllCustomers() As DataTable
        Dim dt As DataTable = New DataTable()

        Using conn As SqlConnection = New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT 
                                    u.UserID, 
                                    u.Name as FullName, 
                                    u.Username, 
                                    u.Email, 
                                    u.Phone, 
                                    c.CreatedAt,
                                    c.CreatedByAdminID
                               FROM Customers c
                               INNER JOIN Users u ON c.UserID = u.UserID;"

            Using cmd As SqlCommand = New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            dt.Load(reader)
                        End If

                    End Using

                Catch ex As Exception : CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                End Try
            End Using
        End Using

        Return dt
    End Function

    Public Shared Function GetCustomerInfoByID(userID As Integer) As CustomerDTO

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "Select u.UserID, u.Name, u.Username,
            u.Email, u.Phone, u.PasswordHash,
            u.RoleType, u.IsDeleted,
            c.CreatedAt, c.Credit, c.TotalHoursRes, c.CreatedByAdminID
            from Users u
            Inner join Customers c 
            On c.UserID = u.UserID
            Where U.UserID = @UserID and IsDeleted = 0;"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userID

                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader

                        If reader.Read() Then

                            Dim customer As New CustomerDTO
                            With customer
                                .UserID = userID
                                .Name = CType(reader("Name"), String)
                                .Username = CType(reader("Username"), String)
                                .Email = CType(reader("Email"), String)
                                .Phone = CType(reader("Phone"), String)
                                .Password = CType(reader("PasswordHash"), String)
                                .IsDeleted = CType(reader("IsDeleted"), Boolean)
                                .CreatedAt = CType(reader("CreatedAt"), DateTime)
                                .Credit = CType(reader("Credit"), Decimal)
                                .TotalHoursRes = CType(reader("TotalHoursRes"), Integer)
                                .CreatedByAdminID = CType(reader("CreatedByAdminID"), Integer)
                                .RoleType = CType(reader("RoleType"), UserRoleType)
                            End With

                            Return customer

                        End If

                    End Using

                Catch ex As Exception : CyberCafeModels.ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)
                    Return Nothing
                End Try

            End Using
        End Using
        Return Nothing
    End Function

    Public Shared Function IsCustomerExistsByID(UserID As Integer) As Boolean
        Return UserRepo.IsUserExistsByID(UserID)
    End Function
    '''
    Public Shared Function IsUsernameTaken(username As String) As Boolean
        Return UserRepo.IsUsernameTaken(username)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="اوف"></param>
    ''' <returns></returns>

    Public Shared Function GetTop10Customers(search As String) As List(Of CustomerDTO)

        Dim result As New List(Of CustomerDTO)

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT TOP 10 U.UserID, U.Name " &
            "FROM Customers C " &
            "JOIN Users U ON C.UserID = U.UserID " &
            "WHERE (U.Name LIKE @Search OR @Search = '%%') " &
            "AND NOT EXISTS ( " &
            "   SELECT 1 " &
            "   FROM Sessions S " &
            "   WHERE S.CustomerID = C.UserID " &
            "   AND S.SessionStatus = @ActiveStatus " &
            ") " &
            "ORDER BY U.Name ASC"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue(
                "@Search",
                "%" & search & "%")

                cmd.Parameters.AddWithValue(
                "@ActiveStatus",
                CInt(SessionStatus.Active))

                conn.Open()

                Using reader = cmd.ExecuteReader()

                    While reader.Read()

                        result.Add(New CustomerDTO With {
                        .UserID = CInt(reader("UserID")),
                        .Name = reader("Name").ToString()
                    })

                    End While

                End Using

            End Using

        End Using

        Return result

    End Function

    Public Shared Function HasActiveSessionByCustomerId(customerID As Integer) As Boolean

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String = "SELECT COUNT(1) FROM Sessions WHERE CustomerID = @CustomerID AND SessionStatus = @ActiveStatus"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@CustomerID", customerID)
                cmd.Parameters.AddWithValue("@ActiveStatus", CInt(SessionStatus.Active))

                Try
                    conn.Open()

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    Return count > 0

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(ex, System.Reflection.MethodBase.GetCurrentMethod().Name)

                    Throw

                End Try

            End Using

        End Using

    End Function

End Class