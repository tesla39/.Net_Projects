Imports System
Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Console.WriteLine("enter the length ")
        a = Console.ReadLine()
        Console.WriteLine("enter the breadth")
        b = Console.ReadLine()
        c = 2 * (a + b)
        Console.WriteLine("perimeter of rectangle=" & c)

    End Sub
End Module


