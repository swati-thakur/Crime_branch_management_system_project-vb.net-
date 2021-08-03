Public Class Finger_print_matcher
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim openfile As New OpenFileDialog
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openfile.FileName)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim openfile As New OpenFileDialog
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(openfile.FileName)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        ' Load the images.
        Dim bm1 As Bitmap = PictureBox1.Image
        Dim bm2 As Bitmap = PictureBox2.Image

        ' Make a difference image.
        Dim wid As Integer = Math.Min(bm1.Width, bm2.Width)
        Dim hgt As Integer = Math.Min(bm1.Height, bm2.Height)
        Dim bm3 As New Bitmap(wid, hgt)

        ' Create the difference image.
        Dim are_identical As Boolean = True

        Dim eq_color As Color = Color.White
        Dim ne_color As Color = Color.Red
        For x As Integer = 0 To wid - 1
            For y As Integer = 0 To hgt - 1
                If bm1.GetPixel(x, y).Equals(bm2.GetPixel(x, _
                    y)) Then
                    bm3.SetPixel(x, y, eq_color)
                Else
                    bm3.SetPixel(x, y, ne_color)
                    are_identical = False
                End If
            Next y
        Next x

        ' Display the result.


        Me.Cursor = Cursors.Default
        If (bm1.Width <> bm2.Width) OrElse (bm1.Height <> _
            bm2.Height) Then are_identical = False
        If are_identical Then
            MessageBox.Show("The finger print are identical")
        Else
            MessageBox.Show("The finger print are different")
        End If

        bm1.Dispose()
        bm2.Dispose()
    End Sub
End Class