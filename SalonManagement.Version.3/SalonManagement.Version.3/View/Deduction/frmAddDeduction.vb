﻿Public Class frmAddDeduction
    Private deduction As New Deduction

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        With deduction
            If txtName.Text = "" And txtAmount.Text = "" Then
                MessageBox.Show("Deduction type and Amount are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtName.Text = "" Then
                MessageBox.Show("Deduction type is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtAmount.Text = "" Then
                MessageBox.Show("Deduction amount is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf deduction.IsDeductionTypeExist(txtName.Text) Then
                MessageBox.Show("Deduction type already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtAmount.Text > 800 Then
                MessageBox.Show("Maximum deduction is 800.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtAmount.Text < 50 Then
                MessageBox.Show("Minimum deduction is 50.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                .DeductionType = txtName.Text
                .DeductionAmount = txtAmount.Text

                If .AddDeduction() = True Then
                    MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Failed to save deduction.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If

        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(AlphaChar, txtName)
        SentenceCase(txtName)
        txtName.MaxLength = 10
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        AllowedOnly(NumberOnly, txtAmount)
        txtAmount.MaxLength = 5
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class