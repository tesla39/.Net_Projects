Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("enter the value of a=")
        a = Console.ReadLine()
        Console.WriteLine("enter the value of b=")
        b = Console.ReadLine()
        If (a > b) Then
            Console.WriteLine("a is larger=" & a)
        Else
            Console.WriteLine("b is larger=")
        End If
    End Sub
End Module
