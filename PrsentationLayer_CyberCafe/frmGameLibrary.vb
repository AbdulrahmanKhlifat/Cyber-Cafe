Imports System.IO
Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmGameLibrary

    Private _allGames As List(Of GameDTO)

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

    Private Sub DisableCard(card As ctrGameCard)
        Dim btn = card.btnGameCard

        btn.Enabled = False

        Dim clr = Color.FromArgb(22, 27, 34)

        btn.FillColor = clr
        btn.DisabledState.FillColor = clr

        btn.DisabledState.ForeColor = Color.Gray
        btn.DisabledState.BorderColor = clr


        btn.HoverState.FillColor = clr
        btn.PressedColor = clr
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

        ' Forces the scrollbar to recalculate 
        flpGames.AutoScroll = False
        flpGames.AutoScroll = True
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
        If card Is Nothing Then Exit Sub


        Dim gameIdToDelete As Integer = card.GameID
        Dim gameName As String = card.GameName
        Dim imageName = GameServices.GetImagePath(gameIdToDelete)

        If ShowConfirmDialog($"Are you sure you want to delete {gameName}?") = DialogResult.Yes Then


            If GameServices.DeleteGame(gameIdToDelete) Then


                If card.btnGameCard.Image IsNot Nothing Then
                    card.btnGameCard.Image.Dispose()
                    card.btnGameCard.Image = Nothing
                End If


                flpGames.Controls.Remove(card)
                card.Dispose()


                If Not String.IsNullOrEmpty(imageName) Then
                    Try
                        Dim fullPath = UIHelper.GetImagePath(imageName)
                        If File.Exists(fullPath) Then

                            GC.Collect()
                            GC.WaitForPendingFinalizers()
                            File.Delete(fullPath)
                        End If
                    Catch ex As Exception

                    End Try
                End If

                UIHelper.ShowGunaMessage("Deleted successfully", "Success", MessageDialogIcon.Information)
            Else

                UIHelper.ShowGunaMessage("Cannot delete this game because it is linked to active devices or logs.", "Database Constraint", MessageDialogIcon.Error)
            End If
        End If
    End Sub


    Private Sub EnableDoubleBuffering(ctrl As Control)
        Dim prop = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        prop?.SetValue(ctrl, True, Nothing)
    End Sub

End Class