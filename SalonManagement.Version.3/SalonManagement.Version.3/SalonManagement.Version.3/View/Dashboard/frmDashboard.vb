Imports MySql.Data.MySqlClient
Imports System.ComponentModel.Design
Imports System.Windows.Forms.Form

Public Class frmDashboard
    Public Shared flag As Integer = 0
    Public Shared UserID As Integer = 0
    Public Shared fullName As String = "User Admin"
    Public Shared userType As String = "Administrator"
    Public Shared dtServer As Date = DateTime.Now

    Private account As New Accounts
    Private customer As New Customer
    Private employee As New Employee
    Private Sub timerMain_Tick(sender As Object, e As EventArgs) Handles timerMain.Tick
        Dim sql As String = "SELECT now();"
        Try
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                dtServer = cmd.ExecuteScalar
                lnklblUsername.Text = fullName
                'lbluserType.Text = userType
                lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
                lblDate.Text = dtServer.ToString("MMMM d, yyyy")
                'lblDate.Text = MonthName(dtServer.Month) + " " + dtServer.Day.ToString() + ", " + dtServer.Year.ToString()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class