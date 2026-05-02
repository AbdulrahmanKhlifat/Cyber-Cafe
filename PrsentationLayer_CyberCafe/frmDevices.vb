Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmDevices
    Private Property isInitializing As Boolean

    Private _SelectedDeviceID As Integer = -1
    Public Sub New()

        isInitializing = True
        InitializeComponent()
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
        FillComboBox()

    End Sub

    Private Sub FillComboBox()

        Dim dt As DataTable = DeviceTypeServices.GetAllDeviceTypes()
        cboDeviceType.DataSource = dt
        cboDeviceType.ValueMember = "DeviceTypeID"
        cboDeviceType.DisplayMember = "DeviceTypeName"
        cboDeviceType.SelectedIndex = -1

    End Sub

    Private Sub LoadDevices()

        flpDevices.Controls.Clear()
        flpDevices.SuspendLayout()

        Dim devicesList As List(Of DeviceDTO) = GetAllDevicesList()

        For Each device In devicesList
            AddDeviceToFlowLayout(device)
        Next

        flpDevices.ResumeLayout()
    End Sub

    Private Function GetAllDevicesList() As List(Of DeviceDTO)

        Dim list As New List(Of DeviceDTO)
        Dim dtDevices As DataTable = DeviceServices.GetAllDevices()

        For Each row As DataRow In dtDevices.Rows

            list.Add(New DeviceDTO With {
                .DeviceID = Convert.ToInt32(row("DeviceID")),
                .DeviceName = row("DeviceName").ToString(),
                .DeviceTypeName = row("DeviceTypeName").ToString(),
                .Status = CType(CByte(row("Status")), enDeviceStatus)
            })

        Next

        Return list

    End Function

    Private Sub AddDeviceToFlowLayout(device As DeviceDTO)

        Dim ctrl As New ctrDeviceInfo()
        ctrl.LoadData(device)
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
            nUpDownPrice.Value = device.PricePerHour
            btnSaveDevice.Text = "Save Changes"
            pnlDeviceDetail.Visible = True

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveDevice.Click
        If Not IsValidData() Then Return

        Dim device As New DeviceDTO With {
            .DeviceName = txtDeviceName.Text.Trim(),
            .DeviceTypeID = Convert.ToInt32(cboDeviceType.SelectedValue),
            .PricePerHour = nUpDownPrice.Value,
            .Status = enDeviceStatus.Available
        }

        Dim result As Boolean = False

        If _SelectedDeviceID = -1 Then

            result = DeviceServices.AddDevice(device)
        Else

            device.DeviceID = _SelectedDeviceID
            result = DeviceServices.UpdateDevice(device)

        End If

        If result Then

            _ShowGunaMessage("Saved successfully!", "Success", MessageDialogIcon.Information)
            pnlDeviceDetail.Visible = False
            LoadDevices()

        Else

            _ShowGunaMessage("An error occurred during the save process.", "Error", MessageDialogIcon.Error)

        End If
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click

        PrepareForAdd()

    End Sub

    Private Function GetSelectedDeviceInfoCard() As ctrDeviceInfo

        Dim sourceCtrl = DeviceContextMenu.SourceControl
        Dim tempCtrl = sourceCtrl

        'While tempCtrl IsNot Nothing

        If TypeOf tempCtrl Is ctrDeviceInfo Then
            Return DirectCast(tempCtrl, ctrDeviceInfo)
        End If

        '    tempCtrl = tempCtrl.Parent

        'End While

        Return Nothing
    End Function
    Private Sub tsEditDevice_Click(sender As Object, e As EventArgs) Handles tsUpdateDevice.Click

        Dim card As ctrDeviceInfo = GetSelectedDeviceInfoCard()
        If card IsNot Nothing Then
            PrepareForEdit(card.DeviceID)
        End If

    End Sub

    Private Sub tsShowDetails_Click(sender As Object, e As EventArgs) Handles tsShowDetails.Click

        Dim card As ctrDeviceInfo = GetSelectedDeviceInfoCard()

        If card IsNot Nothing Then

            Dim devInfo = DeviceServices.Find(card.DeviceID)

            If devInfo IsNot Nothing Then
                Using detailsForm As New frmShowDeviceDetails(devInfo)
                    detailsForm.ShowDialog()
                End Using
            Else

                _ShowGunaMessage("Could not load device details. Check your database connection.", "Error", MessageDialogIcon.Error)
            End If
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
        Dim searchText As String = txtSearch.Text.ToLower().Trim()
        Dim selectedStatus As String = cmbStatus.Text.ToLower()
        Dim selectedType As String = cmbDeviceType.Text.ToLower()

        flpDevices.SuspendLayout()

        For Each control As Control In flpDevices.Controls
            Dim device As ctrDeviceInfo = TryCast(control, ctrDeviceInfo)
            If device IsNot Nothing Then

                Dim matchesName As Boolean = String.IsNullOrEmpty(searchText) _
                    OrElse device.lblDeviceName.Text.ToLower().Contains(searchText)

                Dim matchesStatus As Boolean = String.IsNullOrEmpty(cmbStatus.Text) _
                    OrElse cmbStatus.Text = "All Status" _
                    OrElse device.Status.ToLower().Contains(selectedStatus)

                Dim matchesType As Boolean = String.IsNullOrEmpty(cmbDeviceType.Text) _
                    OrElse cmbDeviceType.Text = "All Types" _
                    OrElse device.lblDeviceType.Text.ToLower().Contains(selectedType)

                device.Visible = matchesName AndAlso matchesStatus AndAlso matchesType
            End If
        Next

        flpDevices.ResumeLayout()
        Guna2Transition1.ShowSync(flpDevices)
    End Sub

    Private Sub ClearAddDeviceDetails()
        txtDeviceName.Clear()
        cboDeviceType.SelectedIndex = -1
        nUpDownPrice.Value = 0.5
    End Sub

    Private Function IsValidData() As Boolean

        If String.IsNullOrWhiteSpace(txtDeviceName.Text) OrElse cboDeviceType.SelectedValue Is Nothing Then
            _ShowGunaMessage("Please fill in all required fields.", "Validation Error", MessageDialogIcon.Warning)
            Return False
        End If

        Return True
    End Function

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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not isInitializing Then ApplyFilters()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If Not isInitializing Then ApplyFilters()
    End Sub

    Private Sub cmbDeviceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeviceType.SelectedIndexChanged
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
End Class