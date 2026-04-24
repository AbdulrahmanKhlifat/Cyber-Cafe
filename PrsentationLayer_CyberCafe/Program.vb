Module Program
    <STAThread>
    Sub Main()
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