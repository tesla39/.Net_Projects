Public Class Form2

    ''Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    Private Sub FrmRadioOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Text = "Radio Button"
        End Sub

    Private Sub red_checkedchanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoRed.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub RdoGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoGreen.CheckedChanged
            Me.BackColor = Color.Green
        End Sub

        Private Sub RdoBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoBlue.CheckedChanged
            Me.BackColor = Color.Blue

        End Sub

        Private Sub RdoBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoBlack.CheckedChanged
            Me.ForeColor = Color.Black
        End Sub

        Private Sub RdoWhite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoWhite.CheckedChanged
            Me.ForeColor = Color.White
        End Sub

        Private Sub RdoForcolorRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoForcolorRed.CheckedChanged
            Me.ForeColor = Color.Red

        End Sub

End Class