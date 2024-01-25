Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NRS As Integer
        Dim DOLLAR As Decimal
        NRS = TextBox1.Text
        DOLLAR = NRS / 126.1
        TextBox2.Text = DOLLAR

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
End Class
