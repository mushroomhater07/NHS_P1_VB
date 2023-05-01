Module Module1
    Structure CarDetail
        Dim Make As String
        Dim model As String
        Dim price As Single
        Dim registrationa As String
        Dim colour As String
        Dim door As Single
    End Structure
    Sub Main()
        Dim car As New CarDetail()
        car.Make = "Tesla"
        car.model = "Model S"
        car.price = 1255
        car.registrationa = "Yes"
        car.colour = "Black"
        car.door = "2"
        Console.WriteLine("{0}'s {1}, selling with {2}, registration {3}, colour {4} with {5} doors. ", car.Make, car.model, car.price, car.registrationa, car.colour, car.door)
        Console.ReadLine()

    End Sub

End Module
