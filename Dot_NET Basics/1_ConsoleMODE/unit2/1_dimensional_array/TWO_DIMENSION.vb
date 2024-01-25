Public Class TWO_DIMENSION
    Dim Tab(3, 3) As Integer
    Dim i As Integer
    Dim j As Integer
    Dim counter As Integer = 1
    Private Sub btnReadArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadArray.Click
        For i = 0 To 2
            For j = 0 To 2
                Tab(i, j) = InputBox("enter Array element")
            Next
        Next
        MsgBox("Array element has been raed")
    End Sub---------------------------------------------------------------------------------------------------------------------------------------
 Private Sub btnPrintArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintArray.Click
        Dim temp As String = ""
        For i = 0 To 2
            For j = 0 To 2
                ListBox1.Items.Add(Tab(i, j))
                ''temp = temp & Tab(i, j).ToString() & ","
            Next
            '' ListBox1.Items.Add(temp)
            ''temp = " "
        Next
    End Sub
End Class