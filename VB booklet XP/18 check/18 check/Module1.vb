Module Module1

    Sub Main()
        Dim age As Integer

        age = InputBox("what's your age?")
        If age >= 18 Then
            MsgBox("you are eligible to vote")
        Else
            MsgBox("you are a kid, NO")
        End If
    End Sub

End Module
