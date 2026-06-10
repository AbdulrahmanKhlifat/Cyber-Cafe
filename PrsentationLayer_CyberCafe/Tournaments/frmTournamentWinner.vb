Imports System.Windows.Forms
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class frmTournamentWinner

    Private _tournamentID As Integer
    Private _tournamentName As String

    Public Sub New(tournamentID As Integer, tournamentName As String)

        InitializeComponent()
        _tournamentID = tournamentID
        _tournamentName = tournamentName

    End Sub

    Private Sub frmTournamentWinner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadWinnerDetails()

    End Sub

    Private Sub LoadWinnerDetails()

        Try

            Dim row As DataRow = TournamentMatchesServices.GetTournamentWinner(_tournamentID)

            If row Is Nothing Then

                UIHelper.ShowGunaMessage("No winner recorded for this tournament.", "Winner Info", MessageBoxIcon.Information)
                Me.Close()
                Return

            End If

            lblWinnerName.Text = row("WinnerName").ToString().ToUpper()
            lblTournamentName.Text = row("TournamentName").ToString().ToUpper()

            Dim dateFinished As DateTime = CDate(row("DateFinished"))
            lblDateFinished.Text = $"COMPLETED ON: {dateFinished:yyyy-MM-dd HH:mm}"

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            UIHelper.ShowGunaMessage("Failed to load winner information.", "Error", MessageBoxIcon.Error)
            Me.Close()

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnOk.Click

        Me.Close()

    End Sub

End Class
