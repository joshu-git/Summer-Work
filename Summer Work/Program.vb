Module SelectionInterface
    Sub MainMenu()
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
            Call Header()
            Console.WriteLine("(1) Moderation Exercises")
            Console.WriteLine("(2) Programming Tasks")
            userinput = Console.ReadLine()
            Select Case userinput
                Case 1
                    Call ModerationExercisesMenu()
                Case 2
                    Call ProgrammingTasks()
                Case Else
                    validinput = False
                    Console.WriteLine("Error: Please try again")
                    Console.ReadLine()
            End Select
            Console.Clear()
        End While
    End Sub

    Sub ModerationExercisesMenu()
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
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
                    validinput = False
                    Console.WriteLine("Error: Please try again")
                    Console.ReadLine()
            End Select
            Console.Clear()
        End While
    End Sub

    Sub ProgrammingTasks()
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
            Call Header()
            Console.WriteLine("(1) Sequence")
            Console.WriteLine("(2) Assignment")
            Console.WriteLine("(3) Arithmetic")
            Console.WriteLine("(4) Selection")
            Console.WriteLine("(5) Relational Operators")
            Console.WriteLine("(6) Boolean Operators")
            Console.WriteLine("(7) Logical Bitwise Operators")
            Console.WriteLine("(8) Arithmetic Functions")
            Console.WriteLine("(9) String Handling Functions")
            Console.WriteLine("(10) String Conversion Functions")
            Console.WriteLine("(11) Iteration")
            Console.WriteLine("(12) Flowcharts")
            Console.WriteLine("(13) Procedures & Functions")
            Console.WriteLine("(14) By Ref Vs By Val")
            Console.WriteLine("(15) Constants")
            Console.WriteLine("(16) Data Structures")
            Console.WriteLine("(17) Other Built-in Data Types")
            Console.WriteLine("(18) 1 Dimensional Arrays")
            Console.WriteLine("(19) Read/Write Text From/To A Text File")
            Console.WriteLine("(20) Read/Write Records From/To A File Of Records")
            Console.WriteLine("(21) Validation")
            Console.WriteLine("(22) 2 Dimensional Arrays")
            Console.WriteLine("(23) Enumerated")
            Console.WriteLine("(24) Set Operators")
            Console.WriteLine("(25) Linear Search")
            Console.WriteLine("(26) Bubble Search")
            userinput = Console.ReadLine()
            Select Case userinput
                Case 1
                    Call Sequence()
                Case 2
                    Call Assignment()
                Case 3
                    Call Arithmetic()
                Case 4
                    Call Selection()
                Case 5
                    Call RelationalOperators()
                Case 6
                    Call BooleanOperators()
                Case 7
                    Call LogicalBitwiseOperators()
                Case 8
                    Call ArithmeticFunctions()
                Case 9
                    Call StringHandlingFunctions()
                Case 10
                    Call StringConversionFunctions()
                Case 11
                    Call Iteration()
                Case 12
                    Call Flowcharts()
                Case 13
                    Call ProceduresAndFunctions()
                Case 14
                    Call ByRefVsByVal()
                Case 15
                    Call Constants()
                Case 16
                    Call DataStructures()
                Case 17
                    Call OtherBuiltInDataTypes()
                Case 18
                    Call OneDimensionalArrays()
                Case 19
                    Call ReadWriteTextFromToATextFile()
                Case 20
                    Call ReadWriteRecordsFromToAFileOfRecords()
                Case 21
                    Call Validation()
                Case 22
                    Call TwoDimensionalArrays()
                Case 23
                    Call Enumerated()
                Case 24
                    Call SetOperators()
                Case 25
                    Call LinearSearch()
                Case 26
                    Call BubbleSearch()
                Case Else
                    validinput = False
                    Console.WriteLine("Error: Please try again")
                    Console.ReadLine()
            End Select
            Console.Clear()
        End While
    End Sub

    Sub Header()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("***** Summer Work *****" & vbCrLf)
        Console.WriteLine("Please select one of the following:" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
    End Sub
    Function ExitMenu()
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
            Console.Clear()
            Call Header()
            Console.WriteLine("(1) Repeat Code")
            Console.WriteLine("(2) Main Menu")
            userinput = Console.ReadLine()
            If userinput = 1 Or userinput = 2 Then
                Return userinput
            Else
                validinput = False
                Console.WriteLine("Error: Please try again")
                Console.ReadLine()
            End If
        End While
    End Function
End Module

Module ModerationExercises
    Sub CentralHeating()

    End Sub
    Sub CarHire()

    End Sub
End Module

Module ProgrammingTasks
    Sub Sequence()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Red")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine("Amber")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Green")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine(vbCrLf & "Task 2:" & vbCrLf)
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Red")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine("Orange")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Yellow")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Green")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("Blue")
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.WriteLine("Indigo")
            Console.ForegroundColor = ConsoleColor.DarkMagenta
            Console.WriteLine("Violet")
            Console.ReadLine()
            userinput = ExitMenu()
        End While
        Call MainMenu()
    End Sub
    Sub Assignment()

    End Sub
    Sub Arithmetic()

    End Sub
    Sub Selection()

    End Sub
    Sub RelationalOperators()

    End Sub
    Sub BooleanOperators()

    End Sub
    Sub LogicalBitwiseOperators()

    End Sub
    Sub ArithmeticFunctions()

    End Sub
    Sub StringHandlingFunctions()

    End Sub
    Sub StringConversionFunctions()

    End Sub
    Sub Iteration()

    End Sub
    Sub Flowcharts()

    End Sub
    Sub ProceduresAndFunctions()

    End Sub
    Sub ByRefVsByVal()

    End Sub
    Sub Constants()

    End Sub
    Sub DataStructures()

    End Sub
    Sub OtherBuiltInDataTypes()

    End Sub
    Sub OneDimensionalArrays()

    End Sub
    Sub ReadWriteTextFromToATextFile()

    End Sub
    Sub ReadWriteRecordsFromToAFileOfRecords()

    End Sub
    Sub Validation()

    End Sub
    Sub TwoDimensionalArrays()

    End Sub
    Sub Enumerated()

    End Sub
    Sub SetOperators()

    End Sub
    Sub LinearSearch()

    End Sub
    Sub BubbleSearch()

    End Sub
End Module
