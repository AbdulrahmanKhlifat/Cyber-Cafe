Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Namespace Helpers
    Public Module DataReaderExtensions

        <Extension()>
        Public Function GetNullableInt(reader As SqlDataReader, columnName As String) As Integer?

            Dim val = reader(columnName)

            If IsDBNull(val) Then

                Return Nothing

            End If

            Return Convert.ToInt32(val)

        End Function

        <Extension()>
        Public Function GetNullableByte(reader As SqlDataReader, columnName As String) As Byte?

            Dim val = reader(columnName)

            If IsDBNull(val) Then

                Return Nothing

            End If

            Return Convert.ToByte(val)

        End Function

        <Extension()>
        Public Function GetNullableDateTime(reader As SqlDataReader, columnName As String) As DateTime?

            Dim val = reader(columnName)

            If IsDBNull(val) Then

                Return Nothing

            End If

            Return Convert.ToDateTime(val)

        End Function

    End Module
End Namespace
