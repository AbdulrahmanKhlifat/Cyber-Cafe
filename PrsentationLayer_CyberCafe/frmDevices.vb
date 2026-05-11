Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmDevices
    Private Property isInitializing As Boolean

    Private _SelectedDeviceID As Integer = -1
    Private _SelectedDeviceType As DeviceTypeDTO
    Public Sub New()

        isInitializing = True

        InitializeComponent()

        FillComboBox()


        isInitializing = False

    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property


    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDevices()

    End Sub

    Private Sub FillComboBox()

        Dim dt As List(Of DeviceTypeDTO) = DeviceTypeServices.GetAllDeviceTypes()

        cboDeviceType.ValueMember = "DeviceTypeID"
        cboDeviceType.DisplayMember = "DeviceTypeName"
        cboDeviceType.DataSource = dt
        cboDeviceType.SelectedIndex = -1

        Dim dtWithAll As New List(Of DeviceTypeDTO)

        dtWithAll.Add(New DeviceTypeDTO With {
        .DeviceTypeID = 0,
        .DeviceTypeName = "All Types"
        })

        dtWithAll.AddRange(dt)

        cmbDeviceType.ValueMember = "DeviceTypeID"
        cmbDeviceType.DisplayMember = "DeviceTypeName"
        cmbDeviceType.DataSource = dtWithAll
        cmbDeviceType.SelectedIndex = -1

    End Sub

    Private Sub LoadDevices()

        flpDevices.Controls.Clear()
        flpDevices.SuspendLayout()

        Dim devicesList As List(Of DeviceDTO) = DeviceServices.GetAllDevicesList()

        For Each device In devicesList
            AddDeviceToFlowLayout(device)
        Next

        flpDevices.ResumeLayout()
    End Sub

    Private Sub AddDeviceToFlowLayout(device As DeviceDTO)

        Dim ctrl As New ctrDeviceInfo(device)
        ctrl.ContextMenuStrip = DeviceContextMenu
        flpDevices.Controls.Add(ctrl)

    End Sub

    Public Sub PrepareForAdd()

        If pnlDeviceDetail.Visible Then

            pnlDeviceDetail.Visible = False

            Return
        End If

        _SelectedDeviceID = -1

        ClearAddDeviceDetails()

        btnSaveDevice.Text = "Add Device"

        pnlDeviceDetail.Visible = True

    End Sub


    Public Sub PrepareForEdit(DeviceID As Integer)

        Dim device = DeviceServices.Find(DeviceID)

        If device IsNot Nothing Then

            _SelectedDeviceID = DeviceID
            txtDeviceName.Text = device.DeviceName
            cboDeviceType.SelectedValue = device.DeviceTypeID
            btnSaveDevice.Text = "Save Changes"
            pnlDeviceDetail.Visible = True

        End If

    End Sub
    Private Sub cboDeviceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDeviceType.SelectedIndexChanged

        Dim img As Image = Nothing

        If cboDeviceType.SelectedValue IsNot Nothing AndAlso Convert.ToInt32(cboDeviceType.SelectedValue) <> -1 Then

            _SelectedDeviceType = DeviceTypeServices.Find(Convert.ToInt32(cboDeviceType.SelectedValue))

            If _SelectedDeviceType IsNot Nothing Then
                img = UIHelper.LoadImageUnlocked(UIHelper.GetImagePath(_SelectedDeviceType.ImagePath))
                img = UIHelper.ResizeImage(img, 215, 150)
                If Not String.IsNullOrEmpty(_SelectedDeviceType.ImagePath) Then
                    PictureBox1.Image = img
                End If
            End If
        Else

            PictureBox1.Image = Nothing
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveDevice.Click
        If Not IsValidData() Then Return

        Dim device As New DeviceDTO With {
            .DeviceName = txtDeviceName.Text.Trim(),
            .DeviceTypeID = Convert.ToInt32(cboDeviceType.SelectedValue),
            .Status = enDeviceStatus.Available,
            .ImagePath = _SelectedDeviceType?.ImagePath
        }

        Dim result As Boolean = False

        If _SelectedDeviceID = -1 Then

            result = DeviceServices.AddDevice(device)
        Else

            device.DeviceID = _SelectedDeviceID
            result = DeviceServices.UpdateDevice(device)

        End If

        If result Then

            UIHelper.ShowGunaMessage("Saved successfully!", "Success", MessageDialogIcon.Information)
            pnlDeviceDetail.Visible = False
            LoadDevices()

        Else

            UIHelper.ShowGunaMessage("An error occurred during the save process.", "Error", MessageDialogIcon.Error)

        End If
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click

        PrepareForAdd()

    End Sub

    Private Sub btnManagePlatforms_Click(sender As Object, e As EventArgs) Handles btnManagePlatforms.Click

        Using managePlatformsForm As New frmManagePlatforms()

            managePlatformsForm.ShowDialog()
            FillComboBox()
            LoadDevices()

        End Using
    End Sub

    Private Function GetSelectedDeviceInfoCard() As ctrDeviceInfo

        Dim sourceCtrl = DeviceContextMenu.SourceControl
        Dim tempCtrl = sourceCtrl


        If TypeOf tempCtrl Is ctrDeviceInfo Then
            Return DirectCast(tempCtrl, ctrDeviceInfo)
        End If

        tempCtrl = tempCtrl.Parent



        Return Nothing
    End Function
    Private Sub tsStartSession_Click(sender As Object, e As EventArgs) Handles tsDeleteDevice.Click

        Dim card As ctrDeviceInfo = GetSelectedDeviceInfoCard()

        If card IsNot Nothing Then

            Using startSessionForm As New frmStartSession(card.DeviceID)

                If startSessionForm.ShowDialog() = DialogResult.OK Then

                    LoadDevices()

                End If

            End Using

        End If

    End Sub

    Private Sub tsEditDevice_Click(sender As Object, e As EventArgs) Handles tsUpdateDevice.Click

        Dim card As ctrDeviceInfo = GetSelectedDeviceInfoCard()
        If card IsNot Nothing Then
            PrepareForEdit(card.DeviceID)
        End If

    End Sub

    Private Sub tsShowDetails_Click(sender As Object, e As EventArgs) Handles tsShowDetails.Click

        Dim card As ctrDeviceInfo = GetSelectedDeviceInfoCard()

        If card IsNot Nothing Then

            Using detailsForm As New frmShowDeviceDetails(card.DeviceID)

                detailsForm.ShowDialog()

            End Using

        End If

    End Sub

    Private Sub btnCancelDevice_Click(sender As Object, e As EventArgs) Handles btnCancelDevice.Click
        pnlDeviceDetail.Visible = False
        ClearAddDeviceDetails()
    End Sub

    Private Sub btnClearDeviceInfo_Click(sender As Object, e As EventArgs) Handles btnClearDeviceInfo.Click

        ClearAddDeviceDetails()

    End Sub



    Private Sub ApplyFilters()

        Guna2Transition1.HideSync(flpDevices)

        Dim searchDeviceText As String = txtSearch.Text.ToLower().Trim()
        Dim searchGameText As String = txtSearchGame.Text.ToLower().Trim()
        Dim selectedStatus As String = cmbStatus.Text.ToLower()
        Dim selectedType As String = cmbDeviceType.Text.ToLower()


        flpDevices.SuspendLayout()

        Dim devicesWithGame As New List(Of Integer)

        If searchGameText.Length >= 3 Then
            devicesWithGame = DeviceServices.GetDevicesByGameName(searchGameText)
        End If


        For Each control As Control In flpDevices.Controls
            Dim device As ctrDeviceInfo = TryCast(control, ctrDeviceInfo)
            If device IsNot Nothing Then


                Dim matchesName As Boolean = String.IsNullOrEmpty(searchDeviceText) OrElse
                                        device.lblDeviceName.Text.ToLower().Contains(searchDeviceText)


                Dim matchesGame As Boolean = False

                If searchGameText.Length = 0 Then

                    matchesGame = True
                ElseIf searchGameText.Length >= 3 Then

                    matchesGame = devicesWithGame.Contains(device.DeviceID)
                Else
                    matchesGame = False
                End If


                Dim matchesStatus As Boolean = (cmbStatus.Text = "All Status" _
                        OrElse String.IsNullOrEmpty(cmbStatus.Text) OrElse device.Status.ToLower().Contains(selectedStatus))


                Dim matchesType As Boolean = (cmbDeviceType.Text = "All Types" _
                OrElse String.IsNullOrEmpty(cmbDeviceType.Text) OrElse device.lblDeviceType.Text.ToLower().Contains(selectedType))

                device.Visible = matchesName AndAlso matchesGame AndAlso matchesStatus AndAlso matchesType

            End If
        Next

        flpDevices.ResumeLayout()
        Guna2Transition1.ShowSync(flpDevices)
    End Sub

    Private Sub ClearAddDeviceDetails()
        txtDeviceName.Clear()
        cboDeviceType.SelectedIndex = -1
    End Sub

    Private Function IsValidData() As Boolean

        If String.IsNullOrWhiteSpace(txtDeviceName.Text) OrElse cboDeviceType.SelectedValue Is Nothing Then
            UIHelper.ShowGunaMessage("Please fill in all required fields.", "Validation Error", MessageDialogIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not isInitializing Then ApplyFilters()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If Not isInitializing Then ApplyFilters()
    End Sub

    Private Sub cmbDeviceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeviceType.SelectedIndexChanged
        If Not isInitializing Then ApplyFilters()
    End Sub

    Private Sub txtSearchGame_TextChanged(sender As Object, e As EventArgs) Handles txtSearchGame.TextChanged
        If Not isInitializing Then ApplyFilters()
    End Sub
    Private Sub tsAssignGames_Click(sender As Object, e As EventArgs) Handles tsAssignGames.Click
        Dim card As ctrDeviceInfo = GetSelectedDeviceInfoCard()

        If card IsNot Nothing Then
            Using assignForm As New frmAssignGames(card.DeviceID)
                assignForm.ShowDialog()
            End Using
        End If

    End Sub

    Private Sub DeleteDeviceToolStripMenuItem_Click(
    sender As Object,
    e As EventArgs
) Handles DeleteDeviceToolStripMenuItem.Click

        Try

            Dim card As ctrDeviceInfo = GetSelectedDeviceInfoCard()

            If card Is Nothing Then

                Dim guna As New Guna2MessageDialog With {
                .Caption = "Error",
                .Text = "Please select a device",
                .Parent = Application.OpenForms(0),
                .Style = MessageDialogStyle.Dark,
                .Icon = MessageDialogIcon.Error,
                .Buttons = MessageDialogButtons.OK
            }

                guna.Show()

                Return

            End If

            Dim confirmDialog As New Guna2MessageDialog With {
            .Caption = "Confirm Delete",
            .Text = "Are you sure you want to delete this device?",
            .Parent = Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = MessageDialogIcon.Question,
            .Buttons = MessageDialogButtons.YesNo
        }

            Dim result As DialogResult = confirmDialog.Show()

            If result = DialogResult.No Then
                Return
            End If

            DeviceServices.SoftDeleteDevice(card.DeviceID)

            Dim successDialog As New Guna2MessageDialog With {
            .Caption = "Success",
            .Text = "Device deleted successfully",
            .Parent = Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = MessageDialogIcon.Information,
            .Buttons = MessageDialogButtons.OK
        }

            successDialog.Show()

            LoadDevices()

        Catch ex As Exception

            Dim errorDialog As New Guna2MessageDialog With {
            .Caption = "Error",
            .Text = ex.Message,
            .Parent = Application.OpenForms(0),
            .Style = MessageDialogStyle.Dark,
            .Icon = MessageDialogIcon.Error,
            .Buttons = MessageDialogButtons.OK
        }

            errorDialog.Show()

        End Try

    End Sub


End Class