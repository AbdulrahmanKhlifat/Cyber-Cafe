Imports System.Text.RegularExpressions

Namespace PresentationLayer_CyberCafe


    Public Class ValidationHelper

        Public Shared Function ValidateEmail(emailAddress As String) As Boolean

            Dim pattern As String = "^[a-zA-Z0-9.!#$%&'*+\-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+$"

            Dim regex As New Regex(pattern)

            Return regex.IsMatch(emailAddress)

        End Function

        Public Shared Function ValidateInteger(Number As String) As Boolean

            Dim pattern As String = "^[0-9]+$"

            Dim regex As New Regex(pattern)

            Return regex.IsMatch(Number)

        End Function

        Public Shared Function ValidateDecimal(Number As String) As Boolean

            Dim pattern As String = "^[0-9]+(?:\.[0-9]+)?$"

            Dim regex As New Regex(pattern)

            Return regex.IsMatch(Number)

        End Function

        Public Shared Function IsNumber(Number As String) As Boolean

            Return (ValidateInteger(Number) OrElse ValidateDecimal(Number))

        End Function

    End Class


End Namespace
