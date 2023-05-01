Module Module1

    Sub Main()
        Dim name() As String = {"w", "a", "s", "d"}
        Dim num As Integer = name.GetLength(0)
        Dim search As String
        Dim temp, tempnum As Integer
        Console.WriteLine("enter the name you want to search")
        search = Console.ReadLine()
        Array.Sort(name)
        For count As Integer = 0 To num - 1
            If name(count) = search Then
                temp = 1
                Console.WriteLine("founded")
                Console.WriteLine("name({0}) , recorded number: {1}", count, count + 1)
            End If
        Next
        If temp = 0 Then
            Console.WriteLine("item not found")
        End If
        Console.ReadLine()
    End Sub

End Module
