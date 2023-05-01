Module Module1

    Sub Main()
        Dim wide, deep, num As Integer
        Dim cost, total As Single

        Console.WriteLine("Slab Calculator")
        Console.WriteLine("press <ENTER> to continue")
        Console.ReadLine()
        Console.Clear()

        wide = Microsoft.VisualBasic.Interaction.InputBox("how many slab wide")
        deep = InputBox("how mant slab deep")
        cost = InputBox("how much is one slab")
        num = wide * deep
        total = num * cost

        MsgBox(num & " slabs required")
        MsgBox("total cost will be " & Format(total, "currency"))
        ' prevent extreme number and negative number and round the decimal place  prevent 0

    End Sub

End Module
