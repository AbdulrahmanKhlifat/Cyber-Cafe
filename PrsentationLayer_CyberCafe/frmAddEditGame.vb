Imports System.IO
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms
Public Class frmAddEditGame

    Private game As GameDTO

    Private Property _ImageChanged As Boolean = False

    Private Property _ImageSourcePath As String

    Dim savedImageFileName As String = Nothing

    Private Enum enMode
        Add
        Update
    End Enum

    Private Property _Mode As enMode

    Public Sub New()
        InitializeComponent()

        _Mode = enMode.Add

        game = New GameDTO()

        lblTitle.Text = "Add New Game"

    End Sub

    Public Sub New(gameID As Integer)

        InitializeComponent()

        _Mode = enMode.Update

        game = GameServices.Find(gameID)

        lblTitle.Text = "Edit Game"

        LoadGameData()

    End Sub

    Private Sub SyncPlatformsCheckboxes()

        Dim supportedDevicesHashSet As New HashSet(Of Integer)(game.SupportedDevices)

        For Each ctrl In flpPlatforms.Controls

            If TypeOf ctrl Is Guna2CheckBox Then
                Dim chk = DirectCast(ctrl, Guna2CheckBox)

                chk.Checked = supportedDevicesHashSet.Contains(CInt(chk.Tag))

            End If
        Next
    End Sub

    Private Sub frmAddEditGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulatePlatforms()

        SyncPlatformsCheckboxes()

    End Sub

    Private Sub PopulatePlatforms()

        flpPlatforms.Controls.Clear()

        Dim deviceTypes As List(Of DeviceTypeDTO) =
        DeviceTypeServices.GetAllDeviceTypes()

        If deviceTypes Is Nothing OrElse deviceTypes.Count = 0 Then
            Exit Sub
        End If

        For Each dt In deviceTypes

            Dim chk As New Guna2CheckBox()

            chk.Text = dt.DeviceTypeName
            chk.Tag = dt.DeviceTypeID

            chk.ForeColor = Color.FromArgb(230, 237, 243)
            chk.CheckedState.FillColor = Color.FromArgb(0, 200, 160)
            chk.UncheckedState.BorderColor = Color.FromArgb(0, 150, 120)
            chk.Margin = New Padding(5)
            chk.AutoSize = True

            flpPlatforms.Controls.Add(chk)

        Next

    End Sub

    Private Sub LoadGameData()

        txtGameName.Text = game.GameName

        lblGameID.Text = game.GameID.ToString()

        _ImageSourcePath = UIHelper.GetImagePath(game.ImagePath)

        If game.ImagePath Is Nothing Then
            pbGameImage.Image = My.Resources.PlayStationIcon
        Else
            pbGameImage.Image = Image.FromFile(_ImageSourcePath)
            pbGameImage.Tag = _ImageSourcePath
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Using ofd As New OpenFileDialog()

            If ofd.ShowDialog() = DialogResult.OK Then

                _ImageChanged = True

                _ImageSourcePath = ofd.FileName

                pbGameImage.Image = Image.FromFile(_ImageSourcePath)
            End If

        End Using

    End Sub

    Private Function ValidateInput() As String

        If String.IsNullOrWhiteSpace(txtGameName.Text) Then
            Return "Please enter a game name."
        End If

        Dim hasPlatform As Boolean = False

        For Each ctrl In flpPlatforms.Controls
            If TypeOf ctrl Is Guna2CheckBox AndAlso DirectCast(ctrl, Guna2CheckBox).Checked Then
                hasPlatform = True
                Exit For
            End If
        Next

        If Not hasPlatform Then
            Return "Please select at least one supported platform."
        End If

        Return Nothing

    End Function

    Private Sub FillGameObject()

        game.GameName = txtGameName.Text.Trim()

        If _ImageChanged Then

            savedImageFileName = UIHelper.SaveImageToDirectory(_ImageSourcePath)
            game.ImagePath = savedImageFileName

        End If

        Dim selectedPlatforms As New List(Of Integer)

        For Each ctrl In flpPlatforms.Controls
            If TypeOf ctrl Is Guna2CheckBox Then
                Dim chk = DirectCast(ctrl, Guna2CheckBox)
                If chk.Checked Then
                    selectedPlatforms.Add(CInt(chk.Tag))
                End If
            End If
        Next

        game.SupportedDevices = selectedPlatforms

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim validationError = ValidateInput()

        If validationError IsNot Nothing Then

            UIHelper.ShowGunaMessage(validationError, "Validation Error", MessageDialogIcon.Error)
            Exit Sub
        End If

        FillGameObject()

        Dim success As Boolean = False

        Try

            Select Case _Mode
                Case enMode.Add
                    GameServices.AddGame(game)

                Case enMode.Update
                    GameServices.UpdateGame(game)

            End Select

            success = True

            Me.DialogResult = DialogResult.OK
            Me.Close()


        Catch ex As ArgumentException
            UIHelper.ShowGunaMessage(ex.Message, "Error", MessageDialogIcon.Warning)

        Catch ex As InvalidOperationException
            UIHelper.ShowGunaMessage(ex.Message, "Error", MessageDialogIcon.Warning)

        Catch ex As Exception
            UIHelper.ShowGunaMessage("Something Went Wrong.", "Error", MessageDialogIcon.Error)


        Finally

            If Not success AndAlso _ImageChanged Then

                Dim fullPath = UIHelper.GetImagePath(savedImageFileName)

                If File.Exists(fullPath) Then

                    File.Delete(fullPath)

                End If

            End If

        End Try



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
