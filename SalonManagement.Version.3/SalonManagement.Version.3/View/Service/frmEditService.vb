Public Class frmEditService
    Public service As Service

    Private Sub frmEditService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
        With service
            txtName.Text = .ServiceName
            txtDescription.Text = .ServiceDescription
            txtAmount.Text = .ServicePrice
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtName.Text = "" Then
            MessageBox.Show("Name is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAmount.Text > 1500 Then
            MessageBox.Show("Maximum amount is 1500.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAmount.Text < 50 Then
            MessageBox.Show("Minimum amount is 50.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With service
                .ServiceName = txtName.Text
                .ServiceDescription = txtDescription.Text
                .ServicePrice = txtAmount.Text
                If service.EditService() = True Then
                    MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Failed to update Service.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End With
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(AlphaChar, txtName)
        SentenceCase(txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        AllowedOnly(AlphaChar, txtDescription)
        SentenceCase(txtDescription)
        txtDescription.MaxLength = 30
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        AllowedOnly(NumberOnly, txtAmount)
        txtAmount.MaxLength = 4
    End Sub

End Class