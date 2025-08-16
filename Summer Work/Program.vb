Imports System

Module Program
    Sub Main(args As String())
        Dim userselect As Integer = 0
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("***** Summer Work *****" & vbCrLf)
        Console.WriteLine("Please select one of the following:" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("(1) Moderation Exercises")
        Console.WriteLine("(2) Programming Tasks")
        Console.ReadLine()
    End Sub
End Module
