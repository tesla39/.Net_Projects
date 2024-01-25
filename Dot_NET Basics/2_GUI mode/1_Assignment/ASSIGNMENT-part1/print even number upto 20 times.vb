Public Class print_even_number_upto_20_times
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        While num <= 20
            even_number.Items.Add(num)
            num += 2
        End While
    End Sub
End Class