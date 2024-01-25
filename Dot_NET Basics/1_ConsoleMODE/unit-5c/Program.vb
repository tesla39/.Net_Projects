Imports System.IO
Module ModuleStreamWriter

    Sub Main()

        Dim s As String
        Using sw As StreamWriter = New StreamWriter("d:\student.txt")

            For i = 1 To 5
                s = InputBox("Enter Record")
                sw.WriteLine(s)
            Next
        End Using
        ' Read and show each line from the file. 
        Dim line As String
        Using sr As StreamReader = New StreamReader("d:\student.txt")
            line = sr.ReadLine()
            While (line <> Nothing)
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
        End Using
        Console.ReadLine()
    End Sub
End Module

