Public Class frmEditManualTimein
    Public attendance As Attendance
    Public employee As Employee

    Private Sub frmEditManualTimein_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLName.Text = employee.EmployeeLN
        txtFName.Text = employee.EmployeeFN
        txtMName.Text = employee.EmployeeMN
        If employee.EmployeePosition = "Male" Then
            rdbMale.Checked = True
        Else
            rdbFemale.Checked = True
        End If
        txtPosition.Text = employee.EmployeePosition

        'With attendance
        '    dtpDate.Value = .AttendanceDate
        'End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If attendance.IsInMorningIn(attendance.EmployeeID) = True Then
            MessageBox.Show(employee.EmployeeLN + "," + employee.EmployeeFN + "has already Time-In.", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf attendance.IsInMorningOut(attendance.EmployeeID) = True Then
            MessageBox.Show(employee.EmployeeLN + "," + employee.EmployeeFN + "has already Time-Out.", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf attendance.IsInAfternoonIn(attendance.EmployeeID) = True Then
            MessageBox.Show(employee.EmployeeLN + "," + employee.EmployeeFN + "has already Time-In.", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With attendance

            End With
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class