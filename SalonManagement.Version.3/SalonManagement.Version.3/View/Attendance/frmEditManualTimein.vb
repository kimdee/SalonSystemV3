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

        With attendance
            'dtpDate.Value.ToString = .AttendanceDate
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With attendance
            .EmployeeID = employee.EmployeeID
            .AttendanceDate = dtpDate.Value.ToString

            If rdbAmTimeIn.Checked = True Then
                .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
            ElseIf rdbAmTimeOut.Checked = True Then
                .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
            ElseIf rdbPmTimeIn.Checked = True Then
                .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
            ElseIf rdbPmTimeOut.Checked = True Then
                .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
            End If

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
                MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                attendance.IsAttendanceUpdated()
                Me.Close()
            End If

            'If rdbAmTimeOut.Checked = True Then
            '    .SetAttendanceDetails(attendance.EmployeeID)
            '    .AttendanceMornOut = dtpTime.Value.ToString

            '    .IsAttendanceUpdated()
            '    MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.DialogResult = DialogResult.OK
            '    Me.Close()
            'ElseIf rdbPmTimeIn.Checked = True Then
            '    .AttendanceAftIn = dtpTime.Value.ToString

            '    .UpdateAfternoonIn()
            '    MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.DialogResult = DialogResult.OK
            '    Me.Close()
            'ElseIf rdbPmTimeOut.Checked = True Then
            '    .AttendanceAftOut = dtpTime.Value.ToString

            '    .UpdateAfternoonOut()
            '    MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.DialogResult = DialogResult.OK
            '    Me.Close()
            'Else
            '    MessageBox.Show("Failed to update. Account already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        dtpDate.MinDate = Date.Today.AddDays(-1)
        dtpDate.MaxDate = Date.Now.ToString
    End Sub
End Class