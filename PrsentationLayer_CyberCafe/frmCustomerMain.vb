Imports CyberCafeModels.CyberCafe.Models

Public Class frmCustomerMain
    Private _Customer As CustomerDTO

    Public Sub New(customer As CustomerDTO)
        InitializeComponent()

        _Customer = customer
    End Sub
    Private Sub frmCustomerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class