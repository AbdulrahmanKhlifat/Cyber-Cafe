Imports System.Data.SqlClient
Imports CyberCafeModels

Public Class DashboardRepo
    Public Shared Function GetDashboardKpis() As DashboardKpiDTO

        Using conn As New SqlConnection(DataAccessSettings.connectionString)

            Dim query As String =
            "SELECT
                (SELECT COUNT(*) 
                 FROM Users 
                 WHERE IsDeleted = 0 AND RoleType = 2
                 ) AS TotalCustomers,

                COUNT(*) AS TotalDevices,

                SUM(CASE 
                    WHEN Status = 1 THEN 1 
                    ELSE 0 
                END) AS AvailableDevices,

                (SELECT COUNT(*) 
                 FROM Sessions 
                 WHERE SessionStatus = 0) AS ActiveSessions,

                (SELECT ISNULL(SUM(PaidAmount), 0)
                 FROM Transactions
                 WHERE CAST(TransactionDate AS DATE) = CAST(GETDATE() AS DATE)
                   AND IsDeleted = 0) AS TodayRevenue

            FROM Devices
            Where IsDeleted = 0;"

            Using cmd As New SqlCommand(query, conn)

                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            Dim kpis As New DashboardKpiDTO With {
                                .TotalCustomers = CType(reader("TotalCustomers"), Integer),
                                .TotalDevices = CType(reader("TotalDevices"), Integer),
                                .AvailableDevices = CType(reader("AvailableDevices"), Integer),
                                .ActiveSessions = CType(reader("ActiveSessions"), Integer),
                                .TodayRevenue = CType(reader("TodayRevenue"), Decimal)
                            }

                            Return kpis

                        End If

                    End Using

                Catch ex As Exception

                    ErrorLogger.LogErrorToFile(
                        ex,
                        System.Reflection.MethodBase.GetCurrentMethod().Name
                    )

                    Return Nothing

                End Try

            End Using

        End Using

        Return Nothing

    End Function
End Class
