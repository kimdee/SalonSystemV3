<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPayroll
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
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtOvertime = New System.Windows.Forms.TextBox()
        Me.txtCommission = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStandardPay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNetpay = New System.Windows.Forms.TextBox()
        Me.txtBasicPay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbcntrlSalary = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.panelSalary = New System.Windows.Forms.Panel()
        Me.btnAddDeduction = New System.Windows.Forms.Button()
        Me.gvViewDeduction = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chckboxSelectAll = New System.Windows.Forms.CheckBox()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.panelMain.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContainer.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tbcntrlSalary.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.panelSalary.SuspendLayout()
        CType(Me.gvViewDeduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcntrlEmployee.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panelEmployee.SuspendLayout()
        CType(Me.gvViewEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.Panel12)
        Me.panelMain.Controls.Add(Me.Panel9)
        Me.panelMain.Controls.Add(Me.Panel10)
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1384, 786)
        Me.panelMain.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 753)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1384, 33)
        Me.Panel12.TabIndex = 27
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 33)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1384, 35)
        Me.Panel9.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(540, -24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(326, 46)
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
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1384, 33)
        Me.Panel10.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(540, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(326, 46)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "GENERATE PAYROLL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1363, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'panelContainer
        '
        Me.panelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContainer.Controls.Add(Me.btnClose)
        Me.panelContainer.Controls.Add(Me.TabControl2)
        Me.panelContainer.Controls.Add(Me.TabControl1)
        Me.panelContainer.Controls.Add(Me.btnSave)
        Me.panelContainer.Controls.Add(Me.tbcntrlSalary)
        Me.panelContainer.Controls.Add(Me.tbcntrlEmployee)
        Me.panelContainer.Location = New System.Drawing.Point(11, 93)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1362, 642)
        Me.panelContainer.TabIndex = 24
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(1132, 581)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(194, 40)
        Me.btnClose.TabIndex = 112
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl2.Location = New System.Drawing.Point(861, 320)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(465, 246)
        Me.TabControl2.TabIndex = 111
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage4.Size = New System.Drawing.Size(457, 208)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Salary Details"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtOvertime)
        Me.Panel2.Controls.Add(Me.txtCommission)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtStandardPay)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtGrossPay)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNetpay)
        Me.Panel2.Controls.Add(Me.txtBasicPay)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 202)
        Me.Panel2.TabIndex = 0
        '
        'txtOvertime
        '
        Me.txtOvertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOvertime.Enabled = False
        Me.txtOvertime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtOvertime.ForeColor = System.Drawing.Color.Black
        Me.txtOvertime.Location = New System.Drawing.Point(215, 24)
        Me.txtOvertime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.Size = New System.Drawing.Size(163, 32)
        Me.txtOvertime.TabIndex = 110
        '
        'txtCommission
        '
        Me.txtCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommission.Enabled = False
        Me.txtCommission.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtCommission.ForeColor = System.Drawing.Color.Black
        Me.txtCommission.Location = New System.Drawing.Point(215, 86)
        Me.txtCommission.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(163, 32)
        Me.txtCommission.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Basic Pay"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(210, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 25)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Commission"
        '
        'txtStandardPay
        '
        Me.txtStandardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStandardPay.Enabled = False
        Me.txtStandardPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtStandardPay.ForeColor = System.Drawing.Color.Black
        Me.txtStandardPay.Location = New System.Drawing.Point(10, 24)
        Me.txtStandardPay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStandardPay.Name = "txtStandardPay"
        Me.txtStandardPay.Size = New System.Drawing.Size(163, 32)
        Me.txtStandardPay.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(5, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Gross Pay"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossPay.Enabled = False
        Me.txtGrossPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtGrossPay.ForeColor = System.Drawing.Color.Black
        Me.txtGrossPay.Location = New System.Drawing.Point(10, 154)
        Me.txtGrossPay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(163, 32)
        Me.txtGrossPay.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 25)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Standard Pay(Per Day)"
        '
        'txtNetpay
        '
        Me.txtNetpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetpay.Enabled = False
        Me.txtNetpay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtNetpay.ForeColor = System.Drawing.Color.Black
        Me.txtNetpay.Location = New System.Drawing.Point(215, 155)
        Me.txtNetpay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNetpay.Name = "txtNetpay"
        Me.txtNetpay.Size = New System.Drawing.Size(163, 32)
        Me.txtNetpay.TabIndex = 105
        '
        'txtBasicPay
        '
        Me.txtBasicPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBasicPay.Enabled = False
        Me.txtBasicPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtBasicPay.ForeColor = System.Drawing.Color.Black
        Me.txtBasicPay.Location = New System.Drawing.Point(10, 87)
        Me.txtBasicPay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBasicPay.Name = "txtBasicPay"
        Me.txtBasicPay.Size = New System.Drawing.Size(163, 32)
        Me.txtBasicPay.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(210, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Overtime"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(210, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Net Pay"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl1.Location = New System.Drawing.Point(544, 320)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(311, 246)
        Me.TabControl1.TabIndex = 110
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage3.Size = New System.Drawing.Size(303, 208)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Date & Time"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPosition)
        Me.Panel1.Controls.Add(Me.dtpYear)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.dtpMonth)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtpTime)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 202)
        Me.Panel1.TabIndex = 0
        '
        'txtPosition
        '
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPosition.Enabled = False
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(107, 155)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(163, 32)
        Me.txtPosition.TabIndex = 115
        Me.txtPosition.Visible = False
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(108, 20)
        Me.dtpYear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(163, 32)
        Me.dtpYear.TabIndex = 114
        Me.dtpYear.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(45, 24)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 25)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Year :"
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM"
        Me.dtpMonth.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(108, 69)
        Me.dtpMonth.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.ShowUpDown = True
        Me.dtpMonth.Size = New System.Drawing.Size(163, 32)
        Me.dtpMonth.TabIndex = 112
        Me.dtpMonth.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(27, 73)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 25)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "Month :"
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "h:mm tt"
        Me.dtpTime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(108, 113)
        Me.dtpTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(163, 32)
        Me.dtpTime.TabIndex = 103
        Me.dtpTime.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(42, 117)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 25)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Time :"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(933, 581)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(194, 40)
        Me.btnSave.TabIndex = 68
        Me.btnSave.Text = "Generate Payroll"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tbcntrlSalary
        '
        Me.tbcntrlSalary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcntrlSalary.Controls.Add(Me.TabPage2)
        Me.tbcntrlSalary.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tbcntrlSalary.Location = New System.Drawing.Point(544, 17)
        Me.tbcntrlSalary.Name = "tbcntrlSalary"
        Me.tbcntrlSalary.SelectedIndex = 0
        Me.tbcntrlSalary.Size = New System.Drawing.Size(782, 297)
        Me.tbcntrlSalary.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.panelSalary)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(774, 259)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Deduction"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'panelSalary
        '
        Me.panelSalary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSalary.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSalary.Controls.Add(Me.btnAddDeduction)
        Me.panelSalary.Controls.Add(Me.gvViewDeduction)
        Me.panelSalary.Controls.Add(Me.txtTotalDeduction)
        Me.panelSalary.Controls.Add(Me.Label6)
        Me.panelSalary.Location = New System.Drawing.Point(3, 3)
        Me.panelSalary.Name = "panelSalary"
        Me.panelSalary.Size = New System.Drawing.Size(771, 256)
        Me.panelSalary.TabIndex = 0
        '
        'btnAddDeduction
        '
        Me.btnAddDeduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAddDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDeduction.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnAddDeduction.ForeColor = System.Drawing.Color.White
        Me.btnAddDeduction.Location = New System.Drawing.Point(2, 2)
        Me.btnAddDeduction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddDeduction.Name = "btnAddDeduction"
        Me.btnAddDeduction.Size = New System.Drawing.Size(181, 36)
        Me.btnAddDeduction.TabIndex = 64
        Me.btnAddDeduction.Text = "Add Deduction"
        Me.btnAddDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDeduction.UseVisualStyleBackColor = False
        '
        'gvViewDeduction
        '
        Me.gvViewDeduction.AllowUserToAddRows = False
        Me.gvViewDeduction.AllowUserToDeleteRows = False
        Me.gvViewDeduction.AllowUserToResizeColumns = False
        Me.gvViewDeduction.AllowUserToResizeRows = False
        Me.gvViewDeduction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvViewDeduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvViewDeduction.BackgroundColor = System.Drawing.Color.White
        Me.gvViewDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvViewDeduction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvViewDeduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvViewDeduction.ColumnHeadersHeight = 35
        Me.gvViewDeduction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.gvViewDeduction.EnableHeadersVisualStyles = False
        Me.gvViewDeduction.Location = New System.Drawing.Point(2, 42)
        Me.gvViewDeduction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.gvViewDeduction.Size = New System.Drawing.Size(766, 173)
        Me.gvViewDeduction.TabIndex = 30
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
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDeduction.Enabled = False
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtTotalDeduction.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDeduction.Location = New System.Drawing.Point(615, 219)
        Me.txtTotalDeduction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.Size = New System.Drawing.Size(148, 32)
        Me.txtTotalDeduction.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(465, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 25)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Total Deduction"
        '
        'tbcntrlEmployee
        '
        Me.tbcntrlEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbcntrlEmployee.Controls.Add(Me.TabPage1)
        Me.tbcntrlEmployee.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tbcntrlEmployee.Location = New System.Drawing.Point(18, 17)
        Me.tbcntrlEmployee.Name = "tbcntrlEmployee"
        Me.tbcntrlEmployee.SelectedIndex = 0
        Me.tbcntrlEmployee.Size = New System.Drawing.Size(520, 549)
        Me.tbcntrlEmployee.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panelEmployee)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(512, 511)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panelEmployee
        '
        Me.panelEmployee.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmployee.Controls.Add(Me.gvViewEmployee)
        Me.panelEmployee.Controls.Add(Me.Panel3)
        Me.panelEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEmployee.Location = New System.Drawing.Point(3, 3)
        Me.panelEmployee.Name = "panelEmployee"
        Me.panelEmployee.Size = New System.Drawing.Size(506, 505)
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
        Me.gvViewEmployee.Location = New System.Drawing.Point(0, 47)
        Me.gvViewEmployee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gvViewEmployee.Name = "gvViewEmployee"
        Me.gvViewEmployee.ReadOnly = True
        Me.gvViewEmployee.RowHeadersVisible = False
        Me.gvViewEmployee.RowTemplate.Height = 24
        Me.gvViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvViewEmployee.Size = New System.Drawing.Size(504, 456)
        Me.gvViewEmployee.TabIndex = 30
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.chckboxSelectAll)
        Me.Panel3.Controls.Add(Me.cboPosition)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(504, 47)
        Me.Panel3.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Filter By :"
        '
        'chckboxSelectAll
        '
        Me.chckboxSelectAll.AutoSize = True
        Me.chckboxSelectAll.Location = New System.Drawing.Point(11, 9)
        Me.chckboxSelectAll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chckboxSelectAll.Name = "chckboxSelectAll"
        Me.chckboxSelectAll.Size = New System.Drawing.Size(108, 29)
        Me.chckboxSelectAll.TabIndex = 1
        Me.chckboxSelectAll.Text = "Select All"
        Me.chckboxSelectAll.UseVisualStyleBackColor = True
        '
        'cboPosition
        '
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Location = New System.Drawing.Point(220, 8)
        Me.cboPosition.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(160, 33)
        Me.cboPosition.TabIndex = 0
        '
        'frmAddPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 786)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAddPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMain.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContainer.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tbcntrlSalary.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.panelSalary.ResumeLayout(False)
        Me.panelSalary.PerformLayout()
        CType(Me.gvViewDeduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcntrlEmployee.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.panelEmployee.ResumeLayout(False)
        CType(Me.gvViewEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents panelContainer As Panel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents tbcntrlSalary As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents panelSalary As Panel
    Friend WithEvents btnAddDeduction As Button
    Friend WithEvents gvViewDeduction As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewLinkColumn
    Friend WithEvents txtTotalDeduction As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbcntrlEmployee As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents panelEmployee As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCommission As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStandardPay As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNetpay As TextBox
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOvertime As TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents chckboxSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents gvViewEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
