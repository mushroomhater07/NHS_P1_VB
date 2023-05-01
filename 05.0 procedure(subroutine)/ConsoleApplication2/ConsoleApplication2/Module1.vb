Module Module1

    Sub Main()
        Dim input(9) As Single
        Dim result As Single
        For Count As Integer = 0 To 9
            Console.WriteLine("enter the number {0}", Count + 1)
            input(Count) = Console.ReadLine()
        Next
        result = Avg(input)
        Console.WriteLine("Average: {0}", result)
        Console.ReadLine()
    End Sub
    Function Avg(ByVal input() As Single)
        Dim sum As Single
        For pCount As Integer = 0 To 9
            sum += input(pCount)
        Next
        Return sum / 10
    End Function
End Module
