Public Class Frm2


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Frm1.Hide()
    End Sub

    Private Sub Frm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("loading form2")
    End Sub
End Class