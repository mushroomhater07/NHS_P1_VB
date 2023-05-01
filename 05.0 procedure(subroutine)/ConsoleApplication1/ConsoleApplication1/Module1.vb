Module Module1

    Sub Main()
        WelcomeMsg()
        Console.ReadLine()

    End Sub
    Sub WelcomeMsg()
        Dim n As String
        Console.Write("Enter yourname:")
        n = Console.ReadLine
        Console.WriteLine("Welcome " & n & "!")
    End Sub
End Module
