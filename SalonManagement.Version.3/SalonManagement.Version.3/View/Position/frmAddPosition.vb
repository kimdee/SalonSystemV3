﻿Public Class frmAddPosition
    Private position As New Position
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
        ElseIf txtStandardPay.Text = "" Then
            MessageBox.Show("Standard pay is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtName, txtStandardPay) = True Then
            MessageBox.Show("Name and Basic Pay are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStandardPay.Text >= 1001 Then
            MessageBox.Show("Maximum standard pay is 1000.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStandardPay.Text <= 99 Then
            MessageBox.Show("Minimum standard pay is 100.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtOT.Text > txtStandardPay.Text * 0.2 Then
            MessageBox.Show("Maximum overtime is 20% of standard pay.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            With position
                .PositionName = txtName.Text
                .PositionStandardPay = txtStandardPay.Text
                .PositionOvertime = txtOT.Text
                .PositionBasicPay = txtBasicPays.Text

                If position.AddPosition = True Then
                    MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    ClearInput(Me)
                    Me.Close()
                Else
                    MessageBox.Show("Failed to save.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub txtStandardPay_TextChanged(sender As Object, e As EventArgs) Handles txtStandardPay.TextChanged
        AllowedOnly(NumberWDot, txtStandardPay)
        txtStandardPay.MaxLength = 4
        CheckforDoubleDot(txtStandardPay)

        If txtStandardPay.Text = "" Then
            txtBasicPays.Text = "0"
        Else
            txtBasicPays.Text = txtStandardPay.Text * 15
        End If
    End Sub

    Private Sub txtOT_TextChanged(sender As Object, e As EventArgs) Handles txtOT.TextChanged
        AllowedOnly(NumberWDot, txtOT)
        txtOT.MaxLength = 4
        CheckforDoubleDot(txtOT)
    End Sub

    Private Sub txtBasicPays_TextChanged(sender As Object, e As EventArgs) Handles txtBasicPays.TextChanged
        AllowedOnly(NumberWDot, txtBasicPays)
        CheckforDoubleDot(txtBasicPays)
    End Sub
End Class