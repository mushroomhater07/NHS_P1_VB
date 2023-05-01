Module Module1

    Sub Main()
        Dim test1, test2, test3, total1, total2, total3, totalyear, index, avg1, avg2, avg3, avgyr As Single
        For index = 1 To 30
            Console.WriteLine("enter test 1 score")
            test1 = Console.ReadLine()

            Console.WriteLine("enter test 2 score")
            test2 = Console.ReadLine()

            Console.WriteLine("enter test 3 score")
            test3 = Console.ReadLine()
            total1 = total1 + test1
            total2 = total2 + test2
            total3 = total3 + test3
            totalyear = total1 + total2 + total3
        Next
        avg1 = total1 / 30
        avg2 = total2 / 30
        avg3 = total3 / 30
        avgyr = totalyear / 30
        Console.WriteLine()
        Console.WriteLine("averages:1: {0},2: {1},3: {2},year: {3}", avg1, avg2, avg3, avgyr)
        Console.WriteLine("total:1: {0},2: {1},3: {2},year: {3}", total1, total2, total3, totalyear)
        Console.ReadLine()

    End Sub

End Module
