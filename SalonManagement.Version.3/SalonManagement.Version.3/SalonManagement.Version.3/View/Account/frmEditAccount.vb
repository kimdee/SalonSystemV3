Imports System.Windows.Forms

Public Class frmEditAccount
    Public account As Accounts

    Dim role As String = "clerk"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtName, txtPw, txtUserName) = True Or cboPosition.SelectedIndex = -1 Then
            MessageBox.Show("Name, User Name, Password and Position are required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtUserName.TextLength < 6 Then
            MessageBox.Show("Username must be atleast 6 characters long.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPw.TextLength < 6 Then
            MessageBox.Show("Password must be atleast 6 characters long.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPw.Text <> txtRetype.Text Then
            MessageBox.Show("Password did not match.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtRetype) = True Or cboPosition.SelectedIndex = -1 Then
            MessageBox.Show("Please Retype Password.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            account.FirstName = txtName.Text
            account.LastName = txtLastName.Text
            account.AccountRole = cboPosition.Text
            account.UserName = txtUserName.Text
            account.Password = txtPw.Text
            account.LoginStatus = 0
            If account.EditAccount() = True Then
                MessageBox.Show("Successfully Update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to update. Account already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        ToUpperOnly(LetterOnly, txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        AllowedOnly(LetterOnly, txtLastName)
        ToUpperOnly(LetterOnly, txtLastName)
        txtLastName.MaxLength = 15
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        Me.role = cboPosition.Text
    End Sub

    Private Sub frmEditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With account
            txtName.Text = .FirstName
            txtLastName.Text = .LastName
            If .AccountRole = "Administrator" Then
                cboPosition.Enabled = False
            Else
                cboPosition.SelectedIndex = cboPosition.FindString(.AccountRole)
            End If
            txtUserName.Text = .UserName
            txtPw.Text = .Password
        End With
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-_", txtUserName)
        txtUserName.MaxLength = 15
    End Sub

    Private Sub txtPw_TextChanged(sender As Object, e As EventArgs) Handles txtPw.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-_", txtPw)
        txtPw.MaxLength = 20
    End Sub

    Private Sub txtRetype_TextChanged(sender As Object, e As EventArgs) Handles txtRetype.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-_", txtRetype)
        txtRetype.MaxLength = 20
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class