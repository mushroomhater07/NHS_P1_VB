Module Module1

    Sub Main()
        Dim score As Integer
        Console.Write("Enter the score: ")
        score = Console.ReadLine()
        If score > 60 Then score += 10
        Console.WriteLine("Score = {0}", score)
        Console.ReadLine()

    End Sub

End Module
