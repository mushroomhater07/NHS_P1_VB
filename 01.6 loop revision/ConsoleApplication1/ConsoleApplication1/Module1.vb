Module Module1

    Sub Main()
        Dim count As Integer
        Dim done As Integer
        For count = 7 To 1 Step -1
            Do Until done = count
                Console.Write("*")
                done += 1
            Loop
            done = 0
            Console.WriteLine()
            Console.WriteLine()

        Next
        Console.ReadLine()

    End Sub

End Module
