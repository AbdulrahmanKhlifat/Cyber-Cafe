Public Class SessionDTO
    Public Property SessionID As Integer

    Public Property CreatedByAdminID As Integer

    Public Property CustomerID As Integer

    Public Property DeviceTypeID As Integer

    ' Nullable because "Allow Nulls" is checked
    Public Property CurrentDeviceID As Integer?

    Public Property SessionStatus As SessionStatus

    Public Property RemainingSeconds As Integer

    Public Property SessionRatePerHour As Decimal

    Public Property StartTime As DateTime

    Public Property EndTime As DateTime?

    Public Property LastResumeTime As DateTime

End Class