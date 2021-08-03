Public Class update_fir


    Private Sub update_fir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Register_fir' table. You can move, or remove it, as needed.
        Me.Register_firTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Register_fir)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.RegisterfirBindingSource.EndEdit()
        Me.Register_firTableAdapter.Update(Me.National_crime_record_management_systemDataSet)
        MsgBox("fir is update")
    End Sub
End Class