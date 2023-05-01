Module Module1

    Sub Main()
        Dim num As Integer
        Dim message As String

        Console.WriteLine("enter the message")
        message = Console.ReadLine()
        Console.WriteLine("enter number of times you want to repeat")
        num = Console.ReadLine()
        Console.WriteLine()

        For num = 1 To num
            Console.WriteLine(message)
        Next
        Console.ReadLine()

    End Sub

End Module
