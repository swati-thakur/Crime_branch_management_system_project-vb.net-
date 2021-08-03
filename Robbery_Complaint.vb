Public Class Robbery_Complaint
    Dim dt As New DataTable
    Dim dr As DataRow
    Private Sub Robbery_Compliant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Robbery' table. You can move, or remove it, as needed.
        Me.RobberyTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Robbery)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = National_crime_record_management_systemDataSet.Robbery
        dr = dt.NewRow
        dr(0) = TextBox1.Text
        dr(1) = DateTimePicker1.Text
        dr(2) = TextBox7.Text
        dr(3) = DateTimePicker2.Text
        dr(4) = TextBox9.Text

        dt.Rows.Add(dr)
        RobberyTableAdapter.Update(National_crime_record_management_systemDataSet.Robbery)
        MsgBox("Saved")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class