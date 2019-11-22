Public Class frmEditAppointment
    Public appointment As Appointment
    Public customer As Customer
    Public service As Service


    Private Sub frmEditAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With customer
            txtName.Text = .CustomerName
            If .CustomerSex = "Male" Then
                rdbMale.Checked = True
            ElseIf .CustomerSex = "Female" Then
                rdbFemale.Checked = True
            End If
            txtCN.Text = .CustomerCN
        End With

        With appointment

        End With

    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs)
        Try
            ''Edit CustomerTable
            With customer
                .CustomerName = txtName.Text
                .CustomerCN = txtCN.Text
                If rdbMale.Checked = True Then
                    .CustomerSex = "Male"
                ElseIf rdbFemale.Checked = True Then
                    .CustomerSex = "Female"
                End If
                .EditCustomer()
                .SetCustomerID()
            End With

            ''Edit AppointmentTable
            For Each r As DataGridViewRow In gvView.Rows
                With appointment
                    .CustomerID = customer.CustomerID

                    .AppointmentTime =
                    .AppointmentDate = lblDateNow.Text
                    If rdbWalkin.Checked = True Then
                        .AppointmentType = "Walk-In"
                    ElseIf rdbReservation.Checked = True Then
                        .AppointmentType = "Reservation"
                    End If

                    If .EditAppointment() = True Then
                        Dim ok As New OKMessage
                        ok = New OKMessage
                        ok.lblMsg.Text = "Appointment has been updated."
                        ok.ShowDialog()

                        btnPayments.Enabled = True
                        btnEdit.Enabled = True
                    Else
                        Dim err As ErrorMessage
                        err = New ErrorMessage
                        err.lblMsg.Text = "Failed to update Appointment."
                        err.ShowDialog()
                    End If
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddservice_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs)

    End Sub
End Class