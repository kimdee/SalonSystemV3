Imports System.Windows.Forms
Public Class frmAddServices
    Private service As New Service

    Private Sub frmAddService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        service.SelectService(gvView)
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

    Private Sub btnAddservice_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

End Class