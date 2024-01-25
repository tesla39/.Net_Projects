Imports System

Module Program
    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Console.WriteLine("enter the first number")
        num1 = Console.ReadLine()
        Console.WriteLine("enter the second number")
        num2 = Console.ReadLine()
        If (num1 > num2) Then
            Console.WriteLine("first number is greater")
        Else
            Console.WriteLine("second number is greater")
        End If

    End Sub
End Module
