Public Class Form1
    Private Sub division(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        Try
            result = num1 \ num2
            TextBox1.Text = result
        Catch e As DivideByZeroException
            'TextBox2.Text = "EXCEPTION OCCUR,'Division by zero'"
            MsgBox(e.ToString())
            ' Finally
            ' MsgBox("Final block statement")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        Call division(x, y)

    End Sub
End Class
