Public Class FrmAppointment
    Private appointment As New Appointment
    Private customer As New Customer

    Private customerservice As New CustomerService
    Private employee As New Employee
    Private billing As New Billing

    Private Sub FrmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appointment.ViewAppointment(gvView)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim obj As New frmAddAppointment
        If obj.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            appointment.ViewAppointment(gvView)
        Else
            appointment.ViewAppointment(gvView)
        End If
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 7 Then
            appointment.SetAppointmentDetails(gvView.SelectedRows(0).Cells(0).Value)
            If MessageBox.Show("Are you sure you want to delete " + customer.CustomerName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If appointment.DeleteAppointment() = True Then
                    appointment.ViewAppointment(gvView)
                Else
                    MessageBox.Show("Failed to delete. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.ColumnIndex = 6 Then
            appointment.SetAppointmentDetails(gvView.SelectedRows(0).Cells(0).Value)
            customer.SetCustomerDetails(gvView.SelectedRows(0).Cells(0).Value)
            billing.SetBillingDetails(gvView.SelectedRows(0).Cells(0).Value)
            customerservice.SetCustomerServiceDetails(gvView.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditAppointment
            obj.appointment = Me.appointment
            obj.customer = Me.customer
            obj.customerservice = Me.customerservice
            obj.billing = Me.billing
            If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                appointment.ViewAppointment(gvView)
            End If

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmPrintreportpreview
            Dim rpt As New crystalrepAppointment
            Dim dt As New DataTable

            With dt.Columns
                .Add("customerID")
                .Add("appointmentDate")
                .Add("appointmentTime")
            End With

            For i As Integer = 0 To gvView.RowCount - 1
                dt.Rows.Add(gvView.Rows(i).Cells(2).Value,
                           gvView.Rows(i).Cells(4).Value,
                           gvView.Rows(i).Cells(3).Value)
            Next

            rpt.SetDataSource(dt)
            'With frm
            frm.CrystalReportViewer1.ReportSource = rpt
            frm.ShowDialog()
            'End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class