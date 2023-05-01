Module Module1

    Sub Main()
        Dim type As String
        type = 0
        Do
            Console.WriteLine("Are we there yet")
            type = Console.ReadLine()
        Loop Until type = 1
        Console.WriteLine("wonderful, we have arrived")
        Console.ReadLine()
    End Sub

End Module
