Module Module1

    Sub Main()
        Dim count As Integer
        Dim starcount As Integer
        Dim done As Integer
        For count = 1 To 7 Step 1
            starcount = 7 - count
            Do Until count = done
                Console.Write(done + 1)
                done += 1
            Loop
            done = 0
            Do Until starcount = done
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
