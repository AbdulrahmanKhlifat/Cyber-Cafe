Imports System.ComponentModel.Design
Imports CyberCafe_DataAccess
Imports CyberCafeModels.CyberCafe.Models

Public Class CustomerServices


    Public Shared Function AddCustomer(customerDTO As CustomerDTO) As Boolean

        If CustomerRepo.IsUsernameTaken(customerDTO.Username) Then
            Throw New Exception("Username already exists.")
        End If

        customerDTO.Password =
            HashUtility.ComputeHash(customerDTO.Password)

        Dim userID =
            CustomerRepo.AddCustomer(customerDTO)

        Return userID <> -1

    End Function


    Public Shared Function UpdateCustomer(
        customerDTO As CustomerDTO) As Boolean

        Dim existingCustomer =
            CustomerRepo.GetCustomerInfoByID(
                customerDTO.UserID)

        If existingCustomer Is Nothing Then
            Return False
        End If


        If Not Equals(
            existingCustomer.Username,
            customerDTO.Username) _
            AndAlso CustomerRepo.IsUsernameTaken(
                customerDTO.Username) Then

            Throw New Exception(
                "Username already exists")

        End If


        If Not String.IsNullOrEmpty(
            customerDTO.Password) Then

            customerDTO.Password =
                HashUtility.ComputeHash(
                    customerDTO.Password)

        Else

            customerDTO.Password =
                existingCustomer.Password

        End If


        Return CustomerRepo.UpdateCustomer(
            customerDTO)

    End Function


    Public Shared Function Find(
        userID As Integer) As CustomerDTO

        Return CustomerRepo.GetCustomerInfoByID(
            userID)

    End Function


    Public Shared Function DeleteCustomer(
        userID As Integer) As Boolean

        Dim isDeleted As Boolean =
            CustomerRepo.DeleteCustomer(userID)

        If Not isDeleted Then

            Throw New InvalidOperationException(
                "Customer does not exist!")

        End If

        Return True

    End Function


    Public Function IsUserExist(
        userID As Integer) As Boolean

        Return CustomerRepo.IsCustomerExistsByID(
            userID)

    End Function


    Public Function VerifyPassword(
        userID As Integer,
        password As String) As Boolean

        Dim customer =
            CustomerRepo.GetCustomerInfoByID(
                userID)

        If customer Is Nothing Then
            Throw New Exception(
                "Customer does not exist!")
        End If


        If String.IsNullOrEmpty(password) Then
            Return False
        End If


        Return HashUtility.VerifyPassword(
            password,
            customer.Password)

    End Function

    Public Shared Function GetAllCustomers() As DataTable
        Return CustomerRepo.GetAllActiveCustomers()
    End Function


    Public Shared Function GetTop10Customers(Optional str As String = "", Optional excludeTournamentID As Integer = 0) As List(Of CustomerDTO)
        Return CustomerRepo.GetTop10Customers(str, excludeTournamentID)
    End Function

    Public Shared Function AddCredits(customerID As Integer, amount As Integer, processedByAdminID As Integer) As Boolean

        If amount <= 0 Then
            Throw New ArgumentException("Amount must be greater than zero.")
        End If

        Dim customer = CustomerRepo.GetCustomerInfoByID(customerID)

        If customer Is Nothing Then
            Throw New Exception("Customer does not exist.")
        End If

        Return CustomerRepo.AddCredits(customerID, amount, processedByAdminID)

    End Function

    Public Shared Function DeductCredits(customerID As Integer, amount As Integer, processedByAdminID As Integer) As Boolean

        If amount <= 0 Then
            Throw New ArgumentException("Amount must be greater than zero.")
        End If

        Dim customer = CustomerRepo.GetCustomerInfoByID(customerID)

        If customer Is Nothing Then
            Throw New Exception("Customer does not exist.")
        End If

        Return CustomerRepo.DeductCredits(customerID, amount, processedByAdminID)

    End Function

    Public Shared Function GetCustomerCreditBalance(customerID As Integer) As Decimal

        Return CustomerRepo.GetCustomerCredits(customerID)

    End Function

End Class
