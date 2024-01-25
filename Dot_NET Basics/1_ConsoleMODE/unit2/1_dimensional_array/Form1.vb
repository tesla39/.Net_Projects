
Public Class Form1
        Dim ary(4) As Integer
        Dim i As Integer
    Private Sub btnPrintArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintArray.Click
        For i = 0 To 4
            txtArray.Text = txtArray.Text & ary(i) & ","
        Next i
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReadArray.Click
        For i = 0 To 4
            ary(i) = InputBox("enter array element")
        Next i
    End Sub
End Class
