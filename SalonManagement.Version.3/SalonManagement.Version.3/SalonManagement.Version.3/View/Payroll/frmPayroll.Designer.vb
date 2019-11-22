<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayroll
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelContainer = New System.Windows.Forms.Panel()
        Me.panelGv = New System.Windows.Forms.Panel()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.gvView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnGeneratePayroll = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelbl = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblEmploy = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        Me.panelGv.SuspendLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.panelbl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1085, 715)
        Me.panelMain.TabIndex = 0
        '
        'panelContainer
        '
        Me.panelContainer.Controls.Add(Me.panelGv)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 63)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1085, 605)
        Me.panelContainer.TabIndex = 4
        '
        'panelGv
        '
        Me.panelGv.BackColor = System.Drawing.Color.White
        Me.panelGv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGv.Controls.Add(Me.lblResult)
        Me.panelGv.Controls.Add(Me.gvView)
        Me.panelGv.Controls.Add(Me.panelTop)
        Me.panelGv.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.panelGv.Location = New System.Drawing.Point(11, 5)
        Me.panelGv.Margin = New System.Windows.Forms.Padding(2)
        Me.panelGv.Name = "panelGv"
        Me.panelGv.Size = New System.Drawing.Size(1063, 595)
        Me.panelGv.TabIndex = 29
        '
        'lblResult
        '
        Me.lblResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblResult.Location = New System.Drawing.Point(432, 307)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(196, 28)
        Me.lblResult.TabIndex = 293
        Me.lblResult.Text = "NO RESULT FOUND"
        '
        'gvView
        '
        Me.gvView.AllowUserToAddRows = False
        Me.gvView.AllowUserToDeleteRows = False
        Me.gvView.AllowUserToResizeColumns = False
        Me.gvView.AllowUserToResizeRows = False
        Me.gvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvView.BackgroundColor = System.Drawing.Color.White
        Me.gvView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvView.ColumnHeadersHeight = 35
        Me.gvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.gvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvView.EnableHeadersVisualStyles = False
        Me.gvView.Location = New System.Drawing.Point(0, 50)
        Me.gvView.Margin = New System.Windows.Forms.Padding(2)
        Me.gvView.Name = "gvView"
        Me.gvView.ReadOnly = True
        Me.gvView.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.gvView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvView.RowTemplate.Height = 24
        Me.gvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvView.Size = New System.Drawing.Size(1061, 543)
        Me.gvView.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "No."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Deduction"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "Commission"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 155
        '
        'Column6
        '
        Me.Column6.HeaderText = "Overtime"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Gross Pay"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Net Pay"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Date"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Time"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.Column11.HeaderText = ""
        Me.Column11.LinkColor = System.Drawing.Color.DodgerBlue
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.VisitedLinkColor = System.Drawing.Color.DodgerBlue
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.btnGeneratePayroll)
        Me.panelTop.Controls.Add(Me.DateTimePicker2)
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Controls.Add(Me.DateTimePicker1)
        Me.panelTop.Controls.Add(Me.Label4)
        Me.panelTop.Controls.Add(Me.panelbl)
        Me.panelTop.Controls.Add(Me.txtSearch)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(2)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1061, 50)
        Me.panelTop.TabIndex = 28
        '
        'btnGeneratePayroll
        '
        Me.btnGeneratePayroll.BackColor = System.Drawing.Color.Transparent
        Me.btnGeneratePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePayroll.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.btnGeneratePayroll.ForeColor = System.Drawing.Color.Black
        Me.btnGeneratePayroll.Location = New System.Drawing.Point(7, 5)
        Me.btnGeneratePayroll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGeneratePayroll.Name = "btnGeneratePayroll"
        Me.btnGeneratePayroll.Size = New System.Drawing.Size(229, 39)
        Me.btnGeneratePayroll.TabIndex = 56
        Me.btnGeneratePayroll.Text = "Generate Payroll"
        Me.btnGeneratePayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneratePayroll.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(475, 8)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(133, 32)
        Me.DateTimePicker2.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(438, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(301, 8)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 32)
        Me.DateTimePicker1.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(240, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "From"
        '
        'panelbl
        '
        Me.panelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbl.Controls.Add(Me.lblSearch)
        Me.panelbl.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.panelbl.Location = New System.Drawing.Point(977, 8)
        Me.panelbl.Name = "panelbl"
        Me.panelbl.Size = New System.Drawing.Size(81, 32)
        Me.panelbl.TabIndex = 45
        '
        'lblSearch
        '
        Me.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblSearch.Location = New System.Drawing.Point(0, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(79, 30)
        Me.lblSearch.TabIndex = 42
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(731, 8)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 32)
        Me.txtSearch.TabIndex = 44
        Me.txtSearch.Text = "Search Employee"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 668)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 47)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblEmploy)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 63)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.SalonManagement.Version._3.My.Resources.Resources.cost
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.SalonManagement.Version._3.My.Resources.Resources.exit_door
        Me.PictureBox1.Location = New System.Drawing.Point(1034, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblEmploy
        '
        Me.lblEmploy.AutoSize = True
        Me.lblEmploy.BackColor = System.Drawing.Color.Transparent
        Me.lblEmploy.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmploy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblEmploy.Location = New System.Drawing.Point(76, 11)
        Me.lblEmploy.Name = "lblEmploy"
        Me.lblEmploy.Size = New System.Drawing.Size(277, 39)
        Me.lblEmploy.TabIndex = 4
        Me.lblEmploy.Text = "Generate Payroll"
        '
        'FrmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1085, 715)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPayroll"
        Me.panelMain.ResumeLayout(False)
        Me.panelContainer.ResumeLayout(False)
        Me.panelGv.ResumeLayout(False)
        Me.panelGv.PerformLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.panelbl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmploy As System.Windows.Forms.Label
    Friend WithEvents panelContainer As System.Windows.Forms.Panel
    Friend WithEvents panelGv As System.Windows.Forms.Panel
    Friend WithEvents gvView As System.Windows.Forms.DataGridView
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents btnGeneratePayroll As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panelbl As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewLinkColumn
    Friend WithEvents lblResult As Label
End Class
