Imports System

Module Program
    Sub Main(args As String())
        Dim num, digit As Integer
        Dim sum As Integer = 0
        Console.WriteLine("enter the number")
        num = Console.ReadLine()
        While num > 0
            digit = num Mod 10
            If (digit Mod 2 <> 0) Then
                sum = sum + digit

            End If
            num = num / 10
        End While
        Console.WriteLine(sum)
    End Sub
End Module
