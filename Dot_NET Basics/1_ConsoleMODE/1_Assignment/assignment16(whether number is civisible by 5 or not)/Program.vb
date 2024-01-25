Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer
        Console.WriteLine("enter the number to check")
        num = Console.ReadLine()
        If (num Mod 5 = 0) Then
            Console.WriteLine("number is divisible by 5")
        Else
            Console.WriteLine("number isnot divisible by 5")
        End If
    End Sub
End Module
