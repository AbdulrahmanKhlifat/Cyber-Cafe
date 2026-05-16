Imports CyberCafe_DataAccess
Imports CyberCafeModels

Public Class SessionService

    Public Shared Event SessionStarted(session As ActiveSession)
    Public Shared Event SessionPaused(session As ActiveSession)
    Public Shared Event SessionResumed(session As ActiveSession)
    Public Shared Event SessionEnded(session As ActiveSession)
    Public Shared Event SessionTicked(session As ActiveSession)

    Public Shared Sub Initialize()

        AddHandler ActiveSessionsManager.SessionExpired,
        AddressOf HandleSessionExpired

        AddHandler ActiveSessionsManager.SessionTicked,
        AddressOf HandleSessionTicked

        InitializeRuntimeSessions()

        ActiveSessionsManager.Start()

    End Sub

    Private Shared Sub InitializeRuntimeSessions()

        Try

            Dim runtimeSessionDTOs As List(Of SessionDTO) = SessionRepo.GetRuntimeSessions()

            For Each sessionDTO In runtimeSessionDTOs

                If sessionDTO Is Nothing Then

                    ErrorLogger.LogNullSession(NameOf(InitializeRuntimeSessions))

                    Continue For

                End If

                If sessionDTO.SessionStatus = SessionStatus.Active Then

                    Dim endTime As DateTime

                    If TryGetSessionEndTime(sessionDTO, endTime) Then

                        SessionRepo.MarkSessionEnded(sessionDTO.SessionID, endTime, sessionDTO.CurrentDeviceID.Value)

                        Continue For

                    End If

                End If

                AddSessionToRuntimeEngine(New ActiveSession(sessionDTO))

            Next

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

        End Try

    End Sub

    Private Shared Function TryGetSessionEndTime(session As SessionDTO, ByRef endTime As DateTime) As Boolean

        Dim difference As TimeSpan = Date.Now - session.LastResumeTime

        If difference.TotalSeconds > session.RemainingSeconds Then

            endTime = session.LastResumeTime.AddSeconds(session.RemainingSeconds)

            Return True

        End If

        session.RemainingSeconds = session.RemainingSeconds - difference.TotalSeconds

        Return False

    End Function

    Private Shared Sub AddSessionToRuntimeEngine(session As ActiveSession)


        Try

            ActiveSessionsManager.RegisterSession(session)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try


    End Sub

    Private Shared Sub HandleSessionTicked(session As ActiveSession)
        'In case the UI needs it
        RaiseEvent SessionTicked(session)

    End Sub

    Private Shared Sub HandleSessionExpired(session As ActiveSession)

        Try

            SessionRepo.MarkSessionEnded(session.SessionID, DateTime.Now, session.CurrentDeviceID.Value)

            RaiseEvent SessionEnded(session)

            ActiveSessionsManager.RemoveSession(session.SessionID)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

        End Try

    End Sub

    Private Shared Sub ValidateSessionStart(session As SessionDTO)
        If session Is Nothing Then
            Throw New ArgumentNullException(NameOf(session))
        End If

        If session.CurrentDeviceID Is Nothing Then
            Throw New InvalidOperationException("Session does not have a current device assigned.")
        End If

        If session.StartTime > DateTime.Now Then
            Throw New ArgumentException("Session StartTime cannot be in the future.")
        End If

        If session.RemainingSeconds <= 0 Then
            Throw New ArgumentException("Session Seconds was not set.")
        End If

        If Not CustomerRepo.IsCustomerExistsByID(session.CustomerID) Then
            Throw New ArgumentException("Customer Does not Exist!")
        End If

        If Not DeviceRepo.IsDeviceExists(session.CurrentDeviceID) Then
            Throw New ArgumentException("Device Does not exist!")
        End If

        Dim deviceStatus As enDeviceStatus = DeviceRepo.GetDeviceStatus(session.CurrentDeviceID)

        If deviceStatus = enDeviceStatus.InUse Then
            Throw New ArgumentException("Device already has an active session!")
        End If

        If deviceStatus = enDeviceStatus.Maintenance Then
            Throw New ArgumentException("Device is under maintenance!")
        End If

        If CustomerRepo.HasActiveSessionByCustomerId(session.CustomerID) Then
            Throw New InvalidOperationException("Customer already has an active session.")
        End If

        If Not DeviceRepo.DoesDeviceMatchType(session.CurrentDeviceID, session.DeviceTypeID) Then
            Throw New ArgumentException("Device does not match the session's device type.")
        End If

    End Sub

    Public Shared Function StartSession(session As SessionDTO) As Integer

        ValidateSessionStart(session)

        Try
            Dim start = DateTime.Now
            session.SessionStatus = SessionStatus.Active
            session.EndTime = Nothing
            session.StartTime = start
            session.LastResumeTime = start

            session.SessionCost = (session.RemainingSeconds / 3600D) * session.SessionRatePerHour

            session.SessionID = SessionRepo.InsertSession(session)

            'Keeps the reference to the same active session object
            Dim active = New ActiveSession(session)

            AddSessionToRuntimeEngine(active)

            RaiseEvent SessionStarted(active)

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

        Return session.SessionID

    End Function

    Public Shared Function PauseSession(sessionID As Integer) As Boolean

        If sessionID <= 0 Then
            Throw New ArgumentException(
            "Invalid SessionID."
        )
        End If

        Try
            Dim active = ActiveSessionsManager.GetSession(sessionID)

            If active.Status <> SessionStatus.Active Then
                Throw New InvalidOperationException("Only active sessions can be paused.")
            End If

            Dim isPaused As Boolean = SessionRepo.PauseSession(active.SessionID, active.RemainingSeconds, active.CurrentDeviceID)

            If isPaused Then

                active.Status = SessionStatus.Paused

                RaiseEvent SessionPaused(active)

            End If

            Return isPaused

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function

    Private Shared Function ValidateResumeSession(
    sessionID As Integer,
    deviceID As Integer
    ) As ActiveSession

        If sessionID <= 0 Then

            Throw New ArgumentException(
            "Invalid SessionID."
        )

        End If

        If deviceID <= 0 Then

            Throw New ArgumentException(
            "Invalid DeviceID."
        )

        End If

        'A paused session is loaded into the runtime engine by InitializeRuntimeSessions() which calls SessionRepo.GetRuntimeSessions()
        Dim pausedSession As ActiveSession = ActiveSessionsManager.GetSession(sessionID)

        If pausedSession.Status <>
        SessionStatus.Paused Then

            Throw New InvalidOperationException(
            "Only paused sessions can be resumed."
        )

        End If

        If DeviceRepo.IsDeviceOccupied(deviceID) Then

            Throw New InvalidOperationException(
            "Device already has an active session."
        )

        End If

        If Not DeviceRepo.DoesDeviceMatchType(
        deviceID,
        pausedSession.DeviceTypeID
        ) Then

            Throw New InvalidOperationException(
            "Cannot resume session on different device type."
        )

        End If

        If CustomerRepo.HasActiveSessionByCustomerId(pausedSession.CustomerID) Then

            Throw New InvalidOperationException(
            "Customer already has an active session."
        )

        End If

        Return pausedSession

    End Function

    Public Shared Function ResumeSession(sessionID As Integer, deviceID As Integer) As Boolean

        Try

            Dim pausedSession As ActiveSession = ValidateResumeSession(sessionID, deviceID)

            Dim resumeTime As DateTime = DateTime.Now
            Dim isResumed As Boolean = SessionRepo.ResumeSession(sessionID, resumeTime, deviceID)

            If isResumed Then

                pausedSession.LastResumeTime = resumeTime
                pausedSession.Status = SessionStatus.Active
                pausedSession.CurrentDeviceID = deviceID
                pausedSession.DeviceID = deviceID
                RaiseEvent SessionResumed(pausedSession)

            End If

            Return isResumed

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(ex, Reflection.MethodBase.GetCurrentMethod().Name)

            Throw

        End Try

    End Function

    Public Shared Function GetDeviceSessionKPI(
    deviceID As Integer
) As DeviceSessionKPI

        Try

            Return SessionRepo.GetDeviceSessionKPI(
                deviceID
            )

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
                ex,
                Reflection.MethodBase.
                GetCurrentMethod().Name
            )

            Throw

        End Try

    End Function

    Public Shared Function GetResumeSessionDetails(sessionID As Integer) As ResumeSessionDTO

        Try

            Dim dto As ResumeSessionDTO =
            SessionRepo.GetResumeSessionDetails(sessionID)

            If dto Is Nothing Then
                Throw New Exception("Paused session not found.")
            End If

            Return dto

        Catch ex As Exception

            ErrorLogger.LogErrorToFile(
            ex,
            Reflection.MethodBase.GetCurrentMethod().Name
        )

            Throw

        End Try

    End Function

    Public Shared Function GetActiveSessionsAsView() As DataTable
        Return SessionRepo.GetActiveSessionsView
    End Function

    Public Shared Function GetPausedSessionsAsView() As DataTable
        Return SessionRepo.GetPausedSessionsView
    End Function

    Public Shared Function GetSessionHistoryAsView() As DataTable
        Return SessionRepo.GetSessionsHistoryView()
    End Function



End Class
