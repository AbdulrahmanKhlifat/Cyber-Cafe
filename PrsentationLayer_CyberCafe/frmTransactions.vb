Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports Guna.UI2.WinForms

Public Class frmTransactions
    Private Sub styleDataGridView()
        ' 1. Basic Background & Border
        ' Matches the dark grey/black background of your main panel
        dgvTrans.BackgroundColor = Color.FromArgb(24, 26, 32)
        dgvTrans.GridColor = Color.FromArgb(45, 47, 55) ' Subtle separator lines
        dgvTrans.BorderStyle = BorderStyle.None

        ' 2. Header Styling (Fixing the white bar)
        ' CRITICAL: Must be false for custom header colors to work in WinForms
        dgvTrans.EnableHeadersVisualStyles = False
        dgvTrans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTrans.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 35, 43) ' Slightly lighter header
        dgvTrans.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvTrans.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 35, 43) ' Prevent header color change on click
        dgvTrans.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        dgvTrans.ColumnHeadersHeight = 40

        ' 3. Row Styling
        dgvTrans.DefaultCellStyle.BackColor = Color.FromArgb(24, 26, 32)
        dgvTrans.DefaultCellStyle.ForeColor = Color.LightGray
        ' The teal accent color from your sidebar for selected rows
        dgvTrans.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 220, 160)
        dgvTrans.DefaultCellStyle.SelectionForeColor = Color.Black

        ' 4. Alternating Rows (Optional, but looks premium)
        dgvTrans.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(29, 31, 38)

        ' 5. Clean up the edges
        dgvTrans.RowHeadersVisible = False ' Hides the blank selector column on the far left
        dgvTrans.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal ' Only horizontal lines look cleaner

        ' 6. Fix the gap
        dgvTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub LoadTransactionsSummaryInPanels()
        Dim summary As DailyTransactionsSummaryDTO = TransactionServices.GetTransactionSummary()

        lblTransNum.Text = summary.TotalTransactions.ToString()

        lblMoney.Text = summary.TotalRevenue.ToString("C2")

    End Sub

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        styleDataGridView()
        dgvTrans.DataSource = TransactionServices.GetAllTransactions()
        LoadTransactionsSummaryInPanels()
    End Sub

    Private Sub pnlDetails_Paint(sender As Object, e As PaintEventArgs) Handles pnlDetails.Paint

    End Sub

    Private Sub dgvTrans_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTrans.SelectionChanged

        If dgvTrans.CurrentRow Is Nothing Or dgvTrans.CurrentRow.Index < 0 Then

            txtCustomerName.Clear()
            txtAdmin.Clear()
            txtTransactionType.Clear()
            txtAmount.Clear()
            lblTotal.Text = "Transaction Reference ID: ??"
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvTrans.CurrentRow

        txtCustomerName.Text = selectedRow.Cells("Customer Name").Value?.ToString()
        txtAdmin.Text = selectedRow.Cells("CreatedByAdmin").Value?.ToString()
        txtTransactionType.Text = selectedRow.Cells("TransactionType").Value?.ToString()
        lblTotal.Text = "Transaction Reference ID: " & selectedRow.Cells("TransactionID").Value?.ToString()

        If selectedRow.Cells("PaidAmount").Value IsNot Nothing Then

            Dim amount As Decimal
            If Decimal.TryParse(selectedRow.Cells("PaidAmount").Value.ToString(), amount) Then
                txtAmount.Text = amount.ToString("C2")
            Else
                txtAmount.Text = selectedRow.Cells("PaidAmount").Value.ToString()
            End If
        End If

    End Sub
End Class