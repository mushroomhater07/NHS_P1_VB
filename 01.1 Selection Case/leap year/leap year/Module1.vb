Module Module1

    Sub Main()
        Dim year As Integer
        Dim div, century, hundred As Single

        year = InputBox("enter the year")
        div = year Mod 4
        century = year Mod 100
        hundred = year Mod 400
        If ((div = 0 And century <> 0) Or hundred = 0) Then
            Console.WriteLine("it is a leap year {0}", year)
        Else
            Console.WriteLine("it is not a leap year {0}", year)
        End If
        Console.ReadLine()

    End Sub

End Module
