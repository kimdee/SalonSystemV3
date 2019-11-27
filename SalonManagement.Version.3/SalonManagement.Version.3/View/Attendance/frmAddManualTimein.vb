Public Class frmAddManualTimein
    Private attendance As New Attendance
    Private employee As New Employee

    Private Sub frmAddManualTimein_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTime.Value = DateTime.Now
        dtpDate.Value = Date.Now.ToString
    End Sub

    Private Sub btnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles btnBrowseEmployee.Click
        Dim obj As New frmBrowseEmployee
        obj.employee = Me.employee
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                With employee
                    txtLName.Text = .EmployeeLN
                    txtFName.Text = .EmployeeFN
                    txtMName.Text = .EmployeeMN
                    If .EmployeeGender = "Male" Then
                        rdbMale.Checked = True
                    ElseIf .EmployeeGender = "Female" Then
                        rdbFemale.Checked = True
                    End If
                    txtPosition.Text = .EmployeePosition
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            employee.EmployeeID = employee.EmployeeID
            employee.SetEmployeeDetails(employee.EmployeeID)

            With attendance
                .EmployeeID = employee.EmployeeID
                .AttendanceDate = dtpDate.Value.ToString("d")
                If rdbAmTimeIn.Checked = True Then
                    .AttendanceMornIn = dtpTime.Value.ToString("t")
                ElseIf rdbAmTimeOut.Checked = True Then
                    .AttendanceMornIn = dtpTime.Value.ToString("t")
                ElseIf rdbPmTimeIn.Checked = True Then
                    .AttendanceMornIn = dtpTime.Value.ToString("t")
                ElseIf rdbPmTimeOut.Checked = True Then
                    .AttendanceMornIn = dtpTime.Value.ToString("t")
                End If
            End With

            If attendance.IsInMorningIn(attendance.EmployeeID) = True Then
                MessageBox.Show(employee.EmployeeLN + "," + employee.EmployeeFN + " has already Time-In.", "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf attendance.IsInMorningOut(attendance.EmployeeID) = True Then
                MessageBox.Show(employee.EmployeeLN + "," + employee.EmployeeFN + " has already Time-Out.", "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf attendance.IsInAfternoonIn(attendance.EmployeeID) = True Then
                MessageBox.Show(employee.EmployeeLN + "," + employee.EmployeeFN + " has already Time-In.", "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Successfully Time-In.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                attendance.IsAttendanceAdded()
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
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