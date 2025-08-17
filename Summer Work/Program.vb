Imports System.Security.Cryptography.X509Certificates

Module SelectionInterface
    Sub Main()
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub MainMenu(MenuName As String)
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
            MenuName = "Main Menu"
            Console.Clear()
            Call Header(MenuName)
            Console.WriteLine("(1) Moderation Exercises")
            Console.WriteLine("(2) Programming Tasks" & vbCrLf)
            userinput = Console.ReadLine()
            Console.Clear()
            Select Case userinput
                Case 1
                    Call ModerationExercisesMenu(MenuName)
                Case 2
                    Call ProgrammingTasksMenu(MenuName)
                Case Else
                    validinput = False
                    Console.WriteLine(vbCrLf & "Error: Please try again")
                    Console.ReadLine()
            End Select
        End While
    End Sub

    Sub ModerationExercisesMenu(MenuName As String)
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
            MenuName = "Moderation Exercises Menu"
            Console.Clear()
            Call Header(MenuName)
            Console.WriteLine("(1) Central Heating")
            Console.WriteLine("(2) Car Hire" & vbCrLf)
            userinput = Console.ReadLine()
            Console.Clear()
            Select Case userinput
                Case 1
                    Call CentralHeating()
                Case 2
                    Call CarHire()
                Case Else
                    validinput = False
                    Console.WriteLine(vbCrLf & "Error: Please try again")
                    Console.ReadLine()
            End Select
        End While
    End Sub

    Sub ProgrammingTasksMenu(MenuName As String)
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
            MenuName = "Programming Tasks menu"
            Console.Clear()
            Call Header(MenuName)
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
            Console.WriteLine("(26) Bubble Search" & vbCrLf)
            userinput = Console.ReadLine()
            Console.Clear()
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
                    Console.WriteLine(vbCrLf & "Error: Please try again")
                    Console.ReadLine()
            End Select
        End While
    End Sub

    Sub Header(MenuName As String)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("***** " & MenuName & " *****" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Please select one of the following:" & vbCrLf)
    End Sub
    Function ProgramFooter()
        Dim userinput As Integer = 0
        Dim validinput As Boolean = False
        While validinput = False
            validinput = True
            Console.WriteLine(vbCrLf & "Please select one of the following:" & vbCrLf)
            Console.WriteLine("(1) Repeat Program")
            Console.WriteLine("(2) Main Menu" & vbCrLf)
            userinput = Console.ReadLine()
            Console.Clear()
            If userinput = 1 Or userinput = 2 Then
                Return userinput
            Else
                validinput = False
                Console.WriteLine(vbCrLf & "Error: Please try again")
                Console.ReadLine()
            End If
        End While
    End Function
End Module

Module ModerationExercises
    Sub CentralHeating()
        Dim userinput As Integer = 1
        While userinput = 1
            Dim TempOne As Integer = 0
            Dim TempTwo As Integer = 0
            Dim TempThree As Integer = 0
            Dim AverageTemp As Integer = 0
            Console.Write("Please enter the temperature of the Art Department: ")
            TempOne = Console.ReadLine()
            Console.Write("Please enter the temperature of the English Department: ")
            TempTwo = Console.ReadLine()
            Console.Write("Please enter the temperature of the Music Department: ")
            TempThree = Console.ReadLine()
            AverageTemp = (TempOne + TempTwo + TempThree) / 3
            Console.WriteLine("The average temperature is: " & AverageTemp)
            If AverageTemp < 17 Then
                Console.WriteLine("Heating should be on")
            Else
                Console.WriteLine("Heating should be off")
            End If
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
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
            Console.ForegroundColor = ConsoleColor.White
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub Assignment()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub Arithmetic()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim usernumber As Decimal = 0
            Console.Write("Please enter a number: ")
            usernumber = Console.ReadLine() / 2
            Console.WriteLine("Your number divided by 2 is: " & usernumber)
            Console.ReadLine()
            Console.WriteLine("Task 2:" & vbCrLf)
            Console.WriteLine("The 7 times table is:")
            For i = 1 To 12
                Console.WriteLine(7 * i)
            Next
            Console.ReadLine()
            Console.WriteLine("Task 3" & vbCrLf)
            Console.Write("Please enter a number: ")
            usernumber = Console.ReadLine()
            Console.WriteLine("The " & usernumber & " times table is:")
            For i = 1 To 12
                Console.WriteLine(usernumber * i)
            Next
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub Selection()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim usernumber As Integer = 0
            Console.Write("What is 24 + 9 = ")
            usernumber = Console.ReadLine()
            If usernumber = 33 Then
                Console.WriteLine("Excellent")
                Console.ReadLine()
            End If
            Console.WriteLine("Task 2:" & vbCrLf)
            Console.Write("How many are in a bakers dozen: ")
            usernumber = Console.ReadLine()
            If usernumber = 13 Then
                Console.WriteLine("Most Excellent")
                Console.ReadLine()
            End If
            Console.WriteLine("Task 3:" & vbCrLf)
            Dim age As Integer = 0
            Console.Write("Please enter your age: ")
            age = Console.ReadLine()
            If age < 18 Then
                Console.WriteLine("Sorry, this film is not for you")
                Console.ReadLine()
            End If
            Console.WriteLine("Task 4:" & vbCrLf)
            Dim NumOne As Integer = 0
            Dim NumTwo As Integer = 0
            Console.Write("Please enter the first number: ")
            NumOne = Console.ReadLine()
            Console.Write("Please enter the second number: ")
            NumTwo = Console.ReadLine()
            If NumOne = NumTwo Then
                Console.WriteLine("The numbers are equal")
            ElseIf NumOne > NumTwo Then
                Console.WriteLine("The first is bigger")
            ElseIf NumOne < NumTwo Then
                Console.WriteLine("The second is bigger")
            End If
            Console.ReadLine()
            Console.WriteLine("Task 5:" & vbCrLf)
            Dim userpassword As String = ""
            Console.Write("Please enter your password: ")
            userpassword = Console.ReadLine()
            If userpassword = "PASSWORD" Then
                Console.WriteLine("Welcome to the treasure")
            Else
                Console.WriteLine("Go away, it's all mine")
            End If
            Console.ReadLine()
            Console.WriteLine("Task 6:" & vbCrLf)
            Console.Write("Please enter a number between 1 and 10: ")
            usernumber = Console.ReadLine()
            If 1 > usernumber Or usernumber > 10 Then
                Console.WriteLine("Sorry... out of range")
            End If
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub RelationalOperators()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub BooleanOperators()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub LogicalBitwiseOperators()
        Console.WriteLine("Task 1: " & vbCrLf)
        Dim a, b, c, d, e, f, g As Boolean
        a = 23 > 14 And 11 > 8
        Console.WriteLine("a = 23 > 14 And 11 > 8     This sets a to: " & a)
        b = 14 > 23 And 11 > 8
        Console.WriteLine("b = 14 > 23 And 11 > 8     This sets b to: " & b)
        c = 23 > 14 Or 8 > 11
        Console.WriteLine("c = 23 > 14 Or 8 > 11      This sets c to: " & c)
        d = 23 > 67 Or 8 > 11
        Console.WriteLine("d = 23 > 67 Or 8 > 11      This sets d to: " & d)
        e = 23 > 67 Xor 11 > 8
        Console.WriteLine("e = 23 > 67 Xor 11 > 8     This sets e to: " & e)
        f = 23 > 14 Xor 11 > 8
        Console.WriteLine("f = 23 > 14 Xor 11 > 8     This sets f to: " & f)
        g = 14 > 23 Xor 8 > 11
        Console.WriteLine("g = 14 > 23 Xor 8 > 11     This sets g to: " & g)
        Dim x, y As Boolean
        x = Not 23 > 14
        Console.WriteLine("x = Not 23 > 14            This sets x to: " & x)
        y = Not 23 > 67
        Console.WriteLine("y = Not 23 > 67            This sets y to: " & y)
        Console.ReadLine()
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
