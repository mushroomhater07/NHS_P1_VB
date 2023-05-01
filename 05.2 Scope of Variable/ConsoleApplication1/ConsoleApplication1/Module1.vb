Module Module1
    Dim globalvar As String = "hi"
    Sub Main()
        Dim localvar As String = "there"
        Console.WriteLine(globalvar + localvar)
        Another()
        Console.ReadLine()
    End Sub
    Sub Another()
        Console.WriteLine(globalvar)
    End Sub
End Module
