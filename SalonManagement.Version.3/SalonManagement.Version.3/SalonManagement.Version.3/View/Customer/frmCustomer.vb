Public Class frmCustomer
    Private billing As New Billing

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'billing.ViewBillings(gvView)
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick

    End Sub
End Class