Public Class FrmDeduction
    Private deduction As New Deduction

    Private Sub btnAddDeduction_Click(sender As Object, e As EventArgs) Handles btnAddDeduction.Click
        Dim obj As New frmAddDeduction
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            deduction.ViewDeduction(gvView, lblResult)
        Else
            deduction.ViewDeduction(gvView, lblResult)
        End If
    End Sub

    Private Sub frmViewDeduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deduction.ViewDeduction(gvView, lblResult)
    End Sub
    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 5 Then
            deduction.SetDeductionDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete the service of  " + deduction.DeductionType, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If deduction.DeleteDeduction() = True Then
                    deduction.ViewDeduction(gvView, lblResult)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.ColumnIndex = 4 Then
            deduction.SetDeductionDetails(gvView.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditDeduction
            obj.deduction = Me.deduction
            If obj.ShowDialog = DialogResult.OK Then
                deduction.ViewDeduction(gvView, lblResult)
            End If
        End If
    End Sub
End Class