Module module1
    Sub main()
        Dim a, b, c, s, area As Decimal
        Console.WriteLine("enter the value of first side=")
        a = Console.ReadLine()
        Console.WriteLine("enter the value of second side=")
        b = Console.ReadLine()
        Console.WriteLine("enter the value of third side=")
        c = Console.ReadLine()
        s = (a + b + c) / 2
        area = 0.5 * (s * (s - a) * (s - b) * (s - c))
        Console.WriteLine("area of triangle=" & area)
    End Sub
End Module
