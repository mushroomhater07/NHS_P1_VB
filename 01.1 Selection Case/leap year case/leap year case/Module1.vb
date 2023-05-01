Module Module1

    Sub Main()
        Dim year As Integer
        Dim div, century, fhundred As Single
        Console.WriteLine("enter the year you want to know")
        year = Console.ReadLine()
        div = year Mod 4
        century = year Mod 100
        fhundred = year Mod 400
        Select Case fhundred
            Case 0
                Console.WriteLine("it is a leap year")
            Case Else
                Select Case century
                    Case 0
                        Console.WriteLine("it is not a leap year")
                    Case Else
                        Console.WriteLine("it is a leap year")
                End Select
        End Select
        Console.ReadLine()
    End Sub

End Module
