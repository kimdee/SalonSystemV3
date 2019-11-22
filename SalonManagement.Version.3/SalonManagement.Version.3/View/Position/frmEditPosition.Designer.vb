<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPosition
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.txtStandardPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBasicPays = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.panelTop)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(295, 399)
        Me.panelMain.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtOT)
        Me.Panel1.Controls.Add(Me.txtStandardPay)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtBasicPays)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(11, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 315)
        Me.Panel1.TabIndex = 18
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(140, 273)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 32)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(14, 273)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 32)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Update"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(2, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 18)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "*"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(2, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 18)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 28)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Position Name"
        '
        'txtOT
        '
        Me.txtOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOT.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtOT.ForeColor = System.Drawing.Color.Black
        Me.txtOT.Location = New System.Drawing.Point(14, 164)
        Me.txtOT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(248, 32)
        Me.txtOT.TabIndex = 53
        Me.txtOT.Text = "0"
        '
        'txtStandardPay
        '
        Me.txtStandardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStandardPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtStandardPay.ForeColor = System.Drawing.Color.Black
        Me.txtStandardPay.Location = New System.Drawing.Point(14, 102)
        Me.txtStandardPay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStandardPay.Name = "txtStandardPay"
        Me.txtStandardPay.Size = New System.Drawing.Size(248, 32)
        Me.txtStandardPay.TabIndex = 49
        Me.txtStandardPay.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 28)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Standard  Pay (Per Day)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 28)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Overtime Pay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 28)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Basic Pay (15 Days)"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(14, 37)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(248, 32)
        Me.txtName.TabIndex = 46
        '
        'txtBasicPays
        '
        Me.txtBasicPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBasicPays.Enabled = False
        Me.txtBasicPays.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtBasicPays.ForeColor = System.Drawing.Color.Black
        Me.txtBasicPays.Location = New System.Drawing.Point(14, 229)
        Me.txtBasicPays.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBasicPays.Name = "txtBasicPays"
        Me.txtBasicPays.Size = New System.Drawing.Size(248, 32)
        Me.txtBasicPays.TabIndex = 51
        Me.txtBasicPays.Text = "0"
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
        Me.Label1.Location = New System.Drawing.Point(50, -26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "EDIT POSITION"
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
        Me.Label3.Location = New System.Drawing.Point(50, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 37)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "EDIT POSITION"
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
        'frmEditPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEditPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOT As TextBox
    Friend WithEvents txtStandardPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBasicPays As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
