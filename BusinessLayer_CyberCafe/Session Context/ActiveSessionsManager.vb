Imports System.Timers
Imports CyberCafeModels

Public Class ActiveSessionsManager

    Public Shared Event SessionTicked(session As ActiveSession)

    Public Shared Event SessionExpired(session As ActiveSession)

    Private Shared ReadOnly _timer As New Timer()

    Private Shared ReadOnly _activeSessions As New Dictionary(Of Integer, ActiveSession)

    Public Shared Function SessionExists(sessionID As Integer) As Boolean

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID."
        )
        End If

        Return _activeSessions.ContainsKey(sessionID)

    End Function
    Public Shared Sub RegisterSession(session As ActiveSession)

        If session Is Nothing Then
            Throw New ArgumentNullException(NameOf(session))
        End If

        If _activeSessions.ContainsKey(session.SessionID) Then

            Throw New InvalidOperationException("Session is already registered.")

        End If

        _activeSessions.Add(session.SessionID, session)
    End Sub

    Public Shared Function GetSession(sessionID As Integer) As ActiveSession
        If sessionID <= 0 Then
            Throw New ArgumentException("Invalid Session ID")
        End If

        If Not _activeSessions.ContainsKey(sessionID) Then

            Throw New KeyNotFoundException("Session is not registered.")

        End If

        Return _activeSessions(sessionID)

    End Function

    Public Shared Function GetActiveSessionByDeviceID(deviceID As Integer) As ActiveSession

        For Each session In _activeSessions.Values.ToList()

            If session.DeviceID = deviceID AndAlso
           session.Status = SessionStatus.Active Then

                Return session

            End If

        Next

        Return Nothing

    End Function

    Public Shared Function RemoveSession(sessionID As Integer) As Boolean
        If sessionID <= 0 Then
            Throw New ArgumentException("Invalid SessionID")
        End If

        If Not _activeSessions.ContainsKey(sessionID) Then

            Throw New KeyNotFoundException("Session is not registered.")

        End If

        Return _activeSessions.Remove(sessionID)

    End Function

    Public Shared Function GetAllSessions() As IReadOnlyCollection(Of ActiveSession)

        Return _activeSessions.Values.ToList()

    End Function

    Public Shared Sub Start()

        If _timer.Enabled Then Return

        _timer.Interval = 1000

        AddHandler _timer.Elapsed,
            AddressOf OnTimerElapsed

        _timer.Start()

    End Sub

    '[stop] cause stop is a reserved keyword
    Public Shared Sub [Stop]()

        If Not _timer.Enabled Then Return

        _timer.Stop()

        RemoveHandler _timer.Elapsed,
            AddressOf OnTimerElapsed

    End Sub

    Private Shared Sub OnTimerElapsed(sender As Object, e As ElapsedEventArgs)

        '.ToList() creates safe snapshot if the session gets removed the app doesn't crash
        For Each session In _activeSessions.Values.ToList()

            If session.Status <> SessionStatus.Active Then
                Continue For
            End If

            session.RemainingSeconds -= 1

            If session.RemainingSeconds <= 0 Then

                session.RemainingSeconds = 0

            End If

            RaiseEvent SessionTicked(session)

            If session.RemainingSeconds = 0 Then

                session.Status = SessionStatus.Ended

                RaiseEvent SessionExpired(session)

            End If

        Next

    End Sub
End Class
