Imports System.Reflection
Imports BusinessLayer_CyberCafe
Imports CyberCafeModels

Public Class frmSessions

    Private Sub frmSessions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigureGrids()

        'LoadMockActiveSessions()
        RefreshData()

        'LoadMockPausedSessions()
        'LoadMockSessionHistory()

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
    Private Sub LoadMockPausedSessions()

        dgvPausedSessions.Columns.Clear()
        dgvPausedSessions.Rows.Clear()

        dgvPausedSessions.Columns.Add("SessionID", "Session ID")
        dgvPausedSessions.Columns.Add("Customer", "Customer")
        dgvPausedSessions.Columns.Add("Device", "Device")
        dgvPausedSessions.Columns.Add("DeviceType", "Device Type")
        dgvPausedSessions.Columns.Add("Status", "Status")
        dgvPausedSessions.Columns.Add("PausedAt", "Paused At")
        dgvPausedSessions.Columns.Add("Remaining", "Remaining Time")

        dgvPausedSessions.Rows.Add(
        2001,
        "Omar",
        "PC-04",
        "Gaming PC",
        "Paused",
        "07:10 PM",
        "00:32:11"
    )

        dgvPausedSessions.Rows.Add(
        2002,
        "Kareem",
        "PS5-01",
        "PlayStation 5",
        "Paused",
        "07:18 PM",
        "01:12:45"
    )

        For Each row As DataGridViewRow In dgvPausedSessions.Rows

            row.Cells("Status").Style.ForeColor =
            Color.Goldenrod

        Next

    End Sub

    Private Sub LoadMockActiveSessions()

        dgvActiveSessions.Columns.Clear()
        dgvActiveSessions.Rows.Clear()

        dgvActiveSessions.Columns.Add("SessionID", "Session ID")
        dgvActiveSessions.Columns.Add("Customer", "Customer")
        dgvActiveSessions.Columns.Add("Device", "Device")
        dgvActiveSessions.Columns.Add("DeviceType", "Device Type")
        dgvActiveSessions.Columns.Add("Status", "Status")
        dgvActiveSessions.Columns.Add("Remaining", "Remaining Time")
        dgvActiveSessions.Columns.Add("StartTime", "Start Time")
        dgvActiveSessions.Columns.Add("Cost", "Cost")

        dgvActiveSessions.Rows.Add(
        1001,
        "Ahmad",
        "PC-01",
        "Gaming PC",
        "Active",
        "01:24:15",
        "06:00 PM",
        "$3.50"
    )

        dgvActiveSessions.Rows.Add(
        1002,
        "Mohammad",
        "PS5-02",
        "PlayStation 5",
        "Active",
        "00:45:20",
        "06:35 PM",
        "$2.00"
    )

        For Each row As DataGridViewRow In dgvActiveSessions.Rows

            row.Cells("Status").Style.ForeColor =
            Color.FromArgb(0, 200, 160)

        Next

    End Sub

    Private Sub LoadMockSessionHistory()

        dgvSessionsHistory.Columns.Clear()
        dgvSessionsHistory.Rows.Clear()

        dgvSessionsHistory.Columns.Add("SessionID", "Session ID")
        dgvSessionsHistory.Columns.Add("Customer", "Customer")
        dgvSessionsHistory.Columns.Add("Device", "Device")
        dgvSessionsHistory.Columns.Add("DeviceType", "Device Type")
        dgvSessionsHistory.Columns.Add("StartTime", "Start Time")
        dgvSessionsHistory.Columns.Add("EndTime", "End Time")
        dgvSessionsHistory.Columns.Add("Duration", "Duration")
        dgvSessionsHistory.Columns.Add("Cost", "Cost")

        dgvSessionsHistory.Rows.Add(
        3001,
        "Ali",
        "PC-07",
        "Gaming PC",
        "03:00 PM",
        "05:00 PM",
        "02:00:00",
        "$5.00"
    )

        dgvSessionsHistory.Rows.Add(
        3002,
        "Yousef",
        "PS5-03",
        "PlayStation 5",
        "04:30 PM",
        "06:00 PM",
        "01:30:00",
        "$4.00"
    )

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