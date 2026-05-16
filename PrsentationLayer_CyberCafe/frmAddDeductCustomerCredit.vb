Imports BusinessLayer_CyberCafe
Imports CyberCafeModels
Imports CyberCafeModels.CyberCafe.Models
Imports Guna.UI2.WinForms

Public Class frmAddDeductCustomerCredit

    Public Enum enMode
        Add = 1
        Deduct = 2
    End Enum

    Private ReadOnly _mode As enMode

    Private Property customer As CustomerDTO

    Public Sub New(
        customerID As Integer,
        mode As enMode
    )

        InitializeComponent()

        customer = CustomerServices.Find(customerID)

        _mode = mode

        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtAddCredit_TextChanged(
    sender As Object,
    e As EventArgs
) Handles txtAddCredit.TextChanged

        Dim txt As Guna2TextBox = DirectCast(
        sender,
        Guna2TextBox
    )

        If String.IsNullOrWhiteSpace(txt.Text) Then
            Return
        End If

        Dim value As Integer

        If Not Integer.TryParse(txt.Text, value) _
    OrElse value < 0 Then

            Dim cursorPosition As Integer =
            txt.SelectionStart - 1

            txt.Text =
            New String(
                txt.Text.Where(
                    Function(c) Char.IsDigit(c)
                ).ToArray()
            )

            If cursorPosition < 0 Then
                cursorPosition = 0
            End If

            txt.SelectionStart =
            Math.Min(
                cursorPosition,
                txt.Text.Length
            )

        End If

    End Sub

    Private Sub SetUIColor(color As Color)

        pnlContainer.BorderColor = color
        btnUpdate.FillColor = color
        lblCurrentCredit.ForeColor = color
        lblHeader.ForeColor = color
        txtAddCredit.HoverState.BorderColor = color
        txtAddCredit.FocusedState.BorderColor = color

    End Sub

    Private Sub frmAddCustomerCredit_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        pnlContainer.EnableDragging()

        lblCurrentCredit.Text =
        $"{customer.Credit}"

        lblCustomername.Text =
        $"{customer.Username}"

        Select Case _mode

            Case enMode.Add

                btnUpdate.Text = "ADD CREDIT"

                SetUIColor(Color.FromArgb(120, 90, 255))

            Case enMode.Deduct

                btnUpdate.Text = "DEDUCT CREDIT"

                SetUIColor(Color.Crimson)

        End Select

    End Sub

    Private Sub btnUpdate_Click(
    sender As Object,
    e As EventArgs
) Handles btnUpdate.Click

        Try

            If String.IsNullOrWhiteSpace(
            txtAddCredit.Text
        ) Then

                UIHelper.ShowGunaMessage(
                "Please enter an amount.",
                "Validation",
                MessageDialogIcon.Warning
            )

                txtAddCredit.Focus()

                Return

            End If

            Dim amount As Decimal

            If Not Decimal.TryParse(
            txtAddCredit.Text,
            amount
        ) Then

                UIHelper.ShowGunaMessage(
                "Invalid amount.",
                "Validation",
                MessageDialogIcon.Warning
            )

                txtAddCredit.Focus()

                Return

            End If

            If amount <= 0 Then

                UIHelper.ShowGunaMessage(
                "Amount must be greater than 0.",
                "Validation",
                MessageDialogIcon.Warning
            )

                txtAddCredit.Focus()

                Return

            End If

            Dim isUpdated As Boolean = False

            Select Case _mode

                Case enMode.Add

                    isUpdated =
            CustomerServices.AddCredits(
                customer.UserID,
                amount,
                LoggedInUser.CurrentUser.UserID
            )

                Case enMode.Deduct

                    isUpdated =
            CustomerServices.DeductCredits(
                customer.UserID,
                amount,
                LoggedInUser.CurrentUser.UserID
            )

            End Select

            If Not isUpdated Then

                UIHelper.ShowGunaMessage(
                $"Failed to {_mode.ToString().ToLower()} credit.",
                "Error",
                MessageDialogIcon.Error
            )

                Return

            End If

            UIHelper.ShowGunaMessage(
            $"Credit {_mode.ToString().ToLower()}ed successfully.",
            "Success",
            MessageDialogIcon.Information
        )

            Me.Close()

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
            ex,
            Reflection.MethodBase.
            GetCurrentMethod().Name
        )

            UIHelper.ShowGunaMessage(
            $"Failed to {_mode.ToString().ToLower()} credit.",
            "Error",
            MessageDialogIcon.Error
        )

        End Try

    End Sub


End Class