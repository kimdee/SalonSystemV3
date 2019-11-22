Public Class FrmService
    Public service As New Service
    Dim edit As Boolean

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim obj As New frmAddService
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            service.ViewService(gvView, lblResult)
        Else
            service.ViewService(gvView, lblResult)
        End If
    End Sub

    Private Sub frmServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        service.ViewService(gvView, lblResult)
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 6 Then
            service.SetServiceDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete the service of  " + service.ServiceName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If service.DeletePosition() = True Then
                    service.ViewService(gvView, lblResult)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.ColumnIndex = 5 Then
            service.SetServiceDetails(gvView.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditService
            obj.service = Me.service
            If obj.ShowDialog = DialogResult.OK Then
                service.ViewService(gvView, lblResult)
            End If
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
            service.SearchService(txtSearch.Text, gvView, lblResult)
        End If
    End Sub
End Class