Public Class reverse_number
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, rev As Integer

        Dim num As Integer = TextBox1.Text
        While num > 0

            n = num Mod 10
            rev = rev * 10 + n
            num = num / 10

        End While
        TextBox2.Text = rev
    End Sub
End Class