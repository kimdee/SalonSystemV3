<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelContianers = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.txtStandardPay = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBasicPays = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureNoImage = New System.Windows.Forms.PictureBox()
        Me.PictureImage = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureShowPasword = New System.Windows.Forms.PictureBox()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.txtPasscode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMain.SuspendLayout()
        Me.panelContianers.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureNoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureShowPasword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelContianers)
        Me.panelMain.Controls.Add(Me.Panel9)
        Me.panelMain.Controls.Add(Me.Panel10)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(769, 583)
        Me.panelMain.TabIndex = 0
        '
        'panelContianers
        '
        Me.panelContianers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContianers.Controls.Add(Me.Panel4)
        Me.panelContianers.Controls.Add(Me.Panel1)
        Me.panelContianers.Location = New System.Drawing.Point(12, 73)
        Me.panelContianers.Name = "panelContianers"
        Me.panelContianers.Size = New System.Drawing.Size(745, 498)
        Me.panelContianers.TabIndex = 95
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.btnSearch)
        Me.Panel4.Controls.Add(Me.btnNew)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnDelete)
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnEdit)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel4.Location = New System.Drawing.Point(527, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 492)
        Me.Panel4.TabIndex = 94
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(10, 32)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(194, 47)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(10, 134)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(194, 47)
        Me.btnNew.TabIndex = 23
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(10, 286)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(194, 47)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(10, 236)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(194, 47)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(10, 431)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(194, 47)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(10, 336)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(194, 47)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(10, 185)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(194, 47)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.TabControl3)
        Me.Panel1.Controls.Add(Me.TabControl2)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 492)
        Me.Panel1.TabIndex = 93
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl3.Location = New System.Drawing.Point(253, 218)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(263, 263)
        Me.TabControl3.TabIndex = 87
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(255, 225)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Role Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.txtOT)
        Me.Panel3.Controls.Add(Me.txtStandardPay)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txtBasicPays)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.cboPosition)
        Me.Panel3.Location = New System.Drawing.Point(4, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(247, 217)
        Me.Panel3.TabIndex = 0
        '
        'txtOT
        '
        Me.txtOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOT.Enabled = False
        Me.txtOT.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtOT.ForeColor = System.Drawing.Color.Black
        Me.txtOT.Location = New System.Drawing.Point(12, 130)
        Me.txtOT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(206, 29)
        Me.txtOT.TabIndex = 94
        '
        'txtStandardPay
        '
        Me.txtStandardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStandardPay.Enabled = False
        Me.txtStandardPay.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtStandardPay.ForeColor = System.Drawing.Color.Black
        Me.txtStandardPay.Location = New System.Drawing.Point(12, 80)
        Me.txtStandardPay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStandardPay.Name = "txtStandardPay"
        Me.txtStandardPay.Size = New System.Drawing.Size(206, 29)
        Me.txtStandardPay.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 20)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Standard  Pay (Per Day)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 108)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 20)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Overtime Pay"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(10, 161)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 20)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Basic Pay (15 Days)"
        '
        'txtBasicPays
        '
        Me.txtBasicPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBasicPays.Enabled = False
        Me.txtBasicPays.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBasicPays.ForeColor = System.Drawing.Color.Black
        Me.txtBasicPays.Location = New System.Drawing.Point(14, 183)
        Me.txtBasicPays.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBasicPays.Name = "txtBasicPays"
        Me.txtBasicPays.Size = New System.Drawing.Size(206, 29)
        Me.txtBasicPays.TabIndex = 92
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(9, 3)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 28)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Position"
        '
        'cboPosition
        '
        Me.cboPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Location = New System.Drawing.Point(14, 32)
        Me.cboPosition.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(205, 29)
        Me.cboPosition.TabIndex = 88
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl2.Location = New System.Drawing.Point(253, 2)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(263, 214)
        Me.TabControl2.TabIndex = 86
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureNoImage)
        Me.TabPage3.Controls.Add(Me.PictureImage)
        Me.TabPage3.Controls.Add(Me.btnUpload)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(255, 176)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Photo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureNoImage
        '
        Me.PictureNoImage.BackColor = System.Drawing.Color.White
        Me.PictureNoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureNoImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureNoImage.Location = New System.Drawing.Point(4, 5)
        Me.PictureNoImage.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureNoImage.Name = "PictureNoImage"
        Me.PictureNoImage.Size = New System.Drawing.Size(247, 118)
        Me.PictureNoImage.TabIndex = 33
        Me.PictureNoImage.TabStop = False
        Me.PictureNoImage.Visible = False
        '
        'PictureImage
        '
        Me.PictureImage.BackColor = System.Drawing.Color.White
        Me.PictureImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureImage.Location = New System.Drawing.Point(4, 5)
        Me.PictureImage.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureImage.Name = "PictureImage"
        Me.PictureImage.Size = New System.Drawing.Size(247, 118)
        Me.PictureImage.TabIndex = 2
        Me.PictureImage.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(4, 127)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(247, 47)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(251, 480)
        Me.TabControl1.TabIndex = 84
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(243, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.PictureShowPasword)
        Me.Panel2.Controls.Add(Me.txtCN)
        Me.Panel2.Controls.Add(Me.txtPasscode)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtAge)
        Me.Panel2.Controls.Add(Me.dtpDob)
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Controls.Add(Me.txtMName)
        Me.Panel2.Controls.Add(Me.txtFName)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtLName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(4, 5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 433)
        Me.Panel2.TabIndex = 0
        '
        'PictureShowPasword
        '
        Me.PictureShowPasword.BackColor = System.Drawing.Color.Transparent
        Me.PictureShowPasword.BackgroundImage = CType(resources.GetObject("PictureShowPasword.BackgroundImage"), System.Drawing.Image)
        Me.PictureShowPasword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureShowPasword.Location = New System.Drawing.Point(193, 359)
        Me.PictureShowPasword.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureShowPasword.Name = "PictureShowPasword"
        Me.PictureShowPasword.Size = New System.Drawing.Size(28, 26)
        Me.PictureShowPasword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureShowPasword.TabIndex = 119
        Me.PictureShowPasword.TabStop = False
        '
        'txtCN
        '
        Me.txtCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCN.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtCN.Location = New System.Drawing.Point(15, 327)
        Me.txtCN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(206, 32)
        Me.txtCN.TabIndex = 118
        '
        'txtPasscode
        '
        Me.txtPasscode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasscode.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtPasscode.Location = New System.Drawing.Point(15, 385)
        Me.txtPasscode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasscode.Name = "txtPasscode"
        Me.txtPasscode.Size = New System.Drawing.Size(206, 32)
        Me.txtPasscode.TabIndex = 117
        Me.txtPasscode.UseSystemPasswordChar = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 361)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 28)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Passcode"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtAge.Location = New System.Drawing.Point(187, 210)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(34, 32)
        Me.txtAge.TabIndex = 115
        '
        'dtpDob
        '
        Me.dtpDob.CustomFormat = "MM/dd/yy"
        Me.dtpDob.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDob.Location = New System.Drawing.Point(15, 210)
        Me.dtpDob.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(120, 32)
        Me.dtpDob.TabIndex = 114
        Me.dtpDob.Value = New Date(2019, 1, 20, 0, 0, 0, 0)
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbFemale.ForeColor = System.Drawing.Color.Black
        Me.rdbFemale.Location = New System.Drawing.Point(108, 269)
        Me.rdbFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(90, 29)
        Me.rdbFemale.TabIndex = 111
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbMale.ForeColor = System.Drawing.Color.Black
        Me.rdbMale.Location = New System.Drawing.Point(15, 269)
        Me.rdbMale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 29)
        Me.rdbMale.TabIndex = 110
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'txtMName
        '
        Me.txtMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtMName.Location = New System.Drawing.Point(18, 152)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(203, 32)
        Me.txtMName.TabIndex = 109
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtFName.Location = New System.Drawing.Point(15, 93)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(206, 32)
        Me.txtFName.TabIndex = 108
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(139, 211)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 28)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 185)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 28)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Birthdate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 300)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 28)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Contact No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 243)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 28)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 28)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 28)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "First Name"
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtLName.Location = New System.Drawing.Point(15, 35)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(206, 32)
        Me.txtLName.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Last Name"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label15)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 33)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(769, 35)
        Me.Panel9.TabIndex = 93
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(250, -24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(265, 46)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "NEW EMPLOYEE"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Controls.Add(Me.PictureBox1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(769, 33)
        Me.Panel10.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(250, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 46)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "NEW EMPLOYEE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(748, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(769, 583)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.panelContianers.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureNoImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureShowPasword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContainer As Panel
    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelContianers As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtOT As TextBox
    Friend WithEvents txtStandardPay As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBasicPays As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureNoImage As PictureBox
    Friend WithEvents PictureImage As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureShowPasword As PictureBox
    Friend WithEvents txtCN As TextBox
    Friend WithEvents txtPasscode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
End Class
