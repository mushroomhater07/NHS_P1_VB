Module Module1

    Sub Main()
        Dim input As Char
        Dim check As String = "y"
        Console.WriteLine("What is the correct way to declare a variable to an integer value in VB.NET?")
        Console.WriteLine("a. int a")
        Console.WriteLine("b. Dim a As Single")
        Console.WriteLine("c. Dim a As String")
        Console.WriteLine("d. Dim a As Integer")
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
        Do While check = "y"
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
