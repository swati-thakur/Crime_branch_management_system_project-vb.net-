<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_post_mortem_reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_post_mortem_reports))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PostMortemReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.National_crime_record_management_systemDataSet = New crime_file_managemmet_system.National_crime_record_management_systemDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComplaintNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostMortemReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Post_Mortem_ReportsTableAdapter = New crime_file_managemmet_system.National_crime_record_management_systemDataSetTableAdapters.Post_Mortem_ReportsTableAdapter()
        CType(Me.PostMortemReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.National_crime_record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostMortemReportsBindingSource, "Complaint Number", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(176, 51)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 23)
        Me.TextBox1.TabIndex = 8
        '
        'PostMortemReportsBindingSource
        '
        Me.PostMortemReportsBindingSource.DataMember = "Post Mortem Reports"
        Me.PostMortemReportsBindingSource.DataSource = Me.National_crime_record_management_systemDataSet
        '
        'National_crime_record_management_systemDataSet
        '
        Me.National_crime_record_management_systemDataSet.DataSetName = "National_crime_record_management_systemDataSet"
        Me.National_crime_record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(31, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Complaint number"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ComplaintNumberDataGridViewTextBoxColumn, Me.PostMortemReportDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PostMortemReportsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(404, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(264, 193)
        Me.DataGridView1.TabIndex = 11
        '
        'ComplaintNumberDataGridViewTextBoxColumn
        '
        Me.ComplaintNumberDataGridViewTextBoxColumn.DataPropertyName = "Complaint Number"
        Me.ComplaintNumberDataGridViewTextBoxColumn.HeaderText = "Complaint Number"
        Me.ComplaintNumberDataGridViewTextBoxColumn.Name = "ComplaintNumberDataGridViewTextBoxColumn"
        '
        'PostMortemReportDataGridViewTextBoxColumn
        '
        Me.PostMortemReportDataGridViewTextBoxColumn.DataPropertyName = "Post mortem report"
        Me.PostMortemReportDataGridViewTextBoxColumn.HeaderText = "Post mortem report"
        Me.PostMortemReportDataGridViewTextBoxColumn.Name = "PostMortemReportDataGridViewTextBoxColumn"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(19, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(322, 193)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "view Post mortem reports"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(373, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(332, 232)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Post_Mortem_ReportsTableAdapter
        '
        Me.Post_Mortem_ReportsTableAdapter.ClearBeforeFill = True
        '
        'view_post_mortem_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(724, 252)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "view_post_mortem_reports"
        Me.Text = "view_post_mortem_reports"
        CType(Me.PostMortemReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.National_crime_record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents National_crime_record_management_systemDataSet As crime_file_managemmet_system.National_crime_record_management_systemDataSet
    Friend WithEvents PostMortemReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Post_Mortem_ReportsTableAdapter As crime_file_managemmet_system.National_crime_record_management_systemDataSetTableAdapters.Post_Mortem_ReportsTableAdapter
    Friend WithEvents ComplaintNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostMortemReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
