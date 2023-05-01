Module Module1

    Sub Main()
        Dim sunshine As Single = 0
        Dim maxhours As Single = 0
        Dim minhours As Single = 100
        Dim total As Single = 0

        Do Until sunshine = -1
            Console.WriteLine("input the sunshine")
            sunshine = Console.ReadLine()
            If sunshine > maxhours Then
                maxhours = sunshine
            End If
            If (sunshine < minhours) And (sunshine <> -1) Then
                minhours = sunshine
            End If
            total = total + sunshine
        Loop
        Console.WriteLine("max sunshine: {0}", maxhours)
        Console.WriteLine("min sunshine: {0}", minhours)
        Console.WriteLine("total sunshine: {0}", total)
        Console.ReadLine()

    End Sub

End Module
