Imports MaterialSkin
Public Class frmAddAppointment
    Public Shared dtServer As Date = DateTime.Now

    Private customer As New Customer
    Private appointment As New Appointment
    Private service As New Service
    Private billing As New Billing
    Private customerService As New CustomerService

    Private add As Boolean = False
    Private edit As Boolean = False

    Dim status As String = "Not Paid"

    Private Sub EnableInput(root As Control)
        For Each ctrl As Control In root.Controls
            EnableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = True
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = True
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = True
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = True
            End If
            If TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Enabled = True
            End If
        Next ctrl
    End Sub
    Private Sub DisableInput(root As Control)
        For Each ctrl As Control In root.Controls
            DisableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = False
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = False
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = False
            End If
            If TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Enabled = False
            End If
        Next ctrl
    End Sub

    Sub SetAppointment()
        appointment.CustomerID = customer.CustomerID
        appointment.AppointmentTime = dtpTime.Value.ToShortTimeString
        appointment.AppointmentDate = dtpDate.Value.ToString
        appointment.AppointmentType =
        appointment.AddAppointment()
        appointment.SetAppointmentID()

        For Each r As DataGridViewRow In gvViewService.Rows
            With service
                .AppointmentID = appointment.AppointmentID
                .ServiceName = r.Cells(2).Value
                .ServiceDescription = r.Cells(3).Value
                .ServicePrice = r.Cells(4).Value
                .AddService()
            End With
        Next
    End Sub
    Public Sub ClearInput(root As Control)
        For Each ctrl As Control In root.Controls
            ClearInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            ElseIf TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Text = String.Empty
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    '---------Buttons Enable/Color---------
    Private Sub ResetButton()
        btnNewCustomer.Enabled = True
        btnNewCustomer.BackColor = Color.WhiteSmoke
        btnBrowseCustomer.Enabled = True
        btnBrowseCustomer.BackColor = Color.WhiteSmoke
        btnPayments.Enabled = False
        btnPayments.BackColor = Color.WhiteSmoke

        btnAddEmployee.Enabled = False
        btnAddservice.Enabled = False

        btnSave.Enabled = False

        btnClose.Enabled = True
        btnClose.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub OnActionButton()
        btnNewCustomer.Enabled = True
        btnNewCustomer.BackColor = Color.WhiteSmoke
        btnBrowseCustomer.Enabled = False
        btnBrowseCustomer.BackColor = Color.WhiteSmoke
        btnPayments.Enabled = False
        btnPayments.BackColor = Color.WhiteSmoke

        btnAddEmployee.Enabled = True
        btnAddservice.Enabled = True

        btnSave.Enabled = True

        btnClose.Enabled = True
        btnClose.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub timerWalkin_Tick(sender As Object, e As EventArgs) Handles timerWalkin.Tick
        lblTimeNow.Text = dtServer.ToString("h:mm tt")
        lblDateNow.Text = dtServer.ToShortDateString
    End Sub

    Private Sub frmAddWalkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableInput(Me)
        ResetButton()
        timerWalkin.Start()

        add = True
        edit = True

        'dtpDate.Value = dtServer.ToShortDateString
        'dtpTime.Value = dtServer.ToString("h:mm tt")
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Dim obj As New frmAddCustomer
        obj.customer = Me.customer

        If btnNewCustomer.Text = "Edit Customer" Then
            obj.edit = True
        End If

        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ''Insert CustomerTable
            With customer
                txtName.Text = .CustomerName
                txtCN.Text = .CustomerCN
                If .CustomerSex = "Male" Then
                    rdbMale.Checked = True
                ElseIf .CustomerSex = "Female" Then
                    rdbFemale.Checked = True
                End If
            End With
            btnNewCustomer.Text = "Edit Customer"

            OnActionButton()
            btnClose.Text = "Cancel"
        End If

        gvViewService.Rows.Clear()
        gvViewEmployee.Rows.Clear()

        EnableInput(Me)

        txtName.Enabled = False
        rdbMale.Enabled = False
        rdbFemale.Enabled = False
        txtCN.Enabled = False

        txtTotalAmount.Enabled = False
        txtRecieve.Enabled = False
        txtChange.Enabled = False
    End Sub

    Private Sub btnBrowseCustomer_Click(sender As Object, e As EventArgs) Handles btnBrowseCustomer.Click
        gvViewService.Rows.Clear()
        ClearInput(Me)

        EnableInput(Me)
        txtName.Enabled = False
        rdbMale.Enabled = False
        rdbFemale.Enabled = False
        txtCN.Enabled = False

        txtTotalAmount.Enabled = False
        txtRecieve.Enabled = False
        txtChange.Enabled = False

        Dim obj As New frmSearchCustomer
        obj.customer = Me.customer

        Dim obj2 As New frmAddCustomer
        obj.customer = Me.customer
        If btnNewCustomer.Text = "Edit Customer" Then
            obj2.edit = True
        End If

        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                With customer
                    txtName.Text = .CustomerName
                    If .CustomerSex = "Male" Then
                        rdbMale.Checked = True
                    ElseIf .CustomerSex = "Female" Then
                        rdbFemale.Checked = True
                    End If
                    txtCN.Text = .CustomerCN
                End With
                btnNewCustomer.Text = "Edit Customer"

                OnActionButton()
                btnClose.Text = "Cancel"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    ''Total Amount Count
    Sub recount()
        Dim i As Integer = 1
        Dim c As Decimal = 0
        For Each r As DataGridViewRow In gvViewService.Rows
            r.Cells(1).Value = i
            i = i + 1
            c = c + r.Cells(4).Value
        Next
        txtTotalAmount.Text = c
        'recolor()
        gvViewService.ClearSelection()
    End Sub
    Private Sub btnAddservice_Click(sender As Object, e As EventArgs) Handles btnAddservice.Click
        Dim obj As New frmAddServices
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim index As Integer = 1
            For Each row As DataGridViewRow In obj.gvView.Rows
                If row.Cells(1).Value = True Then
                    With gvViewService
                        .Rows.Add(row.Cells(0).Value.ToString,
                                       index.ToString,
                                       row.Cells(3).Value.ToString,
                                       row.Cells(4).Value.ToString,
                                       row.Cells(5).Value.ToString,
                                       "Remove")
                    End With
                    index += 1
                    recount()
                End If
            Next
        End If
    End Sub
    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvViewService.CellContentClick
        If e.ColumnIndex = 5 Then
            gvViewService.Rows.RemoveAt(service.ServiceID)
            recount()
        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim obj As New frmEmployeeServe
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim index As Integer = 1
            For Each row As DataGridViewRow In obj.gvView.Rows
                If row.Cells(1).Value = True Then
                    With gvViewEmployee
                        .Rows.Add(row.Cells(0).Value.ToString,
                                  index.ToString,
                                  row.Cells(3).Value.ToString,
                                  "Remove")
                    End With
                    index += 1
                End If
            Next
        End If
    End Sub
    Private Sub gvViewEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvViewEmployee.CellContentClick
        If e.ColumnIndex = 3 Then
            gvViewEmployee.Rows.RemoveAt(billing.EmployeeID)
        End If
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim obj As New frmAddPayments
        appointment.SetAppointmentDetails(appointment.AppointmentID)
        customer.SetCustomerDetails(customer.CustomerID)
        obj.appointment = Me.appointment
        obj.customer = Me.customer
        If obj.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub OnDone()
        ResetButton()
        DisableInput(Me)
    End Sub
    Public Sub doAdd()
        Try
            ''Insert Customer
            With customer
                .AddCustomer()
                .SetCustomerID()
            End With

            ''Instert AppointmentTable
            With appointment
                .AppointmentID = appointment.AppointmentID
                .CustomerID = customer.CustomerID
                .AppointmentDate = lblDateNow.Text
                If rdbWalkin.Checked = True Then
                    .AppointmentType = "Walk-In"
                    .AppointmentTime = lblTimeNow.Text
                    .AppointmentDate = lblDateNow.Text
                ElseIf rdbReservation.Checked = True Then
                    .AppointmentType = "Reservation"
                    .AppointmentTime = dtpTime.Value.ToString("t")
                    .AppointmentDate = dtpDate.Value.ToString("d")
                End If
                .AddAppointment()
                .SetAppointmentID()
            End With

            ''Insert CustomerService
            For Each r As DataGridViewRow In gvViewService.Rows
                With customerService
                    .AppointmentID = appointment.AppointmentID
                    .CustomerID = customer.CustomerID
                    .ServiceID = r.Cells(0).Value.ToString
                    .AddCustomerService()
                End With
            Next

            ''Insert Billing
            For Each r As DataGridViewRow In gvViewEmployee.Rows
                With billing
                    .AppointmentID = appointment.AppointmentID
                    .CustomerID = customer.CustomerID
                    .EmployeeID = r.Cells(0).Value.ToString
                    .BillingTime = lblTimeNow.Text
                    .BillingDate = lblDateNow.Text
                    .BillingAmount = txtTotalAmount.Text
                    .BillingStatus = status
                    .AddBilling()
                End With
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gvViewService.Rows.Count = 0 And dtpDate.Value.ToString < dtpDate.Value.ToString Then
            MessageBox.Show("Please check your date and services", "Message",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf gvViewService.Rows.Count = 0 Then
            MessageBox.Show("Please add service.", "Message",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dtpDate.Value.ToString < dtpDate.Value.ToString Then
            MessageBox.Show("Please check your date", "Message",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            If add = True Then
                doAdd()
                If MessageBox.Show("Do you want to proceed to payment?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim obj As New frmAddPayments
                    appointment.SetAppointmentDetails(appointment.AppointmentID)
                    customer.SetCustomerDetails(customer.CustomerID)
                    billing.SetBillingDetails(billing.BillingID)
                    obj.appointment = Me.appointment
                    obj.customer = Me.customer
                    obj.billing = Me.billing
                    If obj.ShowDialog = DialogResult.OK Then
                        OnDone()
                        ResetButton()
                        ClearInput(Me)
                        DisableInput(Me)

                        gvViewService.Rows.Clear()
                        gvViewEmployee.Rows.Clear()

                        rdbMale.Checked = True
                        rdbWalkin.Checked = True

                        btnClose.Text = "Close"
                        btnNewCustomer.Text = "New Customer"
                    End If
                ElseIf MessageBox.Show("Appointment Save", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
                    OnDone()
                    ResetButton()
                    ClearInput(Me)
                    DisableInput(Me)

                    gvViewService.Rows.Clear()
                    gvViewEmployee.Rows.Clear()

                    rdbMale.Checked = True
                    rdbWalkin.Checked = True

                    btnClose.Text = "Close"
                    btnNewCustomer.Text = "New Customer"
                End If
            End If
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "Cancel" Then
            ResetButton()
            ClearInput(Me)
            DisableInput(Me)

            gvViewService.Rows.Clear()
            gvViewEmployee.Rows.Clear()

            rdbMale.Checked = True
            rdbWalkin.Checked = True

            btnClose.Text = "Close"
            btnNewCustomer.Text = "New Customer"
        ElseIf btnClose.Text = "Close" Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtCN_TextChanged_1(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        PhoneFormat(txtCN)
        ContactNo(txtCN)
        AllowedOnly(NumberWDash, txtCN)
        txtCN.MaxLength = 13
    End Sub


    Private Sub rdbWalkin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWalkin.CheckedChanged
        lblTimeNow.Show()
        lblDateNow.Show()

        dtpTime.Hide()
        dtpDate.Hide()
    End Sub

    Private Sub rdbReservation_CheckedChanged(sender As Object, e As EventArgs) Handles rdbReservation.CheckedChanged
        dtpTime.Show()
        dtpDate.Show()

        lblTimeNow.Hide()
        lblDateNow.Hide()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        dtpDate.MinDate = Date.Now.ToString
        dtpDate.MaxDate = Date.Now.AddMonths(1)
    End Sub


End Class