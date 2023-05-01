Module Module1

    Sub Main()
        Dim ans As Integer = 0
        Dim col As Integer = 16
        Dim bit As Integer
        Do Until col < 1
            Console.WriteLine("enter bit value(1 or 0): ")
            bit = Console.ReadLine()
            ans = ans + (col * bit)
            col = col / 2
        Loop
        Console.WriteLine("Decimal value is: {0}", ans)
        Console.ReadLine()

    End Sub

End Module
