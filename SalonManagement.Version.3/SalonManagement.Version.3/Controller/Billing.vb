Imports MySql.Data.MySqlClient

Public Class Billing

    Private _billingID As Integer = 0
    Public Property BillingID As Integer
        Set(value As Integer)
            _billingID = value
        End Set
        Get
            Return _billingID
        End Get
    End Property

    Private _appointmentID As Integer = 0
    Public Property AppointmentID As Integer
        Set(value As Integer)
            _appointmentID = value
        End Set
        Get
            Return _appointmentID
        End Get
    End Property

    Private _customerID As Integer = 0
    Public Property CustomerID As Integer
        Set(value As Integer)
            _customerID = value
        End Set
        Get
            Return _customerID
        End Get
    End Property

    Private _employeeID As Integer = 0
    Public Property EmployeeID As Integer
        Set(value As Integer)
            _employeeID = value
        End Set
        Get
            Return _employeeID
        End Get
    End Property

    Private _billingTime As String
    Public Property BillingTime As String
        Set(value As String)
            _billingTime = value
        End Set
        Get
            Return _billingTime
        End Get
    End Property

    Private _billingDate As String
    Public Property BillingDate As String
        Set(value As String)
            _billingDate = value
        End Set
        Get
            Return _billingDate
        End Get
    End Property

    Private _billingAmount As String
    Public Property BillingAmount As String
        Set(value As String)
            _billingAmount = value
        End Set
        Get
            Return _billingAmount
        End Get
    End Property

    Private _billingStatus As String = ""
    Public Property BillingStatus As String
        Set(value As String)
            _billingStatus = value
        End Set
        Get
            Return _billingStatus
        End Get
    End Property

    Public Sub SetBillingID()
        Try
            Dim sql As String
            sql = "SELECT LAST_INSERT_ID();"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                CustomerID = Integer.Parse(cmd.ExecuteScalar)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetBillingDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM billing WHERE billingid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    BillingID = reader(0)
                    AppointmentID = reader(1)
                    CustomerID = reader(2)
                    EmployeeID = reader(3)
                    BillingTime = reader(4)
                    BillingDate = reader(5)
                    BillingAmount = reader(6)
                    BillingStatus = reader(7)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddBilling() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO billing (appointmentID,customerID,employeeID,billingTime,billingDate,billingAmount,billingStatus) VALUES (@0,@1,@2,@3,@4,@5,@6);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID, CustomerID, EmployeeID, BillingTime, BillingDate, BillingAmount, BillingStatus)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditBilling() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE billing SET appointmentID=@0,customerID=@1,employeeID=@2,billingTime=@3,billingDate=@4,billingAmount=@5,billingStatus=@6 WHERE billingID=@7;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID, CustomerID, EmployeeID, BillingTime, BillingDate, BillingAmount, BillingStatus, BillingID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteBilling() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM billing WHERE billingID=@0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, BillingID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function


    Public Sub ViewBillings(gv As DataGridView, lbl As Label, status As String, startDate As Date, endDate As Date, filter As String)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT billingID,billingTime,billingDate,billingAmount,billingStatus FROM billing " _
                & "INNER JOIN appointment on billing.appointmentID=appointment.appointmentID WHERE appointment.appointmentID" _
                & "=" & AppointmentID & "and billingStatus = 0 ORDER BY billingDate DESC;"
            If IsConnected() Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv

                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class
