Public Class Criminals_Records
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dt = National_crime_record_management_systemDataSet.Criminal_Records
        dr = dt.NewRow
        dr(0) = TextBox1.Text
        dr(1) = DateTimePicker1.Text
        dr(2) = TextBox2.Text
        dr(3) = TextBox3.Text
        dr(4) = TextBox4.Text
        dr(5) = TextBox5.Text
        dr(6) = TextBox6.Text

        dt.Rows.Add(dr)
        Criminal_RecordsTableAdapter.Update(National_crime_record_management_systemDataSet.Criminal_Records)
        MsgBox("Saved")
    End Sub

    Private Sub Criminals_Records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Criminal_Records' table. You can move, or remove it, as needed.
        Me.Criminal_RecordsTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Criminal_Records)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class