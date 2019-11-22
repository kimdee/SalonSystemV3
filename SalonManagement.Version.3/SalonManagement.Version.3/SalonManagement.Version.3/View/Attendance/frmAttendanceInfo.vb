Imports System.Windows.Forms

Public Class frmAttendanceInfo
    Dim i As Integer = 0

    Private Sub TimerTimein_Tick(sender As Object, e As EventArgs) Handles TimerTimein.Tick
        i = i + 1
        If i = 10 Then
            Me.Close()
        End If
    End Sub

    Private Sub AttendanceTimeIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerTimein.Start()
    End Sub

End Class