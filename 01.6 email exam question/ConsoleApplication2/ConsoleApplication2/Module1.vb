Module Module1

    Sub Main()
        Dim player1score As Integer = 0
        Dim player2score As Integer = 0
        Dim noOfGamesInMatch, NoOfGamesPlayed As Integer
        Dim playeronewinsgame As Char
        Console.WriteLine("how many games?")
        noOfGamesInMatch = Console.ReadLine()
        For NoOfGamesPlayed = 1 To noOfGamesInMatch
            Console.Write("Did player 1 win the game (ENTER Y or N)? ")
            playeronewinsgame = Console.ReadLine()
            If playeronewinsgame = "Y" Then
                player1score += 1
            Else
                player2score += 1

            End If
        Next
        Console.WriteLine("player one score: {0}", player1score)
        Console.WriteLine("player two score: {0}", player2score)
        Console.ReadLine()

    End Sub

End Module
