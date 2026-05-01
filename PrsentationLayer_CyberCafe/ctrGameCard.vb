Public Class ctrGameCard

    Private Shared ReadOnly CyberDark As Color = Color.FromArgb(18, 18, 18)
    Private Shared ReadOnly CyberAccent As Color = Color.FromArgb(0, 251, 255)
    Private Shared ReadOnly CyberAccentDim As Color = Color.FromArgb(0, 180, 183)
    Private Shared ReadOnly CyberSurface As Color = Color.FromArgb(28, 28, 36)
    Private Shared ReadOnly CyberHover As Color = Color.FromArgb(35, 35, 48)
    Private Shared ReadOnly CyberBorder As Color = Color.FromArgb(40, 40, 55)
    Private Shared ReadOnly CyberText As Color = Color.FromArgb(220, 225, 230)
    Private Shared ReadOnly CyberTextDim As Color = Color.FromArgb(140, 145, 155)

    Private Const THUMB_WIDTH As Integer = 140
    Private Const THUMB_HEIGHT As Integer = 150

    Public Property GameID As Integer

    Public Property GameName As String
        Get
            Return btnGameCard.Text
        End Get
        Set(value As String)
            btnGameCard.Text = value
        End Set
    End Property

    Public Property ImagePath As String

    Public Property IsSelected As Boolean
        Get
            Return chkSelected.Checked
        End Get
        Set(value As Boolean)
            chkSelected.Checked = value
        End Set
    End Property


    Public Event SelectionChanged(sender As ctrGameCard, isSelected As Boolean)

    Public Sub LoadGameData(id As Integer, name As String, imgPath As String, Optional cache As Dictionary(Of Integer, Image) = Nothing)
        GameID = id
        GameName = name
        ImagePath = imgPath


        If cache IsNot Nothing AndAlso cache.ContainsKey(id) Then
            btnGameCard.Image = cache(id)
            Return
        End If


        Dim img As Image = Nothing

        Try

            If Not String.IsNullOrEmpty(imgPath) AndAlso IO.File.Exists(imgPath) Then

                Using fs As New IO.FileStream(imgPath, IO.FileMode.Open, IO.FileAccess.Read)

                    Using originalImg As Image = Image.FromStream(fs)

                        img = New Bitmap(originalImg, New Size(140, 150))
                    End Using
                End Using

            End If

        Catch ex As Exception

            img = Nothing

        End Try

        If img IsNot Nothing Then

            If cache IsNot Nothing Then cache(id) = img
            btnGameCard.Image = img

        End If
    End Sub



    Private Sub btnGameCard_Click(sender As Object, e As EventArgs) Handles btnGameCard.Click
        chkSelected.Checked = Not chkSelected.Checked
    End Sub

    Private Sub chkSelected_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelected.CheckedChanged
        If chkSelected.Checked Then
            btnGameCard.BorderColor = CyberAccent
            btnGameCard.BorderThickness = 2
            btnGameCard.FillColor = Color.FromArgb(20, 30, 38)
        Else
            btnGameCard.BorderColor = CyberBorder
            btnGameCard.BorderThickness = 1
            btnGameCard.FillColor = CyberSurface
        End If

        RaiseEvent SelectionChanged(Me, chkSelected.Checked)
    End Sub

    Private Sub btnGameCard_MouseEnter(sender As Object, e As EventArgs) Handles btnGameCard.MouseEnter
        If Not chkSelected.Checked Then
            btnGameCard.FillColor = CyberHover
            btnGameCard.BorderColor = CyberAccentDim
        End If
    End Sub

    Private Sub btnGameCard_MouseLeave(sender As Object, e As EventArgs) Handles btnGameCard.MouseLeave
        If Not chkSelected.Checked Then
            btnGameCard.FillColor = CyberSurface
            btnGameCard.BorderColor = CyberBorder
        End If
    End Sub

End Class
