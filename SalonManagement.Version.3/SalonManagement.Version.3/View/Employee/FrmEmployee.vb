Public Class frmEmployee
    Private employee As New Employee

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim obj As New frmAddEmployee
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            employee.ViewEmployee(gvView, lblResult)
        Else
            employee.ViewEmployee(gvView, lblResult)
        End If
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee.ViewEmployee(gvView, lblResult)
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 11 Then
            employee.SetEmployeeDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete " + employee.EmployeeLN, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If employee.DeleteEmployee() = True Then
                    employee.ViewEmployee(gvView, lblResult)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.ColumnIndex = 10 Then
            employee.SetEmployeeDetails(gvView.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditEmployee
            obj.employee = Me.employee
            If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                employee.ViewEmployee(gvView, lblResult)
            Else
                employee.ViewEmployee(gvView, lblResult)
            End If
        End If
    End Sub

    Private Sub gvView_MouseDown(sender As Object, e As MouseEventArgs) Handles gvView.MouseDown
        Dim _ht As DataGridView.HitTestInfo = Me.gvView.HitTest(e.X, e.Y)
        If _ht.Type = DataGridViewHitTestType.Cell Then
            employee.SetEmployeeDetails(Me.gvView.Rows(_ht.RowIndex).Cells(0).Value)
        End If
    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        txtSearch.Text = ""
        txtSearch.ForeColor = Color.Black
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        txtSearch.ForeColor = Color.Gray
        txtSearch.Text = "Search Account"
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(AlphaChar, txtSearch)
        ToUpperOnly(CodeOnly, txtSearch)
        If txtSearch.Text.ToLower() <> "search account" Then
            employee.SearchEmployee(txtSearch.Text, gvView, lblResult)
        End If
    End Sub
End Class