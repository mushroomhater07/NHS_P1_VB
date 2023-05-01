Module Module1

    Sub Main()
        Dim list(10000000) As String
        Dim input As Integer
        Dim count As Integer = 0
        Console.WriteLine("enter 1 to add list")
        Console.WriteLine("enter 2 to view list")
        Console.WriteLine("enter 3 to clean the list")
        Console.WriteLine("enter 4 to end the program")
        Console.WriteLine("Enter the number correspond to the program")
        input = Console.ReadLine()
        Do While input <= 3
            
            Select Case input
                Case 1
                    Console.WriteLine("Add an item to the list:")
                    list(count) = Console.ReadLine()
                    count += 1
                Case 2
                    For coun As Integer = 0 To count - 1
                        Console.WriteLine("{0}: {1}", coun + 1, list(coun))
                    Next
                    Console.WriteLine("End of the list")
                Case 3
                    Array.Clear(list, 0, list.Length)
                    Erase list
            End Select
            Console.WriteLine("Enter the number correspond to the program")
            input = Console.ReadLine()
        Loop
    End Sub

End Module
