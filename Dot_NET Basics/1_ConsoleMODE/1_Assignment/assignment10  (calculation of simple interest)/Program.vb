
Imports System

Module Program
    Sub Main(args As String())
        Dim p As Decimal
        Dim t As Decimal
        Dim r As Decimal
        Dim si As Decimal

        Console.WriteLine("enter the amount of principal")
        p = Console.ReadLine()
        Console.WriteLine("enter the amount of time")
        t = Console.ReadLine()
        Console.WriteLine("enter the amount of rate")
        r = Console.ReadLine()
        si = (p * t * r) / 100
        Console.WriteLine("total amount of simple interest=" & si)

    End Sub
End Module
