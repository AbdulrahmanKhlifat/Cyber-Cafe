Imports System.Windows.Forms
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class frmMatchResult

    Private _matchID As Integer
    Private _player1ID As Integer
    Private _player2ID As Integer

    Public Sub New(matchID As Integer)

        InitializeComponent()
        _matchID = matchID

    End Sub

    Private Sub frmMatchResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMatchDetails()

    End Sub

    Private Sub LoadMatchDetails()
        Try

            Dim match As TournamentMatchDTO = TournamentMatchesServices.GetMatchByID(_matchID)

            If match Is Nothing Then
                UIHelper.ShowGunaMessage("Match details could not be found.", "Error", MessageBoxIcon.Error)
                Me.Close()
                Return
            End If


            _player1ID = match.Player1ID
            _player2ID = match.Player2ID



            lblRoundVal.Text = $"Round {match.RoundNumber}"
            lblMatchOrderVal.Text = $"Match #{match.MatchOrder}"

            lblPlayer1Name.Text = match.Player1Name.ToUpper()
            lblPlayer2Name.Text = match.Player2Name.ToUpper()


            If match.Player1Score.HasValue Then
                numPlayer1Score.Value = match.Player1Score.Value
            End If

            If match.Player2Score.HasValue Then
                numPlayer2Score.Value = match.Player2Score.Value
            End If

            UpdateWinnerLabel()

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            UIHelper.ShowGunaMessage("Failed to load match details.", "Error", MessageBoxIcon.Error)
            Me.Close()

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim score1 As Byte = CByte(numPlayer1Score.Value)
        Dim score2 As Byte = CByte(numPlayer2Score.Value)
        Dim ScheduleTime As DateTime = DateTime.Now
        Dim winnerID As Integer = If(score1 > score2, _player1ID, _player2ID)


        If score1 = score2 Then

            UIHelper.ShowGunaMessage("Ties are not allowed in single elimination! Please enter a winning score.", "Tie Game", MessageBoxIcon.Warning)
            Return

        End If

        Try

            Dim matchResultData As New MatchResultDTO With {
            .MatchID = _matchID,
            .Score1 = score1,
            .Score2 = score2,
            .ScheduleTime = ScheduleTime,
            .WinnerID = winnerID
}



            Dim success As Boolean = TournamentMatchesServices.SaveMatchResult(matchResultData)



            If success Then

                UIHelper.ShowGunaMessage("Match result saved successfully!", "Success", MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()

            Else

                UIHelper.ShowGunaMessage("Failed to save match result.", "Error", MessageBoxIcon.Error)

            End If

        Catch ex As Exception

            UIHelper.ShowGunaMessage(ex.Message, "Error Saving Result", MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub numPlayer1Score_ValueChanged(sender As Object, e As EventArgs) Handles numPlayer1Score.ValueChanged, numPlayer2Score.ValueChanged

        UpdateWinnerLabel()

    End Sub

    Private Sub UpdateWinnerLabel()

        Dim score1 As Byte = CByte(numPlayer1Score.Value)
        Dim score2 As Byte = CByte(numPlayer2Score.Value)

        If score1 > score2 Then

            lblWinnerVal.Text = lblPlayer1Name.Text
            lblWinnerVal.ForeColor = Color.FromArgb(0, 242, 254)

        ElseIf score2 > score1 Then

            lblWinnerVal.Text = lblPlayer2Name.Text
            lblWinnerVal.ForeColor = Color.FromArgb(0, 242, 254)

        Else

            lblWinnerVal.Text = "TIE (No Winner)"
            lblWinnerVal.ForeColor = Color.FromArgb(139, 148, 158)

        End If

    End Sub

End Class
