Imports System.IO
Module fileProg
    Sub Main()
        Dim f1 As FileStream = New FileStream("d:/sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim i As Integer

        For i = 0 To 20
            f1.WriteByte(i)
        Next i
        'f1.Position = 0
        'if f1.position is not used produces o/p only -1

        f1.Position = 0
        For i = 0 To 20
            Console.Write("{0} ", f1.ReadByte())
        Next i
        f1.Close()
        Console.ReadKey()
    End Sub
End Module

