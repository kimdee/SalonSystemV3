Public Class FrmAttendance
    Private attendance As New Attendance
    Private employee As New Employee
    Private Sub frmViewFilterAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attendance.ViewAttendance(gvView)
    End Sub

    Private Sub btnManualAttendance_Click(sender As Object, e As EventArgs) Handles btnManualAttendance.Click
        Dim obj As New frmAddManualTimein
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            attendance.ViewAttendance(gvView)
        Else
            attendance.ViewAttendance(gvView)
        End If
    End Sub
    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 13 Then
            attendance.SetAttendanceDetails(gvView.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditManualTimein
            obj.attendance = Me.attendance
            obj.employee = Me.employee
            If obj.ShowDialog = DialogResult.OK Then
                attendance.ViewAttendance(gvView)
            End If
        End If
    End Sub

End Class