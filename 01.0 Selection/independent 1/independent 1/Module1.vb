Module Module1

    Sub Main()

        Dim a, b As Single

        a = InputBox(“enter value of a”)
        b = InputBox(“enter value of b”)
        If a > b Then
            Console.WriteLine(“A ({0}) is greater than B ({1})”, a, b)
        ElseIf a <> b Then
            Console.WriteLine(“A ({0}) is less than B ({1})”, a, b)
        Else
            Console.WriteLine(“A ({0}) and B ({1}) is equal ”, a, b)
        End If
        Console.ReadLine()

    End Sub

End Module
