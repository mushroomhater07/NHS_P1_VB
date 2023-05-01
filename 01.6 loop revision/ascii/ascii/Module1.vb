Module Module1

    Sub Main()
        Dim count As Integer
        Dim line As Integer
        For count = 1 To 122 Step 1
            line = 0
            Do Until line = 10
                Console.Write(Chr(count))
                count += 1
                line += 1
            Loop
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub

End Module
