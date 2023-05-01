Module Module1

    Sub Main()
        Dim start, dest As String
        Dim average_speed, time, distance As Single

        start = InputBox("where you start")
        dest = InputBox("where you are going / destination")
        average_speed = InputBox("what is your estimate speed? (km/h or mph)")
        distance = InputBox("how far is it from start to distance? (km or miles)")
        time = distance / average_speed
        MsgBox("time estimate is : " & Format(time, ".0") & " hr(s)")
        MsgBox("from " & start & " to destination: " & dest & " distance: " & distance & " speed: " & average_speed & " time estimate is : " & Format(time, ".0") & " hr(s)")

    End Sub

End Module
