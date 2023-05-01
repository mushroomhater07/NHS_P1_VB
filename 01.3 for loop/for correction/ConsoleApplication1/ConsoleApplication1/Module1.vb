Module Module1

    Sub Main()
        Dim num, count As Integer

        Console.WriteLine("which times tables you would like to see ")
        num = Console.ReadLine()
        Console.WriteLine()
        For count = 1 To 12
            Console.Write(count & " x " & num & " = ")
            Console.WriteLine(num *count)
        Next
        Console.ReadLine()
    End Sub

End Module
