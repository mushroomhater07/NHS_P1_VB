Module Module1

    Sub Main()
        Dim type As Char

        type = "a"c
        'c is to define the char?? -by the internet
        type = InputBox(“enter a single character at the keyboard”)
        If Char.IsDigit(type) = True Then
            Console.WriteLine(“you typed {0} and that is a number”, type)
        ElseIf Char.IsLetter(type) = False Then
            Console.WriteLine(“you typed {0} and that is a symbol”, type)
        ElseIf Char.IsLower(type) = False Then
            Console.WriteLine(“you typed {0} and that is a uppercase letter”, type)
        Else
            Console.WriteLine(“you typed {0} and that is a lowercase letter”, type)
        End If
        Console.ReadLine()

    End Sub

End Module
