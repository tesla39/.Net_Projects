Public Class multipication_number
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double = 1
        Dim n As Integer = Val(TextBox1.Text)

        a = 1
        While (a <= 10)
            ListBox1.Items.Add(n & " *" & a & "=" & n * a)


            a = a + 1
        End While

    End Sub
End Class