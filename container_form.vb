Public Class container_form
    Private r As New Random()

    Private Sub RegisterFIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterFIRToolStripMenuItem.Click
        Register_FIR_details.Show()
    End Sub

    
    Private Sub MissingPersonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MissingPersonToolStripMenuItem.Click
        Missing_Person.Show()
    End Sub

    Private Sub AccidentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccidentToolStripMenuItem1.Click
        Accident_Complaint.Show()

    End Sub

    Private Sub RobberyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RobberyToolStripMenuItem1.Click
        Robbery_Complaint.Show()

    End Sub

    Private Sub ViewPostMortemReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPostMortemReportsToolStripMenuItem.Click
        Post_Mortem_Report.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer = +1

        PictureBox1.Image = My.Resources.ResourceManager.GetObject("image" & r.Next(i, 12))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer1.Interval = 1000
        '2  sec
    End Sub

    

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim i As Integer = +1

        PictureBox2.Image = My.Resources.ResourceManager.GetObject("image" & r.Next(13, 21))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer2.Start()
        Timer2.Interval = 1000
        '2  sec
    End Sub

    Private Sub ViewCriminalsRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCriminalsRecordsToolStripMenuItem.Click
        Criminals_Records.Show()
    End Sub

    Private Sub FingerPrintMatcherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FingerPrintMatcherToolStripMenuItem.Click
        Finger_print_matcher.Show()
    End Sub

    Private Sub UpdateFIRDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFIRDetailsToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub UpdateFIRDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFIRDetailsToolStripMenuItem.Click
        update_fir.Show()
    End Sub

    Private Sub DeleteFIRDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFIRDetailsToolStripMenuItem.Click
        Delete_fir.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        update_missing_person.Show()
    End Sub

    Private Sub UpdateAccidentCompliantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAccidentCompliantToolStripMenuItem.Click
        update_accident_compliant.Show()

    End Sub

    Private Sub UpdateRobberyCompliantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRobberyCompliantToolStripMenuItem.Click
        Update_robbery_compliant.Show()

    End Sub

    Private Sub UpdatePostMortemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePostMortemToolStripMenuItem.Click
        view_post_mortem_reports.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class