Imports System

Module Program
    Sub Main(args As String())
        Dim num, remainder, num_org, rev As Integer
        Console.WriteLine("enter the number=")
        num = Console.ReadLine()
        num_org = num
        While num > 0
            remainder = num Mod 10
            rev = rev * 10 + remainder
            num = num / 10

        End While
        If (num_org = rev) Then
            Console.WriteLine("palindrome")
        Else
            Console.WriteLine("not palindrome")
        End If
    End Sub
End Module
