Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmAssignGames

    Private Shared ReadOnly CyberDark As Color = Color.FromArgb(18, 18, 18)
    Private Shared ReadOnly CyberAccent As Color = Color.FromArgb(0, 251, 255)
    Private Shared ReadOnly CyberAccentDim As Color = Color.FromArgb(0, 180, 183)
    Private Shared ReadOnly CyberSurface As Color = Color.FromArgb(28, 28, 36)
    Private Shared ReadOnly CyberText As Color = Color.FromArgb(220, 225, 230)
    Private Shared ReadOnly CyberTextDim As Color = Color.FromArgb(140, 145, 155)


    Private ReadOnly _thumbnailCache As New Dictionary(Of Integer, Image)


    Private _allGames As List(Of GameSelectionDTO)

    Private _selectedGamesCount As Integer = 0


    Private _currentDeviceID As Integer

    Private _SelectedDeviceDTO As DeviceDTO

    Public Sub New(deviceID As Integer)

        InitializeComponent()

        _currentDeviceID = deviceID

        _SelectedDeviceDTO = DeviceServices.Find(deviceID)
    End Sub

    Private Sub EnableDoubleBuffering(ctrl As Control)
        Dim prop As PropertyInfo = GetType(Control).GetProperty(
            "DoubleBuffered",
            BindingFlags.Instance Or BindingFlags.NonPublic)
        prop.SetValue(ctrl, True, Nothing)


        Dim setStyle As MethodInfo = GetType(Control).GetMethod(
            "SetStyle",
            BindingFlags.Instance Or BindingFlags.NonPublic)
        setStyle.Invoke(ctrl, New Object() {
            ControlStyles.OptimizedDoubleBuffer Or
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.UserPaint,
            True})
    End Sub

    Private Sub _ShowGunaMessage(message As String, caption As String, icon As MessageDialogIcon)

        Dim guna As New Guna2MessageDialog With {
            .caption = caption,
            .Text = message,
            .Parent = System.Windows.Forms.Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .icon = icon,
            .Buttons = MessageDialogButtons.OK
        }

        guna.Show()
    End Sub
    Private Sub frmAssignGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EnableDoubleBuffering(flpGames)
        'LoadDummyGames()
        LoadAllGames()
        pnlHeader.EnableDragging()
    End Sub

    Private Function CreateDummyList() As List(Of GameDTO)
        Dim gamesList As New List(Of GameDTO)

        Dim gameNames() As String = {
            "Cyberpunk 2077", "GTA V", "Red Dead Redemption 2",
            "The Witcher 3", "Elden Ring", "God of War",
            "Horizon Zero Dawn", "Spider-Man", "Forza Horizon 5",
            "Halo Infinite", "Call of Duty: MW III", "FIFA 25",
            "Assassin's Creed Valhalla", "Far Cry 6", "Resident Evil 4",
            "Minecraft", "Fortnite", "Apex Legends",
            "Valorant", "League of Legends", "Counter-Strike 2",
            "Overwatch 2", "Diablo IV", "Starfield",
            "Baldur's Gate 3", "Hogwarts Legacy", "Palworld",
            "Lethal Company", "Helldivers 2", "Tekken 8",
            "Street Fighter 6", "Mortal Kombat 1", "Need for Speed Unbound",
            "Gran Turismo 7", "NBA 2K25", "Madden NFL 25",
            "The Last of Us Part I", "Uncharted 4", "Ghost of Tsushima",
            "Death Stranding", "Metal Gear Solid V", "Sekiro",
            "Dark Souls III", "Bloodborne", "Nioh 2",
            "Dragon Ball FighterZ", "Genshin Impact", "Honkai Star Rail",
            "Final Fantasy XVI", "Persona 5 Royal"
        }

        For i As Integer = 0 To gameNames.Length - 1
            gamesList.Add(New GameDTO With {
            .GameID = i + 1,
            .GameName = gameNames(i),
            .ImagePath = ""
        })
        Next

        Return gamesList
    End Function

    Private Sub LoadAllGames()
        _allGames = GameServices.GetGamesForDeviceUpdate(_SelectedDeviceDTO.DeviceID, _SelectedDeviceDTO.DeviceTypeID)
        If _allGames IsNot Nothing Then
            LoadGamesToUI(_allGames)
        Else
            _ShowGunaMessage("Error loading games.", "Error", MessageDialogIcon.Error)
        End If
    End Sub

    Public Sub LoadGamesFromList(games As List(Of GameDTO))

        flpGames.SuspendLayout()

        For Each ctrl As Control In flpGames.Controls
            ctrl.Dispose()
        Next

        flpGames.Controls.Clear()

        For Each game In games

            Dim card As New ctrGameCard()

            card.LoadGameData(game)

            card.Margin = New Padding(5)

            AddHandler card.SelectionChanged,
                   AddressOf OnGameSelectionChanged

            flpGames.Controls.Add(card)

        Next

        flpGames.ResumeLayout(True)

    End Sub

    'Move this to frmShowDeviceDetails
    Private Sub LoadAssignedGames()

        Dim assignedGames As List(Of GameDTO) =
        DeviceGameService.GetGamesByDeviceID(_currentDeviceID)

        If assignedGames IsNot Nothing Then

            LoadGamesFromList(assignedGames)

        Else

            _ShowGunaMessage(
            "Error loading assigned games.",
            "Error",
            MessageDialogIcon.Error)

        End If

    End Sub

    Public Sub LoadGamesToUI(gamesList As List(Of GameSelectionDTO))

        flpGames.SuspendLayout()

        ' Clean previous controls safely
        For Each ctrl As Control In flpGames.Controls
            RemoveHandler DirectCast(ctrl, ctrGameCard).SelectionChanged,
                      AddressOf OnGameSelectionChanged
            ctrl.Dispose()
        Next

        flpGames.Controls.Clear()

        If gamesList Is Nothing Then Return

        Dim selectedCount As Integer = 0

        For Each game In gamesList

            Dim gID As Integer = game.GameID

            Dim gName As String =
            If(String.IsNullOrWhiteSpace(game.GameName),
               "Unknown",
               game.GameName)

            Dim gPath As String =
            If(String.IsNullOrWhiteSpace(game.ImagePath),
               String.Empty,
               game.ImagePath)

            Dim card As New ctrGameCard()

            card.LoadGameData(game)

            ' Set initial selection state
            card.IsSelected = game.Exists

            If game.Exists Then
                selectedCount += 1
            End If

            card.Margin = New Padding(5)

            AddHandler card.SelectionChanged,
                   AddressOf OnGameSelectionChanged

            flpGames.Controls.Add(card)

        Next

        flpGames.ResumeLayout(True)

        lblCounter.Text =
        $"{selectedCount} / {flpGames.Controls.Count} selected"

    End Sub


    Private Sub OnGameSelectionChanged(sender As ctrGameCard, isSelected As Boolean)

        If isSelected Then
            _selectedGamesCount += 1
        Else
            _selectedGamesCount -= 1
        End If

        lblCounter.Text = $"{_selectedGamesCount} / {flpGames.Controls.Count} selected"

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        flpGames.SuspendLayout()

        For Each ctrl As Control In flpGames.Controls

            If TypeOf ctrl Is ctrGameCard Then
                Dim card = DirectCast(ctrl, ctrGameCard)

                card.Visible = String.IsNullOrEmpty(searchText) OrElse card.GameName.ToLower().Contains(searchText)
            End If

        Next

        flpGames.ResumeLayout()

    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        For Each ctrl As Control In flpGames.Controls

            If TypeOf ctrl Is ctrGameCard Then

                DirectCast(ctrl, ctrGameCard).IsSelected = True

            End If

        Next
    End Sub

    Private Sub btnDeselectAll_Click(sender As Object, e As EventArgs) Handles btnDeselectAll.Click
        For Each ctrl As Control In flpGames.Controls

            If TypeOf ctrl Is ctrGameCard Then

                DirectCast(ctrl, ctrGameCard).IsSelected = False

            End If

        Next
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim selectedIDs = GetSelectedGameIDs()


        If selectedIDs.Count = 0 Then

            _ShowGunaMessage("Please select at least one game.", "No Selection", MessageDialogIcon.Warning)
            Return

        End If

        If SaveSelectedGames(selectedIDs) Then

            _ShowGunaMessage("Games Assigned Successfully!", "Success", MessageDialogIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else

            _ShowGunaMessage("Error saving games. Please try again.", "Error", MessageDialogIcon.Error)

        End If

    End Sub
    Private Function SaveSelectedGames(selectedIDs As List(Of Integer)) As Boolean

        Return DeviceGameService.SetDeviceGames(_currentDeviceID, selectedIDs)

    End Function
    Public Function GetSelectedGameIDs() As List(Of Integer)

        Dim result As New List(Of Integer)

        For Each ctrl As Control In flpGames.Controls

            If TypeOf ctrl Is ctrGameCard Then

                Dim card = DirectCast(ctrl, ctrGameCard)

                If card.IsSelected Then

                    result.Add(card.GameID)

                End If

            End If

        Next

        Return result
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub



    Private Sub frmAssignGames_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        For Each kvp In _thumbnailCache

            If kvp.Value IsNot Nothing Then
                kvp.Value.Dispose()
            End If

        Next

        _thumbnailCache.Clear()
    End Sub


End Class
