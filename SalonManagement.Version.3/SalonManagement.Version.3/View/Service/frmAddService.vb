Public Class frmAddService
    Private service As New Service
    Dim edit As Boolean
    Private Sub ClearInput(root As Control)
        For Each ctrl As Control In root.Controls
            ClearInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MessageBox.Show("Name is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAmount.Text > 1500 Then
            MessageBox.Show("Maximum amount is 1500.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAmount.Text < 50 Then
            MessageBox.Show("Minimum amount is 50.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            With service
                .ServiceName = txtName.Text.Trim
                .ServiceDescription = txtDescription.Text.Trim
                .ServicePrice = txtAmount.Text

                If service.AddService = True Then
                    MessageBox.Show("Succesfully added a new service.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    ClearInput(Me)
                    Me.Close()
                Else
                    MessageBox.Show("Failed to save. Service already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End With
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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