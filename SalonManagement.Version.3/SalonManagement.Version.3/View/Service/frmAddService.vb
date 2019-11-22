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
            MessageBox.Show("Name And Description required.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtDescription) = True Then
            MessageBox.Show("Name And Description are required.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            With service
                .ServiceName = txtName.Text.Trim
                .ServiceDescription = txtDescription.Text.Trim
                .ServicePrice = nudPrice.Value

                If service.AddService = True Then
                    MessageBox.Show("Succesfully added a new service.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    ClearInput(Me)
                    nudPrice.Value = "0.00"
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
        ToUpperOnly(AlphaChar, txtName)
        SentenceCase(txtName)
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        AllowedOnly(AlphaChar, txtDescription)
        ToUpperOnly(AlphaChar, txtDescription)
        SentenceCase(txtName)
    End Sub

End Class