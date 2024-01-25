Public Class AREA_OF_CIRCLE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim R As Integer
        Const PI As Decimal = 3.14

        R = TextBox1.Text
        TextBox2.Text = 2 * 3.14 * R * R
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
End Class
