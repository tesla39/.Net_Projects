Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer
        Dim digit As Integer
        Console.WriteLine("enter the number")
        num = Console.ReadLine
        While num > 0
            digit = num Mod 10
            Console.WriteLine(digit)
            num = num / 10
        End While
    End Sub
End Module
