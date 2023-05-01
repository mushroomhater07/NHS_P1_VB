Module Module1

    Sub Main()
        Dim type As String
        Dim total As String = 0
        Dim fever As String = 0
        Dim count As String = 0
        Dim average As Single
        Do Until type = -1
            Console.WriteLine("enter your temp")
            Console.ReadLine()
            Do Until (type <= 44) And (type >= 37)
                Console.WriteLine("invalid, enter your temperature")
                type = Console.ReadLine()
            Loop
            Select Case type
                Case Is > 37
                    fever += 1
                    total += type
                    count += 1
                    Console.WriteLine("fever is recorded, come back 6 hour later")
                Case Else
                    total += type
                    count += 1
                    Console.WriteLine("Nice! recorded, come back 6 hour later")
            End Select

        Loop

        average = total / count
        Console.WriteLine("average temp: {0}", average)
        Console.WriteLine("fever count: {0}", fever)
        Console.WriteLine("input count: {0}", count)
        Console.ReadLine()
    End Sub

End Module
