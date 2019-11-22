Public Class frmReadPasscode
    Private attendance As New Attendance
    Public employee As Employee

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPasscode_TextChanged(sender As Object, e As EventArgs) Handles txtPasscode.TextChanged
        If employee.IsPasscodeRead(txtPasscode.Text) = True Then

        End If
    End Sub
End Class