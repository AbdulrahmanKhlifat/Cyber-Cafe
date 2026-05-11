Imports BusinessLayer_CyberCafe
Imports Guna.UI2.WinForms

Public Class frmInventoryManagement


    Private _dtConsumables As DataTable
    Public Sub New()

        InitializeComponent()

        LoadData()

    End Sub

    Private Sub RefreshData()
        _dtConsumables = ConsumableServices.GetConsumablesDataTable()

        dgvInventory.DataSource = _dtConsumables

        Dim selectionColor As Color =
    Color.FromArgb(30, 45, 65)

        dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgvInventory.RowsDefaultCellStyle.SelectionBackColor = selectionColor

        dgvInventory.AlternatingRowsDefaultCellStyle.SelectionBackColor = selectionColor

        dgvInventory.RowsDefaultCellStyle.SelectionForeColor = Color.White
        dgvInventory.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White


        dgvInventory.ClearSelection()
    End Sub


    Private Sub LoadData()

        RefreshData()

        With dgvInventory

            .EnableHeadersVisualStyles = False

            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(25, 35, 50)
            .DefaultCellStyle.SelectionForeColor = Color.White

        End With

        ApplyCMS()


        LoadAlerts()
    End Sub
    Private Sub ApplyCMS()
        EditToolStripMenuItem.Text = "    📝  Edit Details"
        EditToolStripMenuItem.ForeColor = Color.FromArgb(0, 170, 255)
        EditToolStripMenuItem.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        RestockToolStripMenuItem.Text = "    📦  Restock Item"
        RestockToolStripMenuItem.ForeColor = Color.FromArgb(249, 115, 22)
        RestockToolStripMenuItem.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        DeleteToolStripMenuItem.Text = "    🗑  Delete Item"
        DeleteToolStripMenuItem.ForeColor = Color.FromArgb(239, 68, 68)
        DeleteToolStripMenuItem.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        cms.Items.Clear()
        cms.Items.Add(EditToolStripMenuItem)
        cms.Items.Add(RestockToolStripMenuItem)
        cms.Items.Add(New ToolStripSeparator())
        cms.Items.Add(DeleteToolStripMenuItem)

        cms.BackColor = Color.FromArgb(22, 27, 34)
        cms.ShowImageMargin = False
        cms.RenderMode = ToolStripRenderMode.Professional

        dgvInventory.ContextMenuStrip = cms
    End Sub
    Private Sub LoadAlerts()

        flpAlerts.Controls.Clear()

        Dim lowStock As DataTable =
        ConsumableServices.GetLowStockConsumables()

        Dim outOfStock As DataTable =
        ConsumableServices.GetOutOfStockConsumables()


        For Each row As DataRow In lowStock.Rows

            AddAlert(row("ConsumableName").ToString(), row("Quantity").ToString() & " left", Color.FromArgb(255, 128, 0)
        )

        Next

        For Each row As DataRow In outOfStock.Rows

            AddAlert(row("ConsumableName").ToString(), "OUT OF STOCK", Color.FromArgb(255, 49, 49)
        )

        Next

    End Sub

    Private Sub AddAlert(itemName As String, status As String, accentColor As Color)
        Dim pnl As New Guna2Panel With {
            .Size = New Size(210, 60),
            .BorderRadius = 10,
            .BorderThickness = 1,
            .BorderColor = accentColor,
            .FillColor = Color.FromArgb(33, 38, 45),
            .Margin = New Padding(0, 0, 0, 10)
        }

        Dim lblName As New Label With {
            .Text = itemName,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .Location = New Point(10, 10),
            .AutoSize = True,
            .BackColor = Color.Transparent
        }

        Dim lblStatus As New Label With {
            .Text = status,
            .ForeColor = accentColor,
            .Font = New Font("Segoe UI", 9),
            .Location = New Point(10, 30),
            .AutoSize = True,
            .BackColor = Color.Transparent
        }

        pnl.Controls.Add(lblName)
        pnl.Controls.Add(lblStatus)
        flpAlerts.Controls.Add(pnl)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Using frmAdd As New frmAddEditConsumable()

            If frmAdd.ShowDialog() = DialogResult.OK Then

                LoadData()

            End If

        End Using
    End Sub




    Private Sub ApplyFilter(filter As String)
        If _dtConsumables Is Nothing Then
            Return
        End If
        filter = filter.Replace("'", "''")

        _dtConsumables.DefaultView.RowFilter = $"ConsumableName LIKE '%{filter}%'"

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilter(txtSearch.Text.Trim().ToLower())
    End Sub

    Private Sub btnWalkIn_Click(sender As Object, e As EventArgs) Handles btnWalkIn.Click

        Using walkInForm As New frmCustomerCart()

            walkInForm.ShowDialog()
            LoadData()

        End Using

    End Sub

    Private Sub Restock_Click(sender As Object, e As EventArgs) Handles RestockToolStripMenuItem.Click

        If dgvInventory.CurrentRow Is Nothing Then Return

        Dim consumableID As Integer = Convert.ToInt32(dgvInventory.CurrentRow.Cells("ConsumableID").Value)

        Using restockForm As New frmRestockConsumable(consumableID)

            If restockForm.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If

        End Using
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        If dgvInventory.CurrentRow Is Nothing Then Return

        Dim consumableID As Integer = Convert.ToInt32(dgvInventory.CurrentRow.Cells("ConsumableID").Value)

        Using editForm As New frmAddEditConsumable(consumableID)

            If editForm.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If

        End Using
    End Sub


End Class
