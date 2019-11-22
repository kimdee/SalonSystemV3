Public Class FrmAppointment
    Private appointment As New Appointment
    Private customer As New Customer
    Private service As New Service

    Private Sub FrmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appointment.ViewAppointment(gvView)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim obj As New frmAddAppointment
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Appointment.ViewAppointment(gvView)
        Else
            Appointment.ViewAppointment(gvView)
        End If
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 9 Then
            appointment.SetAppointmentDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete customer " + customer.CustomerName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If appointment.DeleteAppointment() = True Then
                    appointment.ViewAppointment(gvView)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.ColumnIndex = 8 Then


        End If
    End Sub
End Class