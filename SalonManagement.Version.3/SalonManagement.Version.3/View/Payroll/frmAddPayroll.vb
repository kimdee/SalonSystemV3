Public Class frmAddPayroll
    Private employee As New Employee
    Private deduction As New Deduction
    Private position As New Position
    Private payroll As New Payroll

    Private Sub frmAddEmployeePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee.SelectEmployee(gvViewEmployee)
        position.LoadPositionToCBO(cboPosition)

        'For yy = DateTime.Now.Year To DateTime.Now.Year
        '    cboYear.Items.Add(yy)
        'Next

        'For mm = DateTime.MinValue.Month To DateTime.Now.Month
        '    cboMonth.Items.Add(mm)
        'Next
    End Sub

    Sub recount()
        Dim i As Integer = 1
        Dim c As Decimal = 0
        For Each r As DataGridViewRow In gvViewDeduction.Rows
            r.Cells(1).Value = i
            i = i + 1
            c = c + r.Cells(3).Value
        Next
        txtTotalDeduction.Text = c
        'recolor()
        gvViewDeduction.ClearSelection()
    End Sub

    Private Sub btnAddDeduction_Click(sender As Object, e As EventArgs) Handles btnAddDeduction.Click
        Dim obj As New frmEmployeeDeduction
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim index As Integer = 1
            For Each row As DataGridViewRow In obj.gvView.Rows
                If row.Cells(1).Value = True Then
                    With gvViewDeduction
                        .Rows.Add(row.Cells(0).Value.ToString,
                                       index.ToString,
                                       row.Cells(3).Value.ToString,
                                       row.Cells(4).Value.ToString,
                                       "Remove")
                    End With
                    index += 1
                    recount()
                End If
            Next
        End If
    End Sub

    Private Sub gvViewEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvViewEmployee.CellContentClick
        If e.ColumnIndex = 1 And gvViewEmployee.SelectedRows.Count > 0 Then
            If gvViewEmployee.SelectedRows(0).Cells(1).Value = False Then
                gvViewEmployee.SelectedRows(0).Cells(1).Value = True
                txtPosition.Text = gvViewEmployee.SelectedRows(0).Cells(5).Value.ToString
                position.LoadPositionTextBox(txtPosition, txtStandardPay, txtOvertime, txtBasicPay)
            Else
                gvViewEmployee.SelectedRows(0).Cells(1).Value = False
                txtPosition.Text = ""
            End If
        ElseIf gvViewEmployee.SelectedRows.Count And gvViewEmployee.SelectedRows.Count > 0 Then
            If gvViewEmployee.SelectedRows(0).Cells(1).Value = False Then
                gvViewEmployee.SelectedRows(0).Cells(1).Value = True
                txtPosition.Text = gvViewEmployee.SelectedRows(0).Cells(5).Value.ToString
                position.LoadPositionTextBox(txtPosition, txtStandardPay, txtOvertime, txtBasicPay)
            Else
                gvViewEmployee.SelectedRows(0).Cells(1).Value = False
                txtPosition.Text = ""
            End If
        End If
    End Sub

    Public Sub ClearInput(root As Control)
        For Each ctrl As Control In root.Controls
            ClearInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            ElseIf TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Text = String.Empty
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Sub doAdd()
        Try
            ''Instert AppointmentTable
            For Each r As DataGridViewRow In gvViewEmployee.Rows
                For Each row As DataGridViewRow In gvViewDeduction.Rows
                    With payroll
                        .EmployeeID = r.Cells(0).Value.ToString
                        .DeductionID = r.Cells(0).Value.ToString
                        .PayrollCommission = ""
                        .PayrollOvertime = txtOvertime.Text
                        .PayrollGrossPay = txtGrossPay.Text
                        .PayrollNetPay = txtNetpay.Text
                        .PayrollDate = dtpMonth.Value.ToString("d")
                        .PayrollTime = dtpTime.Value.ToString("t")

                        If .AddPayroll() = True Then
                            MessageBox.Show("Successfully generate payroll.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.DialogResult = DialogResult.OK
                            ClearInput(Me)
                            DisableInput(Me)
                            gvViewDeduction.Rows.Clear()
                        Else
                            MessageBox.Show("Successfully generate payroll.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End With
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        doAdd()
    End Sub

    Private Sub txtPosition_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged
        position.LoadPositionTextBox(txtPosition, txtStandardPay, txtOvertime, txtBasicPay)
    End Sub

    Private Sub txtBasicPay_TextChanged(sender As Object, e As EventArgs) Handles txtBasicPay.TextChanged
        txtGrossPay.Text = Val(txtBasicPay.Text) + Val(txtOvertime.Text)
    End Sub

    Private Sub txtTotalDeduction_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDeduction.TextChanged
        txtNetpay.Text = Val(txtGrossPay.Text) - Val(txtTotalDeduction.Text)
    End Sub

    Private Sub gvViewDeduction_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvViewDeduction.CellContentClick
        If e.ColumnIndex = 4 Then
            gvViewDeduction.Rows.RemoveAt(deduction.DeductionID)
            recount()
        End If
    End Sub

    Private Sub dtpYear_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        dtpYear.MinDate = Date.Now
        dtpYear.MaxDate = Date.Now
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged

    End Sub

    Private Sub chckboxSelectAll_Click(sender As Object, e As EventArgs) Handles chckboxSelectAll.Click
        If chckboxSelectAll.Checked = True Then
            For Each row As DataGridViewRow In gvViewEmployee.Rows
                row.Cells(1).Value = True
            Next
        Else
            For Each row As DataGridViewRow In gvViewEmployee.Rows
                row.Cells(1).Value = False
            Next
        End If
    End Sub
End Class