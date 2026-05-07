Imports System.Data.SqlClient
Imports System.IO
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmAddPlatform

    Private _PlatformID As Integer = -1
    Private _Platform As DeviceTypeDTO
    Private _selectedImagePath As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(platformID As Integer)
        InitializeComponent()
        _PlatformID = platformID
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                _selectedImagePath = ofd.FileName


                If picPlatform.Image IsNot Nothing Then picPlatform.Image.Dispose()


                picPlatform.Image = UIHelper.LoadImageUnlocked(_selectedImagePath)
            End If
        End Using
    End Sub

    Private Function HandleImageStorage() As String

        Try

            If picPlatform.Image IsNot Nothing AndAlso Not String.IsNullOrEmpty(_selectedImagePath) Then

                Return UIHelper.SaveImageToDirectory(picPlatform.Image, 60, 60)

            End If


            Return If(_Platform IsNot Nothing, _Platform.ImagePath, Nothing)

        Catch ex As Exception
            Throw New IOException("Failed to process and save the platform image: " & ex.Message)
        End Try

    End Function

    Private Function CreatePlatformDTO(savedFileName As String) As DeviceTypeDTO
        Return New DeviceTypeDTO With {
            .DeviceTypeName = txtPlatformName.Text.Trim(),
            .DeviceDescription = txtDescription.Text.Trim(),
            .ImagePath = If(String.IsNullOrEmpty(savedFileName), Nothing, savedFileName)
        }
    End Function

    Private Sub CleanupImage(fileName As String)
        If String.IsNullOrEmpty(fileName) Then Exit Sub

        Dim fullPath = UIHelper.GetImagePath(fileName)

        Try
            ' 1. تحرير الذاكرة بشكل هجومي
            GC.Collect()
            GC.WaitForPendingFinalizers()

            If File.Exists(fullPath) Then
                ' 2. محاولة الحذف العادية
                File.Delete(fullPath)
            End If
        Catch ex As Exception
            ' 3. إذا فشل (بسبب الشاشة اللي ورا)، سنقوم بإعادة تسمية الملف 
            ' لكي يختفي منطقياً ثم يحذف عند إغلاق البرنامج
            Try
                Dim renamedPath = fullPath & ".deleted"
                If File.Exists(renamedPath) Then File.Delete(renamedPath)
                File.Move(fullPath, renamedPath)
                ' التحريك (Move) أحياناً ينجح حتى لو كان الملف مقفلاً للقراءة
            Catch
                ' إذا فشل كل شيء، لا تظهر خطأ لكي لا يتوقف البرنامج
            End Try
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtPlatformName.Text) Then
            UIHelper.ShowGunaMessage("Please enter name.", "Error", MessageDialogIcon.Warning)
            Return
        End If

        Dim savedFileName As String = ""
        Dim success As Boolean = False
        Dim oldImageName As String = If(_Platform IsNot Nothing, _Platform.ImagePath, "")

        Try
            savedFileName = HandleImageStorage()
            Dim deviceType = CreatePlatformDTO(savedFileName)

            If _PlatformID = -1 Then
                success = DeviceTypeServices.Add(deviceType)
            Else
                deviceType.DeviceTypeID = _PlatformID
                success = DeviceTypeServices.Update(deviceType)


                If success AndAlso Not String.IsNullOrEmpty(oldImageName) AndAlso savedFileName <> oldImageName Then

                    If picPlatform.Image IsNot Nothing Then
                        picPlatform.Image.Dispose()
                        picPlatform.Image = Nothing
                    End If


                    CleanupImage(oldImageName)
                End If
            End If

            If success Then
                UIHelper.ShowGunaMessage("Saved successfully!", "Success", MessageDialogIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            UIHelper.ShowGunaMessage(ex.Message, "Error", MessageDialogIcon.Error)
        End Try
    End Sub

    Private Sub LoadPlatformData()
        _Platform = DeviceTypeServices.Find(_PlatformID)

        If _Platform IsNot Nothing Then
            lblTitle.Text = "Edit Platform"
            btnSave.Text = "Update Platform"
            txtPlatformName.Text = _Platform.DeviceTypeName
            txtDescription.Text = _Platform.DeviceDescription

            If Not String.IsNullOrEmpty(_Platform.ImagePath) Then
                Dim fullPath = UIHelper.GetImagePath(_Platform.ImagePath)

                picPlatform.Image = UIHelper.LoadImageUnlocked(fullPath)
            End If
        End If
    End Sub

    Private Sub frmAddPlatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2BorderlessForm1.AnimateWindow = True
        If _PlatformID <> -1 Then
            LoadPlatformData()
        End If
    End Sub

End Class