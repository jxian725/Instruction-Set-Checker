﻿Public Class InstructionSetChecker
    <Runtime.InteropServices.DllImport("kernel32.dll")>
    Shared Function GetEnabledXStateFeatures() As Long
    End Function
    Public Function SSEAVX() As Boolean
        Try
            If Not (GetEnabledXStateFeatures() & 4) = 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        If SSEAVX() Then
            MsgBox("Your PC support AVX Instruction Set")
        Else
            MsgBox("Your PC only support SSE Instruction Set")
        End If
    End Sub
End Class
