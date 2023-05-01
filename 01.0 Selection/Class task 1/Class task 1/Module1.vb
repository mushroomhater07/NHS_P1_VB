Module Module1

    Sub Main()
        Dim x, age As String

        Console.WriteLine("what is ur age")
        age = Console.ReadLine()
        x = Integer.Parse(age)
        If age >= 18 Then
            Console.WriteLine("you are eligible to vote ")
        Else
            Console.WriteLine("you are a kid, no")
        End If
        Console.ReadLine()

    End Sub

End Module
