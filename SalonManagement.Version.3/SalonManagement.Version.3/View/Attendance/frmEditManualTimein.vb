Public Class frmEditManualTimein
    Public attendance As Attendance
    Public employee As Employee

    Private Sub frmEditManualTimein_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With employee
            txtLName.Text = .EmployeeLN
            txtFName.Text = .EmployeeFN
            txtMName.Text = .EmployeeMN

            If .EmployeePosition = "Male" Then
                rdbMale.Checked = True
            Else
                rdbFemale.Checked = True
            End If
            txtPosition.Text = .EmployeePosition
        End With

        With attendance
            .SetAttendanceDetails(attendance.EmployeeID)
            dtpDate.Text = .AttendanceDate
        End With

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            With attendance
                .EmployeeID = employee.EmployeeID
                .AttendanceDate = dtpDate.Value.ToString
                .AttendanceMornOut = dtpTime.Value.ToString("hh:mm tt")
                .UpdateMorningOut()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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