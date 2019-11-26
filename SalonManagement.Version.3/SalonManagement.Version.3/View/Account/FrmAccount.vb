Public Class FrmAccount
    Private account As New Accounts
    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        account.ViewAccounts(gvView, lblResult)
    End Sub

    Private Sub gvView_MouseDown(sender As Object, e As MouseEventArgs) Handles gvView.MouseDown
        Dim _ht As DataGridView.HitTestInfo = Me.gvView.HitTest(e.X, e.Y)
        If _ht.Type = DataGridViewHitTestType.Cell Then
            account.SetAccountDetails(Me.gvView.Rows(_ht.RowIndex).Cells(0).Value)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New frmAddAccount
        If obj.ShowDialog() = DialogResult.OK Then
            account.ViewAccounts(gvView, lblResult)
        Else
            account.ViewAccounts(gvView, lblResult)
        End If
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        Try
            If e.ColumnIndex = 6 Then
                'account.SetAccountDetails(gvView.SelectedRows(0).Cells(0).Value)
                If account.AccountRole = "Administrator" Then
                    MessageBox.Show("Sorry you cannot delete this Administrator Account.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If MessageBox.Show("Are you sure you want to delete the account of  " + account.UserName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If account.DeleteAccount() = True Then
                            account.ViewAccounts(gvView, lblResult)
                        Else
                            MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If

            ElseIf e.ColumnIndex = 5 Then
                'account.SetAccountDetails(gvView.SelectedRows(0).Cells(0).Value)
                Dim obj As New frmEditAccount
                obj.account = Me.account
                If obj.ShowDialog = DialogResult.OK Then
                    account.ViewAccounts(gvView, lblResult)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
            account.SearchAccount(txtSearch.Text, gvView, lblResult)
        End If
    End Sub
End Class