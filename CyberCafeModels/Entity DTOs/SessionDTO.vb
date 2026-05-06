Public Class SessionDTO
    Public Property SessionID As Integer
    Public Property CreatedByAdmin As Integer
    Public Property CustomerID As Integer
    Public Property DeviceTypeID As Integer

    ' Nullable because "Allow Nulls" is checked
    Public Property CurrentDeviceID As Integer?

    ' tinyint maps to Byte; nullable per schema
    Public Property SessionStatus As Byte?

    Public Property RemainingSeconds As Integer

    Public Property SessionRatePerHour As Decimal

    Public Property StartTime As DateTime

    Public Property EndTime As DateTime?

    Public Property LastResumeTime As DateTime
End Class