Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = Nothing
        If CheckBox1.Checked = True Then
            str = str & CheckBox1.Text & "   "
        End If
        If CheckBox2.Checked = True Then
            str = str & CheckBox2.Text & "   "
        End If
        If CheckBox3.Checked = True Then
            str = str & CheckBox3.Text & "   "
        End If
        If CheckBox4.Checked = True Then
            str = str & CheckBox4.Text & "   "
        End If
        If CheckBox5.Checked = True Then
            str = str & CheckBox5.Text & "   "
        End If
        If CheckBox6.Checked = True Then
            str = str & CheckBox6.Text & "   "
        End If
        textbox1.Text = str

    End Sub
End Class
