Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmAddUpdateTournament

    Private _tournamentID As Integer = -1
    Private _tournament As TournamentDTO
    Private Enum enMode
        Add
        Update
    End Enum

    Dim _Mode As enMode

    Public Sub New()

        InitializeComponent()

        lblTitle.Text = "Add New Tournament"
        Me.Text = "Add Tournament"

        _Mode = enMode.Add

    End Sub

    Public Sub New(tournamentID As Integer)

        InitializeComponent()

        _tournamentID = tournamentID
        _tournament = TournamentServices.Find(tournamentID)

        _Mode = enMode.Update

    End Sub

    Private Sub frmAddUpdateTournament_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If _Mode = enMode.Add Then

            dtpStartDate.MinDate = DateTime.Now.Date
            dtpStartTimePicker.MinDate = DateTime.Now.Date.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute)

        Else

            dtpStartDate.MinDate = DateTimePicker.MinimumDateTime

        End If





        ApplyHoverEffects()

        LoadTournamentGames()

        If _Mode = enMode.Update Then

            LoadTournamentData()

        End If

    End Sub

    Private Sub LoadTournamentData()

        lblTitle.Text = "Update Tournament"

        Me.Text = "Update Tournament"

        btnSave.Text = "Update"


        txtTournamentName.Text = _tournament.TournamentName
        cmbGames.SelectedValue = _tournament.GameID
        txtEntryFee.Text = _tournament.EntryFee.ToString("F2")
        txtPrizePool.Text = _tournament.PrizeAmount.ToString("F2")
        numMaxPlayers.Value = _tournament.MaxPlayers



        dtpStartDate.Value = _tournament.TournamentTime.Date
        dtpStartTimePicker.Value = _tournament.TournamentTime.Date.Add(_tournament.TournamentTime.TimeOfDay)

    End Sub


    Private Sub UpdateStartPreview()

        Dim selectedDate = dtpStartDate.Value.Date
        Dim selectedTime = dtpStartTimePicker.Value.TimeOfDay
        Dim combinedDateTime = selectedDate.Add(selectedTime)

        lblStartPreview.Text = "Starts On: " & combinedDateTime.ToString("dd MMM yyyy hh:mm tt")

    End Sub

    Private Sub LoadTournamentGames()

        cmbGames.DataSource = GameServices.GetTournamentSupportedGames()

        cmbGames.DisplayMember = "GameName"
        cmbGames.ValueMember = "GameID"

    End Sub



    Private Function CreateTournamentDTO() As TournamentDTO

        Dim startDateTime As DateTime = dtpStartDate.Value.Date.Add(dtpStartTimePicker.Value.TimeOfDay)

        Return New TournamentDTO With {
        .TournamentName = txtTournamentName.Text.Trim(),
        .GameID = CInt(cmbGames.SelectedValue),
        .EntryFee = Decimal.Parse(txtEntryFee.Text),
        .PrizeAmount = Decimal.Parse(txtPrizePool.Text),
        .MaxPlayers = CInt(numMaxPlayers.Value),
        .TournamentTime = startDateTime,
        .TournamentStatus = enTournamentStatus.Upcoming,
        .CreatedDate = DateTime.Now,
        .CreatedByAdminID = LoggedInUser.CurrentUser.UserID,
        .ExpectedEndTime = startDateTime.AddHours(2)
    }

    End Function

    Private Function BuildUpdatedTournamentDTO() As TournamentDTO

        Dim tournament = CreateTournamentDTO()

        tournament.TournamentID = _tournamentID
        tournament.CreatedDate = _tournament.CreatedDate
        tournament.CreatedByAdminID = _tournament.CreatedByAdminID
        tournament.TournamentStatus = _tournament.TournamentStatus

        Return tournament

    End Function

    Private Function ValidateTournament() As Boolean

        If String.IsNullOrWhiteSpace(txtTournamentName.Text) Then

            UIHelper.ShowGunaMessage("Please enter a tournament name.", "Add Tournament", MessageDialogIcon.Error)
            Return False

        End If

        If cmbGames.SelectedIndex < 0 Then

            UIHelper.ShowGunaMessage("Please select a game.", "Add Tournament", MessageDialogIcon.Error)
            Return False

        End If

        Return True

    End Function


    Private Sub HandleAddTournament()

        Dim tournament = CreateTournamentDTO()



        If TournamentServices.AddTournament(tournament) Then

            UIHelper.ShowGunaMessage("Tournament added successfully!", "Success", MessageDialogIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else

            UIHelper.ShowGunaMessage("Failed to add tournament.", "Error", MessageDialogIcon.Error)

        End If

    End Sub



    Private Sub HandleUpdateTournament()

        Dim tournament = BuildUpdatedTournamentDTO()

        If TournamentServices.UpdateTournament(tournament) Then

            UIHelper.ShowGunaMessage("Tournament updated successfully!", "Success", MessageDialogIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else

            UIHelper.ShowGunaMessage("Failed to update tournament.", "Error", MessageDialogIcon.Error)

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not ValidateTournament() Then

            Return

        End If

        If _Mode = enMode.Add Then

            HandleAddTournament()

        Else

            HandleUpdateTournament()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub ApplyHoverEffects()

        btnSave.Cursor = Cursors.Hand
        btnCancel.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand

    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged

        UpdateStartPreview()

    End Sub

    Private Sub dtpStartTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartTimePicker.ValueChanged

        UpdateStartPreview()

    End Sub
End Class
