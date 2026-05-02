Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmGameLibrary

    Private _allGames As List(Of GameDTO)
    Private ReadOnly _thumbnailCache As New Dictionary(Of Integer, Image)

    Private Shared ReadOnly CyberAccent As Color = Color.FromArgb(0, 251, 255)

    Private Sub frmGameLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableDoubleBuffering(flpGames)

        LoadGames()
    End Sub

    Private Sub LoadGames()
        Try

            _allGames = GameServices.GetAllGames()

        Catch ex As Exception

            _allGames = New List(Of GameDTO)

        End Try

        RefreshFlowLayoutPanel(_allGames)
    End Sub

    Private Sub RefreshFlowLayoutPanel(games As List(Of GameDTO))
        flpGames.SuspendLayout()


        For Each ctrl As Control In flpGames.Controls
            ctrl.Dispose()
        Next
        flpGames.Controls.Clear()

        If games Is Nothing OrElse games.Count = 0 Then
            Return
        End If


        For Each game In games
            Dim card As New ctrGameCard()

            card.LoadGameData(game)
            card.DisableCheckBox()

            Dim targetBtn = card.btnGameCard

            targetBtn.ContextMenuStrip = cmsGameMenu

            AddHandler targetBtn.MouseDown,
                    Sub(s, e)
                        If e.Button = MouseButtons.Right Then
                            cmsGameMenu.Tag = card
                        End If
                    End Sub

            flpGames.Controls.Add(card)
        Next

        flpGames.ResumeLayout(True)
    End Sub


    Private Function GetSelectedGameCard() As ctrGameCard

        Dim sourceCtrl = cmsGameMenu.SourceControl

        If TypeOf sourceCtrl Is ctrGameCard Then
            Return DirectCast(sourceCtrl, ctrGameCard)
        End If

        If cmsGameMenu.Tag IsNot Nothing AndAlso TypeOf cmsGameMenu.Tag Is ctrGameCard Then
            Return DirectCast(cmsGameMenu.Tag, ctrGameCard)
        End If

        Return Nothing
    End Function


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim searchText As String = txtSearch.Text.Trim().ToLower()
        flpGames.SuspendLayout()

        For Each ctrl In flpGames.Controls

            If TypeOf ctrl Is ctrGameCard Then

                Dim card = DirectCast(ctrl, ctrGameCard)
                card.Visible = String.IsNullOrEmpty(searchText) OrElse card.GameName.ToLower().Contains(searchText)

            End If

        Next
        flpGames.ResumeLayout()
    End Sub

    Private Sub btnAddGame_Click(sender As Object, e As EventArgs) Handles btnAddGame.Click

        Using frm As New frmAddEditGame()

            If frm.ShowDialog() = DialogResult.OK Then
                LoadGames()
            End If

        End Using

    End Sub

    Private Sub tsiEdit_Click(sender As Object, e As EventArgs) Handles tsiEdit.Click
        Dim card = GetSelectedGameCard()

        If card IsNot Nothing Then

            Using frm As New frmAddEditGame(card.GameID)

                If frm.ShowDialog() = DialogResult.OK Then
                    LoadGames()
                End If

            End Using

        End If
    End Sub
    Private Function ShowConfirmDialog(message As String, Optional title As String = "Confirm") As DialogResult

        Dim msgDialog As New Guna.UI2.WinForms.Guna2MessageDialog
        msgDialog.Parent = System.Windows.Forms.Application.OpenForms(0)
        msgDialog.Style = MessageDialogStyle.Dark
        msgDialog.Icon = MessageDialogIcon.Question
        msgDialog.Buttons = MessageDialogButtons.YesNo
        msgDialog.Caption = title
        msgDialog.Text = message

        Return msgDialog.Show()

    End Function
    Private Sub tsiDelete_Click(sender As Object, e As EventArgs) Handles tsiDelete.Click
        Dim card = GetSelectedGameCard()
        If card IsNot Nothing Then

            If ShowConfirmDialog($"Are you sure you want to delete {card.GameName}?") = DialogResult.Yes Then
                ' GameServices.DeleteGame(card.GameID)
                LoadGames()
            End If

        End If
    End Sub


    Private Sub EnableDoubleBuffering(ctrl As Control)
        Dim prop = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        prop?.SetValue(ctrl, True, Nothing)
    End Sub

    Private Sub frmGameLibrary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        For Each img In _thumbnailCache.Values
            img?.Dispose()
        Next

        _thumbnailCache.Clear()
    End Sub

End Class