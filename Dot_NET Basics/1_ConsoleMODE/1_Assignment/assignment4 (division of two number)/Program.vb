Imports System
Imports System.Runtime.Intrinsics.X86

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Decimal
        Console.WriteLine("enter the first number ")
        a = Console.ReadLine()
        Console.WriteLine("enter the second number")
        b = Console.ReadLine()
        c = a / b
        Console.WriteLine("division of two number=" & c)

    End Sub
End Module
