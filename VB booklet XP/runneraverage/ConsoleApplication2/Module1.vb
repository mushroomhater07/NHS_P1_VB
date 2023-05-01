Module Module1

    Sub Main()
        Dim runnersname, whichevent As String
        Dim time1, time2, time3, Laverage As Single
        Dim average, sqnumber As Integer

        runnersname = InputBox("enter the runnername : ")
        sqnumber = InputBox("enter squad number : ")
        whichevent = InputBox("which event you join : ")
        ' why there is the first input in console?
        Console.Write("Time in 1st race : ")
        time1 = Console.ReadLine()
        Console.Write("Time in 2nd race : ")
        time2 = Console.ReadLine()
        Console.Write("time in 3rd race : ")
        time3 = Console.ReadLine()

        average = CInt((time1 + time2 + time3) / 3)
        Laverage = ((time1 + time2 + time3) / 3)

        MsgBox("welcome " & runnersname & "! we got ur record")
        Console.WriteLine()
        Console.WriteLine("Name : " & runnersname)
        Console.WriteLine("Number : " & sqnumber)
        Console.WriteLine("Event : " & whichevent)
        Console.WriteLine("Average : " & average & "s")
        Console.WriteLine("Press ENTER to continue")

        Console.ReadLine()

        MsgBox("thank you " & runnersname & " and your real average is : " & Format(Laverage, ".00"))
    End Sub

End Module
