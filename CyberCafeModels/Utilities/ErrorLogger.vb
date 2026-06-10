Imports System.IO





Public Class ErrorLogger
    'This Class Should be in its own infrastructure layer kept here for simplicity

    ' Method and parameter description for mouse hover
    ''' <summary>
    ''' Logs an exception to a text file in the application's root directory.
    ''' </summary>
    ''' <param name="ex">The exception that was thrown.</param>
    ''' <param name="methodName">The name of the method where the error occurred.</param>
    Public Shared Sub LogErrorToFile(ex As Exception, methodName As String)

        ' 1. Get the directory where the .exe is running from
        Dim appPath As String = AppDomain.CurrentDomain.BaseDirectory

        ' 2. Combine it to create a "Logs" folder right next to the .exe
        Dim logDirectory As String = Path.Combine(appPath, "Logs")
        Dim logFilePath As String = Path.Combine(logDirectory, "ErrorLog.txt")

        Try
            ' Create the Logs directory if it doesn't exist
            If Not Directory.Exists(logDirectory) Then
                Directory.CreateDirectory(logDirectory)
            End If

            ' Open the file in append mode (True)
            Using writer As New StreamWriter(logFilePath, True)
                writer.WriteLine("--------------------------------------------------")
                writer.WriteLine($"Date        : {DateTime.Now}")
                writer.WriteLine($"Method      : {methodName}")
                writer.WriteLine($"Error       : {ex.Message}")
                writer.WriteLine($"Stack Trace : {ex.StackTrace}")
                writer.WriteLine("--------------------------------------------------")
                writer.WriteLine()
            End Using

        Catch logEx As Exception
            System.Diagnostics.Debug.WriteLine($"Failed to log error: {logEx.Message}")
        End Try
    End Sub

    Public Shared Sub LogNullSession(methodName As String)

        Dim appPath As String = AppDomain.CurrentDomain.BaseDirectory

        Dim logDirectory As String = Path.Combine(appPath, "Logs")
        Dim logFilePath As String = Path.Combine(logDirectory, "ErrorLog.txt")

        Try

            If Not Directory.Exists(logDirectory) Then
                Directory.CreateDirectory(logDirectory)
            End If

            Using writer As New StreamWriter(logFilePath, True)

                writer.WriteLine("--------------------------------------------------")
                writer.WriteLine($"Date        : {DateTime.Now}")
                writer.WriteLine($"Method      : {methodName}")
                writer.WriteLine("Error       : A Session object was Nothing during runtime engine load.")
                writer.WriteLine("--------------------------------------------------")
                writer.WriteLine()

            End Using

        Catch logEx As Exception
            Debug.WriteLine($"Failed to log error: {logEx.Message}")
        End Try

    End Sub

End Class