Public Class sequence3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 1
        Dim result As Integer = 1
        While num <= 10

            result = 2 * num * num
            sequence.Items.Add(result)
            num = num + 1
        End While

    End Sub
End Class