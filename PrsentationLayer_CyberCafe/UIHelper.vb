Imports System.IO
Imports CyberCafeModels
Imports Guna.UI2.WinForms
Public Class UIHelper

    Public Shared Sub ShowGunaMessage(message As String, caption As String, icon As MessageDialogIcon)
        Dim guna As New Guna2MessageDialog With {
            .Caption = caption,
            .Text = message,
            .Parent = System.Windows.Forms.Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = icon,
            .Buttons = MessageDialogButtons.OK
        }

        guna.Show()
    End Sub

    Public Shared Function ResizeImage(original As Image, Optional targetWidth As Integer = 130, Optional targetHeight As Integer = 160) As Image

        Dim bmp As New Bitmap(targetWidth, targetHeight)

        Using g As Graphics = Graphics.FromImage(bmp)

            g.InterpolationMode =
                Drawing2D.InterpolationMode.HighQualityBicubic

            g.DrawImage(
                original,
                0,
                0,
                targetWidth,
                targetHeight)

        End Using

        Return bmp

    End Function

    Public Shared Function GetImagesFolder() As String

        Dim basePath As String =
        Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
            "CyberCafe",
            "Images"
        )

        If Not Directory.Exists(basePath) Then
            Directory.CreateDirectory(basePath)
        End If

        Return basePath

    End Function

    Public Shared Function SaveImageToDirectory(img As Image, Optional targetWidth As Integer = 130, Optional targetHeight As Integer = 160) As String

        If img Is Nothing Then Return Nothing

        Dim imagesFolder As String = GetImagesFolder()
        Try
            Dim fileName As String =
                Guid.NewGuid().ToString() & ".png"

            Dim fullPath As String =
            Path.Combine(imagesFolder, fileName)

            Using resized As Image = ResizeImage(img, targetWidth, targetHeight)

                resized.Save(fullPath, Imaging.ImageFormat.Png)

            End Using

            Return fileName

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Return Nothing

        End Try

    End Function

    Public Shared Function SaveImageToDirectory(imageSourcePath As String, Optional targetWidth As Integer = 130, Optional targetHeight As Integer = 160) As String

        Return SaveImageToDirectory(Image.FromFile(imageSourcePath), targetWidth, targetHeight)

    End Function

    Public Shared Function GetImagePath(imageFileName As String) As String

        If String.IsNullOrEmpty(imageFileName) Then Return Nothing

        Dim imagesFolder As String = GetImagesFolder()

        Return Path.Combine(imagesFolder, imageFileName)

    End Function

    Public Shared Function LoadImageUnlocked(path As String) As Image
        Using fs As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)

            Return Image.FromStream(fs)

        End Using
    End Function

End Class
