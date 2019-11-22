Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmSearchCustomer
    Public customer As Customer

    Private Sub frmSearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer.FilterCustomer("", gvView, lblResult)
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 6 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub gvView_MouseDown(sender As Object, e As MouseEventArgs) Handles gvView.MouseDown
        Dim _ht As DataGridView.HitTestInfo = Me.gvView.HitTest(e.X, e.Y)
        If _ht.Type = DataGridViewHitTestType.Cell Then
            customer.SetCustomerDetails(Me.gvView.Rows(_ht.RowIndex).Cells(0).Value)
        End If
    End Sub

    Private Sub gvView_SelectionChanged(sender As Object, e As EventArgs) Handles gvView.SelectionChanged
        gvView.ClearSelection()
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
        txtSearch.MaxLength = 15
        AllowedOnly(AlphaChar, txtSearch)
        ToUpperOnly(CodeOnly, txtSearch)
        If txtSearch.Text.ToLower() <> "search customer" Then
            customer.FilterCustomer(txtSearch.Text, gvView, lblResult)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class