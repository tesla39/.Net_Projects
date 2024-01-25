Imports System
Module Program
    Sub Main(args As String())
        Dim l As Integer
        Dim b As Integer
        Dim h As Integer
        Dim v As Integer
        Console.WriteLine("enter the length ")
        l = Console.ReadLine()
        Console.WriteLine("enter the breadth")
        b = Console.ReadLine()
        Console.WriteLine("enter the height")
        h = Console.ReadLine()
        v = l * b * h
        Console.WriteLine("volume of cuboid=" & v)

    End Sub
End Module