Public Class SDI
    Dim frm As New Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.Show()
        frm.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Frm2.Show()
        Me.Text = "hello"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub SDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("click ok to continue")
        'Button2.Enabled = False
    End Sub


End Class