<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadPasscode
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPasscode = New System.Windows.Forms.TextBox()
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMain.Controls.Add(Me.btnCancel)
        Me.panelMain.Controls.Add(Me.Label6)
        Me.panelMain.Controls.Add(Me.txtPasscode)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(353, 132)
        Me.panelMain.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(79, 84)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(194, 37)
        Me.btnCancel.TabIndex = 135
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(92, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 25)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "ENTER PASSCODE"
        '
        'txtPasscode
        '
        Me.txtPasscode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasscode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPasscode.ForeColor = System.Drawing.Color.DimGray
        Me.txtPasscode.Location = New System.Drawing.Point(29, 51)
        Me.txtPasscode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasscode.Name = "txtPasscode"
        Me.txtPasscode.Size = New System.Drawing.Size(294, 29)
        Me.txtPasscode.TabIndex = 67
        Me.txtPasscode.Text = "ENTER PASSCODE"
        Me.txtPasscode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPasscode.UseSystemPasswordChar = True
        '
        'frmReadPasscode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 132)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReadPasscode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPasscode As TextBox
    Friend WithEvents btnCancel As Button
End Class
