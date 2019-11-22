<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttendanceTimein
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
        Me.components = New System.ComponentModel.Container()
        Me.timerAttendance = New System.Windows.Forms.Timer(Me.components)
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTodayDate = New System.Windows.Forms.Label()
        Me.txtPasscode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTodayTime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMain.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerAttendance
        '
        Me.timerAttendance.Enabled = True
        Me.timerAttendance.Interval = 1000
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1137, 721)
        Me.panelMain.TabIndex = 0
        '
        'panelContainer
        '
        Me.panelContainer.Controls.Add(Me.PictureBox2)
        Me.panelContainer.Controls.Add(Me.lblTodayDate)
        Me.panelContainer.Controls.Add(Me.txtPasscode)
        Me.panelContainer.Controls.Add(Me.Label1)
        Me.panelContainer.Controls.Add(Me.lblTodayTime)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 96)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1137, 554)
        Me.panelContainer.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SalonManagement.Version._3.My.Resources.Resources.comb1
        Me.PictureBox2.Location = New System.Drawing.Point(435, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(267, 196)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'lblTodayDate
        '
        Me.lblTodayDate.AutoSize = True
        Me.lblTodayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayDate.ForeColor = System.Drawing.Color.Red
        Me.lblTodayDate.Location = New System.Drawing.Point(228, 214)
        Me.lblTodayDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTodayDate.Name = "lblTodayDate"
        Me.lblTodayDate.Size = New System.Drawing.Size(636, 58)
        Me.lblTodayDate.TabIndex = 17
        Me.lblTodayDate.Text = "Saturday, Monday 4, 2020"
        Me.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPasscode
        '
        Me.txtPasscode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasscode.Location = New System.Drawing.Point(233, 459)
        Me.txtPasscode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPasscode.Name = "txtPasscode"
        Me.txtPasscode.Size = New System.Drawing.Size(668, 41)
        Me.txtPasscode.TabIndex = 16
        Me.txtPasscode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPasscode.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(424, 410)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 54)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enter Passcode"
        '
        'lblTodayTime
        '
        Me.lblTodayTime.AutoSize = True
        Me.lblTodayTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 75.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayTime.ForeColor = System.Drawing.Color.Red
        Me.lblTodayTime.Location = New System.Drawing.Point(149, 271)
        Me.lblTodayTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTodayTime.Name = "lblTodayTime"
        Me.lblTodayTime.Size = New System.Drawing.Size(781, 142)
        Me.lblTodayTime.TabIndex = 14
        Me.lblTodayTime.Text = "44:46:00 AM"
        Me.lblTodayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 650)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1137, 71)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1137, 96)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(1109, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.Location = New System.Drawing.Point(1759, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmAttendanceTimein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 721)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAttendanceTimein"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAttendance"
        Me.panelMain.ResumeLayout(False)
        Me.panelContainer.ResumeLayout(False)
        Me.panelContainer.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerAttendance As Timer
    Friend WithEvents panelMain As Panel
    Friend WithEvents panelContainer As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTodayDate As Label
    Friend WithEvents txtPasscode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTodayTime As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
