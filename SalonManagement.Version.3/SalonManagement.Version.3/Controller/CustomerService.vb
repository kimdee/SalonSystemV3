Imports MySql.Data.MySqlClient

Public Class CustomerService

    Private _CustomerServiceID As Integer = 0
    Public Property CustomerServiceID As Integer
        Set(value As Integer)
            _CustomerServiceID = value
        End Set
        Get
            Return _CustomerServiceID
        End Get
    End Property

    Private _AppointmentID As Integer = 0
    Public Property AppointmentID As Integer
        Set(value As Integer)
            _AppointmentID = value
        End Set
        Get
            Return _AppointmentID
        End Get
    End Property

    Private _CustomerID As Integer
    Public Property CustomerID As Integer
        Set(value As Integer)
            _CustomerID = value
        End Set
        Get
            Return _CustomerID
        End Get
    End Property

    Private _ServiceID As Integer
    Public Property ServiceID As Integer
        Set(value As Integer)
            _ServiceID = value
        End Set
        Get
            Return _ServiceID
        End Get
    End Property

    Public Sub SetCustomerServiceID()
        Try
            Dim sql As String
            sql = "SELECT LAST_INSERT_ID();"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                AppointmentID = Integer.Parse(cmd.ExecuteScalar)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetCustomerServiceDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM CustomerService WHERE CustomerServiceID =" & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    CustomerServiceID = reader(0)
                    AppointmentID = reader(1)
                    CustomerID = reader(2)
                    ServiceID = reader(3)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function AddCustomerService() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO CustomerService (appointmentID,customerID,serviceID) VALUES (@0,@1,@2);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID, CustomerID, ServiceID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            MsgBox(ex.ToString, vbCritical, "Error")
            Return False
        End Try
    End Function
    Public Function EditCustomerServiceID() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE CustomerService SET appointmentID=@0,customerID=@1,serviceID=@2 WHERE CustomerService=@3;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID, CustomerID, ServiceID, CustomerServiceID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            MsgBox(ex.ToString, vbCritical, "Error")
            Return False
        End Try
    End Function
    Public Function DeleteCustomerService() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM CustomerService WHERE CustomerServiceID=@0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub ViewCustomerService(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM customerservice INNER JOIN customer ON customerservice.customerID=customer.customerID INNER JOIN service ON customerservice.serviceID=service.serviceID WHERE appointmentID= " & AppointmentID & " ORDER BY service.serviceName ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader("serviceName"), reader("serviceDescription"), reader("servicePrice"), "Remove")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
