Module Module1

    Sub Main()

        Dim type As String
        type = 0
        Do Until type = 1
            Console.WriteLine("Are we there yet")
            type = Console.ReadLine()
        Loop
        Console.WriteLine("wonderful, we have arrived")
        Console.ReadLine()
    End Sub

End Module
