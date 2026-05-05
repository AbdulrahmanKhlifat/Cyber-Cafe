Imports CyberCafeModels

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

    Public Sub LoadGameData(gameDTO As GameDTO)
        GameID = gameDTO.GameID
        GameName = gameDTO.GameName
        ImagePath = UIHelper.GetImagePath(gameDTO.ImagePath)

        Try

            If Not String.IsNullOrWhiteSpace(ImagePath) AndAlso IO.File.Exists(ImagePath) Then
                btnGameCard.Image = UIHelper.LoadImageUnlocked(ImagePath)
            Else
                btnGameCard.Image = My.Resources.PlayStationIcon
            End If

        Catch
            btnGameCard.Image = My.Resources.PlayStationIcon
        End Try

    End Sub
    Public Sub DisableCheckBox()

        Dim clr = Color.FromArgb(22, 27, 34)

        btnGameCard.FillColor = clr
        btnGameCard.DisabledState.FillColor = clr

        btnGameCard.DisabledState.ForeColor = Color.Gray
        btnGameCard.DisabledState.BorderColor = clr


        btnGameCard.HoverState.FillColor = clr
        btnGameCard.PressedColor = clr

        Me.chkSelected.Visible = False
    End Sub

    Public Sub LoadGameData(gameDTO As GameSelectionDTO)
        GameID = gameDTO.GameID
        GameName = gameDTO.GameName
        ImagePath = UIHelper.GetImagePath(gameDTO.ImagePath)

        If ImagePath Is Nothing Then
            btnGameCard.Image = My.Resources.PlayStationIcon
        Else
            btnGameCard.Image = Image.FromFile(ImagePath)
        End If

        btnGameCard.Checked = gameDTO.Exists

    End Sub

    Private Sub btnGameCard_Click(sender As Object, e As EventArgs) Handles btnGameCard.Click
        chkSelected.Checked = Not chkSelected.Checked
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
