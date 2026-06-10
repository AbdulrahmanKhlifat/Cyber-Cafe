Imports Guna.UI2.WinForms
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class frmGenerateDraw

    Private _tournamentID As Integer
    Private _tournamentName As String

    Public Sub New(tournamentID As Integer, tournamentName As String)

        InitializeComponent()
        _tournamentID = tournamentID
        _tournamentName = tournamentName

    End Sub

    Private Sub frmGenerateDraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeTournamentDrawForm()

    End Sub

    Private Sub InitializeTournamentDrawForm()

        Try
            lblTournamentName.Text = _tournamentName.ToUpper()

            btnGenerateDraw.Cursor = Cursors.Hand
            btnShuffleAgain.Cursor = Cursors.Hand
            btnStartTournament.Cursor = Cursors.Hand
            btnCancel.Cursor = Cursors.Hand
            btnClose.Cursor = Cursors.Hand

            _RefreshMatchesGrid()
            _UpdateUIStates()

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

        End Try

    End Sub

    Private Sub _RefreshMatchesGrid()

        Try

            Dim matchesList As List(Of TournamentMatchDTO) = TournamentMatchesServices.GetTournamentMatchesList(_tournamentID)

            dgvMatches.AutoGenerateColumns = False
            dgvMatches.DataSource = Nothing
            dgvMatches.DataSource = matchesList
        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            UIHelper.ShowGunaMessage("Failed to load matches list.", "Error", MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub _UpdateUIStates()

        Try

            Dim hasDraw As Boolean = TournamentMatchesServices.HasTournamentDraw(_tournamentID)

            btnGenerateDraw.Enabled = Not hasDraw
            btnShuffleAgain.Enabled = hasDraw

            Dim tournament = TournamentServices.Find(_tournamentID)

            If tournament IsNot Nothing Then

                Select Case tournament.TournamentStatus

                    Case enTournamentStatus.Running

                        btnStartTournament.Enabled = False
                        btnShuffleAgain.Enabled = False
                        btnGenerateDraw.Enabled = False

                    Case enTournamentStatus.DrawGenerated

                        btnStartTournament.Enabled = True

                    Case Else

                        btnStartTournament.Enabled = False

                End Select

            End If

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

        End Try
    End Sub

    Private Sub btnGenerateDraw_Click(sender As Object, e As EventArgs) Handles btnGenerateDraw.Click

        Dim confirm = ConfirmationGunaMessage("Are you sure you want to generate the tournament draw?", "Confirm Generation")

        If confirm = DialogResult.Yes Then

            Try

                Dim success As Boolean = TournamentMatchesServices.GenerateDraw(_tournamentID)

                If success Then

                    UIHelper.ShowGunaMessage("Tournament draw generated successfully!", "Success", MessageBoxIcon.Information)
                    _RefreshMatchesGrid()
                    _UpdateUIStates()

                Else

                    UIHelper.ShowGunaMessage("Failed to generate tournament draw.", "Error", MessageBoxIcon.Error)

                End If

            Catch ex As Exception

                UIHelper.ShowGunaMessage(ex.Message, "Draw Generation Failed", MessageBoxIcon.Warning)

            End Try

        End If

    End Sub

    Private Sub btnShuffleAgain_Click(sender As Object, e As EventArgs) Handles btnShuffleAgain.Click

        Dim confirm = ConfirmationGunaMessage("Are you sure you want to delete the existing draw and generate a new one randomly?", "Confirm Reshuffle")

        If confirm = DialogResult.Yes Then
            Try

                TournamentMatchesServices.DeleteTournamentDraw(_tournamentID)

                Dim success As Boolean = TournamentMatchesServices.GenerateDraw(_tournamentID)

                If success Then

                    UIHelper.ShowGunaMessage("Tournament draw reshuffled successfully!", "Success", MessageBoxIcon.Information)

                    _RefreshMatchesGrid()

                    _UpdateUIStates()

                Else

                    UIHelper.ShowGunaMessage("Failed to reshuffle tournament draw.", "Error", MessageBoxIcon.Error)

                End If

            Catch ex As Exception

                UIHelper.ShowGunaMessage(ex.Message, "Reshuffle Failed", MessageBoxIcon.Warning)

            End Try
        End If
    End Sub

    Private Sub btnStartTournament_Click(sender As Object, e As EventArgs) Handles btnStartTournament.Click

        Dim confirm = ConfirmationGunaMessage("Are you sure you want to start the tournament? This will mark its status as Running and freeze the draw.", "Confirm Start")

        If confirm = DialogResult.Yes Then

            Try

                Dim success As Boolean = TournamentServices.UpdateTournamentStatus(_tournamentID, enTournamentStatus.Running)

                If success Then

                    UIHelper.ShowGunaMessage("Tournament started successfully!", "Success", MessageBoxIcon.Information)
                    _UpdateUIStates()
                    Me.DialogResult = DialogResult.OK
                    Me.Close()

                Else

                    UIHelper.ShowGunaMessage("Failed to start the tournament.", "Error", MessageBoxIcon.Error)

                End If

            Catch ex As Exception

                ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
                UIHelper.ShowGunaMessage("An error occurred while starting the tournament.", "Error", MessageBoxIcon.Error)

            End Try

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Function ConfirmationGunaMessage(Message As String, title As String) As DialogResult

        Dim GunaMsg As New Guna2MessageDialog()
        GunaMsg.Text = Message
        GunaMsg.Caption = title
        GunaMsg.Icon = MessageDialogIcon.Question
        GunaMsg.Buttons = MessageDialogButtons.YesNo
        GunaMsg.Style = MessageDialogStyle.Default
        GunaMsg.Parent = Me
        Return GunaMsg.Show()

    End Function

End Class
