Public Class SIMPLE_INTEREST
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, t, r As Integer
        p = TextBox1.Text
        t = TextBox2.Text
        r = TextBox3.Text
        TextBox4.Text = (p * t * r) / 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "

    End Sub
End Class