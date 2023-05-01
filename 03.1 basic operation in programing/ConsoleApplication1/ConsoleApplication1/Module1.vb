Module Module1

    Sub Main()
        Dim value As String = "bird frog dog"

        ' Find position of last space.
        Dim index As Integer = value.LastIndexOf(" "c)
        Dim count As Integer

        Do Until index = -1
            value = value.Remove(index)
            Console.WriteLine("REMOVE RESULT: {0}", value)
            index = value.LastIndexOf(" ")
        Loop
        Console.ReadLine()

    End Sub

End Module
