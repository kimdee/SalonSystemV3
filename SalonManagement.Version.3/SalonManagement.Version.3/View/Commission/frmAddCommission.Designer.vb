﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCommission
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.panelMain.Size = New System.Drawing.Size(345, 255)
        Me.panelMain.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 33)
        Me.Panel2.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, -22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 37)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "COMMISSION SETTING"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(345, 35)
        Me.panelTop.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "COMMISSION SETTING"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.SalonManagement.Version._3.My.Resources.Resources.x_button1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(324, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(11, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 171)
        Me.Panel1.TabIndex = 18
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtAmount.Location = New System.Drawing.Point(135, 45)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 32)
        Me.txtAmount.TabIndex = 38
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(21, 114)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 32)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Add"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(147, 114)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 32)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Close"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(35, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "In Percent %"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Commission"
        '
        'frmAddCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(345, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddCommission"
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
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
