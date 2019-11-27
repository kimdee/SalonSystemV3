Public Class frmAddAccountFirst
    Private acc As New Accounts
    Dim role As String = "Clerk"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        SentenceCase(txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        AllowedOnly(LetterOnly, txtLastName)
        SentenceCase(txtLastName)
        txtLastName.MaxLength = 15
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosition.SelectedIndexChanged
        Me.role = cboPosition.Text
    End Sub

    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        'If col.ValidateUserName(txtUserName.Text) = False Then
        '    MessageBox.Show("Your User Name is already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtUserName.Focus()
        'End If
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtName, txtLastName, txtUserName, txtPw) = True Then
            MessageBox.Show("First Name, Last Name, username and password are required.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtUserName.TextLength < 5 Then
            MessageBox.Show("Username must be atleast 5 characters long.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf acc.IsAccountExist(txtUserName.Text) Then
            MessageBox.Show("Username already exist.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPw.TextLength < 5 Then
            MessageBox.Show("Password must be atleast 5 characters long.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPw.Text <> txtRetype.Text Then
            MessageBox.Show("Password did not match.", "Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtName, txtPw, txtUserName) = True Or cboPosition.SelectedIndex = -1 Then
            MessageBox.Show("Name, User Name, Password and Position are required.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsTextBoxEmpty(txtRetype) = True Or cboPosition.SelectedIndex = -1 Then
            MessageBox.Show("Please Retype Password.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            acc.FirstName = txtName.Text.Trim
            acc.LastName = txtLastName.Text.Trim
            acc.AccountRole = cboPosition.Text.Trim
            acc.UserName = txtUserName.Text.Trim
            acc.Password = txtPw.Text.Trim
            acc.LoginStatus = 0
            If acc.AddAccount = True Then
                MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to save. Account already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub frmAddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPosition.SelectedIndex = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class