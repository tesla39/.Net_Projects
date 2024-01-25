Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stack As New Stack
        Dim a As String

        stack.Push("sunday")
        stack.Push("monday")
        stack.Push("tuesday")
        stack.Push("wednesday")
        stack.Push("thursday")
        stack.Push("friday")
        stack.Push("saturday")
        a = InputBox("press any item to start pop")
        Dim i As Integer = 0
        For i = 0 To 7
            If stack.Contains(a) Then
                MsgBox(stack.Pop())
            Else
                MsgBox("not exist")
            End If
        Next

    End Sub
End Class
