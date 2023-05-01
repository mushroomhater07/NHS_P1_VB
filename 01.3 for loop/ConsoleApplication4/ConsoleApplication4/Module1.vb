Module Module1

    Sub Main()
        Dim count, num, total, avg, max, min As Single
        Console.WriteLine("enter your number")
        num = Console.ReadLine()
        min = num
        max = num
        For count = 1 To 9
            Console.WriteLine("enter your number")
            num = Console.ReadLine()
            min = Math.Min(min, num)
            max = Math.Max(max, num)

            total = total + num
        Next
        avg = total / 10
        Console.Write("avg: ")
        Console.WriteLine(avg)
        Console.Write("max: ")
        Console.WriteLine(max)
        Console.Write("min: ")
        Console.WriteLine(min)
        Console.ReadLine()

    End Sub

End Module
