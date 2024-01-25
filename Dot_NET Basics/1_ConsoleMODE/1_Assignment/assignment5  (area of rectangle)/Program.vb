Imports System
Imports System.Runtime.Intrinsics.X86

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Console.WriteLine("enter the length ")
        a = Console.ReadLine()
        Console.WriteLine("enter the breadth")
        b = Console.ReadLine()
        c = a * b
        Console.WriteLine("area of rectangle=" & c)

    End Sub
End Module

