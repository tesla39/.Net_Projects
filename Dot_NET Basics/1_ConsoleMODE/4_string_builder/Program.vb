Imports System.Text
Module Module1
    Sub Main()
        Dim builder As New StringBuilder("Initialize the StringBuilder.")
        builder.Replace("the", "my")

        Console.WriteLine(builder.ToString)
        Console.ReadLine()
    End Sub
End Module
