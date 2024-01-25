Imports System

Module Program
    Sub Main()
        Dim num As Integer
        Console.WriteLine("enter the number to check")
        num = Console.ReadLine()
        If (num Mod 5 = 0 And num Mod 3 = 0) Then
            Console.WriteLine("number is divisible by both 3 and 5")
        Else
            Console.WriteLine("not divisible by 5 and 3 both")
        End If

    End Sub
End Module
