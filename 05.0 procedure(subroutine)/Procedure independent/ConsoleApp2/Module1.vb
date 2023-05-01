Module Module1

    Sub Main()
        Dim startnum, endnum, table As Single
        Dim pupilname As String
        Console.WriteLine("please enter name")
        pupilname = Console.ReadLine()
        Console.WriteLine("please enter the table")
        table = Console.ReadLine()
        Console.WriteLine("please enter start num")
        startnum = Console.ReadLine()
        Console.WriteLine("please enter end num")
        endnum = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("{0}: here is your {1}th table", pupilname, table)
        For count As Integer = startnum To endnum
            multiples(table, count)
        Next
        Console.ReadLine()
    End Sub
    Sub multiples(ByVal ptable As Single, ByVal pcount As Single)
        Dim sum As Single = ptable * pcount
        Console.WriteLine("{0} x {1} = {2}", ptable, pcount, sum)
    End Sub
End Module
