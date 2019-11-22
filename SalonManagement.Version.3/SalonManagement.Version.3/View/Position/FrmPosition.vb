Public Class FrmPosition
    Public position As New Position
    Dim edit As Boolean

    Private Sub FrmPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        position.ViewPosition(gvView, lblResult)
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim obj As New frmAddPosition
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            position.ViewPosition(gvView, lblResult)
        Else
            position.ViewPosition(gvView, lblResult)
        End If
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 7 Then
            position.SetPositionDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete " + position.PositionName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If position.DeletePosition() = True Then
                    position.ViewPosition(gvView, lblResult)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.ColumnIndex = 6 Then
            position.SetPositionDetails(gvView.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditPosition
            obj.position = Me.position
            If obj.ShowDialog = DialogResult.OK Then
                position.ViewPosition(gvView, lblResult)
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
            position.SearchPosition(txtSearch.Text, gvView, lblResult)
        End If
    End Sub
End Class