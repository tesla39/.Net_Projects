Public Class print_odd_numbers_upto_20vb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 1
        While num <= 20
            odd_number.Items.Add(num)
            num += 2
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        odd_number.Items.Remove(num)

    End Sub
End Class