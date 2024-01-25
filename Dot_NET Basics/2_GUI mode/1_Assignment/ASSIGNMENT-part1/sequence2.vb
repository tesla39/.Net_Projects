Public Class sequence2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 1
        While num <= 10
            sequence.Items.Add(num)
            num = num * num
        End While
    End Sub
End Class