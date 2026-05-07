Public Class DeviceDTO
    Public Property DeviceID As Integer
    Public Property DeviceTypeID As Integer
    Public Property DeviceTypeName As String
    Public Property DeviceName As String
    Public Property Status As enDeviceStatus
    Public Property ImagePath As String
    Public Property PricePerHour As Decimal

    Public Property IsDeleted As Boolean
End Class