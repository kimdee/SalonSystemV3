<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConnectionFirst
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
        Me.panelContianer = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMain.SuspendLayout()
        Me.panelContianer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.panelContianer)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Controls.Add(Me.panelTop)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(294, 444)
        Me.panelMain.TabIndex = 1
        '
        'panelContianer
        '
        Me.panelContianer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelContianer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContianer.Controls.Add(Me.btnClose)
        Me.panelContianer.Controls.Add(Me.Label2)
        Me.panelContianer.Controls.Add(Me.txtPort)
        Me.panelContianer.Controls.Add(Me.btnTest)
        Me.panelContianer.Controls.Add(Me.Label6)
        Me.panelContianer.Controls.Add(Me.txtUserName)
        Me.panelContianer.Controls.Add(Me.txtDB)
        Me.panelContianer.Controls.Add(Me.Label3)
        Me.panelContianer.Controls.Add(Me.txtHost)
        Me.panelContianer.Controls.Add(Me.Label4)
        Me.panelContianer.Controls.Add(Me.Label5)
        Me.panelContianer.Controls.Add(Me.txtPw)
        Me.panelContianer.Location = New System.Drawing.Point(11, 73)
        Me.panelContianer.Margin = New System.Windows.Forms.Padding(2)
        Me.panelContianer.Name = "panelContianer"
        Me.panelContianer.Size = New System.Drawing.Size(272, 360)
        Me.panelContianer.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(138, 316)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 32)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Host Name / IP Address / PC Name"
        '
        'txtPort
        '
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPort.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtPort.Location = New System.Drawing.Point(10, 93)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(250, 33)
        Me.txtPort.TabIndex = 2
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.Location = New System.Drawing.Point(10, 316)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(122, 32)
        Me.btnTest.TabIndex = 6
        Me.btnTest.Text = "CONNECT"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(5, 252)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtUserName.Location = New System.Drawing.Point(10, 217)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(250, 33)
        Me.txtUserName.TabIndex = 4
        '
        'txtDB
        '
        Me.txtDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDB.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtDB.Location = New System.Drawing.Point(10, 155)
        Me.txtDB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(250, 33)
        Me.txtDB.TabIndex = 3
        Me.txtDB.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Port No."
        '
        'txtHost
        '
        Me.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHost.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtHost.Location = New System.Drawing.Point(10, 31)
        Me.txtHost.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(247, 33)
        Me.txtHost.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(5, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Database Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username"
        '
        'txtPw
        '
        Me.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPw.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtPw.Location = New System.Drawing.Point(10, 279)
        Me.txtPw.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(250, 33)
        Me.txtPw.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 33)
        Me.Panel1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, -19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DATABASE CONNECTION"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(294, 35)
        Me.panelTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 30)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "DATABASE CONNECTION"
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
        'frmConnectionFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConnectionFirst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.panelContianer.ResumeLayout(False)
        Me.panelContianer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents panelTop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelContianer As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtDB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPw As TextBox
End Class
