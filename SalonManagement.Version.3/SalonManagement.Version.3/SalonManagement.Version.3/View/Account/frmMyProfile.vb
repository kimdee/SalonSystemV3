Imports System.Windows.Forms.Form

Public Class frmMyProfile
    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub
    'Private account As New Accounts

    'Sub logout()
    '    account.SetAccountDetails(MainForm.UserID)
    '    account.LoginStatus = 0
    '    account.EditAccount()
    '    Me.Hide()
    '    MainForm.timerMain.Stop()

    '    Dim obj As New LoginForm
    '    obj.ShowDialog()
    'End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    'If IsTextBoxEmpty(txtPw, txtRetype) = True Then
    '    '    MessageBox.Show("old password and new Password are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    'Else
    '    '    If account.ValidatePassword(txtPw.Text) = False Then
    '    '        MessageBox.Show("wrong password please enter again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    '        txtPw.Focus()
    '    '        Exit Sub
    '    '    End If
    '    '    If account.Editpassword(txtRetype.Text, txtPw.Text) = True Then
    '    '        MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    '        Me.DialogResult = DialogResult.OK
    '    '        Me.Close()
    '    '    Else
    '    '        MessageBox.Show("Failed to save. you input a wrong old password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    '    End If
    '    'End If
    'End Sub

    'Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '    Me.Close()
    'End Sub

    'Private Sub txtOpw_TextChanged(sender As Object, e As EventArgs) Handles txtPw.TextChanged
    '    AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-_", txtPw)

    'End Sub

    'Private Sub txtNpw_TextChanged(sender As Object, e As EventArgs) Handles txtRetype.TextChanged
    '    AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-_", txtRetype)
    'End Sub

    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    '    If MessageBox.Show("Are you sure you want to log-out?", "Message", MessageBoxButtons.YesNo,
    '            MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
    '        logout()
    '    End If
    'End Sub
End Class