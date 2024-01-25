Imports System

Module collections


    Sub fun1()
        ' Create a list of strings.
        Dim salmons As New Queue
        salmons.Enqueue("chinook")
        salmons.Enqueue("coho")
        salmons.Enqueue("pink")
        salmons.Enqueue("sockeye")

        ' Iterate through the list.
        For Each s1 As String In salmons
            Console.WriteLine(s1)
        Next

    End Sub

    Sub hastable()
        Dim ht As Hashtable = New Hashtable()
        ' Dim k As String
        ht.Add("001", "Zara Ali")
        ht.Add("002", "Abida Rehman")
        ht.Add("003", "Joe Holzner")
        ht.Add("004", "Mausam Benazir Nur")
        ht.Add("005", "M. Amlan")
        ht.Add("006", "M. Arif")
        ht.Add("007", "Ritesh Saikia")

        If (ht.ContainsValue("Nuha Ali")) Then
            Console.WriteLine("This student name is already in the list")
        Else
            ht.Add("008", "Nuha Ali")
        End If
        ' Get a collection of the keys. 
        Dim key As ICollection = ht.Keys

        For Each k In key
            Console.WriteLine(" {0} = {1}", k, ht(k))
        Next k
        Console.ReadKey()
    End Sub


    Sub Main()
        Dim st As New Stack(Of String)
        st.Push("A")
        st.Push("M")
        st.Push("G")
        st.Push("W")
        Console.WriteLine("Current stack: ")
        'Dim c As Char

        For Each c In st
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        st.Push("V")
        st.Push("H")
        Console.WriteLine("The next poppable value in stack: {0}", st.Peek())
        Console.WriteLine("Current stack: ")

        For Each c In st
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        Console.WriteLine("Removing values ")
        st.Pop()
        st.Pop()
        st.Pop()
        Console.WriteLine("Current stack: ")

        For Each c In st
            Console.Write(c + " ")
        Next c
        'Console.ReadKey()
        fun1()
        hastable()
    End Sub
End Module


