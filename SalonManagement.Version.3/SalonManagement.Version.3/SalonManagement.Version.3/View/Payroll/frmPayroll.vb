Public Class FrmPayroll
    Private payroll As New Payroll
    Private Sub FrmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        payroll.ViewPayroll(gvView, lblResult)
    End Sub

    Private Sub btnGeneratePayroll_Click(sender As Object, e As EventArgs) Handles btnGeneratePayroll.Click
        Dim obj As New frmAddEmployeePayroll
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            payroll.ViewPayroll(gvView, lblResult)
        Else
            payroll.ViewPayroll(gvView, lblResult)
        End If
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick

    End Sub
End Class