Module Module1

    Sub Main()

        Dim type As Integer
        Dim total As Single = 0
        Dim fever As Integer = 0
        Dim count As Single
        Dim average As Single
        For count = 1 To 7
            Console.WriteLine("enter your temperature")
            type = Console.ReadLine()
            Do Until (type > 30) And (type < 44)
                Console.WriteLine("invalid, enter your temperature again")
                type = Console.ReadLine()
            Loop
            total = total + type
            If type > 37 Then
                fever += 1
                Console.WriteLine("fever recorded")
            Else

                Console.WriteLine("temperature recorded")
            End If
        Next

        average = total / 7
        Console.WriteLine("average temp: {0}", Format(average, ".0"))
        Console.WriteLine("fever count: {0}", fever)
        Console.ReadLine()
    End Sub

End Module
