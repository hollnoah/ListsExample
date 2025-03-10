﻿'header stuff
Option Strict On
Option Explicit On
Option Compare Text
Module ListsExample

    Sub Main()
        Dim names As New List(Of String)

        names.Add("Jimmy")
        names.Add("Mary")
        names.Add("Frank")
        names.Add("Bob")

        Console.WriteLine(names.Count)

        Console.WriteLine(names.Contains("Bob"))
        names.Remove("Bob")
        Console.WriteLine(names.Contains("Bob"))

        names.Insert(2, "Elmer")
        Console.WriteLine(names.Count)
        Console.WriteLine(names.Contains("Elmer"))

        For Each name In names
            names.IndexOf(name)
            Console.WriteLine($"{name} is in index {names.IndexOf(name)}")
        Next

        'Console.WriteLine(names.Item(7)) 'this crashes because 7 out of range

    End Sub

End Module
