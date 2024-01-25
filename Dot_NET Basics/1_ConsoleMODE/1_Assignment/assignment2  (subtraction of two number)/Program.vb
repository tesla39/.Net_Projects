Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        Console.WriteLine("enter the first number")
        a = Console.ReadLine()
        Console.WriteLine("enter the second number")
        b = Console.ReadLine()
        c = a - b
        Console.WriteLine("subtraction of two numbers=" & c)

    End Sub
End Module
