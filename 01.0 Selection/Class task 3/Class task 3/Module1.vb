Module Module1

    Sub Main()
        Dim rate, work, total, workbonus As Single
        Dim num As Integer

        workbonus = 0
        num = InputBox(“what is ur employee number ”)
        rate = InputBox(“what is ur hourly rate”)
        work = InputBox(“how many hours have you work for”)
        If work > 40 Then
            workbonus = work * 0.5
        End If
        total = (work + workbonus) * rate
        Console.WriteLine(“your employee number: {0}”, num)
        Console.WriteLine(“your work hour is {0} and your wages is {1}”, work, total)
        Console.ReadLine()

    End Sub

End Module
