Public Class calcuate_a_b__2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        TextBox3.Text = a * a + 2 * a * b + b * b
    End Sub
End Class