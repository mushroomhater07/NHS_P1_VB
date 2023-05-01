Module Module1

    Sub Main()
        Dim newword, userwordguess As String
        Console.WriteLine("the new word? ")
        newword = Console.ReadLine()
        Console.WriteLine("your guess? ")
        userwordguess = Console.ReadLine()
        If userwordguess = newword Then
            Console.WriteLine("correct")
        Else
            Console.WriteLine("incorrect")
        End If
        Console.ReadLine()

    End Sub

End Module
