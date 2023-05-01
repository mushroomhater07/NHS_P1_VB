Module Module1

    Sub Main()
        Dim word As String = "comeonnoemoc"
        Dim back As String = StrReverse(word)
        If word = back Then
            Console.WriteLine("it is palindrome")
        Else
            Console.WriteLine("it is not")
        End If
        Console.ReadLine()



    End Sub

End Module
