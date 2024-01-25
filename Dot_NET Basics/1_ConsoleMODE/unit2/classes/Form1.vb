Imports Microsoft.VisualBasic

Public Class form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c1 As computer
        c1 = New computer
        c1.company = "noname"
        c1.model = "01tec1"
        c1.price = 10000
        c1.MsgBox()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'form1
        '
        Me.ClientSize = New System.Drawing.Size(448, 362)
        Me.Name = "form1"
        Me.ResumeLayout(False)

    End Sub
End Class
Public Class computer
    Public company As String
    Public model As String
    Public price As Integer
    Public Sub saysomething()
        MsgBox("whats up!")
    End Sub
End Class




