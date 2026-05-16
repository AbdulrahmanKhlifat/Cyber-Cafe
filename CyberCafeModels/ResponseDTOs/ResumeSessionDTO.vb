Public Class ResumeSessionDTO

    Public Property SessionID As Integer
    Public Property CustomerID As Integer
    Public Property CustomerName As String
    Public Property DeviceTypeID As Integer
    Public Property DeviceTypeName As String
    Public Property CurrentDeviceID As Integer?
    Public Property CurrentDeviceName As String
    Public Property RemainingSeconds As Integer
    Public Property SessionStatus As SessionStatus

End Class