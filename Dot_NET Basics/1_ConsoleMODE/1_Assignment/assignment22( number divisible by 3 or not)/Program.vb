Imports System

Module Program
    Sub Main()
        Dim num As Integer
        Console.WriteLine("ënter the number to check")
        num = Console.ReadLine()
        If (num Mod 3 = 0) Then
            Console.WriteLine("number is divisible by 3")
        Else
            Console.WriteLine("number isnot divisible by 3")
        End If
    End Sub
End Module
