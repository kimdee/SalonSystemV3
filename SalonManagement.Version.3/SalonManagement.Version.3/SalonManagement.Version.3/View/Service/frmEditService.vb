Public Class frmEditService
    Public service As Service

    Private Sub frmEditService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
        With service
            txtName.Text = .ServiceName
            txtDescription.Text = .ServiceDescription
            nudPrice.Value = .ServicePrice
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If IsTextBoxEmpty(txtName, txtDescription) = True Or nudPrice.Value = "0.00" Then
            MessageBox.Show("Name, Description and Price are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With service
                .ServiceName = txtName.Text
                .ServiceDescription = txtDescription.Text
                .ServicePrice = nudPrice.Value
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
        ToUpperOnly(AlphaChar, txtName)
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        AllowedOnly(AlphaChar, txtDescription)
        ToUpperOnly(AlphaChar, txtDescription)
    End Sub

End Class