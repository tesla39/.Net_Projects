Public Class palindrome_number
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim reversed As Integer = 0

        Dim remainder As Integer
        Dim original As Integer
        n = TextBox1.Text
        While (n <> 0)
            remainder = n Mod 10
            reversed = reversed * 10 + remainder
            n = n / 10
            If (original <> reversed) Then
                MsgBox("palindrome number is:-" & original)
            Else
                MsgBox("NOT palindrome number:-" & original)
            End If


        End While
    End Sub
End Class