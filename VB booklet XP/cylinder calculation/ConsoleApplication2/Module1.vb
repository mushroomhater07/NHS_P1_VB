Module Module1

    Sub Main()
        Dim radius, height, result As Single
        Const pi = 3.14159265359

        Console.WriteLine("Hello to cylindrical water tank volume calculator")
        Console.WriteLine("Press <ENTER> to continue")
        Console.ReadLine()
        Console.Clear()

        radius = InputBox("what is the radius")
        height = InputBox("what is the height")
        result = radius * radius * height * pi
        MsgBox("radius: " & radius & " height: " & height & " volume: " & Format(result, ".00"))

    End Sub

End Module
