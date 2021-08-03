Public Class Missing_Person
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub Register_FIR_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Missing_Person' table. You can move, or remove it, as needed.
        Me.Missing_PersonTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Missing_Person)
        

    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = National_crime_record_management_systemDataSet.Missing_Person
        dr = dt.NewRow
        dr(0) = Convert.ToInt32(TextBox7.Text)
        dr(1) = TextBox1.Text
        dr(2) = ComboBox1.Text
        dr(3) = DateTimePicker1.Text
        dr(4) = TextBox6.Text
        dr(5) = TextBox2.Text
        dr(6) = DateTimePicker2.Text
        dr(7) = TextBox4.Text
        dr(8) = DateTimePicker3.Text
        '' dr(9) = "na"
        dt.Rows.Add(dr)
        Missing_PersonTableAdapter.Update(National_crime_record_management_systemDataSet.Missing_Person)
        MsgBox("Saved")
    End Sub
End Class