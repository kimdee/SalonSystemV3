<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyProfile
    Inherits System.Windows.Forms.Form

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRetype = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMain.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 35)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(272, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MY PROFILE"
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(293, 389)
        Me.panelMain.TabIndex = 1
        '
        'panelContainer
        '
        Me.panelContainer.Controls.Add(Me.Panel3)
        Me.panelContainer.Controls.Add(Me.Panel2)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 35)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(293, 354)
        Me.panelContainer.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 33)
        Me.Panel3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, -28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 46)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "MY PROFILE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.lblRole)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.txtPw)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtRetype)
        Me.Panel2.Location = New System.Drawing.Point(12, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 303)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 28)
        Me.Label3.TabIndex = 289
        Me.Label3.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtUsername.Location = New System.Drawing.Point(13, 89)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(188, 34)
        Me.txtUsername.TabIndex = 290
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(132, 37)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(126, 25)
        Me.lblRole.TabIndex = 288
        Me.lblRole.Text = "Account Role"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(68, 9)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 25)
        Me.lblName.TabIndex = 287
        Me.lblName.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 28)
        Me.Label2.TabIndex = 286
        Me.Label2.Text = "Account Role: "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(8, 5)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 28)
        Me.Label23.TabIndex = 285
        Me.Label23.Text = "Name: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 28)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Password"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(136, 255)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 32)
        Me.btnCancel.TabIndex = 284
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtPw
        '
        Me.txtPw.Enabled = False
        Me.txtPw.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtPw.Location = New System.Drawing.Point(13, 153)
        Me.txtPw.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(188, 34)
        Me.txtPw.TabIndex = 280
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(10, 255)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 32)
        Me.btnSave.TabIndex = 283
        Me.btnSave.Text = "UPDATE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 189)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 28)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Retype Password"
        '
        'txtRetype
        '
        Me.txtRetype.Enabled = False
        Me.txtRetype.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtRetype.Location = New System.Drawing.Point(13, 217)
        Me.txtRetype.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Size = New System.Drawing.Size(188, 34)
        Me.txtRetype.TabIndex = 282
        '
        'frmMyProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmMyProfile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMain.ResumeLayout(False)
        Me.panelContainer.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelContainer As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtPw As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
