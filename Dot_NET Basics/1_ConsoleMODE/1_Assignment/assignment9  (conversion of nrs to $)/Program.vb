Imports System

Module Program
    Sub Main(args As String())
        Dim nrs As Decimal
        Dim dollar As Decimal
        Console.WriteLine("enter the nepali rupee")
        nrs = Console.ReadLine()
        dollar = nrs / 126.1
        Console.WriteLine("entered nrs value in dollar=" & dollar)
    End Sub
End Module
