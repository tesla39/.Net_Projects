Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer = 1
        Dim result As Integer
        While num < 11
            result = 2 * num * num
            Console.WriteLine(result)
            num = num + 1
        End While

    End Sub
End Module
