Public Class ctrGameCard

    ' Theme Colors (Matching Project Style)
    Private Shared ReadOnly ProjectBackground As Color = Color.FromArgb(13, 17, 23)
    Private Shared ReadOnly ProjectSurface As Color = Color.FromArgb(22, 27, 34)
    Private Shared ReadOnly ProjectAccent As Color = Color.FromArgb(0, 200, 160)
    Private Shared ReadOnly ProjectAccentDim As Color = Color.FromArgb(0, 150, 120)
    Private Shared ReadOnly ProjectHover As Color = Color.FromArgb(35, 35, 48)
    Private Shared ReadOnly ProjectBorder As Color = Color.FromArgb(40, 40, 55)
    Private Shared ReadOnly ProjectText As Color = Color.FromArgb(230, 237, 243)
    Private Shared ReadOnly ProjectTextDim As Color = Color.FromArgb(139, 148, 158)

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
        MessageBox.Show("Width: " & btnGameCard.Image.Width & vbCrLf & "Height: " & btnGameCard.Image.Height)
    End Sub

    Private Sub chkSelected_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelected.CheckedChanged
        If chkSelected.Checked Then
            btnGameCard.BorderColor = ProjectAccent
            btnGameCard.BorderThickness = 2
            btnGameCard.FillColor = Color.FromArgb(20, 30, 38)
        Else
            btnGameCard.BorderColor = ProjectBorder
            btnGameCard.BorderThickness = 1
            btnGameCard.FillColor = ProjectSurface
        End If

        RaiseEvent SelectionChanged(Me, chkSelected.Checked)
    End Sub

    Private Sub btnGameCard_MouseEnter(sender As Object, e As EventArgs) Handles btnGameCard.MouseEnter
        If Not chkSelected.Checked Then
            btnGameCard.FillColor = ProjectHover
            btnGameCard.BorderColor = ProjectAccentDim
        End If
    End Sub

    Private Sub btnGameCard_MouseLeave(sender As Object, e As EventArgs) Handles btnGameCard.MouseLeave
        If Not chkSelected.Checked Then
            btnGameCard.FillColor = ProjectSurface
            btnGameCard.BorderColor = ProjectBorder
        End If
    End Sub


End Class
