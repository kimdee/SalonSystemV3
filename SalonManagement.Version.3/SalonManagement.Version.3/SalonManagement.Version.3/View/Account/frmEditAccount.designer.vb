<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditAccount
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
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.txtRetype = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContainer
        '
        Me.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContainer.Controls.Add(Me.txtRetype)
        Me.panelContainer.Controls.Add(Me.Label7)
        Me.panelContainer.Controls.Add(Me.Label2)
        Me.panelContainer.Controls.Add(Me.btnCancel)
        Me.panelContainer.Controls.Add(Me.txtName)
        Me.panelContainer.Controls.Add(Me.btnSave)
        Me.panelContainer.Controls.Add(Me.Label3)
        Me.panelContainer.Controls.Add(Me.txtPw)
        Me.panelContainer.Controls.Add(Me.txtLastName)
        Me.panelContainer.Controls.Add(Me.Label6)
        Me.panelContainer.Controls.Add(Me.Label4)
        Me.panelContainer.Controls.Add(Me.txtUserName)
        Me.panelContainer.Controls.Add(Me.cboPosition)
        Me.panelContainer.Controls.Add(Me.Label5)
        Me.panelContainer.Location = New System.Drawing.Point(11, 77)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(273, 423)
        Me.panelContainer.TabIndex = 12
        '
        'txtRetype
        '
        Me.txtRetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRetype.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetype.Location = New System.Drawing.Point(11, 345)
        Me.txtRetype.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Size = New System.Drawing.Size(247, 33)
        Me.txtRetype.TabIndex = 15
        Me.txtRetype.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 318)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Re-Type Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(137, 382)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 32)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtName.Location = New System.Drawing.Point(11, 35)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 33)
        Me.txtName.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(11, 382)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 32)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "UPDATE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'txtPw
        '
        Me.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPw.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtPw.Location = New System.Drawing.Point(11, 283)
        Me.txtPw.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(247, 33)
        Me.txtPw.TabIndex = 9
        Me.txtPw.UseSystemPasswordChar = True
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtLastName.Location = New System.Drawing.Point(11, 97)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(247, 33)
        Me.txtLastName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 256)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Position"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtUserName.Location = New System.Drawing.Point(11, 221)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(247, 33)
        Me.txtUserName.TabIndex = 7
        '
        'cboPosition
        '
        Me.cboPosition.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Administrator", "Clerk", "Cashier"})
        Me.cboPosition.Location = New System.Drawing.Point(11, 159)
        Me.cboPosition.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(247, 33)
        Me.cboPosition.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 33)
        Me.Panel1.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, -26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 46)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "EDIT ACCOUNT"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(295, 35)
        Me.panelTop.TabIndex = 16
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 46)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "EDIT ACCOUNT"
        '
        'frmEditAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(295, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmEditAccount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelContainer.ResumeLayout(False)
        Me.panelContainer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContainer As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPw As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
End Class
