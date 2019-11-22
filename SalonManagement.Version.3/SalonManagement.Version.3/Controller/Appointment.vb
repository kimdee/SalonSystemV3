Imports MySql.Data.MySqlClient

Public Class Appointment
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

    Private _appointmentTime As String
    Public Property AppointmentTime As String
        Set(value As String)
            _appointmentTime = value
        End Set
        Get
            Return _appointmentTime
        End Get
    End Property

    Private _appointmentDate As String
    Public Property AppointmentDate As String
        Set(value As String)
            _appointmentDate = value
        End Set
        Get
            Return _appointmentDate
        End Get
    End Property

    Private _appointmentType As String
    Public Property AppointmentType As String
        Set(value As String)
            _appointmentType = value
        End Set
        Get
            Return _appointmentType
        End Get
    End Property

    Private _appointmentTotalAmount As String
    Public Property AppointmentTotalAmount As String
        Set(value As String)
            _appointmentTotalAmount = value
        End Set
        Get
            Return _appointmentTotalAmount
        End Get
    End Property

    Public Sub SetAppointmentID()
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

    Public Sub SetAppointmentDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Appointment WHERE appointmentID =" & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    AppointmentID = reader(0)
                    CustomerID = reader(1)
                    AppointmentTime = reader(2)
                    AppointmentDate = reader(3)
                    AppointmentType = reader(4)
                    AppointmentTotalAmount = reader(5)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function AddAppointment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO Appointment (customerID,appointmentTime,AppointmentDate,appointmentType,appointmentTotalAmount) VALUES (@0,@1,@2,@3,@4);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, CustomerID, AppointmentTime, AppointmentDate, AppointmentType, AppointmentTotalAmount)
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
    Public Function EditAppointment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Appointment SET customerID=@0,appointmentTime=@1,appointmentDate=@2,appointmentType=@3,appointmentTotalAmount=@4 WHERE appointmentID=@5;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, CustomerID, AppointmentTime, AppointmentDate, AppointmentType, AppointmentTotalAmount, AppointmentID)
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
    Public Function DeleteAppointment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM Appointment WHERE appointmentID=@0;"
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

    Public Sub ViewAppointment(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0

            sql = "SELECT * FROM appointment INNER JOIN customer ON appointment.customerID=customer.customerID " _
                & " ORDER BY appointmentDate DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader("customerName"), reader(2), reader(3), reader(4), reader(5), "Not Paid", "Edit", "Delete")
                    End With
                End While
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Public Sub UpdateStatus()
    '    Dim bool As Boolean = False
    '    Try
    '        IsConnected()
    '        Dim sql As String = "UPDATE appointment SET billingID=@0 WHERE appointmentID=@1;"
    '        ServerExecuteSQL(sql, BillingID, AppointmentID)
    '        Commit()
    '    Catch ex As Exception
    '        MsgBox(ex.Message + " Here MorningOut")
    '    End Try
    'End Sub

    Public Function IsServiceExist(kw As DataGridView) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT serviceID FROM appointment WHERE serviceID=serviceID ORDER BY serviceID ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows() Then
                    bool = True
                Else
                    bool = False
                End If
            End If
            Return bool
        Catch ex As Exception
            Return True
        End Try
    End Function
End Class