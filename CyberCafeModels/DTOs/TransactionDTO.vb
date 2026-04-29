Public Class TransactionDTO
    Public Property TransactionID As Integer

    Public Property CustomerID As Integer

    Public Property ProcessedByAdminID As Integer

    Public Property TransactionType As TransactionType

    Public Property TransactionDate As DateTime

    Public Property TransactionNotes As String

    Public Property SessionID As Integer?

    Public Property IsDeleted As Integer
End Class
