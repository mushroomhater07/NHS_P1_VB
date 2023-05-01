Module Module1
    Dim gh As String
    Sub Main()
        Dim list(10) As Integer
        Dim total, min, max As Integer
        Console.WriteLine("enter number 1")
        List(0) = Console.ReadLine
        total += List(0)
        min = List(0)
        max = List(0)
        For count As Integer = 1 To 9
            Console.WriteLine("enter number {0}", count + 1)
            List(count) = Console.ReadLine
            total += List(count)
            If List(count) < min Then
                min = List(count)
            End If
            If List(count) > max Then
                max = List(count)
            End If
        Next
        Console.WriteLine("min: {0}", min)
        Console.WriteLine("max: {0}", max)
        Console.WriteLine("total: {0}", Format(total / List.GetLength(0), ".0"))
        Console.ReadLine()

        Console.ReadLine()


    End Sub

End Module
