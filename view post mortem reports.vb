Public Class view_post_mortem_reports

    Private Sub view_post_mortem_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'National_crime_record_management_systemDataSet.Post_Mortem_Reports' table. You can move, or remove it, as needed.
        Me.Post_Mortem_ReportsTableAdapter.Fill(Me.National_crime_record_management_systemDataSet.Post_Mortem_Reports)

    End Sub
End Class