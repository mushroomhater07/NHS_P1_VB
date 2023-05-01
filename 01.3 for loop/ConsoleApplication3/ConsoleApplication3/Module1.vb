Module Module1

    Sub Main()
        Dim num, count As Integer
        Console.WriteLine("which times table you would like to see")
        num = Console.ReadLine()
        Console.WriteLine()

        For count = 1 To 12
            Console.WriteLine(num * count)
        Next
        Console.ReadLine()

    End Sub

End Module
