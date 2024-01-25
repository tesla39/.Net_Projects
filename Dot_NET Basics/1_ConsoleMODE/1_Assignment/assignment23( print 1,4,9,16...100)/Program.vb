Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer = 1
        Dim square As Integer
        While num < 11
            square = num * num
            Console.WriteLine(square)
            num = num + 1
        End While

    End Sub
End Module
