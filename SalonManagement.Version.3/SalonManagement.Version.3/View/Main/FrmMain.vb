Imports MySql.Data.MySqlClient
Imports System.ComponentModel.Design
Imports System.Windows.Forms.Form

Public Class FrmMain
    Public Shared flag As Integer = 0
    Public Shared UserID As Integer = 0
    Public Shared fullName As String = "User Admin"
    Public Shared userType As String = "Administrator"
    Public Shared dtServer As Date = DateTime.Now

    Private account As New Accounts
    Private customer As New Customer
    Private employee As New Employee

    Sub loadForm(ByVal form As Form)
        panelContainer.Controls.Clear()
        form.TopLevel = False
        panelContainer.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDashboard.timerMain.Start()
        Me.Hide()
        Dim obj As New Frmlogin
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.Show()
            loadForm(frmDashboard)
        End If

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If flag = 1 Then
            If MessageBox.Show("Are you sure you want to exit from the system?", "Message", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                account.SetAccountDetails(UserID)
                account.LoginStatus = 0
                account.EditAccount()
            End If
        End If
    End Sub

    Private Sub tmrMenu_Tick(sender As Object, e As EventArgs) Handles tmrMenu.Tick
        If panelMenu.Width <= 60 Then
            Me.tmrMenu.Enabled = False
            lblmanage.Text = "..."
            lblreport.Text = "..."
            lblsetting.Text = "..."
        Else
            panelMenu.Width = panelMenu.Width - 25
            pnlviewTask.Width = pnlviewTask.Width + 25

            'btnVwEmploy.Width = btnVwEmploy.Width + 25
            'btnVwPresnt.Width = btnVwPresnt.Width + 25
            'btnVwLeave.Width = btnVwLeave.Width + 25
            'btnVwAbsnt.Width = btnVwAbsnt.Width + 25
            'btnVwCustmr.Width = btnVwCustmr.Width + 25
            'btnVwCollect.Width = btnVwCollect.Width + 25

            'pnlVwEmploy.Width = pnlVwEmploy.Width + 25
            'pnlVwPresnt.Width = pnlVwPresnt.Width + 25
            'pnlVwLeave.Width = pnlVwLeave.Width + 25
            'pnlVwAbsnt.Width = pnlVwAbsnt.Width + 25
            'pnlVwCustmr.Width = pnlVwCustmr.Width + 25
            'pnlVwCollct.Width = pnlVwCollct.Width + 25

        End If
    End Sub

    Private Sub tmrMenu2_Tick(sender As Object, e As EventArgs) Handles tmrMenu2.Tick
        If panelMenu.Width >= 273 Then
            Me.tmrMenu2.Enabled = False
            lblmanage.Text = "Manage"
            lblreport.Text = "Reports"
            lblsetting.Text = "Settings"
        Else
            panelMenu.Width = panelMenu.Width + 25
            pnlviewTask.Width = pnlviewTask.Width - 25
            panelContainer.Width = panelContainer.Width - 25

            'btnVwEmploy.Width = btnVwEmploy.Width - 25
            'btnVwPresnt.Width = btnVwPresnt.Width - 25
            'btnVwLeave.Width = btnVwLeave.Width - 25
            'btnVwAbsnt.Width = btnVwAbsnt.Width - 25
            'btnVwCustmr.Width = btnVwCustmr.Width - 25
            'btnVwCollect.Width = btnVwCollect.Width - 25

            'pnlVwEmploy.Width = pnlVwEmploy.Width - 25
            'pnlVwPresnt.Width = pnlVwPresnt.Width - 25
            'pnlVwLeave.Width = pnlVwLeave.Width - 25
            'pnlVwAbsnt.Width = pnlVwAbsnt.Width - 25
            'pnlVwCustmr.Width = pnlVwCustmr.Width - 25
            'pnlVwCollct.Width = pnlVwCollct.Width - 25

        End If
    End Sub

    Private Sub picBoxMenu_Click(sender As Object, e As EventArgs) Handles picBoxMenu.Click
        If panelMenu.Width >= 273 Then
            Me.tmrMenu.Enabled = True
        ElseIf panelMenu.Width <= 60 Then
            Me.tmrMenu2.Enabled = True
        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        FrmHelp.Show()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlIndicator.Height = btnHome.Height
        pnlIndicator.Top = btnHome.Top

        loadForm(frmDashboard)

    End Sub

    Private Sub btnappoint_click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        pnlIndicator.Height = btnAppointment.Height
        pnlIndicator.Top = btnAppointment.Top

        loadForm(FrmAppointment)
    End Sub

    Private Sub btnservice_click(sender As Object, e As EventArgs) Handles btnService.Click
        pnlIndicator.Height = btnService.Height
        pnlIndicator.Top = btnService.Top

        loadForm(FrmService)
    End Sub

    Private Sub btnemployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        pnlIndicator.Height = btnEmployee.Height
        pnlIndicator.Top = btnEmployee.Top

        loadForm(FrmEmployee)
    End Sub

    Private Sub btnposition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        pnlIndicator.Height = btnPosition.Height
        pnlIndicator.Top = btnPosition.Top

        loadForm(FrmPosition)
    End Sub

    Private Sub btndeduct_Click(sender As Object, e As EventArgs) Handles btnDeduction.Click
        pnlIndicator.Height = btnDeduction.Height
        pnlIndicator.Top = btnDeduction.Top

        loadForm(FrmDeduction)
    End Sub

    Private Sub btnAttend_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        pnlIndicator.Height = btnAttendance.Height
        pnlIndicator.Top = btnAttendance.Top

        loadForm(FrmAttendance)
    End Sub

    Private Sub btnPayrol_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        pnlIndicator.Height = btnPayroll.Height
        pnlIndicator.Top = btnPayroll.Top

        loadForm(FrmPayroll)
    End Sub

    Private Sub btnCollect_Click(sender As Object, e As EventArgs) Handles btnCollection.Click
        pnlIndicator.Height = btnCollection.Height
        pnlIndicator.Top = btnCollection.Top

        loadForm(FrmCollection)
    End Sub

    Private Sub btnCustRecord_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        pnlIndicator.Height = btnCustomer.Height
        pnlIndicator.Top = btnCustomer.Top

        loadForm(frmCustomer)
    End Sub

    Private Sub btnAccnt_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        pnlIndicator.Height = btnAccount.Height
        pnlIndicator.Top = btnAccount.Top

        loadForm(FrmAccount)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Frmlogin.Show()
    End Sub

    Private Sub picboxHelp_Click(sender As Object, e As EventArgs) Handles picboxHelp.Click
        Dim obj As New FrmHelp
        obj.ShowDialog()
    End Sub

    Private Sub picboxMyProfile_Click(sender As Object, e As EventArgs) Handles picboxMyProfile.Click
        Dim obj As New frmMyProfile
        account.SetAccountDetails(UserID)
        obj.account = Me.account
        obj.ShowDialog()
    End Sub
End Class
