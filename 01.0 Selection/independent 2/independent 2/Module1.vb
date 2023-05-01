Module Module1

    Sub Main()
        Dim a, b, c, delta, SR, x1, x2 As Single

        a = InputBox(“enter x2 value”)
        b = InputBox(“enter x value”)
        c = InputBox(“enter constant value”)

        delta = b * b - (4 * a * c)

        If delta < 0 Then
            Console.WriteLine(“the equation has no real root”)
        ElseIf delta = 0 Then
            Console.WriteLine(“the equation only have one real root”)
        Else
            Console.WriteLine(“the equation have 2 real root”)
        End If

        SR = Math.Abs(delta)
        SR = Math.Sqrt(SR)
        x1 = (-b + SR) / (2 * a)
        x2 = (-b - SR) / (2 * a)

        Console.WriteLine(“delta(b2-4ac): ” & delta)

        If delta < 0 Then
            Console.WriteLine(“the solution is {0}i and {1}i ”, x1, x2)
        Else
            Console.WriteLine(“the solution is {0} and {1}”, x1, x2)
        End If

        Console.ReadLine()

    End Sub

End Module
