Public Class Form1

    Private Sub ADD_LIST_1_Click(sender As Object, e As EventArgs) Handles ADD_LIST_1.Click
        Dim item
        item = InputBox("enter task")
        THEORETICAL_TASK.Items.Add(item)
        MsgBox("task added")

    End Sub

    Private Sub ADD_LIST_2_Click(sender As Object, e As EventArgs) Handles ADD_LIST_2.Click
        Dim item
        item = InputBox("enter task")
        PRACTICAL_TASK.Items.Add(item)
        MsgBox("task added")

    End Sub

    Private Sub ADD_LIST_3_Click(sender As Object, e As EventArgs) Handles ADD_LIST_3.Click
        Dim item
        item = InputBox("enter task")
        ComboBox1.Items.Add(item)
        MsgBox("task added")
    End Sub

    Private Sub DELETE_LIST_1_Click(sender As Object, e As EventArgs) Handles DELETE_LIST_1.Click
        Dim item
        item = InputBox("enter task")
        THEORETICAL_TASK.Items.Remove(item)
        MsgBox("task removed")
    End Sub

    Private Sub DELETE_LIST_2_Click(sender As Object, e As EventArgs) Handles DELETE_LIST_2.Click
        Dim item
        item = InputBox("enter task")
        PRACTICAL_TASK.Items.Remove(item)
        MsgBox("task removed")
    End Sub

    Private Sub DELETE_LIST_3_Click(sender As Object, e As EventArgs) Handles DELETE_LIST_3.Click
        Dim item
        item = InputBox("enter task")
        ComboBox1.Items.Remove(item)
        MsgBox("task removed")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
