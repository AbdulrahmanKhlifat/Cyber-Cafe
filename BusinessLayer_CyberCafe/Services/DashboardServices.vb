Imports CyberCafe_DataAccess
Imports CyberCafeModels
Public Class DashboardServices
    Public Shared Function GetDashboardKpis() As DashboardKpiDTO

        Return DashboardRepo.GetDashboardKpis()

    End Function
End Class
