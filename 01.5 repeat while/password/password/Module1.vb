Module Module1

    Sub Main()
        Dim password As String = "Tues1212"
        Dim Type As String
        Dim count As Integer = 0
        Dim remain As Integer

        Console.WriteLine("type in password")
        Type = Console.ReadLine()
        Do While ((password <> Type) And (count <> 2))
            count += 1
            remain = 3 - count
            Console.WriteLine("type in password again, remaining time: {0}", remain)
            Type = Console.ReadLine()
        Loop
        If Type = password Then
            Console.WriteLine("password accepted")
        Else
            Console.WriteLine("password rejected")
        End If
        Console.ReadLine()

    End Sub

End Module
