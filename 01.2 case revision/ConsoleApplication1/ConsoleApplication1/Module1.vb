Module Module1

    Sub Main()
        Dim direction As String
        Dim num As Integer
        Console.WriteLine("Let's play paper chatterbox")
        Console.WriteLine("enter the direction (N,S,E,W)")
        direction = Console.ReadLine.ToUpper()
        Console.WriteLine("enter 1 or 2")
        num = Console.ReadLine()
        Select Case direction
            Case "N"
                Select Case num
                    Case 1
                        Console.WriteLine("you are lucky today")
                    Case Else
                        Console.WriteLine("drink more water")
                End Select
            Case "S"
                Select Case num
                    Case 1
                        Console.WriteLine("sleep early")
                    Case Else
                        Console.WriteLine("you look brilliant today")
                End Select
            Case "E"
                Select Case num
                    Case 1
                        Console.WriteLine("keep fit")
                    Case Else
                        Console.WriteLine("surprise")
                End Select
            Case "W"
                Select Case num
                    Case 1
                        Console.WriteLine("eat more fruit")
                    Case Else
                        Console.WriteLine("greeting from hey")
                End Select
        End Select
        Console.ReadLine()
    End Sub

End Module
