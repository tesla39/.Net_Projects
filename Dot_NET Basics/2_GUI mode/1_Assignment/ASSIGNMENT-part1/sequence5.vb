Public Class sequence5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 1
        Dim result
        While num <= 10

            result = 5 * num
            sequence.Items.Add(result)
            num = num + 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result
        sequence.Items.Add(result)
    End Sub
End Class