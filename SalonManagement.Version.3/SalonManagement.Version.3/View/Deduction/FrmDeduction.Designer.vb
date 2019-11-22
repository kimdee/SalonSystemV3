<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeduction
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.gvView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.paneSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnAddDeduction = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblmanage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMain.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        Me.panelGv.SuspendLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.paneSearch.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.panelTop)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1085, 715)
        Me.panelMain.TabIndex = 0
        '
        'panelContainer
        '
        Me.panelContainer.Controls.Add(Me.panelGv)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 63)
        Me.panelContainer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1085, 605)
        Me.panelContainer.TabIndex = 4
        '
        'panelGv
        '
        Me.panelGv.BackColor = System.Drawing.Color.White
        Me.panelGv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGv.Controls.Add(Me.Label2)
        Me.panelGv.Controls.Add(Me.lblResult)
        Me.panelGv.Controls.Add(Me.gvView)
        Me.panelGv.Controls.Add(Me.Panel1)
        Me.panelGv.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.panelGv.Location = New System.Drawing.Point(11, 5)
        Me.panelGv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelGv.Name = "panelGv"
        Me.panelGv.Size = New System.Drawing.Size(1063, 595)
        Me.panelGv.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(844, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 28)
        Me.Label2.TabIndex = 293
        Me.Label2.Text = "Option"
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
        Me.lblResult.TabIndex = 292
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
        Me.gvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.gvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvView.EnableHeadersVisualStyles = False
        Me.gvView.Location = New System.Drawing.Point(0, 50)
        Me.gvView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.gvView.TabIndex = 291
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
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 600
        '
        'Column5
        '
        Me.Column5.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.Column5.HeaderText = ""
        Me.Column5.LinkColor = System.Drawing.Color.DodgerBlue
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.VisitedLinkColor = System.Drawing.Color.DodgerBlue
        '
        'Column6
        '
        Me.Column6.ActiveLinkColor = System.Drawing.Color.Crimson
        Me.Column6.HeaderText = ""
        Me.Column6.LinkColor = System.Drawing.Color.Crimson
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.VisitedLinkColor = System.Drawing.Color.Crimson
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.paneSearch)
        Me.Panel1.Controls.Add(Me.btnAddDeduction)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 50)
        Me.Panel1.TabIndex = 290
        '
        'paneSearch
        '
        Me.paneSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.paneSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneSearch.Controls.Add(Me.lblSearch)
        Me.paneSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.paneSearch.ForeColor = System.Drawing.Color.White
        Me.paneSearch.Location = New System.Drawing.Point(976, 8)
        Me.paneSearch.Name = "paneSearch"
        Me.paneSearch.Size = New System.Drawing.Size(81, 32)
        Me.paneSearch.TabIndex = 43
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
        'btnAddDeduction
        '
        Me.btnAddDeduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAddDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDeduction.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.btnAddDeduction.ForeColor = System.Drawing.Color.White
        Me.btnAddDeduction.Location = New System.Drawing.Point(7, 5)
        Me.btnAddDeduction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddDeduction.Name = "btnAddDeduction"
        Me.btnAddDeduction.Size = New System.Drawing.Size(229, 39)
        Me.btnAddDeduction.TabIndex = 26
        Me.btnAddDeduction.Text = "New Deduction"
        Me.btnAddDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDeduction.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(701, 8)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 32)
        Me.txtSearch.TabIndex = 42
        Me.txtSearch.Text = "Search Deduction"
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
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelTop.Controls.Add(Me.PictureBox2)
        Me.panelTop.Controls.Add(Me.lblmanage)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1085, 63)
        Me.panelTop.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.SalonManagement.Version._3.My.Resources.Resources.bill__1_
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'lblmanage
        '
        Me.lblmanage.AutoSize = True
        Me.lblmanage.BackColor = System.Drawing.Color.Transparent
        Me.lblmanage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.lblmanage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblmanage.Location = New System.Drawing.Point(70, 11)
        Me.lblmanage.Name = "lblmanage"
        Me.lblmanage.Size = New System.Drawing.Size(306, 39)
        Me.lblmanage.TabIndex = 4
        Me.lblmanage.Text = "Manage Deduction"
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
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'FrmDeduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1085, 715)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDeduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1447, 880"
        Me.panelMain.ResumeLayout(False)
        Me.panelContainer.ResumeLayout(False)
        Me.panelGv.ResumeLayout(False)
        Me.panelGv.PerformLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.paneSearch.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblmanage As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelContainer As System.Windows.Forms.Panel
    Friend WithEvents panelGv As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents paneSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnAddDeduction As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents gvView As System.Windows.Forms.DataGridView
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewLinkColumn
End Class
