Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class TransactionManager

    Public Shared Function AddTransaction(transactionDTO As TransactionDTO) As TransactionResults

        If transactionDTO.CustomerID <= 0 Then
            Return TransactionResults.InvalidCustomerID
        End If

        If transactionDTO.ProcessedByAdminID <= 0 Then
            Return TransactionResults.InvalidAdminID
        End If


        If transactionDTO.TransactionDate = Date.MinValue Then
            transactionDTO.TransactionDate = DateTime.Now
        End If

        Dim transactionID = TransactionRepo.AddTransaction(transactionDTO)

        Return If(transactionID <> -1, TransactionResults.Success, TransactionResults.SystemError)
    End Function

    Public Shared Function Find(transactionID As Integer) As TransactionDTO
        Return TransactionRepo.GetTransactionByID(transactionID)
    End Function

    Public Shared Function DeleteTransaction(transactionID As Integer) As Boolean
        Dim isDeleted As Boolean = TransactionRepo.DeleteTransaction(transactionID)

        If Not isDeleted Then
            Throw New InvalidOperationException("Transaction does not exist or has already been deleted!")
        End If

        Return True
    End Function

    Public Shared Function GetAllActiveTransactions() As DataTable
        Return TransactionRepo.GetAllActiveTransactions()
    End Function

    Public Shared Function GetAllTransactions() As DataTable
        Return TransactionRepo.GetAllTransactions()
    End Function

End Class