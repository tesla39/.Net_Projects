Imports System

Module Program
    Sub Main(args As String())
        Dim remainder, num, rev As Integer
        Console.WriteLine("enter the nubmer")
        num = Console.ReadLine()
        While num > 0
            remainder = num Mod 10
            rev = rev * 10 + remainder
            num = num / 10
        End While
        Console.WriteLine(rev)
    End Sub
End Module
