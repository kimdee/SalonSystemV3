Public Class YNMessage
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub
End Class