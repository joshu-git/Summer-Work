Imports System

Module SelectionInterface
    Sub Main()
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            Call Header()
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
        Call Header()
        Console.WriteLine("(1) Central Heating")
        Console.WriteLine("(2) Car Hire")
        userinput = Console.ReadLine()
        Select Case userinput
            Case 1
                Call CentralHeating()
            Case 2
                Call CarHire()
            Case Else
                Console.WriteLine("Error: Please try again")
        End Select
    End Sub

    Sub ProgrammingTasks()
        Dim userinput As Integer = 0
        Call Header()
        Console.WriteLine("(1) ")
        Console.WriteLine("(2) ")

        Select Case userinput

        End Select
    End Sub

    Sub Header()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("***** Summer Work *****" & vbCrLf)
        Console.WriteLine("Please select one of the following:" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
    End Sub
End Module

Module ModerationExercises
    Sub CentralHeating()

    End Sub
    Sub CarHire()

    End Sub
End Module
