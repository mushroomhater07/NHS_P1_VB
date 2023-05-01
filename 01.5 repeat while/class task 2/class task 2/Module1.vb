Module Module1

    Sub Main()
        Randomize()
        Dim value As Integer = CInt(Int((100 * Rnd() + 1)))
        Dim guess As Integer = -1
        Dim count As Integer = 0
        Console.WriteLine(value)
        Do While value <> guess
            Console.WriteLine("type your guess")
            guess = Console.ReadLine()
            If value > guess Then
                Console.WriteLine("too small")
            End If
            If value < guess Then
                Console.WriteLine("too large")
            End If
            count += 1
        Loop

        Console.WriteLine("-------=====you guessed it=====-------")
        Console.WriteLine("you have guessed {0} times", count)
        Console.WriteLine("the number is {0}", value)
        Console.ReadLine()


    End Sub

End Module
