Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class FrmAttendanceTimein
    Dim dtserver As Date

    Private employee As New Employee
    Private attendance As New Attendance

    Dim ms As String = ""


    'Sub PlayAccessGrantedFile()
    '    My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\confirmed.wav",
    '        AudioPlayMode.WaitToComplete)
    'End Sub
    'Sub PlayAccessDeniedFile()
    '    My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\access_denied.wav",
    '        AudioPlayMode.WaitToComplete)
    'End Sub

    Private Sub TimerAttendance_Tick(sender As Object, e As EventArgs) Handles TimerAttendance.Tick
        Dim sql As String = "SELECT NOW();"
        Try
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            dtserver = cmd.ExecuteScalar
            lblTodayTime.Text = TimeOfDay.ToString("h:mm:ss tt")
            lblTodayDate.Text = Today.ToLongDateString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerAttendance.Start()
    End Sub

    Private Sub txtPasscode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasscode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsTextBoxEmpty(txtPasscode) = True Then
                MessageBox.Show("Please Enter Your Passcode", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If employee.IsPasscodeRead(txtPasscode.Text) = True Then
                    employee.EmployeeID = employee.EmployeeID
                    employee.SetEmployeeDetails(employee.EmployeeID)

                    attendance.EmployeeID = employee.EmployeeID
                    attendance.AttendanceDate = dtserver
                    attendance.AttendanceMornIn = dtserver.ToString("hh:mm:ss tt")

                    If attendance.IsInMorningIn(attendance.EmployeeID) = True Then
                        ms = "Morning Time-out"

                        Dim obj As New frmAttendanceInfo
                        obj.lblT.Text = ms
                        obj.lblName.Text = employee.EmployeeLN + " " + employee.EmployeeFN
                        obj.lblTime.Text = dtserver.ToString("hh:mm:ss tt")
                        obj.ShowDialog()

                        attendance.AttendanceMornOut = dtserver.ToString("hh:mm:ss tt")
                        attendance.UpdateMorningOut()

                    ElseIf attendance.IsInMorningOut(attendance.EmployeeID) = True Then
                        ms = "Afternoon Time In"

                        Dim obj As New frmAttendanceInfo
                        obj.lblT.Text = ms
                        obj.lblName.Text = employee.EmployeeLN + " " + employee.EmployeeFN
                        obj.lblTime.Text = dtserver.ToString("hh:mm:ss tt")
                        obj.ShowDialog()

                        attendance.AttendanceAftIn = dtserver.ToString("hh:mm:ss tt")
                        attendance.UpdateAfternoonIn()

                    ElseIf attendance.IsInAfternoonIn(attendance.EmployeeID) = True Then
                        ms = "Afternoon Time Out"

                        Dim obj As New frmAttendanceInfo
                        obj.lblT.Text = ms
                        obj.lblName.Text = employee.EmployeeLN + " " + employee.EmployeeFN
                        obj.lblTime.Text = dtserver.ToString("hh:mm:ss tt")
                        obj.ShowDialog()

                        attendance.AttendanceAftOut = dtserver.ToString("hh:mm:ss tt")
                        attendance.UpdateAfternoonOut()

                    Else
                        ms = "Morning Time In"

                        Dim obj As New frmAttendanceInfo
                        obj.lblT.Text = ms
                        obj.lblName.Text = employee.EmployeeLN + " " + employee.EmployeeFN
                        obj.lblTime.Text = dtserver.ToString("hh:mm:ss tt")
                        obj.ShowDialog()

                        attendance.IsAttendanceAdded()
                    End If

                    'if employee.employeeid = "0" then
                    '    playaccessdeniedfile()
                    'else
                    '    playaccessgrantedfile()
                    'end if
                Else
                    Dim err As ErrorMessage
                    err = New ErrorMessage
                    err.lblMsg.Text = "Employee doesn't exist"
                    err.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub txtPasscode_GotFocus(sender As Object, e As EventArgs) Handles txtPasscode.GotFocus
        txtPasscode.Text = ""
        txtPasscode.ForeColor = Color.Black
    End Sub
    Private Sub txtPasscode_LostFocus(sender As Object, e As EventArgs) Handles txtPasscode.LostFocus
        txtPasscode.ForeColor = Color.DimGray
        txtPasscode.Text = "ENTER PASS CODE"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub txtPasscode_TextChanged(sender As Object, e As EventArgs) Handles txtPasscode.TextChanged

    End Sub
End Class