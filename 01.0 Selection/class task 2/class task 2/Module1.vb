Module Module1

    Sub Main()
        Dim a, b As Integer
        a = InputBox(“enter value of a”)
        b = InputBox(“enter value of b”)
        If a = 100 And b = 200 Then
            MsgBox(“The value of a is 100 and b is 200”)
        End If
        Console.WriteLine("the value of a is {0} and b is {1}", a, b)
        Console.ReadLine()

    End Sub

End Module
