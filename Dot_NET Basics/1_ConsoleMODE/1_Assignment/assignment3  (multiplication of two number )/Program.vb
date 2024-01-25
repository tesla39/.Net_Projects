Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer

        Dim c As Integer
        Dim i As Integer = 1


        Console.WriteLine("enter the first number ")
        a = Console.ReadLine()

        While (i < 11)
            c = a * i
            Console.WriteLine("{0}X{1}={2}", a, i, c)

            i = i + 1
        End While



    End Sub
End Module
