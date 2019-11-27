Imports System.Windows.Forms
Imports MaterialSkin
Imports MySql.Data

Public Class Frmlogin
    Private account As New Accounts
    Dim i As Integer = 0

    Sub EnableButton()
        If txtUsername.Text.Count = 0 Or txtPassword.Text.Count = 0 Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub
    Sub TextReset()
        txtUsername.Text = "Username"
        txtPassword.Text = "Password"
    End Sub

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmAddaccount As New frmAddAccountFirst
        'If account.IsCountAccount() = 0 Then
        '    frmAddaccount.ShowDialog()
        'Else
        '    EnableButton()
        '    TextReset()
        'End If

        EnableButton()
        TextReset()

        Me.KeyPreview = True

    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If i = 0 Then
            FrmMain.flag = 0
            FrmMain.Close()
        End If
    End Sub

    Private Sub login()
        account.EditAccount()
        FrmMain.UserID = account.AccountID
        frmDashboard.fullName = account.FirstName + " " + account.LastName
        FrmMain.userType = account.AccountRole
        i = 1
        If account.AccountRole = "Administrator" Then
            FrmMain.btnHome.Enabled = True
            FrmMain.btnAppointment.Enabled = True
            FrmMain.btnService.Enabled = True
            FrmMain.btnEmployee.Enabled = True
            FrmMain.btnPosition.Enabled = True
            FrmMain.btnDeduction.Enabled = True
            FrmMain.btnAttendance.Enabled = True
            FrmMain.btnPayroll.Enabled = True
            FrmMain.btnCollection.Enabled = True
            FrmMain.btnCustomer.Enabled = True
            FrmMain.btnAccount.Enabled = True
            FrmMain.btnLogout.Enabled = True

        ElseIf account.AccountRole = "Clerk" Then
            FrmMain.btnHome.Enabled = True
            FrmMain.btnAppointment.Enabled = True
            FrmMain.btnService.Enabled = False
            FrmMain.btnEmployee.Enabled = False
            FrmMain.btnPosition.Enabled = False
            FrmMain.btnDeduction.Enabled = False
            FrmMain.btnAttendance.Enabled = True
            FrmMain.btnPayroll.Enabled = False
            FrmMain.btnCollection.Enabled = True
            FrmMain.btnCustomer.Enabled = True
            FrmMain.btnAccount.Enabled = False
            FrmMain.btnLogout.Enabled = True

        ElseIf account.AccountRole = "Cashier" Then
            For Each btn As Button In FrmMain.panelMain.Controls
                btn.Enabled = False
            Next

            For Each pb As PictureBox In FrmMain.panelMain.Controls
                pb.Enabled = False
            Next

        End If
        FrmMain.Show()
        frmDashboard.timerMain.Start()

        Me.DialogResult = DialogResult.OK
        Me.Close()
        FrmMain.flag = 1
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsTextBoxEmpty(txtUsername, txtPassword) = True Then
            MessageBox.Show("Please enter Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If account.IsLogin(txtUsername.Text, txtPassword.Text) = True Then
                account.SetAccountDetails(account.AccountID)
                If account.AccountRole = "Administrator" Then
                    account.LoginStatus = 0
                    login()
                ElseIf account.LoginStatus = 1 Then
                    MessageBox.Show("Your account is already login from another device.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    account.LoginStatus = 1
                    login()
                End If
            Else
                MessageBox.Show("This account does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsTextBoxEmpty(txtUsername, txtPassword) = True Then
                MessageBox.Show("Please enter Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If account.IsLogin(txtUsername.Text, txtPassword.Text) = True Then
                    account.SetAccountDetails(account.AccountID)
                    If account.AccountRole = "Administrator" Then
                        account.LoginStatus = 0
                        login()
                    ElseIf account.LoginStatus = 1 Then
                        MessageBox.Show("Your account is already login from another device.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        account.LoginStatus = 1
                        login()
                    End If
                Else
                    MessageBox.Show("Please enter a valid username and password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsTextBoxEmpty(txtUsername, txtPassword) = True Then
                MessageBox.Show("Please enter Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If account.IsLogin(txtUsername.Text, txtPassword.Text) = True Then
                    account.SetAccountDetails(account.AccountID)
                    If account.AccountRole = "Administrator" Then
                        account.LoginStatus = 0
                        login()
                    ElseIf account.LoginStatus = 1 Then
                        MessageBox.Show("Your account is already login from another device.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        account.LoginStatus = 1
                        login()
                    End If
                Else
                    MessageBox.Show("Please enter a valid username and password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        EnableButton()
        txtUsername.MaxLength = 20
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        EnableButton()
        txtPassword.MaxLength = 20
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = "Username"
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.UseSystemPasswordChar = True
            'txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.ForeColor = Color.Gray
            txtPassword.UseSystemPasswordChar = True
            txtPassword.Text = "Password"
            'txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim obj As New FrmAttendanceTimein
        obj.timerAttendance.Start()
        obj.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Dim obj As New frmConnection
        obj.ShowDialog()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub

    Private Sub PictureShowPasword_Click(sender As Object, e As EventArgs) Handles PictureShowPasword.Click
        If txtPassword.UseSystemPasswordChar = True Then
            PictureNotShowPassword.Show()
            PictureShowPasword.Hide()
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            PictureShowPasword.Show()
            PictureNotShowPassword.Hide()
        End If
    End Sub

    Private Sub PictureNotShowPassword_Click(sender As Object, e As EventArgs) Handles PictureNotShowPassword.Click
        If txtPassword.UseSystemPasswordChar = True Then
            PictureNotShowPassword.Show()
            PictureShowPasword.Hide()
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            PictureShowPasword.Show()
            PictureNotShowPassword.Hide()
        End If
    End Sub

    Private Sub Frmlogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim obj As New frmConnection
        If e.KeyCode = Keys.F1 Then
            obj.ShowDialog()
        End If
    End Sub
End Class