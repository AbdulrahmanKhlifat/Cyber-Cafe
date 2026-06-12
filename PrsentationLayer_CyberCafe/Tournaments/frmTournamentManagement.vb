Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmTournamentManagement


    Private dtTournaments As DataTable
    Private IsInitialLoad As Boolean = False

    Private Sub frmTournamentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _RefreshTournamentsDataGrid()
        IsInitialLoad = True

    End Sub

    Private Sub _RefreshTournamentsDataGrid()

        dtTournaments = TournamentServices.GetAllTournaments()
        dgvTournaments.DataSource = dtTournaments
        dgvTournaments.Columns("TournamentStatus").Visible = False

    End Sub



    Private Function GetSelectedTournamentID() As Integer
        Return CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)
    End Function




    Private Sub tsmiShowDetails_Click(sender As Object, e As EventArgs) Handles tsmiShowDetails.Click

        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim tournament = TournamentServices.Find(GetSelectedTournamentID())


        Dim detailsForm As New frmTournamentDetails(tournament)

        detailsForm.ShowDialog()

    End Sub


    Private Sub cmsTournament_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsTournament.Opening

        If dgvTournaments.SelectedRows.Count = 0 Then

            e.Cancel = True
            Return

        End If

        Dim status = dgvTournaments.SelectedRows(0).Cells("TournamentStatusText").Value.ToString().ToLower()


        For Each item As ToolStripItem In cmsTournament.Items
            item.Visible = False
        Next

        tsmiShowDetails.Visible = True


        If status = "upcoming" OrElse status = "registration closed" OrElse status = "draw generated" OrElse status = "running" Then

            tsmiViewPlayers.Visible = True

        End If

        Select Case status
            Case "upcoming"
                tsmiEdit.Visible = True
                tsmiRegister.Visible = True
                tsmiCancel.Visible = True
                tsmiGenerateDraw.Text = "🎲 Generate Draw"
                tsmiGenerateDraw.Visible = True

            Case "registration closed"
                tsmiEdit.Visible = True
                tsmiCancel.Visible = True
                tsmiGenerateDraw.Text = "🎲 Generate Draw"
                tsmiGenerateDraw.Visible = True

            Case "draw generated"
                tsmiStart.Visible = True
                tsmiEdit.Visible = True
                tsmiCancel.Visible = True
                tsmiGenerateDraw.Text = "🎲 Manage Draw"
                tsmiGenerateDraw.Visible = True
                tsmiViewMatches.Text = "View Matches / Bracket"
                tsmiViewMatches.Visible = True

            Case "running"
                tsmiViewMatches.Text = "View Matches / Bracket"
                tsmiViewMatches.Visible = True
                tsmiViewPlayers.Visible = True

            Case "finished"
                tsmiViewResults.Visible = True
                tsmiViewWinner.Visible = True

            Case "cancelled"
                tsmiReopen.Visible = True
        End Select

    End Sub

    Private Sub tsmiRegister_Click(sender As Object, e As EventArgs) Handles tsmiRegister.Click

        Dim fee As Decimal = Convert.ToDecimal(dgvTournaments.SelectedRows(0).Cells("EntryFee").Value)

        Dim regForm As New frmRegisterTournamentPlayer(fee, CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value))

        If regForm.ShowDialog() = DialogResult.OK Then

            _RefreshTournamentsDataGrid()

        End If

    End Sub

    Private Sub btnAddTournament_Click(sender As Object, e As EventArgs) Handles btnAddTournament.Click


        Dim addForm As New frmAddUpdateTournament()

        If addForm.ShowDialog() = DialogResult.OK Then

            _RefreshTournamentsDataGrid()

        End If

    End Sub

    Private Sub tsmiEdit_Click(sender As Object, e As EventArgs) Handles tsmiEdit.Click
        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim id As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)

        Dim editForm As New frmAddUpdateTournament(id)

        If editForm.ShowDialog() = DialogResult.OK Then

            _RefreshTournamentsDataGrid()

        End If
    End Sub

    Private Sub tsmiStart_Click(sender As Object, e As EventArgs) Handles tsmiStart.Click

        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim id As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)

        Dim success As Boolean = TournamentServices.UpdateTournamentStatus(id, enTournamentStatus.Running)

        If success Then

            UIHelper.ShowGunaMessage("Tournament has been Started.", "Tournament Started", MessageBoxIcon.Information)
            _RefreshTournamentsDataGrid()

        Else

            UIHelper.ShowGunaMessage("Failed to start tournament.", "Error", MessageBoxIcon.Error)

        End If

    End Sub


    Private Function ConfirmationGunaMessage(Message As String, title As String) As DialogResult

        Dim GunaMsg As New Guna2MessageDialog()
        GunaMsg.Text = Message
        GunaMsg.Caption = title
        GunaMsg.Icon = MessageDialogIcon.Question
        GunaMsg.Buttons = MessageDialogButtons.YesNo
        GunaMsg.Style = MessageDialogStyle.Default
        GunaMsg.Parent = System.Windows.Forms.Application.OpenForms(0)

        Return GunaMsg.Show()

    End Function

    Private Sub tsmiCancel_Click(sender As Object, e As EventArgs) Handles tsmiCancel.Click

        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim tournamentID As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)

        Dim tournamentName As String = dgvTournaments.SelectedRows(0).Cells("TournamentName").Value.ToString()

        Dim confirm As DialogResult = ConfirmationGunaMessage($"Are you sure you want to cancel the '{tournamentName}' tournament?", "Confirm Cancellation")

        If confirm <> DialogResult.Yes Then
            Return
        End If

        Try

            Dim success As Boolean = TournamentServices.UpdateTournamentStatus(tournamentID, enTournamentStatus.Cancelled)

            If success Then

                UIHelper.ShowGunaMessage($"'{tournamentName}' tournament has been cancelled.", "Tournament Cancelled", MessageBoxIcon.Information)

                _RefreshTournamentsDataGrid()

            Else

                UIHelper.ShowGunaMessage("Failed to cancel tournament.", "Error", MessageBoxIcon.Error)

            End If

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            UIHelper.ShowGunaMessage($"An error occurred while cancelling the tournament:{Environment.NewLine}{ex.Message}", "Error", MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub tsmiReopen_Click(sender As Object, e As EventArgs) Handles tsmiReopen.Click

        If dgvTournaments.SelectedRows.Count = 0 Then Return

        Dim tournamentID As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)

        Dim tournament = TournamentServices.Find(tournamentID)

        If tournament Is Nothing Then
            Return
        End If

        If tournament.TournamentTime < DateTime.Now Then

            UIHelper.ShowGunaMessage("This tournament has an old date." & Environment.NewLine & "Please choose a new future date before reopening.", "Reopen Tournament", MessageBoxIcon.Information)

            Dim frm As New frmAddUpdateTournament(tournamentID)

            If frm.ShowDialog() <> DialogResult.OK Then

                Return

            End If

        End If

        If TournamentServices.UpdateTournamentStatus(tournamentID, enTournamentStatus.Upcoming) Then

            UIHelper.ShowGunaMessage("Tournament reopened successfully.", "Success", MessageBoxIcon.Information)

            _RefreshTournamentsDataGrid()

        End If

    End Sub


    Private Sub tsmiGenerateDraw_Click(sender As Object, e As EventArgs) Handles tsmiGenerateDraw.Click

        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim id As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)
        Dim name = dgvTournaments.SelectedRows(0).Cells("TournamentName").Value.ToString()

        If tsmiGenerateDraw.Text.Contains("Manage Draw") Then
            Dim bracketForm As New frmTournamentBracket(id, name)
            bracketForm.ShowDialog()
        Else
            Dim drawForm As New frmGenerateDraw(id, name)
            drawForm.ShowDialog()
        End If

        _RefreshTournamentsDataGrid()

    End Sub

    Private Sub tsmiViewMatches_Click(sender As Object, e As EventArgs) Handles tsmiViewMatches.Click
        If dgvTournaments.SelectedRows.Count = 0 Then Return

        Dim id As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)
        Dim name = dgvTournaments.SelectedRows(0).Cells("TournamentName").Value.ToString()

        Dim bracketForm As New frmTournamentBracket(id, name)
        bracketForm.ShowDialog()
        _RefreshTournamentsDataGrid()
    End Sub

    Private Sub tsmiViewPlayers_Click(sender As Object, e As EventArgs) Handles tsmiViewPlayers.Click

        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim tournamentID As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)
        Dim tournamentName As String = dgvTournaments.SelectedRows(0).Cells("TournamentName").Value.ToString()

        Dim listForm As New frmListTournamentPlayers(tournamentID, tournamentName)
        listForm.ShowDialog()

    End Sub

    Private Sub tsmiViewResults_Click(sender As Object, e As EventArgs) Handles tsmiViewResults.Click

        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim tournamentID As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)
        Dim tournamentName As String = dgvTournaments.SelectedRows(0).Cells("TournamentName").Value.ToString()

        Dim resultsForm As New frmTournamentResults(tournamentID, tournamentName)
        resultsForm.ShowDialog()

    End Sub

    Private Sub tsmiViewWinner_Click(sender As Object, e As EventArgs) Handles tsmiViewWinner.Click

        If dgvTournaments.SelectedRows.Count = 0 Then
            Return
        End If

        Dim tournamentID As Integer = CInt(dgvTournaments.SelectedRows(0).Cells("TournamentID").Value)
        Dim tournamentName As String = dgvTournaments.SelectedRows(0).Cells("TournamentName").Value.ToString()

        Dim winnerForm As New frmTournamentWinner(tournamentID, tournamentName)
        winnerForm.ShowDialog()

    End Sub


    Private Sub ApplyFilters()

        Dim filters As New List(Of String)


        If txtSearch.Text.Trim() <> "" Then

            filters.Add($"TournamentName LIKE '%{txtSearch.Text.Trim()}%'")

        End If

        If cmbStatus.SelectedIndex > -1 AndAlso cmbStatus.SelectedItem.ToString().ToLower() <> "all" Then

            filters.Add($"TournamentStatusText = '{cmbStatus.SelectedItem.ToString().ToLower()}'")

        End If


        If cmbGameFilter.SelectedIndex > -1 AndAlso cmbGameFilter.SelectedItem.ToString().ToLower() <> "all" Then

            filters.Add($"GameName = '{cmbGameFilter.SelectedItem}'")

        End If

        dtTournaments.DefaultView.RowFilter = String.Join(" AND ", filters)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If Not IsInitialLoad Then
            Return
        End If

        ApplyFilters()


    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

        If Not IsInitialLoad Then
            Return
        End If

        ApplyFilters()

    End Sub

    Private Sub cmbGameFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGameFilter.SelectedIndexChanged


        If Not IsInitialLoad Then
            Return
        End If

        ApplyFilters()


    End Sub

    Private Sub pnlToolbar_Paint(sender As Object, e As PaintEventArgs) Handles pnlToolbar.Paint

    End Sub
End Class