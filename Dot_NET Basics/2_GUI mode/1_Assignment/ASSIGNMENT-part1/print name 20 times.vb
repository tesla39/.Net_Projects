Public Class print_name_20_times
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim item
        Dim num As Integer = 0
        While num <= 20
            item = TextBox1.Text
            name_list.Items.Add(item)
            num = num + 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        Dim num As Integer = 0
        Dim item
        While num <= 20
            item = TextBox1.Text
            name_list.Items.clear(item)
            num = num + 1
        End While
    End Sub
End Class