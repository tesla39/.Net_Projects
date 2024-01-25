Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = DateTimePicker1.Value.DayOfWeek
        TextBox2.Text = DateTimePicker1.Value.Day
        TextBox3.Text = DateTimePicker1.Value.Month
        TextBox4.Text = DateTimePicker1.Value.Year

    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs)

    End Sub
End Class
