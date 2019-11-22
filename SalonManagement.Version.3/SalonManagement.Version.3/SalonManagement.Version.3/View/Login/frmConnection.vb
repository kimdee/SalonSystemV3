Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmConnection
    Dim account As New Accounts
    Private Sub txtHost_TextChanged(sender As Object, e As EventArgs) Handles txtHost.TextChanged
        AllowedOnly(AlphaChar, txtHost)
    End Sub

    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged
        AllowedOnly(NumberOnly, txtPort)
    End Sub

    Private Sub txtDB_TextChanged(sender As Object, e As EventArgs) Handles txtDB.TextChanged
        AllowedOnly(AlphaChar, txtDB)
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        AllowedOnly(AlphaChar, txtUserName)
    End Sub

    Private Sub txtPw_TextChanged(sender As Object, e As EventArgs) Handles txtPw.TextChanged
        AllowedOnly(AlphaChar, txtPw)
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim str As String = "Server=" & txtHost.Text & ";Port=" & txtPort.Text _
                                      & ";Database=" & txtDB.Text & ";User=" & txtUserName.Text _
                                      & ";Password=" & txtPw.Text & ";"
        If TestConnection(str) = True Then
            If MessageBox.Show("A new connection has been successfully established. Do you want to save the connection?",
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                My.Settings.DatabaseName = txtDB.Text
                My.Settings.ServerIP = txtHost.Text
                My.Settings.PortNo = txtPort.Text
                My.Settings.Username = txtUserName.Text
                My.Settings.Password = txtPw.Text
                My.Settings.Save()

                Me.DialogResult = DialogResult.OK
                Me.Hide()

                frmMain.Show()
            End If
        Else
            MessageBox.Show("Connection failed. Please review connection fields.",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class