Imports System.IO
Module ModuleStreamReader


    Sub Main()
        Try

            Using sr As StreamReader = New StreamReader("d:/jamaica.txt")
                Dim line As String

                line = sr.ReadLine()
                While (line <> Nothing)
                    Console.WriteLine(line)
                    line = sr.ReadLine()
                End While
            End Using
        Catch e As Exception

            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try
        Console.ReadKey()
    End Sub

End Module

