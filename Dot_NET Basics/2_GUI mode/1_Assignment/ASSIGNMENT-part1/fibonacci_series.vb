Public Class fibonacci_series
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim a As Integer = 1
        Dim b As Integer = 1
        Dim c As Integer = 0
        While i <= 10
            ListBox1.Items.Add(c)
            c = a + b
            a = b
            b = c
            i = i + 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class