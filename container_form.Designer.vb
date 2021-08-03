<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class container_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(container_form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FirstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterFIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFIRDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFIRDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFIRDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompliantRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCompliantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MissingPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccidentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobberyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCompliantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAccidentCompliantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRobberyCompliantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostMortemReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPostMortemReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatePostMortemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriminalRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCriminalsRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FingerPrintMatcherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstToolStripMenuItem, Me.CompliantRegistrationToolStripMenuItem, Me.PostMortemReportsToolStripMenuItem, Me.CriminalRecordsToolStripMenuItem, Me.FingerPrintMatcherToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FirstToolStripMenuItem
        '
        Me.FirstToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterFIRToolStripMenuItem, Me.UpdateFIRDetailsToolStripMenuItem, Me.DeleteFIRDetailsToolStripMenuItem, Me.UpdateFIRDetailsToolStripMenuItem1})
        Me.FirstToolStripMenuItem.Name = "FirstToolStripMenuItem"
        Me.FirstToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.FirstToolStripMenuItem.Text = "First Information Report"
        '
        'RegisterFIRToolStripMenuItem
        '
        Me.RegisterFIRToolStripMenuItem.Name = "RegisterFIRToolStripMenuItem"
        Me.RegisterFIRToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RegisterFIRToolStripMenuItem.Text = " Register FIR Details"
        '
        'UpdateFIRDetailsToolStripMenuItem
        '
        Me.UpdateFIRDetailsToolStripMenuItem.Name = "UpdateFIRDetailsToolStripMenuItem"
        Me.UpdateFIRDetailsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UpdateFIRDetailsToolStripMenuItem.Text = "Update FIR Details"
        '
        'DeleteFIRDetailsToolStripMenuItem
        '
        Me.DeleteFIRDetailsToolStripMenuItem.Name = "DeleteFIRDetailsToolStripMenuItem"
        Me.DeleteFIRDetailsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeleteFIRDetailsToolStripMenuItem.Text = "Delete FIR Details"
        '
        'UpdateFIRDetailsToolStripMenuItem1
        '
        Me.UpdateFIRDetailsToolStripMenuItem1.Name = "UpdateFIRDetailsToolStripMenuItem1"
        Me.UpdateFIRDetailsToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.UpdateFIRDetailsToolStripMenuItem1.Text = "Exit"
        '
        'CompliantRegistrationToolStripMenuItem
        '
        Me.CompliantRegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCompliantsToolStripMenuItem, Me.UpdateCompliantsToolStripMenuItem})
        Me.CompliantRegistrationToolStripMenuItem.Name = "CompliantRegistrationToolStripMenuItem"
        Me.CompliantRegistrationToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.CompliantRegistrationToolStripMenuItem.Text = "Complaint Registration "
        '
        'ViewCompliantsToolStripMenuItem
        '
        Me.ViewCompliantsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MissingPersonToolStripMenuItem, Me.AccidentToolStripMenuItem1, Me.RobberyToolStripMenuItem1})
        Me.ViewCompliantsToolStripMenuItem.Name = "ViewCompliantsToolStripMenuItem"
        Me.ViewCompliantsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ViewCompliantsToolStripMenuItem.Text = "View Complaints"
        '
        'MissingPersonToolStripMenuItem
        '
        Me.MissingPersonToolStripMenuItem.Name = "MissingPersonToolStripMenuItem"
        Me.MissingPersonToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.MissingPersonToolStripMenuItem.Text = "Missing Person"
        '
        'AccidentToolStripMenuItem1
        '
        Me.AccidentToolStripMenuItem1.Name = "AccidentToolStripMenuItem1"
        Me.AccidentToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.AccidentToolStripMenuItem1.Text = "Accident"
        '
        'RobberyToolStripMenuItem1
        '
        Me.RobberyToolStripMenuItem1.Name = "RobberyToolStripMenuItem1"
        Me.RobberyToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.RobberyToolStripMenuItem1.Text = "Robbery"
        '
        'UpdateCompliantsToolStripMenuItem
        '
        Me.UpdateCompliantsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.UpdateAccidentCompliantToolStripMenuItem, Me.UpdateRobberyCompliantToolStripMenuItem})
        Me.UpdateCompliantsToolStripMenuItem.Name = "UpdateCompliantsToolStripMenuItem"
        Me.UpdateCompliantsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UpdateCompliantsToolStripMenuItem.Text = "Update Complaints"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.ToolStripMenuItem1.Text = "Update missing person"
        '
        'UpdateAccidentCompliantToolStripMenuItem
        '
        Me.UpdateAccidentCompliantToolStripMenuItem.Name = "UpdateAccidentCompliantToolStripMenuItem"
        Me.UpdateAccidentCompliantToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.UpdateAccidentCompliantToolStripMenuItem.Text = "Update accident complaint"
        '
        'UpdateRobberyCompliantToolStripMenuItem
        '
        Me.UpdateRobberyCompliantToolStripMenuItem.Name = "UpdateRobberyCompliantToolStripMenuItem"
        Me.UpdateRobberyCompliantToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.UpdateRobberyCompliantToolStripMenuItem.Text = "Update robbery complaint"
        '
        'PostMortemReportsToolStripMenuItem
        '
        Me.PostMortemReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPostMortemReportsToolStripMenuItem, Me.UpdatePostMortemToolStripMenuItem})
        Me.PostMortemReportsToolStripMenuItem.Name = "PostMortemReportsToolStripMenuItem"
        Me.PostMortemReportsToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.PostMortemReportsToolStripMenuItem.Text = "Post Mortem Reports"
        '
        'ViewPostMortemReportsToolStripMenuItem
        '
        Me.ViewPostMortemReportsToolStripMenuItem.Name = "ViewPostMortemReportsToolStripMenuItem"
        Me.ViewPostMortemReportsToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ViewPostMortemReportsToolStripMenuItem.Text = " Post Mortem Reports"
        '
        'UpdatePostMortemToolStripMenuItem
        '
        Me.UpdatePostMortemToolStripMenuItem.Name = "UpdatePostMortemToolStripMenuItem"
        Me.UpdatePostMortemToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.UpdatePostMortemToolStripMenuItem.Text = "View Post Mortem Reports"
        '
        'CriminalRecordsToolStripMenuItem
        '
        Me.CriminalRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCriminalsRecordsToolStripMenuItem})
        Me.CriminalRecordsToolStripMenuItem.Name = "CriminalRecordsToolStripMenuItem"
        Me.CriminalRecordsToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.CriminalRecordsToolStripMenuItem.Text = "Criminals Records"
        '
        'ViewCriminalsRecordsToolStripMenuItem
        '
        Me.ViewCriminalsRecordsToolStripMenuItem.Name = "ViewCriminalsRecordsToolStripMenuItem"
        Me.ViewCriminalsRecordsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ViewCriminalsRecordsToolStripMenuItem.Text = "Criminals Records"
        '
        'FingerPrintMatcherToolStripMenuItem
        '
        Me.FingerPrintMatcherToolStripMenuItem.Name = "FingerPrintMatcherToolStripMenuItem"
        Me.FingerPrintMatcherToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.FingerPrintMatcherToolStripMenuItem.Text = "Finger Print Matcher"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(16, 44)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(16, 333)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 204)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(35, 297)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Missing Person"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(25, 552)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Most Wanted Person"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'container_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 602)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "container_form"
        Me.Text = "container_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterFIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompliantRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostMortemReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriminalRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFIRDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateFIRDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateFIRDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCompliantsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCompliantsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPostMortemReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatePostMortemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCriminalsRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MissingPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccidentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RobberyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents FingerPrintMatcherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateAccidentCompliantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRobberyCompliantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
