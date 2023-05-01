Module Module1

    Sub Main()
        Dim score As Integer
        While True
            score = InputBox("what is ur score??")
            Select Case score
                Case Is >= 47
                    Console.WriteLine("you got A and your score is {0}", score)
                Case 42 To 47
                    Console.WriteLine("you got B and your score is {0}", score)
                Case 37 To 42
                    Console.WriteLine("you got C and your score is {0}", score)
                Case 33 To 37
                    Console.WriteLine("you got D and your score is {0}", score)
                Case 29 To 33
                    Console.WriteLine("you got E and your score is {0}", score)
                Case Is < 29
                    Console.WriteLine("you got (?) and your score is {0}", score)
            End Select
            Console.WriteLine("thank you! ")
            Console.ReadLine()
        End While
    End Sub

End Module
