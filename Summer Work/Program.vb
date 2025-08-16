Imports System

Module Program
    Sub Main(args As String())
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("***** Summer Work *****" & vbCrLf)
            Console.WriteLine("Please select one of the following:" & vbCrLf)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("(1) Moderation Exercises")
            Console.WriteLine("(2) Programming Tasks")
            userinput = Console.ReadLine()
            If userinput = 1 Then
                validinput = True
                Call ModerationExercises()
            ElseIf userinput = 2 Then
                validinput = True
                Call ProgrammingTasks()
            Else
                Console.WriteLine("Error: Please try again")
            End If
            Console.ReadLine()
        End While
    End Sub

    Sub ModerationExercises()
        Dim userinput As Integer = 0
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("***** Summer Work *****" & vbCrLf)
        Console.WriteLine("Please select one of the following:" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("(1) ")
        Console.WriteLine("(2) ")

        Select Case userinput

        End Select
    End Sub

    Sub ProgrammingTasks()
        Dim userinput As Integer = 0
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("***** Summer Work *****" & vbCrLf)
        Console.WriteLine("Please select one of the following:" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("(1) ")
        Console.WriteLine("(2) ")

        Select Case userinput

        End Select
    End Sub
End Module
