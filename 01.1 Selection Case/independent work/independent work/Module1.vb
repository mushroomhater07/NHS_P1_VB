Module Module1

    Sub Main()
        Const a = 220.0
        Const b = 246.94
        Const c = 261.63
        Const d = 293.66
        Const e = 329.63
        Const f = 349.23
        Const g = 392.0
        Dim iput As Char
        iput = "a"c
        While True
            Console.WriteLine("enter a note")
            iput = Console.ReadLine()
            If ((Char.IsLower(iput) = False) Or (Char.IsLetter(iput) = False)) Then
                Console.WriteLine("enter a note")
                iput = Console.ReadLine()
            Else
                Select Case iput
                    Case "a"
                        Console.Beep(a, 500)
                    Case "b"
                        Console.Beep(b, 500)
                    Case "c"
                        Console.Beep(c, 500)
                    Case "d"
                        Console.Beep(d, 500)
                    Case "e"
                        Console.Beep(e, 500)
                    Case "f"
                        Console.Beep(f, 500)
                    Case "g"
                        Console.Beep(g, 500)
                End Select
            End If
        End While
    End Sub

End Module
