Public Class Register_FIR_details
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub Register_FIR_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Register_fir' table. You can move, or remove it, as needed.
        Me.Register_firTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Register_fir)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = National_crime_record_management_systemDataSet.Register_fir
        dr = dt.NewRow
        dr(0) = TextBox11.Text
        dr(1) = TextBox1.Text
        dr(2) = TextBox2.Text
        dr(3) = ListBox1.Text
        dr(4) = DateTimePicker1.Text
        dr(5) = TextBox3.Text
        dr(6) = TextBox5.Text
        dr(7) = TextBox4.Text
        dr(8) = ListBox3.Text
        dr(9) = Convert.ToInt32(TextBox6.Text)
        dr(10) = TextBox7.Text
        dr(11) = Convert.ToInt32(TextBox8.Text)
        dr(12) = TextBox9.Text
        dt.Rows.Add(dr)
        Register_firTableAdapter.Update(National_crime_record_management_systemDataSet.Register_fir)
        MsgBox("Saved")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class