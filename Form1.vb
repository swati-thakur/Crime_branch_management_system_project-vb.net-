Public Class Form1
    Dim ctr As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ctr = ctr + 1
        If Val(TextBox1.Text = "swati thakur") And Val(TextBox2.Text = "scvb123") Then
            MsgBox("welcome")
            container_form.Show()
            Me.Hide()
        ElseIf (ctr < 3) Then
            MsgBox("please try again")
            TextBox1.Focus()
        Else
            MsgBox("unauthorised access")
            Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
