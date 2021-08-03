Public Class update_missing_person

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.MissingPersonBindingSource.EndEdit()
        Me.Missing_PersonTableAdapter.Update(Me.National_crime_record_management_systemDataSet)
        MsgBox("data is update")

    End Sub

    Private Sub update_missing_person_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Missing_Person' table. You can move, or remove it, as needed.
        Me.Missing_PersonTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Missing_Person)

    End Sub
End Class