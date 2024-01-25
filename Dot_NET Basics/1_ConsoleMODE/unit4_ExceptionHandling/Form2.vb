Public Class Form2
    Public Class DivisorIsZeroException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Private Sub division(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        Try

            If (num2 = 0) Then
                Throw (New DivisorIsZeroException("You have entered divisor is zero,Please check it"))
            End If
            result = num1 \ num2
            TextBox3.Text = result
        Catch e As DivisorIsZeroException
            TextBox3.Text = e.Message

        Finally
            MsgBox("Final block statement")
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