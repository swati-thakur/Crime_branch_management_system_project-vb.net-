Public Class Update_robbery_compliant


    Private Sub Update_robbery_compliant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Robbery' table. You can move, or remove it, as needed.
        Me.RobberyTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Robbery)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.RobberyBindingSource.EndEdit()
        Me.RobberyTableAdapter.Update(Me.National_crime_record_management_systemDataSet)
        MsgBox("data is update")
    End Sub
End Class