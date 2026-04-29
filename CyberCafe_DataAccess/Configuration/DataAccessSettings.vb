
Imports System.Configuration

Public Class DataAccessSettings
    Public Shared ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("MyDbConn").ConnectionString
End Class


