Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmGameLauncher

    Private Property _session As ActiveSession

    Public Sub New(active As ActiveSession)

        InitializeComponent()

        _session = active

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim searchText As String = txtSearch.Text.Trim().ToLower()
        flpDeviceGames.SuspendLayout()

        For Each ctrl In flpDeviceGames.Controls

            If TypeOf ctrl Is ctrGameCard Then

                Dim card = DirectCast(ctrl, ctrGameCard)
                card.Visible = String.IsNullOrEmpty(searchText) OrElse card.GameName.ToLower().Contains(searchText)

            End If

        Next
        flpDeviceGames.ResumeLayout()
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

    Private Sub frmGameLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EnableDoubleBuffering(flpDeviceGames)

        LoadDeviceGames()

    End Sub

    Private Sub LoadDeviceGames()

        flpDeviceGames.SuspendLayout()
        flpDeviceGames.Controls.Clear()

        If _session Is Nothing Then
            MessageBox.Show("Session is NULL")
            Return
        End If

        Dim games = DeviceGameService.GetGamesByDeviceID(_session.DeviceID)

        If games IsNot Nothing Then


            For Each game In games

                Dim card As New ctrGameCard()
                card.LoadGameData(game)
                card.DisableCheckBox()

                RegisterCardClickEvents(
                    card,
                    game.GameName
                )

                flpDeviceGames.Controls.Add(card)

            Next

        End If

        flpDeviceGames.ResumeLayout()
        Me.ScrollBar.BindingContainer = Nothing
        Me.ScrollBar.BindingContainer = Me.flpDeviceGames
    End Sub

    Private Sub RegisterCardClickEvents(
    parent As Control,
    gameName As String
)

        AddHandler parent.Click,
            Sub()

                UIHelper.ShowGunaMessage(
                    $"Opening game: {gameName}",
                    "Game Launcher",
                    MessageDialogIcon.Information
                )

            End Sub

        For Each child As Control In parent.Controls

            RegisterCardClickEvents(
                child,
                gameName
            )

        Next

    End Sub

End Class