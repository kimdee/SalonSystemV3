Public Class frmAddManualTimein
    Private attendance As New Attendance
    Private employee As New Employee

    Public Shared dtServer As Date = DateTime.Now

    Private Sub frmAddManualTimein_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = dtServer.ToShortDateString
        dtpTime.Value = dtServer.ToString
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
                    .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
                ElseIf rdbAmTimeOut.Checked = True Then
                    .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
                ElseIf rdbPmTimeIn.Checked = True Then
                    .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
                ElseIf rdbPmTimeOut.Checked = True Then
                    .AttendanceMornIn = dtpTime.Value.TimeOfDay.ToString
                End If
            End With

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


End Class