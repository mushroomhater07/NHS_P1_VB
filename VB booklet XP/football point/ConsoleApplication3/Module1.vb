Module Module1

    Sub Main()
        Dim win, draw, lose, result As Integer

        Console.WriteLine("welcome to football team point calculator")
        Console.WriteLine("press <ENTER> to continue")
        Console.ReadLine()
        Console.Clear()

        win = InputBox("number of winnning")
        lose = InputBox("number of losing")
        draw = InputBox("number of draw")
        result = win * 3 + draw
        MsgBox("your football team has " & result & " points")
        MsgBox("As you provided, win: " & win & ", lose: " & lose & ", draw: " & draw & ", total point: " & result)
    End Sub

End Module
