<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmService
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
        Me.Column6 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.panelbl = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblmanage = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        Me.panelContainer.SuspendLayout()
        Me.panelGv.SuspendLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.panelbl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelContainer)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1085, 715)
        Me.panelMain.TabIndex = 0
        '
        'panelContainer
        '
        Me.panelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panelContainer.Controls.Add(Me.panelGv)
        Me.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContainer.Location = New System.Drawing.Point(0, 63)
        Me.panelContainer.Name = "panelContainer"
        Me.panelContainer.Size = New System.Drawing.Size(1085, 605)
        Me.panelContainer.TabIndex = 4
        '
        'panelGv
        '
        Me.panelGv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.panelGv.TabIndex = 2
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(432, 307)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(196, 28)
        Me.lblResult.TabIndex = 49
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
        Me.gvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
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
        Me.gvView.TabIndex = 48
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
        Me.Column2.HeaderText = "No."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.Column6.HeaderText = ""
        Me.Column6.LinkColor = System.Drawing.Color.DodgerBlue
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.VisitedLinkColor = System.Drawing.Color.DodgerBlue
        '
        'Column7
        '
        Me.Column7.ActiveLinkColor = System.Drawing.Color.Crimson
        Me.Column7.HeaderText = ""
        Me.Column7.LinkColor = System.Drawing.Color.Crimson
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.VisitedLinkColor = System.Drawing.Color.Crimson
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.panelbl)
        Me.panelTop.Controls.Add(Me.btnAddService)
        Me.panelTop.Controls.Add(Me.txtSearch)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1061, 50)
        Me.panelTop.TabIndex = 31
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
        Me.panelbl.TabIndex = 43
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
        'btnAddService
        '
        Me.btnAddService.BackColor = System.Drawing.Color.Transparent
        Me.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddService.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.btnAddService.ForeColor = System.Drawing.Color.Black
        Me.btnAddService.Location = New System.Drawing.Point(7, 5)
        Me.btnAddService.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(229, 39)
        Me.btnAddService.TabIndex = 26
        Me.btnAddService.Text = "New Service"
        Me.btnAddService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddService.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Location = New System.Drawing.Point(701, 8)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 32)
        Me.txtSearch.TabIndex = 42
        Me.txtSearch.Text = "Search Customer"
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
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblmanage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 63)
        Me.Panel1.TabIndex = 2
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
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.SalonManagement.Version._3.My.Resources.Resources.cart
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'lblmanage
        '
        Me.lblmanage.AutoSize = True
        Me.lblmanage.BackColor = System.Drawing.Color.Transparent
        Me.lblmanage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.lblmanage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblmanage.Location = New System.Drawing.Point(70, 12)
        Me.lblmanage.Name = "lblmanage"
        Me.lblmanage.Size = New System.Drawing.Size(267, 39)
        Me.lblmanage.TabIndex = 3
        Me.lblmanage.Text = "Manage Service"
        '
        'FrmService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1085, 715)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmService"
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelContainer As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblmanage As Label
    Friend WithEvents panelGv As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents panelbl As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnAddService As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents gvView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewLinkColumn
    Friend WithEvents Column7 As DataGridViewLinkColumn
End Class
