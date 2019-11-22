﻿Public Class frmEditDeduction
    Public deduction As Deduction
    Private Sub frmEditDeduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
        With deduction
            txtName.Text = .DeductionType
            txtAmount.Text = .DeductionAmount
        End With
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtName, txtAmount) = True Then
            MessageBox.Show("Deduction type and Amount are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With deduction
                .DeductionType = txtName.Text
                .DeductionAmount = txtAmount.Text

                If deduction.EditDeduction = True Then
                    MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Failed to update deduction.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End With
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(AlphaChar, txtName)
        txtName.MaxLength = 20
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        AllowedOnly(NumberOnly, txtAmount)
        txtAmount.MaxLength = 10
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class