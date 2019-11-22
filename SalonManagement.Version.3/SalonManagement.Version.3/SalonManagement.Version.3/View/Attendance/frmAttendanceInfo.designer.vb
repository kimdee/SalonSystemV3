<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendanceInfo
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerTimein = New System.Windows.Forms.Timer(Me.components)
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.panelMain.Controls.Add(Me.lblTime)
        Me.panelMain.Controls.Add(Me.lblT)
        Me.panelMain.Controls.Add(Me.lblName)
        Me.panelMain.Controls.Add(Me.Label1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(379, 395)
        Me.panelMain.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(0, 279)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(379, 116)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblT
        '
        Me.lblT.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblT.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.ForeColor = System.Drawing.Color.White
        Me.lblT.Location = New System.Drawing.Point(0, 182)
        Me.lblT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(379, 97)
        Me.lblT.TabIndex = 3
        Me.lblT.Text = "Time In"
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(0, 90)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(379, 92)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "KHD"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 90)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerTimein
        '
        '
        'frmAttendanceInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 395)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAttendanceInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TimerTimein As Timer
    Friend WithEvents Label1 As Label
End Class
