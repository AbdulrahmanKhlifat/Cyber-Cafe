Public Class ctrShowDeviceInfo

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub LoadTestData(name As String, type As String, status As String)
        lblDeviceName.Text = name
        lblDeviceType.Text = type
        lblStatus.Text = status

        ' Test image logic
        If type = "PC" Then
            pbDeviceIcon.Image = My.Resources.imac
        Else
            pbDeviceIcon.Image = My.Resources.games
        End If
    End Sub
    Public Sub CheckStatusDot(status As String)
        Select Case status
            Case "Available"
                pbStatusDot.FillColor = Color.Green
                lblStatus.ForeColor = Color.Green
            Case "In Use"
                pbStatusDot.FillColor = Color.DarkRed
                lblStatus.ForeColor = Color.Red
            Case "Maintenance"
                pbStatusDot.FillColor = Color.Orange
                lblStatus.ForeColor = Color.Orange
            Case Else
                pbStatusDot.FillColor = Color.Gray
                lblStatus.ForeColor = Color.Gray
        End Select
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class
