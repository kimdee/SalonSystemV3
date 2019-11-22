<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddAppointment
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
        Me.components = New System.ComponentModel.Container()
        Me.timerWalkin = New System.Windows.Forms.Timer(Me.components)
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnAddservice = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnBrowseCustomer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.panelGv = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gvView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.nudTotalAmount = New System.Windows.Forms.NumericUpDown()
        Me.rdbReservation = New System.Windows.Forms.RadioButton()
        Me.rdbWalkin = New System.Windows.Forms.RadioButton()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.lblDateNow = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.panelMain.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContainer.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.panelGv.SuspendLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTotalAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerWalkin
        '
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.Panel9)
        Me.panelMain.Controls.Add(Me.Panel10)
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(963, 603)
        Me.panelMain.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 33)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(963, 35)
        Me.Panel9.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(315, -24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 46)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NEW APPOINTMENT"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Controls.Add(Me.PictureBox1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(963, 33)
        Me.Panel10.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(315, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 46)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "NEW APPOINTMENT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(942, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'panelContainer
        '
        Me.panelContainer.BackColor = System.Drawing.Color.White
        Me.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContainer.Controls.Add(Me.Panel5)
        Me.panelContainer.Controls.Add(Me.Panel3)
        Me.panelContainer.Location = New System.Drawing.Point(11, 72)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(941, 520)
        Me.panelContainer.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Location = New System.Drawing.Point(723, 3)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(214, 507)
        Me.Panel5.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnSave)
        Me.Panel7.Controls.Add(Me.btnClose)
        Me.Panel7.Controls.Add(Me.btnEdit)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 334)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(212, 171)
        Me.Panel7.TabIndex = 31
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(7, 14)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(199, 47)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(7, 115)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(199, 47)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(7, 65)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(199, 47)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnPayments)
        Me.Panel2.Controls.Add(Me.btnAddservice)
        Me.Panel2.Controls.Add(Me.btnNewCustomer)
        Me.Panel2.Controls.Add(Me.btnBrowseCustomer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 220)
        Me.Panel2.TabIndex = 29
        '
        'btnPayments
        '
        Me.btnPayments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayments.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnPayments.ForeColor = System.Drawing.Color.Black
        Me.btnPayments.Location = New System.Drawing.Point(7, 159)
        Me.btnPayments.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(199, 47)
        Me.btnPayments.TabIndex = 27
        Me.btnPayments.Text = "Proceed Payments"
        Me.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'btnAddservice
        '
        Me.btnAddservice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddservice.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnAddservice.ForeColor = System.Drawing.Color.Black
        Me.btnAddservice.Location = New System.Drawing.Point(7, 108)
        Me.btnAddservice.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddservice.Name = "btnAddservice"
        Me.btnAddservice.Size = New System.Drawing.Size(199, 47)
        Me.btnAddservice.TabIndex = 23
        Me.btnAddservice.Text = "Add Service"
        Me.btnAddservice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddservice.UseVisualStyleBackColor = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCustomer.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnNewCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnNewCustomer.Location = New System.Drawing.Point(8, 6)
        Me.btnNewCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(199, 47)
        Me.btnNewCustomer.TabIndex = 28
        Me.btnNewCustomer.Text = "New Customer"
        Me.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnBrowseCustomer
        '
        Me.btnBrowseCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseCustomer.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnBrowseCustomer.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseCustomer.Location = New System.Drawing.Point(7, 57)
        Me.btnBrowseCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowseCustomer.Name = "btnBrowseCustomer"
        Me.btnBrowseCustomer.Size = New System.Drawing.Size(199, 47)
        Me.btnBrowseCustomer.TabIndex = 20
        Me.btnBrowseCustomer.Text = "Browse Customer"
        Me.btnBrowseCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowseCustomer.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TabControl3)
        Me.Panel3.Controls.Add(Me.rdbReservation)
        Me.Panel3.Controls.Add(Me.rdbWalkin)
        Me.Panel3.Controls.Add(Me.TabControl4)
        Me.Panel3.Controls.Add(Me.TabControl2)
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 507)
        Me.Panel3.TabIndex = 0
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl3.Location = New System.Drawing.Point(216, 36)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(495, 465)
        Me.TabControl3.TabIndex = 14
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.panelGv)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(487, 427)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Service"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'panelGv
        '
        Me.panelGv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelGv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelGv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGv.Controls.Add(Me.Label9)
        Me.panelGv.Controls.Add(Me.gvView)
        Me.panelGv.Controls.Add(Me.nudTotalAmount)
        Me.panelGv.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.panelGv.Location = New System.Drawing.Point(4, 5)
        Me.panelGv.Margin = New System.Windows.Forms.Padding(2)
        Me.panelGv.Name = "panelGv"
        Me.panelGv.Size = New System.Drawing.Size(479, 420)
        Me.panelGv.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(175, 383)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 28)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Total Amount"
        '
        'gvView
        '
        Me.gvView.AllowUserToAddRows = False
        Me.gvView.AllowUserToDeleteRows = False
        Me.gvView.AllowUserToResizeColumns = False
        Me.gvView.AllowUserToResizeRows = False
        Me.gvView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvView.BackgroundColor = System.Drawing.Color.White
        Me.gvView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvView.ColumnHeadersHeight = 35
        Me.gvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.gvView.EnableHeadersVisualStyles = False
        Me.gvView.Location = New System.Drawing.Point(2, 2)
        Me.gvView.Margin = New System.Windows.Forms.Padding(2)
        Me.gvView.Name = "gvView"
        Me.gvView.ReadOnly = True
        Me.gvView.RowHeadersVisible = False
        Me.gvView.RowTemplate.Height = 24
        Me.gvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvView.Size = New System.Drawing.Size(473, 375)
        Me.gvView.TabIndex = 24
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
        Me.Column2.HeaderText = "No."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.Width = 35
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.ActiveLinkColor = System.Drawing.Color.Crimson
        Me.Column6.HeaderText = ""
        Me.Column6.LinkColor = System.Drawing.Color.Crimson
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.VisitedLinkColor = System.Drawing.Color.Crimson
        '
        'nudTotalAmount
        '
        Me.nudTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudTotalAmount.DecimalPlaces = 2
        Me.nudTotalAmount.Enabled = False
        Me.nudTotalAmount.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.nudTotalAmount.Location = New System.Drawing.Point(311, 381)
        Me.nudTotalAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.nudTotalAmount.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudTotalAmount.Name = "nudTotalAmount"
        Me.nudTotalAmount.Size = New System.Drawing.Size(163, 32)
        Me.nudTotalAmount.TabIndex = 25
        Me.nudTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTotalAmount.ThousandsSeparator = True
        '
        'rdbReservation
        '
        Me.rdbReservation.AutoSize = True
        Me.rdbReservation.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.rdbReservation.Location = New System.Drawing.Point(407, 3)
        Me.rdbReservation.Name = "rdbReservation"
        Me.rdbReservation.Size = New System.Drawing.Size(155, 32)
        Me.rdbReservation.TabIndex = 12
        Me.rdbReservation.Text = "RESERVATION"
        Me.rdbReservation.UseVisualStyleBackColor = True
        '
        'rdbWalkin
        '
        Me.rdbWalkin.AutoSize = True
        Me.rdbWalkin.Checked = True
        Me.rdbWalkin.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.rdbWalkin.Location = New System.Drawing.Point(290, 3)
        Me.rdbWalkin.Name = "rdbWalkin"
        Me.rdbWalkin.Size = New System.Drawing.Size(111, 32)
        Me.rdbWalkin.TabIndex = 11
        Me.rdbWalkin.TabStop = True
        Me.rdbWalkin.Text = "WALK-IN"
        Me.rdbWalkin.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.TabPage4)
        Me.TabControl4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl4.Location = New System.Drawing.Point(2, 411)
        Me.TabControl4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(210, 89)
        Me.TabControl4.TabIndex = 10
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(202, 51)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Status"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblStatus)
        Me.Panel4.Location = New System.Drawing.Point(4, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(194, 44)
        Me.Panel4.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(9, 6)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(107, 32)
        Me.lblStatus.TabIndex = 34
        Me.lblStatus.Text = "Not Paid"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl2.Location = New System.Drawing.Point(2, 236)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(210, 176)
        Me.TabControl2.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(202, 138)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Date & Time"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.dtpDate)
        Me.Panel8.Controls.Add(Me.lblTimeNow)
        Me.Panel8.Controls.Add(Me.lblDateNow)
        Me.Panel8.Controls.Add(Me.dtpTime)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Location = New System.Drawing.Point(4, 3)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(194, 131)
        Me.Panel8.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = ""
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(15, 86)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(164, 32)
        Me.dtpDate.TabIndex = 27
        Me.dtpDate.Value = New Date(2019, 11, 6, 0, 0, 0, 0)
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblTimeNow.ForeColor = System.Drawing.Color.Black
        Me.lblTimeNow.Location = New System.Drawing.Point(10, 32)
        Me.lblTimeNow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(109, 25)
        Me.lblTimeNow.TabIndex = 36
        Me.lblTimeNow.Text = "Time Today"
        '
        'lblDateNow
        '
        Me.lblDateNow.AutoSize = True
        Me.lblDateNow.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblDateNow.ForeColor = System.Drawing.Color.Black
        Me.lblDateNow.Location = New System.Drawing.Point(10, 86)
        Me.lblDateNow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateNow.Name = "lblDateNow"
        Me.lblDateNow.Size = New System.Drawing.Size(95, 25)
        Me.lblDateNow.TabIndex = 35
        Me.lblDateNow.Text = "Date Now"
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "h:mm tt"
        Me.dtpTime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(14, 28)
        Me.dtpTime.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(164, 32)
        Me.dtpTime.TabIndex = 29
        Me.dtpTime.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 28)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 2)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 28)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Time"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl1.Location = New System.Drawing.Point(2, 6)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(210, 227)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(202, 189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Label11)
        Me.Panel11.Controls.Add(Me.txtCN)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Controls.Add(Me.txtName)
        Me.Panel11.Controls.Add(Me.rdbFemale)
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Controls.Add(Me.Label2)
        Me.Panel11.Controls.Add(Me.rdbMale)
        Me.Panel11.Location = New System.Drawing.Point(4, 5)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(194, 180)
        Me.Panel11.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(2, 7)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 18)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "*"
        '
        'txtCN
        '
        Me.txtCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCN.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtCN.ForeColor = System.Drawing.Color.Black
        Me.txtCN.Location = New System.Drawing.Point(14, 142)
        Me.txtCN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(163, 32)
        Me.txtCN.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 28)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Contact No"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(14, 32)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 32)
        Me.txtName.TabIndex = 30
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.BackColor = System.Drawing.Color.Transparent
        Me.rdbFemale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbFemale.ForeColor = System.Drawing.Color.Black
        Me.rdbFemale.Location = New System.Drawing.Point(87, 85)
        Me.rdbFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(90, 29)
        Me.rdbFemale.TabIndex = 33
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 28)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Sex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 28)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Name"
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.BackColor = System.Drawing.Color.Transparent
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbMale.ForeColor = System.Drawing.Color.Black
        Me.rdbMale.Location = New System.Drawing.Point(15, 85)
        Me.rdbMale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 29)
        Me.rdbMale.TabIndex = 32
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = False
        '
        'frmAddAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContainer.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.panelGv.ResumeLayout(False)
        Me.panelGv.PerformLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTotalAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerWalkin As Timer
    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelContainer As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNewCustomer As Button
    Friend WithEvents btnAddservice As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBrowseCustomer As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents panelGv As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents gvView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewLinkColumn
    Friend WithEvents nudTotalAmount As NumericUpDown
    Friend WithEvents rdbReservation As RadioButton
    Friend WithEvents rdbWalkin As RadioButton
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblTimeNow As Label
    Friend WithEvents lblDateNow As Label
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbMale As RadioButton
End Class
