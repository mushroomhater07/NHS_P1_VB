Module Module1

    Sub Main()
        Dim word As String = "this siht"
        Dim front, back As String
        If (word.Length() Mod 2) = 0 Then
            front = word.Substring(0, (word.Length() / 2))
            back = word.Substring((word.Length() / 2), word.Length())
        Else
            front = word.Substring(0, (word.Length() / 2) - 0.5)
            back = word.Substring((word.Length() / 2) + 0.5, word.Length())
        End If
        Console.WriteLine("done")
        Console.ReadLine()

    End Sub

End Module
