Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmAddEditConsumable

    Private Enum enMode
        AddNew
        Edit
    End Enum
    Private Property _Mode As enMode = enMode.AddNew
    Private Property _ConsumableId As Integer = -1
    Private Property _Consumable As ConsumableDTO

    Private Property _IsImageModified As Boolean = False
    Private Property _SelectedImagePath As String
    Private Property _SavedImageFileName As String = Nothing
    Private Property _ExistingImagePath As String

    Public Sub New()
        InitializeComponent()
        _Mode = enMode.AddNew
    End Sub

    Public Sub New(consumableId As Integer)
        InitializeComponent()
        _ConsumableId = consumableId
        _Mode = enMode.Edit
    End Sub

    Private Sub frmAddEditConsumable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _Mode = enMode.Edit Then
            LoadConsumableData()
        Else
            PrepareForAddNew()
        End If
    End Sub

    Private Sub PrepareForAddNew()
        lblHeader.Text = "ADD ITEM"
        btnSave.Text = "SAVE ITEM"
        txtItemName.Focus()
    End Sub

    Private Sub LoadConsumableData()
        lblHeader.Text = "EDIT ITEM"
        btnSave.Text = "UPDATE ITEM"

        _Consumable = ConsumableServices.GetConsumableByID(_ConsumableId)

        If _Consumable IsNot Nothing Then
            txtItemName.Text = _Consumable.ConsumableName
            txtDescription.Text = _Consumable.Description
            txtPrice.Text = _Consumable.Price.ToString("F2")
            _ExistingImagePath = UIHelper.GetImagePath(_Consumable.ImagePath)
            _SelectedImagePath = _ExistingImagePath

            Try
                If String.IsNullOrWhiteSpace(_Consumable.ImagePath) Then
                    pbConsumable.Image = My.Resources.latest
                Else
                    If IO.File.Exists(_ExistingImagePath) Then
                        pbConsumable.Image = Image.FromFile(_ExistingImagePath)
                    Else
                        pbConsumable.Image = My.Resources.latest
                    End If
                End If
            Catch
                pbConsumable.Image = My.Resources.latest
            End Try
        Else
            UIHelper.ShowGunaMessage("Error Loading Item Details.", "Error", MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Return

        If _Mode = enMode.AddNew Then
            SaveNewConsumable()
        Else
            UpdateExistingConsumable()
        End If
    End Sub

    Private Sub SaveNewConsumable()
        Dim newConsumable As ConsumableDTO = BuildConsumableObject()
        newConsumable.Quantity = 0 ' Default initial stock

        Try
            Dim success As Boolean = ConsumableServices.AddConsumable(newConsumable) > 0

            If success Then
                UIHelper.ShowGunaMessage("Item Added Successfully.", "Success", MessageDialogIcon.Information)
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                UIHelper.ShowGunaMessage("Failed to Add Item.", "Error", MessageDialogIcon.Error)
            End If
        Catch ex As Exception
            CleanupFailedImage()
            UIHelper.ShowGunaMessage("Something went wrong.", "Error", MessageDialogIcon.Error)
            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub

    Private Sub UpdateExistingConsumable()
        Dim updatedConsumable As ConsumableDTO = BuildConsumableObject()
        updatedConsumable.ConsumableId = _ConsumableId
        updatedConsumable.Quantity = _Consumable.Quantity ' Preserve existing stock

        Try
            Dim success As Boolean = ConsumableServices.UpdateConsumable(updatedConsumable)

            If success Then
                DeleteOldImageIfNeeded()
                UIHelper.ShowGunaMessage("Item Updated Successfully.", "Success", MessageDialogIcon.Information)
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                UIHelper.ShowGunaMessage("Failed to Update Item.", "Error", MessageDialogIcon.Error)
            End If
        Catch ex As Exception
            CleanupFailedImage()
            UIHelper.ShowGunaMessage("Something went wrong.", "Error", MessageDialogIcon.Error)
            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub

    Private Function BuildConsumableObject() As ConsumableDTO

        Dim consumable As New ConsumableDTO()
        consumable.ConsumableName = txtItemName.Text.Trim()
        consumable.Description = txtDescription.Text.Trim()
        consumable.Price = Convert.ToDecimal(txtPrice.Text.Trim())

        If _IsImageModified Then

            Try

                Using img As Image = Image.FromFile(_SelectedImagePath)

                    Dim resizedImage As Image = UIHelper.ResizeImage(img, 100, 80)
                    _SavedImageFileName = UIHelper.SaveImageToDirectory(resizedImage)
                    consumable.ImagePath = _SavedImageFileName

                End Using

            Catch

                consumable.ImagePath = Nothing

            End Try

        ElseIf _Consumable IsNot Nothing Then

            consumable.ImagePath = _Consumable.ImagePath

        End If

        Return consumable

    End Function

    Private Sub DeleteOldImageIfNeeded()
        If _IsImageModified AndAlso Not String.IsNullOrWhiteSpace(_ExistingImagePath) AndAlso IO.File.Exists(_ExistingImagePath) Then
            Try
                IO.File.Delete(_ExistingImagePath)
            Catch

            End Try
        End If
    End Sub

    Private Sub CleanupFailedImage()
        If _IsImageModified AndAlso Not String.IsNullOrWhiteSpace(_SavedImageFileName) Then
            Dim fullPath = UIHelper.GetImagePath(_SavedImageFileName)
            If IO.File.Exists(fullPath) Then
                IO.File.Delete(fullPath)
            End If
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtItemName.Text) Then
            UIHelper.ShowGunaMessage("Enter Item Name.", "Validation", MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPrice.Text) Then
            UIHelper.ShowGunaMessage("Enter Price.", "Validation", MessageBoxIcon.Warning)
            Return False
        End If

        Dim price As Decimal
        if Not Decimal.TryParse(txtPrice.Text.Trim(), price) Then
            UIHelper.ShowGunaMessage("Invalid Price.", "Validation", MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    _IsImageModified = True
                    _SelectedImagePath = ofd.FileName
                    
                    If pbConsumable.Image IsNot Nothing Then
                        pbConsumable.Image.Dispose()
                        pbConsumable.Image = Nothing
                    End If

                    Using fs As New IO.FileStream(_SelectedImagePath, IO.FileMode.Open, IO.FileAccess.Read)
                        pbConsumable.Image = Image.FromStream(fs)
                    End Using
                    pbConsumable.SizeMode = PictureBoxSizeMode.Zoom
                Catch ex As Exception
                    UIHelper.ShowGunaMessage("Failed to load image.", "Error", MessageDialogIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
