Public Class whether_a_number_is_divisible_by_5
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        If (a Mod 5 = 0) Then
            TextBox2.Text = " divisible by 5"
        Else
            TextBox2.Text = "not divisible by 5"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub
End Class