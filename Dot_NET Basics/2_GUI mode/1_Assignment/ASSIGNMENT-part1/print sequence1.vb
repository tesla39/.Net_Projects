Public Class print_sequence1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 100
        While num >= 0
            sequence.Items.Add(num)
            num -= 2
        End While
    End Sub
End Class