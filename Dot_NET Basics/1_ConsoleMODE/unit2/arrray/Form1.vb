Public Class Form1
    Dim arr(5) As Integer
    Dim i As Integer
    Dim num As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = TextBox1.Text
        For i = 0 To i = num
            arr(i) = InputBox("enter array element")
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To i = num
            TextBox1.Text = arr(i)
        Next
    End Sub
End Class
