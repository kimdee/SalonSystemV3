Imports MySql.Data.MySqlClient

Public Class frmAddPayments
    Public appointment As Appointment
    Public customer As Customer
    Public billing As Billing

    Public Shared dtServer As Date = DateTime.Now
    Dim status As String = "Paid"

    Private add As Boolean = True
    Private edit As Boolean = True


    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With customer
            txtName.Text = .CustomerName
            If .CustomerSex = "Male" Then
                rdbMale.Checked = True
            Else
                rdbFemale.Checked = True
            End If
            txtCN.Text = .CustomerCN
        End With

        With billing
            txtTotalAmount.Text = .BillingAmount
        End With

        TimerPayment.Start()
    End Sub

    Sub doAdd()

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Try
            With billing
                .AppointmentID = appointment.AppointmentID
                .CustomerID = customer.CustomerID
                .BillingAmount = txtTotalAmount.Text
                .BillingStatus = status

                If .EditBilling() = True Then
                    Dim ok As New OKMessage
                    ok = New OKMessage
                    ok.lblMsg.Text = "Paid"
                    ok.ShowDialog()

                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtxRecieve_TextChanged(sender As Object, e As EventArgs) Handles txtRecieve.TextChanged
        txtChange.Text = txtTotalAmount.Text - txtRecieve.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class