Imports System

Module Program
    Sub Main(args As String())
        Dim num, digit As Integer
        Dim mult As Integer = 1
        Console.WriteLine("enter the number")
        num = Console.ReadLine()
        While num > 0
            digit = num Mod 10
            mult = digit * mult
            num = num / 10
        End While
        Console.WriteLine(mult)
    End Sub
End Module
