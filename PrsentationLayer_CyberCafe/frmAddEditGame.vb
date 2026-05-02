Imports System.IO
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmAddEditGame

    Private _gameID As Integer?
    Private _imagePath As String = ""

    Public Sub New()
        InitializeComponent()
        _gameID = Nothing
        lblTitle.Text = "Add New Game"
    End Sub

    Public Sub New(gameID As Integer)
        InitializeComponent()
        _gameID = gameID
        lblTitle.Text = "Edit Game"
        LoadGameData()
    End Sub

    Private Sub frmAddEditGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulatePlatforms()
    End Sub

    Private Sub PopulatePlatforms()
        flpPlatforms.Controls.Clear()

        Dim dtDeviceTypes As DataTable = DeviceTypeServices.GetAllDeviceTypes()

        If dtDeviceTypes IsNot Nothing AndAlso dtDeviceTypes.Rows.Count > 0 Then
            For Each row As DataRow In dtDeviceTypes.Rows
                Dim chk As New Guna2CheckBox()

                chk.Text = row("DeviceTypeName").ToString()
                chk.Tag = row("DeviceTypeID")

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

        ' Dim game = GameServices.Find(_gameID.Value)
        ' txtGameName.Text = game.GameName
        ' _imagePath = game.ImagePath
        ' If File.Exists(_imagePath) Then pbGameImage.Image = Image.FromFile(_imagePath)

        txtGameName.Text = "Dummy Name"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Using ofd As New OpenFileDialog()

            If ofd.ShowDialog() = DialogResult.OK Then
                _imagePath = ofd.FileName

                Dim bytes = File.ReadAllBytes(_imagePath)
                Using ms As New MemoryStream(bytes)
                    pbGameImage.Image = Image.FromStream(ms)
                End Using
            End If

        End Using

    End Sub

    Private Sub _ShowGunaMessage(message As String, caption As String, icon As MessageDialogIcon)

        Dim guna As New Guna2MessageDialog With {
            .Caption = caption,
            .Text = message,
            .Parent = System.Windows.Forms.Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = icon,
            .Buttons = MessageDialogButtons.OK
        }

        guna.Show()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(txtGameName.Text) Then
            _ShowGunaMessage("Please enter a game name.", "Validation Error", MessageDialogIcon.Warning)
            Return
        End If


        Dim selectedPlatforms As New List(Of Integer)

        For Each ctrl In flpPlatforms.Controls

            If TypeOf ctrl Is Guna2CheckBox Then
                Dim chk = DirectCast(ctrl, Guna2CheckBox)

                If chk.Checked Then
                    selectedPlatforms.Add(chk.Tag)
                End If

            End If
        Next

        Dim game As New GameDTO With {
            .GameName = txtGameName.Text.Trim(),
            .SupportedDevices = selectedPlatforms,
            .ImagePath = _imagePath
        }

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
