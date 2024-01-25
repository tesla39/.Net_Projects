Imports System
Imports System.Diagnostics.CodeAnalysis

Module Program
    Sub Main()
        Dim cp As Decimal
        Dim sp As Decimal
        Console.WriteLine("enter the cost price")
        cp = Console.ReadLine()
        Console.WriteLine("enter the selling price")
        sp = Console.ReadLine()
        If (sp > cp) Then
            Console.WriteLine("profit")
        Else

        End If
        Console.WriteLine("Hello World!")
    End Sub
End Module
