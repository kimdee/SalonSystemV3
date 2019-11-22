Public Class frmEmployeeDeduction
    Private deduction As New Deduction
    Private employee As New Employee

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 1 And gvView.SelectedRows.Count > 0 Then
            If gvView.SelectedRows(0).Cells(1).Value = False Then
                gvView.SelectedRows(0).Cells(1).Value = True
            Else
                gvView.SelectedRows(0).Cells(1).Value = False
            End If
        ElseIf gvView.SelectedRows.Count And gvView.SelectedRows.Count > 0 Then
            If gvView.SelectedRows(0).Cells(1).Value = False Then
                gvView.SelectedRows(0).Cells(1).Value = True
            Else
                gvView.SelectedRows(0).Cells(1).Value = False
            End If
        End If
    End Sub

    Private Sub frmEmployeeDeduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deduction.SelectDeduction(gvView)
    End Sub
End Class