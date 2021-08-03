Public Class update_accident_compliant

    Private Sub update_accident_compliant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Accident' table. You can move, or remove it, as needed.
        Me.AccidentTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Accident)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.AccidentBindingSource.EndEdit()
        Me.AccidentTableAdapter.Update(Me.National_crime_record_management_systemDataSet)
        MsgBox("data is update")
    End Sub
End Class