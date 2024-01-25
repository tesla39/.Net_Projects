Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim P, T, R As Integer
        Dim SI As Decimal
        P = TextBox1.Text
        T = TextBox1.Text
        R = TextBox1.Text
        SI = (P * T * R) / 100
        TextBox4.Text = SI

    End Sub
End Class