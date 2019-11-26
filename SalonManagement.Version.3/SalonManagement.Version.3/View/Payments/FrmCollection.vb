Public Class FrmCollection

    Private Sub FrmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick

    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.MaxDate = Date.Now.ToString
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        dtpTo.MaxDate = Date.Now.ToString
    End Sub
End Class