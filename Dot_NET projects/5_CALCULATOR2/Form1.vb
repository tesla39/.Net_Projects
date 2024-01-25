Public Class Form1
    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles opsub.Click, opdiv.Click, opmult.Click, opadd.Click, opdec.Click, opequalto.Click, num0.Click, num1.Click, num2.Click, num3.Click, num4.Click, num5.Click, num6.Click, num7.Click, num8.Click, num9.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "num0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If

        If button.Name = "num1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If

        If button.Name = "num2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If

        If button.Name = "num3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If

        If button.Name = "num4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If

        If button.Name = "num5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If

        If button.Name = "num6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If

        If button.Name = "num7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If

        If button.Name = "num8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If

        If button.Name = "num9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If

        If button.Name = "opdec" Then
            TextBox1.Text = TextBox1.Text + "."
        End If

        If button.Name = "opsub" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If

        If button.Name = "opequalto" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result
        End If

        If button.Name = "opmult" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If

        If button.Name = "opdiv" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If

        If button.Name = "opadd" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If

    End Sub

    Private Sub opclear_Click(sender As Object, e As EventArgs) Handles opclear.Click
        TextBox1.Text = " "
    End Sub

    Private Sub opexit_Click(sender As Object, e As EventArgs) Handles opexit.Click
        End
    End Sub
End Class
