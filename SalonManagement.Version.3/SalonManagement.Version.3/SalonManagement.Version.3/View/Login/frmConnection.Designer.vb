<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnection
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelMain = New System.Windows.Forms.Panel()
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
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMain.Controls.Add(Me.btnClose)
        Me.panelMain.Controls.Add(Me.Label2)
        Me.panelMain.Controls.Add(Me.txtPort)
        Me.panelMain.Controls.Add(Me.btnTest)
        Me.panelMain.Controls.Add(Me.Label6)
        Me.panelMain.Controls.Add(Me.txtUserName)
        Me.panelMain.Controls.Add(Me.txtDB)
        Me.panelMain.Controls.Add(Me.Label3)
        Me.panelMain.Controls.Add(Me.txtHost)
        Me.panelMain.Controls.Add(Me.Label4)
        Me.panelMain.Controls.Add(Me.Label5)
        Me.panelMain.Controls.Add(Me.txtPw)
        Me.panelMain.Location = New System.Drawing.Point(11, 77)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(273, 361)
        Me.panelMain.TabIndex = 3
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
        Me.btnClose.TabIndex = 11
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
        Me.txtPort.TabIndex = 3
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
        Me.btnTest.TabIndex = 10
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
        Me.txtUserName.TabIndex = 7
        '
        'txtDB
        '
        Me.txtDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDB.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtDB.Location = New System.Drawing.Point(10, 155)
        Me.txtDB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(250, 33)
        Me.txtDB.TabIndex = 5
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
        Me.txtHost.TabIndex = 0
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
        Me.txtPw.TabIndex = 9
        '
        'frmConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 449)
        Me.Controls.Add(Me.panelMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATABASE CONNECTION"
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents txtHost As TextBox
    Friend WithEvents txtPw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDB As TextBox
    Friend WithEvents btnClose As Button
End Class
