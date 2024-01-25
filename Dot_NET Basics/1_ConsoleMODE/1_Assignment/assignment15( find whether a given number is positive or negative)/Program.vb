Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer
        Console.WriteLine("enter the number to check")
        num = Console.ReadLine
        If (num > 0) Then
            Console.WriteLine("entered number is positive")
        Else
            Console.WriteLine("entered number is negative")
        End If
    End Sub
End Module
