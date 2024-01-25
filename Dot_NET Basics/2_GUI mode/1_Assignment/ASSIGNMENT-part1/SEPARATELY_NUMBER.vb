Public Class SEPARATELY_NUMBER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim digit As Integer
        Dim num As Integer = TextBox1.Text
        While num > 0
            digit = num Mod 10
            ListBox1.Items.Add(digit)
            num = num / 10

        End While
    End Sub
End Class