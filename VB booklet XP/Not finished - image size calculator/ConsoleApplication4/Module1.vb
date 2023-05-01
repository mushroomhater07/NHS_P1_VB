Module Module1

    Sub Main()
        Dim height, width, cdepth As Single
        Console.WriteLine("welcome to bitmapped graphics MB calculator")
        Console.WriteLine("please enter the height")
        height = Console.ReadLine()
        Console.WriteLine("please enter the width")
        width = Console.ReadLine()
        Console.WriteLine("please enter the colour depth")
        cdepth = Console.ReadLine()
        Console.WriteLine("the resolution is : {0} ", height * width)
        Console.WriteLine("The file in bit is: {0} bits", height * width * cdepth)
        Console.WriteLine("The file in byte is: {0} bytes", height * width * cdepth / 8)
        Console.WriteLine("The file in kilobyte is: {0} KB", height * width * cdepth / 8000)
        Console.WriteLine("The file in megabyte is: {0} MB", height * width * cdepth / 8000000)
        Console.ReadLine()
        resolution = height * width
    End Sub

End Module
