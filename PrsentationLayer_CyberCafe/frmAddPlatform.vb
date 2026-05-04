Imports CyberCafeModels
Imports System.IO

Public Class frmAddPlatform


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtPlatformName.Text) Then
            UIHelper.ShowGunaMessage("Platform Name is required.", "Validation Error", MessageBoxIcon.Warning)
            Return
        End If

        ''سوي ال save

        UIHelper.ShowGunaMessage("Platform saved successfully! (UI Only)", "Success", MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmAddPlatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2BorderlessForm1.AnimateWindow = True
    End Sub
End Class
