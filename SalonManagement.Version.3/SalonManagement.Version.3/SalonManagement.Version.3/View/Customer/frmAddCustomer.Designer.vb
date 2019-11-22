<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddCustomer
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.panelMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.panelTop)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(295, 325)
        Me.panelMain.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(295, 33)
        Me.Panel2.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, -26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NEW CUSTOMER"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Label3)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(295, 35)
        Me.panelTop.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 37)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "NEW CUSTOMER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(274, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.txtCN)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.rdbFemale)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rdbMale)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(11, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 241)
        Me.Panel1.TabIndex = 15
        '
        'txtCN
        '
        Me.txtCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCN.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtCN.ForeColor = System.Drawing.Color.DimGray
        Me.txtCN.Location = New System.Drawing.Point(19, 141)
        Me.txtCN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(248, 34)
        Me.txtCN.TabIndex = 45
        Me.txtCN.Text = "0000-000-0000"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(2, 13)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 18)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 28)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Contact No"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtName.ForeColor = System.Drawing.Color.DimGray
        Me.txtName.Location = New System.Drawing.Point(20, 38)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 34)
        Me.txtName.TabIndex = 42
        Me.txtName.Text = "Customer"
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.BackColor = System.Drawing.Color.Transparent
        Me.rdbFemale.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.rdbFemale.ForeColor = System.Drawing.Color.Black
        Me.rdbFemale.Location = New System.Drawing.Point(107, 89)
        Me.rdbFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(92, 32)
        Me.rdbFemale.TabIndex = 44
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 25)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 28)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Name"
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.BackColor = System.Drawing.Color.Transparent
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.rdbMale.ForeColor = System.Drawing.Color.Black
        Me.rdbMale.Location = New System.Drawing.Point(20, 89)
        Me.rdbMale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(73, 32)
        Me.rdbMale.TabIndex = 43
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(19, 189)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 32)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "OK"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(145, 189)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 32)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(295, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
