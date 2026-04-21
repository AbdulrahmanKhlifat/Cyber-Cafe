Module Program
    <STAThread>
    Sub Main()
        ' Standard setup for Windows Forms
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Using frm As New frmLogin()
            frm.ShowDialog()
        End Using
    End Sub
End Module