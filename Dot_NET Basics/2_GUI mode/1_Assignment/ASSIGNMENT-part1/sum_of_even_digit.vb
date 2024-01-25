Public Class sum_of_even_digit
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim digit As Integer
        Dim num As Integer = TextBox1.Text
        Dim sum As Integer
        While num > 0
            digit = num Mod 10
            If digit Mod 2 = 0 Then
                sum = sum + digit

            End If
            num = num / 10


        End While
        TextBox2.Text = sum
    End Sub
End Class