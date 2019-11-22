<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEmployeePayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbcntrlSalary = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.panelSalary = New System.Windows.Forms.Panel()
        Me.txtCommission = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtStandardPay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBasicPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOvertime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNetpay = New System.Windows.Forms.TextBox()
        Me.panelGvDeduction = New System.Windows.Forms.Panel()
        Me.gvViewDeduction = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddDeduction = New System.Windows.Forms.Button()
        Me.tbcntrlEmployee = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panelEmployee = New System.Windows.Forms.Panel()
        Me.gvViewEmployee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelMain.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContainer.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tbcntrlSalary.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.panelSalary.SuspendLayout()
        Me.panelGvDeduction.SuspendLayout()
        CType(Me.gvViewDeduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcntrlEmployee.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panelEmployee.SuspendLayout()
        CType(Me.gvViewEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.Panel9)
        Me.panelMain.Controls.Add(Me.Panel10)
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1056, 767)
        Me.panelMain.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 41)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1056, 43)
        Me.Panel9.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(311, -30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(396, 57)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "GENERATE PAYROLL"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Controls.Add(Me.PictureBox1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1056, 41)
        Me.Panel10.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(311, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(396, 57)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "GENERATE PAYROLL"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1028, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'panelContainer
        '
        Me.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContainer.Controls.Add(Me.TabControl1)
        Me.panelContainer.Controls.Add(Me.tbcntrlSalary)
        Me.panelContainer.Controls.Add(Me.tbcntrlEmployee)
        Me.panelContainer.Location = New System.Drawing.Point(15, 89)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1026, 664)
        Me.panelContainer.TabIndex = 24
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl1.Location = New System.Drawing.Point(4, 436)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(469, 217)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(461, 173)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Date & Time"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtpTime)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 165)
        Me.Panel1.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "h:mm tt"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(141, 27)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShowUpDown = True
        Me.dtpDate.Size = New System.Drawing.Size(216, 39)
        Me.dtpDate.TabIndex = 112
        Me.dtpDate.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(53, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 32)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "Time :"
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "h:mm tt"
        Me.dtpTime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(141, 84)
        Me.dtpTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(216, 39)
        Me.dtpTime.TabIndex = 103
        Me.dtpTime.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(52, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 32)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Time :"
        '
        'tbcntrlSalary
        '
        Me.tbcntrlSalary.Controls.Add(Me.TabPage2)
        Me.tbcntrlSalary.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tbcntrlSalary.Location = New System.Drawing.Point(481, 4)
        Me.tbcntrlSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcntrlSalary.Name = "tbcntrlSalary"
        Me.tbcntrlSalary.SelectedIndex = 0
        Me.tbcntrlSalary.Size = New System.Drawing.Size(539, 649)
        Me.tbcntrlSalary.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.panelSalary)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(531, 605)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Salary Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'panelSalary
        '
        Me.panelSalary.Controls.Add(Me.txtCommission)
        Me.panelSalary.Controls.Add(Me.Label10)
        Me.panelSalary.Controls.Add(Me.Label8)
        Me.panelSalary.Controls.Add(Me.txtPosition)
        Me.panelSalary.Controls.Add(Me.txtStandardPay)
        Me.panelSalary.Controls.Add(Me.Label5)
        Me.panelSalary.Controls.Add(Me.txtTotalDeduction)
        Me.panelSalary.Controls.Add(Me.Label6)
        Me.panelSalary.Controls.Add(Me.txtBasicPay)
        Me.panelSalary.Controls.Add(Me.Label4)
        Me.panelSalary.Controls.Add(Me.Label3)
        Me.panelSalary.Controls.Add(Me.txtGrossPay)
        Me.panelSalary.Controls.Add(Me.Label1)
        Me.panelSalary.Controls.Add(Me.txtOvertime)
        Me.panelSalary.Controls.Add(Me.Label2)
        Me.panelSalary.Controls.Add(Me.txtNetpay)
        Me.panelSalary.Controls.Add(Me.panelGvDeduction)
        Me.panelSalary.Controls.Add(Me.btnSave)
        Me.panelSalary.Controls.Add(Me.btnAddDeduction)
        Me.panelSalary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSalary.Location = New System.Drawing.Point(4, 4)
        Me.panelSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSalary.Name = "panelSalary"
        Me.panelSalary.Size = New System.Drawing.Size(523, 597)
        Me.panelSalary.TabIndex = 0
        '
        'txtCommission
        '
        Me.txtCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommission.Enabled = False
        Me.txtCommission.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtCommission.ForeColor = System.Drawing.Color.Black
        Me.txtCommission.Location = New System.Drawing.Point(292, 351)
        Me.txtCommission.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(217, 39)
        Me.txtCommission.TabIndex = 103
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(285, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 32)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Commission"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 32)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Position Type"
        '
        'txtPosition
        '
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPosition.Enabled = False
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(12, 284)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(217, 39)
        Me.txtPosition.TabIndex = 100
        '
        'txtStandardPay
        '
        Me.txtStandardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStandardPay.Enabled = False
        Me.txtStandardPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtStandardPay.ForeColor = System.Drawing.Color.Black
        Me.txtStandardPay.Location = New System.Drawing.Point(12, 351)
        Me.txtStandardPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStandardPay.Name = "txtStandardPay"
        Me.txtStandardPay.Size = New System.Drawing.Size(217, 39)
        Me.txtStandardPay.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 32)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Basic Pay"
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDeduction.Enabled = False
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtTotalDeduction.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDeduction.Location = New System.Drawing.Point(292, 284)
        Me.txtTotalDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.Size = New System.Drawing.Size(217, 39)
        Me.txtTotalDeduction.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(285, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 32)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Total Deduction"
        '
        'txtBasicPay
        '
        Me.txtBasicPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBasicPay.Enabled = False
        Me.txtBasicPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtBasicPay.ForeColor = System.Drawing.Color.Black
        Me.txtBasicPay.Location = New System.Drawing.Point(12, 420)
        Me.txtBasicPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBasicPay.Name = "txtBasicPay"
        Me.txtBasicPay.Size = New System.Drawing.Size(217, 39)
        Me.txtBasicPay.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 32)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Standard Pay(Per Day)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(285, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 32)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Gross Pay"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossPay.Enabled = False
        Me.txtGrossPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtGrossPay.ForeColor = System.Drawing.Color.Black
        Me.txtGrossPay.Location = New System.Drawing.Point(292, 420)
        Me.txtGrossPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(217, 39)
        Me.txtGrossPay.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 460)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 32)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Overtime"
        '
        'txtOvertime
        '
        Me.txtOvertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOvertime.Enabled = False
        Me.txtOvertime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtOvertime.ForeColor = System.Drawing.Color.Black
        Me.txtOvertime.Location = New System.Drawing.Point(12, 492)
        Me.txtOvertime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.Size = New System.Drawing.Size(217, 39)
        Me.txtOvertime.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(285, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Net Pay"
        '
        'txtNetpay
        '
        Me.txtNetpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetpay.Enabled = False
        Me.txtNetpay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtNetpay.ForeColor = System.Drawing.Color.Black
        Me.txtNetpay.Location = New System.Drawing.Point(292, 492)
        Me.txtNetpay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNetpay.Name = "txtNetpay"
        Me.txtNetpay.Size = New System.Drawing.Size(217, 39)
        Me.txtNetpay.TabIndex = 89
        '
        'panelGvDeduction
        '
        Me.panelGvDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGvDeduction.Controls.Add(Me.gvViewDeduction)
        Me.panelGvDeduction.Location = New System.Drawing.Point(5, 4)
        Me.panelGvDeduction.Margin = New System.Windows.Forms.Padding(4)
        Me.panelGvDeduction.Name = "panelGvDeduction"
        Me.panelGvDeduction.Size = New System.Drawing.Size(510, 174)
        Me.panelGvDeduction.TabIndex = 67
        '
        'gvViewDeduction
        '
        Me.gvViewDeduction.AllowUserToAddRows = False
        Me.gvViewDeduction.AllowUserToDeleteRows = False
        Me.gvViewDeduction.AllowUserToResizeColumns = False
        Me.gvViewDeduction.AllowUserToResizeRows = False
        Me.gvViewDeduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvViewDeduction.BackgroundColor = System.Drawing.Color.White
        Me.gvViewDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvViewDeduction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvViewDeduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvViewDeduction.ColumnHeadersHeight = 27
        Me.gvViewDeduction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.gvViewDeduction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvViewDeduction.EnableHeadersVisualStyles = False
        Me.gvViewDeduction.Location = New System.Drawing.Point(0, 0)
        Me.gvViewDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gvViewDeduction.Name = "gvViewDeduction"
        Me.gvViewDeduction.ReadOnly = True
        Me.gvViewDeduction.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.gvViewDeduction.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvViewDeduction.RowTemplate.Height = 24
        Me.gvViewDeduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvViewDeduction.Size = New System.Drawing.Size(508, 172)
        Me.gvViewDeduction.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "No."
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Type"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Amount"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.ActiveLinkColor = System.Drawing.Color.Crimson
        Me.Column10.HeaderText = ""
        Me.Column10.LinkColor = System.Drawing.Color.Crimson
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.VisitedLinkColor = System.Drawing.Color.Crimson
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(251, 538)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(259, 49)
        Me.btnSave.TabIndex = 66
        Me.btnSave.Text = "Generate Payroll"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAddDeduction
        '
        Me.btnAddDeduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAddDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDeduction.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnAddDeduction.ForeColor = System.Drawing.Color.White
        Me.btnAddDeduction.Location = New System.Drawing.Point(5, 185)
        Me.btnAddDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddDeduction.Name = "btnAddDeduction"
        Me.btnAddDeduction.Size = New System.Drawing.Size(228, 59)
        Me.btnAddDeduction.TabIndex = 64
        Me.btnAddDeduction.Text = "+ Deduction"
        Me.btnAddDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDeduction.UseVisualStyleBackColor = False
        '
        'tbcntrlEmployee
        '
        Me.tbcntrlEmployee.Controls.Add(Me.TabPage1)
        Me.tbcntrlEmployee.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tbcntrlEmployee.Location = New System.Drawing.Point(4, 4)
        Me.tbcntrlEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcntrlEmployee.Name = "tbcntrlEmployee"
        Me.tbcntrlEmployee.SelectedIndex = 0
        Me.tbcntrlEmployee.Size = New System.Drawing.Size(469, 425)
        Me.tbcntrlEmployee.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panelEmployee)
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(461, 381)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panelEmployee
        '
        Me.panelEmployee.BackColor = System.Drawing.Color.White
        Me.panelEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmployee.Controls.Add(Me.gvViewEmployee)
        Me.panelEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEmployee.Location = New System.Drawing.Point(4, 4)
        Me.panelEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.panelEmployee.Name = "panelEmployee"
        Me.panelEmployee.Size = New System.Drawing.Size(453, 373)
        Me.panelEmployee.TabIndex = 0
        '
        'gvViewEmployee
        '
        Me.gvViewEmployee.AllowUserToAddRows = False
        Me.gvViewEmployee.AllowUserToDeleteRows = False
        Me.gvViewEmployee.AllowUserToResizeColumns = False
        Me.gvViewEmployee.AllowUserToResizeRows = False
        Me.gvViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvViewEmployee.BackgroundColor = System.Drawing.Color.White
        Me.gvViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvViewEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvViewEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvViewEmployee.ColumnHeadersHeight = 35
        Me.gvViewEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.gvViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvViewEmployee.EnableHeadersVisualStyles = False
        Me.gvViewEmployee.Location = New System.Drawing.Point(0, 0)
        Me.gvViewEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gvViewEmployee.Name = "gvViewEmployee"
        Me.gvViewEmployee.ReadOnly = True
        Me.gvViewEmployee.RowHeadersVisible = False
        Me.gvViewEmployee.RowTemplate.Height = 24
        Me.gvViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvViewEmployee.Size = New System.Drawing.Size(451, 371)
        Me.gvViewEmployee.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 20
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "No."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 35
        '
        'Column4
        '
        Me.Column4.HeaderText = "Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gender"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Position"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'frmAddEmployeePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1056, 767)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddEmployeePayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContainer.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tbcntrlSalary.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.panelSalary.ResumeLayout(False)
        Me.panelSalary.PerformLayout()
        Me.panelGvDeduction.ResumeLayout(False)
        CType(Me.gvViewDeduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcntrlEmployee.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.panelEmployee.ResumeLayout(False)
        CType(Me.gvViewEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelContainer As Panel
    Friend WithEvents tbcntrlSalary As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents panelSalary As Panel
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtStandardPay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalDeduction As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOvertime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNetpay As TextBox
    Friend WithEvents panelGvDeduction As Panel
    Friend WithEvents gvViewDeduction As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddDeduction As Button
    Friend WithEvents tbcntrlEmployee As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents panelEmployee As Panel
    Friend WithEvents gvViewEmployee As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCommission As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewLinkColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
