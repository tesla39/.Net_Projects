Public Class MDI


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As New Form
        frm2.MdiParent = Me
        frm2.Show()
    End Sub

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class