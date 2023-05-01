Module Module1

    Sub Main()
        Dim input As Char
        Dim check As String = "y"
        Console.WriteLine("What is the command keyword to exit a loop in VB.NET?")
        Console.WriteLine("a. int")
        Console.WriteLine("b. continue")
        Console.WriteLine("c. break")
        Console.WriteLine("d. Exit For/Exit While/Exit Do While")
        Do Until check <> "y"
            Console.Write("Enter your choice: ")
            input = Console.ReadLine()
            If input <> "d" Then
                Console.WriteLine("Incorrect!")
                Console.Write("Again? press y to continue: ")
                check = Console.ReadLine
            Else
                Console.WriteLine("Yeah! you are correct")
                check = "n"
            End If
        Loop
        Console.WriteLine("program has finished")
        Console.ReadLine()
    End Sub

End Module
