Imports Guna.UI2.WinForms
Imports System.Windows.Forms
Imports System.Drawing
Imports CyberCafeModels

Public Class frmTournamentDetails

    Private _tournament As TournamentDTO

    Public Sub New(tournament As TournamentDTO)
        InitializeComponent()
        _tournament = tournament
    End Sub



    Private Sub frmTournamentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadTournamentDetails()
        LoadTournamentStatus()

        btnOk.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand

    End Sub


    Private Sub LoadTournamentDetails()

        Dim duration = _tournament.ExpectedEndTime - _tournament.TournamentTime


        lblDetTitle.Text = _tournament.TournamentName

        lblDetGameNameVal.Text = _tournament.GameName

        lblDetStartTimeVal.Text = _tournament.TournamentTime.ToString("dd MMM yyyy hh:mm tt")

        lblDetExpectedEndVal.Text = _tournament.ExpectedEndTime.ToString("dd MMM yyyy hh:mm tt")

        lblDetDurationVal.Text = $"{duration.Days}d {duration.Hours}h {duration.Minutes}m"

        lblDetEntryFeeVal.Text = _tournament.EntryFee.ToString("C")

        lblDetPrizeVal.Text = _tournament.PrizeAmount.ToString("C")

        lblDetPlayersVal.Text = _tournament.MaxPlayers.ToString()
        lblDetRevenueVal.Text = Convert.ToDecimal(_tournament.EntryFee * _tournament.MaxPlayers).ToString("C")

    End Sub

    Private Sub LoadTournamentStatus()

        Dim status = _tournament.TournamentStatus
        Dim statusText As String = GetTournamentStatusText(status)

        lblTournamentStatus.Text = statusText.ToUpper()

        Select Case statusText.ToLower()

            Case "upcoming"

                Dim remaining = _tournament.TournamentTime - DateTime.Now

                lblTournamentStatus.BackColor = Color.FromArgb(0, 120, 215)

                If remaining.TotalSeconds > 0 Then

                    lblLiveTimer.Text = "Starts In: " & remaining.ToString("dd\:hh\:mm\:ss")

                Else

                    lblLiveTimer.Text = "Starting Soon"

                End If

                lblLiveTimer.ForeColor = Color.FromArgb(0, 120, 215)

            Case "running"

                Dim runningTime = DateTime.Now - _tournament.TournamentTime

                lblTournamentStatus.BackColor = Color.FromArgb(0, 200, 83)

                lblLiveTimer.Text = "Running For: " & runningTime.ToString("dd\:hh\:mm\:ss")

                lblLiveTimer.ForeColor = Color.FromArgb(0, 200, 83)

            Case "finished"

                lblTournamentStatus.BackColor = Color.FromArgb(105, 105, 105)

                lblLiveTimer.Text = "Completed"

                lblLiveTimer.ForeColor = Color.FromArgb(105, 105, 105)

            Case "cancelled"

                lblTournamentStatus.BackColor = Color.FromArgb(255, 49, 49)

                lblLiveTimer.Text = "Cancelled"

                lblLiveTimer.ForeColor = Color.FromArgb(255, 49, 49)

        End Select

    End Sub

    Private Function GetTournamentStatusText(status As enTournamentStatus) As String

        Select Case status

            Case enTournamentStatus.Upcoming

                Return "Upcoming"

            Case enTournamentStatus.Running

                Return "Running"

            Case enTournamentStatus.Finished

                Return "Finished"

            Case enTournamentStatus.Cancelled

                Return "Cancelled"

            Case Else
                Return "Unknown"

        End Select

    End Function

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub


End Class
