Imports System.Runtime.InteropServices
Module Program
    <DllImport("user32.dll", SetLastError:=True)>
    Private Function SetProcessDPIAware() As Boolean
    End Function
    <STAThread>
    Sub Main()
        Try
            SetProcessDPIAware()
        Catch ex As Exception
        End Try
        ' Standard setup for Windows Forms
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        If Environment.OSVersion.Version.Major >= 6 Then
            SetProcessDPIAware()
        End If

        Using frm As New frmLogin()
            frm.ShowDialog()
        End Using
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Function SetProcessDPIAware() As Boolean
    End Function
End Module