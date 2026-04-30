Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmDevices
    Private Property isInitializing As Boolean
    Public Sub New()
        isInitializing = True
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        isInitializing = False

    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub ApplyFilters()
        Guna2Transition1.HideSync(flpDevices)

        Dim searchText As String = txtSearch.Text.ToLower().Trim()
        Dim selectedStatus As String = cmbStatus.Text.ToLower()
        Dim selectedType As String = cmbDeviceType.Text.ToLower()

        flpDevices.SuspendLayout()

        For Each control As Control In flpDevices.Controls

            Dim device As ctrDeviceInfo = TryCast(control, ctrDeviceInfo)

            If device IsNot Nothing Then

                Dim matchesName As Boolean = String.IsNullOrEmpty(searchText) OrElse
            device.lblDeviceName.Text.ToLower().Contains(searchText)

                Dim matchesStatus As Boolean = String.IsNullOrEmpty(cmbStatus.Text) OrElse
            cmbStatus.Text = "All Status" OrElse
            device.Status.ToLower().Contains(selectedStatus)

                Dim matchesType As Boolean = String.IsNullOrEmpty(cmbDeviceType.Text) OrElse
            cmbDeviceType.Text = "All Types" OrElse
            device.lblDeviceType.Text.ToLower().Contains(selectedType)

                Dim isMatch As Boolean = matchesName AndAlso matchesStatus AndAlso matchesType

                device.Visible = isMatch

            End If
        Next

        flpDevices.ResumeLayout()

        Guna2Transition1.ShowSync(flpDevices)
    End Sub

    Private Sub FillComboBox()
        Dim dt As DataTable = DeviceTypeServices.GetAllDeviceTypes()
        cboDeviceType.DataSource = dt
        cboDeviceType.ValueMember = "DeviceTypeID"
        cboDeviceType.DisplayMember = "DeviceTypeName"
        cboDeviceType.SelectedIndex = -1
    End Sub


    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDevices()
        FillComboBox()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click

        If Not pnlDeviceDetail.Visible Then
            pnlDeviceDetail.Visible = True
        End If

    End Sub
    Private Sub ClearAddDeviceDetails()
        txtDeviceName.Text = ""
        cboDeviceType.SelectedIndex = -1
    End Sub
    Private Sub btnCancelDevice_Click(sender As Object, e As EventArgs) Handles btnCancelDevice.Click
        ClearAddDeviceDetails()
        pnlDeviceDetail.Visible = False
    End Sub

    Private Sub btnClearDeviceInfo_Click(sender As Object, e As EventArgs) Handles btnDeleteDevice.Click
        ClearAddDeviceDetails()
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
        flpDevices.Controls.Add(ctrl)
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

    Private Function GetNewDeviceInfo() As DeviceDTO
        If String.IsNullOrWhiteSpace(txtDeviceName.Text) OrElse cboDeviceType.SelectedValue Is Nothing Then
            Return Nothing
        End If

        Dim dto As New DeviceDTO()
        dto.DeviceName = txtDeviceName.Text
        dto.DeviceTypeID = cboDeviceType.SelectedValue
        dto.Status = enDeviceStatus.Available
        dto.PricePerHour = nUpDownPrice.Value
        Return dto
    End Function

    Private Function IsValidData() As Boolean
        If String.IsNullOrWhiteSpace(txtDeviceName.Text) OrElse cboDeviceType.SelectedValue Is Nothing Then

            _ShowGunaMessage("Please fill in all required fields.", "Validation Error", MessageDialogIcon.Warning)
            Return False

        End If

        Return True

    End Function
    Private Sub btnSaveDevice_Click(sender As Object, e As EventArgs) Handles btnSaveDevice.Click
        If Not IsValidData() Then
            Return
        End If

        Dim newDevice As New DeviceDTO With {
            .DeviceName = txtDeviceName.Text.Trim(),
            .DeviceTypeID = CInt(cboDeviceType.SelectedValue),
            .Status = enDeviceStatus.Available,
            .PricePerHour = nUpDownPrice.Value
        }

        If DeviceServices.AddDevice(newDevice) Then
            _ShowGunaMessage("Device added successfully!", "Success", MessageDialogIcon.Information)
            ClearAddDeviceDetails()
            pnlDeviceDetail.Visible = False
            LoadDevices()
        Else

            _ShowGunaMessage("Failed to add device.", "Error", MessageDialogIcon.Error)

        End If

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If Not isInitializing Then

            ApplyFilters()

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If Not isInitializing Then

            ApplyFilters()

        End If
    End Sub

    Private Sub cmbDeviceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeviceType.SelectedIndexChanged
        If Not isInitializing Then

            ApplyFilters()

        End If
    End Sub
End Class