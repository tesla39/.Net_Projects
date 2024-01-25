Public Class check_whether_a_number_is_divisible_by_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        If (a Mod 3 = 0) Then
            TextBox2.Text = " divisible by 3"
        Else
            TextBox2.Text = "not divisible by 3"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub
End Class