Module Module1

    Sub Main()
        Dim month, day As Integer
        month = InputBox("enter a month and get the number of days")

        Select Case month
            Case 1 Or 3 Or 5 Or 7 Or 8 Or 10 Or 12
                MsgBox("there are 31 days")
            Case 2
                MsgBox("there are 28 days")
                MsgBox("it is Feburary")
            Case Else
                MsgBox("there are 30 days")
        End Select

        Select Case month
            Case 1
                MsgBox("it is janaury")
            Case 3
                MsgBox("it is march")
            Case 4
                MsgBox("it is april")
            Case 5
                MsgBox("it is may")
            Case 6
                MsgBox("it is june")
            Case 7
                MsgBox("it is july")
            Case 8
                MsgBox("it is august")
            Case 9
                MsgBox("it is september")
            Case 10
                MsgBox("it is october")
            Case 11
                MsgBox("it is november")
            Case 12
                MsgBox("it is december")
        End Select
    End Sub

End Module
