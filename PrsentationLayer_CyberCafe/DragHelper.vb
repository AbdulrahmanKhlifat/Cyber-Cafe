Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices ' Required to create Extension Methods

Public Module DragHelper

    ' 1. Import the Windows APIs once
    <DllImport("user32.dll", SetLastError:=True)>
    Private Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    ' 2. Create the Extension Method
    ' The <Extension()> attribute attaches this sub to ALL standard Windows Controls
    <Extension()>
    Public Sub EnableDragging(ByVal ctrl As Control)

        ' Dynamically attach the MouseDown event to whatever control is passed in
        AddHandler ctrl.MouseDown,
            Sub(sender As Object, e As MouseEventArgs)
                If e.Button = MouseButtons.Left Then
                    ReleaseCapture()

                    ' Automatically find which form this control lives on
                    Dim parentForm As Form = ctrl.FindForm()

                    If parentForm IsNot Nothing Then
                        SendMessage(parentForm.Handle, WM_NCLBUTTONDOWN, New IntPtr(HT_CAPTION), IntPtr.Zero)
                    End If
                End If
            End Sub
    End Sub

End Module