Imports System
Module Program
    Sub Main(args As String())
        Dim r As Integer
        Const pi As Decimal = 3.14
        Dim a As Decimal
        Console.WriteLine("enter the radius ")
        r = Console.ReadLine()
        a = pi * r * r
        Console.WriteLine("area of circle=" & a)

    End Sub
End Module