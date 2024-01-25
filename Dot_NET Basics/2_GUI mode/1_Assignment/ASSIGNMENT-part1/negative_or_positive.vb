Public Class negative_or_positive
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        If (a > 0) Then
            TextBox2.Text = " positive"
        Else
            TextBox2.Text = "negative"
        End If
    End Sub
End Class