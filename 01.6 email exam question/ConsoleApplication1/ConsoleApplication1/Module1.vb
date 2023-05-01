Module Module1

    Sub Main()
        Dim count1 As Integer
        Dim count2 As Integer
        Dim prime As String
        Console.WriteLine("the first few prime number are: ")
        For count1 = 2 To 50
            count2 = 2
            prime = "Yes"
            Do While (count2 * count2) <= count1
                If (count1 Mod count2 = 0) Then
                    prime = "No"
                End If
                count2 += 1
            Loop
            If prime = "Yes" Then
                Console.WriteLine(count1)
            End If
        Next
        Console.ReadLine()

    End Sub

End Module
