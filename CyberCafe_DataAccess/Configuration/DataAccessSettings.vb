
Imports System.Configuration ' لازم تضيف هاد الـ Reference للمشروع

Public Class DataAccessSettings
    Public Shared ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("MyDbConn").ConnectionString
End Class


