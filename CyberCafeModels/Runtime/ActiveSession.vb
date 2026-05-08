Public Class ActiveSession
    Public Property SessionID As Integer

    Public Property CustomerID As Integer

    Public Property DeviceID As Integer

    Public Property DeviceTypeID As Integer

    Public Property RemainingSeconds As Integer

    Public Property LastResumeTime As DateTime

    Public Property Status As SessionStatus
    Public Property CurrentDeviceID As Integer?

    Public Sub New()

    End Sub

    Public Sub New(session As SessionDTO)

        If session Is Nothing Then
            Throw New ArgumentNullException(NameOf(session))
        End If

        SessionID = session.SessionID

        CustomerID = session.CustomerID

        DeviceID = session.CurrentDeviceID.GetValueOrDefault()

        DeviceTypeID = session.DeviceTypeID

        RemainingSeconds = session.RemainingSeconds

        LastResumeTime = session.LastResumeTime

        Status = session.SessionStatus

        CurrentDeviceID = session.CurrentDeviceID

    End Sub

End Class
