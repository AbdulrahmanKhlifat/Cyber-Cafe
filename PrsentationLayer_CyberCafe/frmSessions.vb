Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class frmSessions


    Private WithEvents tsmiResume As New ToolStripMenuItem(" Resume Session")

    Private Sub frmSessions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tsmiResume.ForeColor = Color.White
        tsmiResume.BackColor = Color.FromArgb(28, 33, 40)
        cmsResumeSession.Items.Add(tsmiResume)
        cmsResumeSession.BackColor = Color.FromArgb(28, 33, 40)
        dgvPausedSessions.ContextMenuStrip = cmsResumeSession

        ConfigureGrids()

        RefreshData()

    End Sub

    Private Sub tsmiResume_Click(sender As Object, e As EventArgs) Handles tsmiResume.Click
        If dgvPausedSessions.SelectedRows.Count > 0 Then
            Dim row = dgvPausedSessions.SelectedRows(0)
            
            Dim sessionID As Integer = Convert.ToInt32(row.Cells("Session ID").Value)
            Dim sessionDTO = ActiveSessionsManager.GetSession(sessionID)

            If sessionDTO IsNot Nothing Then

                Dim customerName As String = row.Cells("Customer").Value.ToString()
                Dim currentDeviceName As String = row.Cells("Device").Value.ToString()
                Dim deviceTypeName As String = row.Cells("Device Type").Value.ToString()

                Dim frm As New frmResumeSession(sessionDTO.SessionID, sessionDTO.DeviceTypeID, sessionDTO.RemainingSeconds, customerName, currentDeviceName, deviceTypeName)

                If frm.ShowDialog() = DialogResult.OK Then

                    Dim newDeviceID = frm.SelectedNewDeviceID

                    Try

                        If SessionService.ResumeSession(sessionID, newDeviceID) Then
                            RefreshData()
                        Else

                            UIHelper.ShowGunaMessage("Failed to resume session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If

                    Catch ex As Exception

                        UIHelper.ShowGunaMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub ConfigureGrids()

        ConfigureGrid(dgvActiveSessions)
        ConfigureGrid(dgvPausedSessions)
        ConfigureGrid(dgvSessionsHistory)

    End Sub

    Public Sub RefreshData()

        dgvActiveSessions.DataSource = SessionService.GetActiveSessionsAsView()
        dgvPausedSessions.DataSource = SessionService.GetPausedSessionsAsView()
        dgvSessionsHistory.DataSource = SessionService.GetSessionHistoryAsView()

        'For Each row As DataGridViewRow In dgvActiveSessions.Rows

        '    If row.Cells("Status").Value IsNot Nothing Then

        '        row.Cells("Status").Style.ForeColor = Color.FromArgb(0, 200, 160)

        '    End If

        'Next



    End Sub

    Private Sub ConfigureGrid(dgv As Guna.UI2.WinForms.Guna2DataGridView)

        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False

        dgv.ReadOnly = True
        dgv.MultiSelect = False
        dgv.RowHeadersVisible = False

        dgv.Dock = DockStyle.Fill

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgv.BackgroundColor = Color.FromArgb(13, 17, 23)

        dgv.GridColor = Color.FromArgb(48, 54, 61)

        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        dgv.EnableHeadersVisualStyles = False

        dgv.ColumnHeadersHeight = 45
        dgv.ColumnHeadersHeightSizeMode =
        DataGridViewColumnHeadersHeightSizeMode.EnableResizing

        dgv.RowTemplate.Height = 45

        ' =========================
        ' Alternating Rows
        ' =========================

        dgv.AlternatingRowsDefaultCellStyle.BackColor =
        Color.FromArgb(28, 33, 40)

        ' =========================
        ' Header Style
        ' =========================

        dgv.ColumnHeadersDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter

        dgv.ColumnHeadersDefaultCellStyle.BackColor =
        Color.FromArgb(33, 38, 45)

        dgv.ColumnHeadersDefaultCellStyle.ForeColor =
        Color.FromArgb(230, 237, 243)

        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor =
        Color.FromArgb(33, 38, 45)

        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor =
        Color.FromArgb(230, 237, 243)

        dgv.ColumnHeadersDefaultCellStyle.Font =
        New Font("Segoe UI", 10.5!, FontStyle.Bold)

        ' =========================
        ' Rows Style
        ' =========================

        dgv.DefaultCellStyle.BackColor =
        Color.FromArgb(22, 27, 34)

        dgv.DefaultCellStyle.ForeColor =
        Color.FromArgb(230, 237, 243)

        dgv.DefaultCellStyle.SelectionBackColor =
        Color.FromArgb(0, 120, 100)

        dgv.DefaultCellStyle.SelectionForeColor =
        Color.White

        dgv.DefaultCellStyle.Padding =
        New Padding(10, 0, 10, 0)

        dgv.DefaultCellStyle.Font =
        New Font("Segoe UI", 9.75!)

        ' =========================
        ' ThemeStyle
        ' =========================

        dgv.ThemeStyle.BackColor =
        Color.FromArgb(13, 17, 23)

        dgv.ThemeStyle.GridColor =
        Color.FromArgb(48, 54, 61)

        dgv.ThemeStyle.ReadOnly = True

        dgv.ThemeStyle.HeaderStyle.BackColor =
        Color.FromArgb(33, 38, 45)

        dgv.ThemeStyle.HeaderStyle.ForeColor =
        Color.FromArgb(230, 237, 243)

        dgv.ThemeStyle.HeaderStyle.Font =
        New Font("Segoe UI", 10.5!, FontStyle.Bold)

        dgv.ThemeStyle.HeaderStyle.BorderStyle =
        DataGridViewHeaderBorderStyle.None

        dgv.ThemeStyle.HeaderStyle.Height = 45

        dgv.ThemeStyle.RowsStyle.BackColor =
        Color.FromArgb(22, 27, 34)

        dgv.ThemeStyle.RowsStyle.ForeColor =
        Color.FromArgb(230, 237, 243)

        dgv.ThemeStyle.RowsStyle.SelectionBackColor =
        Color.FromArgb(0, 120, 100)

        dgv.ThemeStyle.RowsStyle.SelectionForeColor =
        Color.White

        dgv.ThemeStyle.RowsStyle.BorderStyle =
        DataGridViewCellBorderStyle.SingleHorizontal

        dgv.ThemeStyle.RowsStyle.Font =
        New Font("Segoe UI", 9.75!)

        dgv.ThemeStyle.RowsStyle.Height = 45

        dgv.ThemeStyle.AlternatingRowsStyle.BackColor =
        Color.FromArgb(28, 33, 40)

    End Sub


End Class