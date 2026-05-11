Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmRestockConsumable

    Private _ConsumableId As Integer
    Private _Consumable As ConsumableDTO

    Public Sub New(consumableId As Integer)
        InitializeComponent()
        _ConsumableId = consumableId
    End Sub

    Private Sub frmRestockConsumable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemData()
    End Sub

    Private Sub LoadItemData()
        _Consumable = ConsumableServices.GetConsumableByID(_ConsumableId)

        If _Consumable IsNot Nothing Then
            lblConsumableName.Text = _Consumable.ConsumableName
            lblCurrentStockVal.Text = $"{_Consumable.Quantity} Units"
            txtQuantity.Focus()
        Else
            UIHelper.ShowGunaMessage("Error Loading Item Details.", "Error", MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidateInput() Then Return

        Dim quantityToAdd As Integer = Convert.ToInt32(txtQuantity.Text.Trim())
        Dim newQuantity As Integer = _Consumable.Quantity + quantityToAdd

        Try
            Dim success As Boolean = ConsumableServices.UpdateStock(_ConsumableId, newQuantity, _Consumable.ImagePath)

            If success Then
                UIHelper.ShowGunaMessage("Stock Updated Successfully.", "Success", MessageDialogIcon.Information)
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                UIHelper.ShowGunaMessage("Failed to Update Stock.", "Error", MessageDialogIcon.Error)
            End If
        Catch ex As Exception
            UIHelper.ShowGunaMessage("Something went wrong.", "Error", MessageDialogIcon.Error)
            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            UIHelper.ShowGunaMessage("Enter Quantity.", "Validation", MessageBoxIcon.Warning)
            Return False
        End If

        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text.Trim(), quantity) Then
            UIHelper.ShowGunaMessage("Invalid Quantity. Must be a number.", "Validation", MessageBoxIcon.Warning)
            Return False
        End If

        If quantity <= 0 Then
            UIHelper.ShowGunaMessage("Quantity Must Be Greater Than 0.", "Validation", MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
