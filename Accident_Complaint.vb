Public Class Accident_Complaint
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub Accident_Compliant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Accident' table. You can move, or remove it, as needed.
        Me.AccidentTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Accident)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = National_crime_record_management_systemDataSet.Accident
        dr = dt.NewRow
        dr(0) = Convert.ToInt32(cmp_no.Text)
        dr(1) = TextBox1.Text
        dr(2) = TextBox2.Text
        dr(3) = TextBox3.Text
        dr(4) = DateTimePicker1.Text
        dr(5) = TextBox7.Text
        dr(6) = DateTimePicker2.Text
        dr(7) = TextBox9.Text
        dr(8) = TextBox4.Text
        dr(9) = Convert.ToInt32(TextBox5.Text)
        dr(10) = TextBox6.Text
        dt.Rows.Add(dr)
        AccidentTableAdapter.Update(National_crime_record_management_systemDataSet.Accident)
        MsgBox("Saved")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class