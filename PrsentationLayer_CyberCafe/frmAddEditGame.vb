Imports System.IO
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Imports System.Data.Odbc
Public Class frmAddEditGame

    Private _SelectedImagePath As String = ""
    Private game As GameDTO

    Private Property _selectedImage As Image
    Private Property imageChanged As Boolean = False

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

        Dim dtDeviceTypes As DataTable = DeviceTypeServices.GetAllDeviceTypes()

        If dtDeviceTypes IsNot Nothing AndAlso dtDeviceTypes.Rows.Count > 0 Then
            For Each row As DataRow In dtDeviceTypes.Rows
                Dim chk As New Guna2CheckBox()

                chk.Text = row("DeviceTypeName").ToString()
                chk.Tag = Convert.ToInt32(row("DeviceTypeID"))

                chk.ForeColor = Color.FromArgb(230, 237, 243)
                chk.CheckedState.FillColor = Color.FromArgb(0, 200, 160)
                chk.UncheckedState.BorderColor = Color.FromArgb(0, 150, 120)
                chk.Margin = New Padding(5)
                chk.AutoSize = True

                flpPlatforms.Controls.Add(chk)
            Next
        End If
    End Sub

    Private Sub LoadGameData()

        txtGameName.Text = game.GameName

        Dim _FullImagePath As String = UIHelper.GetImagePath(game.ImagePath)

        If game.ImagePath Is Nothing Then
            pbGameImage.Image = My.Resources._4239781_200
        Else
            pbGameImage.Image = Image.FromFile(_FullImagePath)
            pbGameImage.Tag = _FullImagePath
            _SelectedImagePath = game.ImagePath
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Using ofd As New OpenFileDialog()

            If ofd.ShowDialog() = DialogResult.OK Then

                imageChanged = True

                Dim fullSelectedImagePath As String = ofd.FileName

                _selectedImage = Image.FromFile(fullSelectedImagePath)

                _SelectedImagePath = Path.GetFileName(fullSelectedImagePath)

                pbGameImage.Image = _selectedImage
            End If

        End Using

    End Sub

    Private Sub _FillGameObject()

        game.GameName = txtGameName.Text

        If imageChanged Then

            game.ImagePath = UIHelper.SaveImageToDirectory(_selectedImage)

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

        If String.IsNullOrWhiteSpace(txtGameName.Text) Then
            UIHelper.ShowGunaMessage("Please enter a game name.", "Validation Error", MessageDialogIcon.Warning)
            Return
        End If

        _FillGameObject()

        Select Case _Mode
            Case enMode.Add
                GameServices.AddGame(game)

            Case enMode.Update
                GameServices.UpdateGame(game)

        End Select


        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
