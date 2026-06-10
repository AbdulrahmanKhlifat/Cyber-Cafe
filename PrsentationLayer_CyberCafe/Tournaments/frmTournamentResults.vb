Imports System.Windows.Forms
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class frmTournamentResults

    Private _tournamentID As Integer
    Private _tournamentName As String

    Public Sub New(tournamentID As Integer, tournamentName As String)

        InitializeComponent()
        _tournamentID = tournamentID
        _tournamentName = tournamentName

    End Sub

    Private Sub frmTournamentResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTournamentName.Text = _tournamentName.ToUpper()
        LoadTournamentResults()

    End Sub

    Private Sub LoadTournamentResults()

        Try

            Dim dt As DataTable = TournamentMatchesServices.GetTournamentResults(_tournamentID)
            dgvResults.AutoGenerateColumns = False
            dgvResults.DataSource = dt

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
            UIHelper.ShowGunaMessage("Failed to load tournament results.", "Error", MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnOk.Click

        Me.Close()

    End Sub

End Class
