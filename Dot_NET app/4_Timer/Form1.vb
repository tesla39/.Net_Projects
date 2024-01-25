Public Class Form1
    Dim min As Integer = 0
    Dim second As Integer = 0
    Dim milli As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        milli += 1
        Label1.Text = min & ":" & second & ":" & milli
        If milli = 100 Then
            milli = 0
            second += 1
            Label1.Text = min & ":" & second & ":" & milli
            If second = 60 Then
                second = 0
                min += 1
                Label1.Text = min & ":" & second & ":" & milli
                If min = 60 Then
                    min = 0
                    second = 0
                    milli = 0
                    Label1.Text = min & ":" & second & ":" & milli
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        min = 0
        second = 0
        milli = 0
        Label1.Text = min & ":" & second & ":" & milli
    End Sub
End Class
