Public Class Form3

    Private Sub button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFill.Click
        Dim i As Integer
        i = 1
        While i <= 5
            ListBox1.Items.Add(InputBox("enter food option"))
            i = i + 1
        End While
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()

    End Sub

    Private Sub button4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        'txtListCount.Text = ListBox1.Items.Count
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs)

    End Sub
End Class

