Public Class Post_Mortem_Report

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF Files |*.pdf"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class