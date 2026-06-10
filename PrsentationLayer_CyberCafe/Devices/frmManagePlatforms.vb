Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmManagePlatforms

    Private Sub frmManagePlatforms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub RefreshData()

        dgvPlatforms.DataSource = DeviceTypeServices.GetAllDeviceTypes()

        If dgvPlatforms.Columns.Count > 0 Then

            dgvPlatforms.Columns("DeviceTypeID").HeaderText = "ID"
            dgvPlatforms.Columns("DeviceTypeName").HeaderText = "Platform Name"
            dgvPlatforms.Columns("DeviceDescription").HeaderText = "Description"
            dgvPlatforms.Columns("PricePerHour").HeaderText = "Price/Hour"

            If dgvPlatforms.Columns.Contains("ImagePath") Then

                dgvPlatforms.Columns("ImagePath").Visible = False

            End If

            dgvPlatforms.Columns("DeviceTypeID").Width = 60
            dgvPlatforms.Columns("DeviceTypeName").Width = 200
            dgvPlatforms.Columns("PricePerHour").Width = 100

        End If
    End Sub

    Private Sub btnAddPlatform_Click(sender As Object, e As EventArgs) Handles btnAddPlatform.Click

        Using addForm As New frmAddPlatform()

            If addForm.ShowDialog() = DialogResult.OK Then

                RefreshData()

            End If

        End Using
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        If dgvPlatforms.SelectedRows.Count > 0 Then

            Dim platformID = Convert.ToInt32(dgvPlatforms.SelectedRows(0).Cells("DeviceTypeID").Value)

            Using editForm As New frmAddPlatform(platformID)

                If editForm.ShowDialog() = DialogResult.OK Then

                    RefreshData()

                End If

            End Using

        End If
    End Sub
    Public Shared Function ShowConfirm(message As String, Optional caption As String = "Confirm") As DialogResult

        Dim guna As New Guna2MessageDialog With {
        .Caption = caption,
        .Text = message,
        .Parent = If(Form.ActiveForm, Application.OpenForms(0)),
        .Style = MessageDialogStyle.Dark,
        .Icon = MessageDialogIcon.Question,
        .Buttons = MessageDialogButtons.YesNo
    }

        Return guna.Show()
    End Function

End Class