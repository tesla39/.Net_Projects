Public Class sequence4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Dim result As Integer = 1
        While num <= 10

            result = result + num
            sequence.Items.Add(result)
            num = num + 1
        End While
    End Sub
End Class