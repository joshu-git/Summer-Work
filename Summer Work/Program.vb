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
    Public Const Pi As Double = 3.14159265358979
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
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
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
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub ArithmeticFunctions()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim NumOne As Decimal = 0
            Dim NumTwo As Decimal = 0
            Dim NumThree As Decimal = 0
            Dim NumFour As Decimal = 0
            Dim NumFive As Decimal = 0
            Dim MeanAverage As Decimal = 0
            Dim Rounded As Integer = 0
            Console.Write("Please enter the first number: ")
            NumOne = Console.ReadLine()
            Console.Write("Please enter the second number: ")
            NumTwo = Console.ReadLine()
            Console.Write("Please enter the third number: ")
            NumThree = Console.ReadLine()
            Console.Write("Please enter the fourth number: ")
            NumFour = Console.ReadLine()
            Console.Write("Please enter the fifth number: ")
            NumFive = Console.ReadLine()
            MeanAverage = (NumOne + NumTwo + NumThree + NumFour + NumFive) / 5
            Rounded = Math.Round(MeanAverage)
            Console.WriteLine(vbCrLf & "The rounded mean average is: " & Rounded)
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub StringHandlingFunctions()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim StoredUser As String = "joshu-git"
            Dim UserUser As String = ""
            Console.Write("Please enter a username: ")
            UserUser = Console.ReadLine()
            If UserUser.ToLower = StoredUser Then
                Console.WriteLine("Correct")
            Else
                Console.WriteLine("Incorrect")
            End If
            Console.ReadLine()
            Console.WriteLine("Task 2:" & vbCrLf)
            Dim StoredPassword As String = "nottellingyou"
            Dim UserPassword As String = ""
            Console.Write("Please enter a password: ")
            UserPassword = RTrim(Console.ReadLine())
            If UserPassword.ToLower = StoredPassword Then
                Console.WriteLine("Correct")
            Else
                Console.WriteLine("Incorrect")
            End If
            Console.ReadLine()
            Console.WriteLine("Task 3:" & vbCrLf)
            Dim UserPhoneNum As String = ""
            Console.Write("Please enter a phone number: ")
            UserPhoneNum = Console.ReadLine()
            If UserPhoneNum.Length = 11 Then
                Console.WriteLine("Correct Length")
            Else
                Console.WriteLine("Incorrect Length")
            End If
            Console.ReadLine()
            Console.WriteLine("Task 4:" & vbCrLf)
            Dim FullName As String = ""
            Dim FirstName As String = ""
            Dim LastName As String = ""
            Console.Write("Please enter your full name: ")
            FullName = Console.ReadLine()
            Dim Names() As String = FullName.Split(" ")
            If Names.Length = 2 Then
                FirstName = Names(0)
                LastName = Names(1)
            End If
            Console.WriteLine("Your first name is: " & FirstName)
            Console.WriteLine("Your last name is: " & LastName)
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub StringConversionFunctions()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim theInt As Integer = 23021980
            Dim theReal As Double = 230.2198
            Dim theDate As DateTime = "23/2/1980"
            Console.WriteLine(Convert.ToString(theInt))
            Console.WriteLine(Convert.ToString(theInt) + "1")
            Console.WriteLine(theInt)
            Console.WriteLine(theInt + 1 & vbCrLf)
            Console.WriteLine(Convert.ToString(theReal))
            Console.WriteLine(Convert.ToString(theReal) + "1")
            Console.WriteLine(theReal)
            Console.WriteLine(theReal + 1 & vbCrLf)
            Console.WriteLine(Convert.ToString(theDate))
            Console.WriteLine(Convert.ToString(theDate) + "1")
            Console.WriteLine(theDate)
            Console.WriteLine(theDate.AddDays(1))
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub Iteration()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim UserName As String = ""
            Console.Write("Please enter your name: ")
            UserName = Console.ReadLine()
            For x = 1 To 5
                Console.WriteLine("(" & x & ") " & UserName)
            Next
            Console.ReadLine()
            Console.WriteLine("Task 2:" & vbCrLf)
            Dim UserTown As String = ""
            Console.Write("Please enter your town: ")
            UserTown = Console.ReadLine()
            For x = 1 To 10
                Console.WriteLine("(" & x & ") " & UserTown)
            Next
            Console.ReadLine()
            Console.WriteLine("Task 3:" & vbCrLf)
            Dim FavouriteCD As String = ""
            Dim CDArtist As String = ""
            Console.Write("Please enter your favourite CD: ")
            FavouriteCD = Console.ReadLine()
            Console.Write("Please enter the Cd's artist: ")
            CDArtist = Console.ReadLine()
            For x = 1 To 5
                Console.WriteLine("(" & x & ") " & FavouriteCD & " by " & CDArtist)
            Next
            Console.ReadLine()
            Console.WriteLine("Task 4:" & vbCrLf)
            Dim UserNum As Integer = 0
            Console.Write("Please enter a number: ")
            UserNum = Console.ReadLine()
            For x = 1 To 100
                Console.WriteLine("(" & x & ") " & x & " times " & UserNum & " = " & x * UserNum)
            Next
            Console.ReadLine()
            Console.WriteLine("Task 5:" & vbCrLf)
            Dim Total As Integer = 0
            Total = 0
            For x = 1 To 5
                Console.Write("(" & x & ") " & "Please enter a number: ")
                UserNum = Console.ReadLine()
                Total = Total + UserNum
            Next
            Console.WriteLine("Your total is: " & Total)
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub Flowcharts()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim x As Decimal = 0
            Dim y As Decimal = 0
            Dim sum As Decimal = 0
            Console.Write("Please input value of x: ")
            x = Console.ReadLine()
            Console.Write("Please input value of y: ")
            y = Console.ReadLine()
            sum = x + y
            Console.WriteLine("Total = " & sum)
            Console.ReadLine()
            Console.WriteLine("Task 2:" & vbCrLf)
            Dim MoreVolumes As Boolean = True
            Dim Radius As Decimal = 0
            Dim Volume As Decimal = 0
            Dim UserChoice As String = ""
            While MoreVolumes
                Console.Write("Please input value of radius: ")
                Radius = Console.ReadLine()
                Volume = 3.142 * (4 / 3) * Radius ^ 2
                Console.WriteLine("Radius: " & Radius)
                Console.WriteLine("Volume: " & Volume)
                Console.WriteLine(vbCrLf & "Any more volumes to be calcualated?")
                UserChoice = Console.ReadLine()
                If UserChoice = "No" Then
                    MoreVolumes = False
                End If
            End While
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub ProceduresAndFunctions()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim length As Decimal = 0
            Dim width As Decimal = 0
            Dim height As Decimal = 0
            Console.Write("Please enter the cuboid length: ")
            length = Console.ReadLine()
            Console.Write("Please enter the cuboid width: ")
            width = Console.ReadLine()
            Console.Write("Please enter the cuboid height: ")
            height = Console.ReadLine()
            Console.WriteLine("The cuboid volume is: " & Cuboid(length, width, height))
            Console.ReadLine()
            Console.WriteLine("Task 2:" & vbCrLf)
            Dim radius As Decimal = 0
            Console.Write("Please enter the sphere radius: ")
            radius = Console.ReadLine()
            Console.WriteLine("The sphere volume is: " & Sphere(radius))
            Console.ReadLine()
            Console.WriteLine("Task 3:" & vbCrLf)
            Call UserPassword()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Function Cuboid(length As Decimal, width As Decimal, height As Decimal)
        Return length * width * height
    End Function
    Function Sphere(radius As Decimal)
        Return radius * Pi * (4 / 3)
    End Function
    Sub UserPassword()
        Dim Validated As Boolean = False
        Dim Password As String = ""
        Dim StoredPassword As String = "nottellingyou"
        Do
            Console.Write("Please enter your password: ")
            Password = Console.ReadLine()
            If Password = StoredPassword Then
                Validated = True
                Console.WriteLine("Correct. Welcome!")
            Else
                Console.WriteLine("Incorrect. Please try again!")
            End If
            Console.ReadLine()
        Loop Until Validated
    End Sub
    Sub ByRefVsByVal()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub Constants()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Structure city
        Public _Name As String
        Public _Population As Long
        Public _Diameter As Double
        Public _Year As Integer
        Public _Council As String
    End Structure
    Structure car
        Public _Name As String
        Public _Year As Integer
        Public _Manufacturer As String
    End Structure
    Structure pet
        Public _Name As String
        Public _Age As Integer
        Public _Type As String
    End Structure
    Sub DataStructures()
        Console.WriteLine("Task 1:" & vbCrLf)
        Dim myRecord As city
        myRecord._Name = "Camberley"
        myRecord._Population = 36783
        myRecord._Year = 2021
        myRecord._Diameter = 4.1
        Console.Write(myRecord._Name & " city has population of ")
        Console.Write(myRecord._Population & " million people ")
        Console.Write("and diameter of " & myRecord._Diameter & " km in year " & myRecord._Year)
        Console.ReadLine()
        Console.WriteLine("Task 2:" & vbCrLf)
        Console.Write("Please enter the citie's name: ")
        myRecord._Name = Console.ReadLine()
        Console.Write("Please enter the citie's population: ")
        myRecord._Population = Console.ReadLine()
        Console.Write("Please enter the citie's year: ")
        myRecord._Year = Console.ReadLine()
        Console.Write("Please enter the citie's diameter: ")
        myRecord._Diameter = Console.ReadLine()
        Console.Write(myRecord._Name & " city has population of ")
        Console.Write(myRecord._Population & " million people ")
        Console.Write("and diameter of " & myRecord._Diameter & " km in year " & myRecord._Year)
        Console.ReadLine()
        Console.WriteLine("Task 3:" & vbCrLf)
        Console.Write("Please enter the citie's council: ")
        myRecord._Council = Console.ReadLine()
        Console.WriteLine("The citie's council is " & myRecord._Council)
        Console.ReadLine()
        Console.WriteLine("Task 4:" & vbCrLf)
        Dim Senna As car
        Console.Write("Please enter the car's name: ")
        Senna._Name = Console.ReadLine()
        Console.Write("Please enter the car's year: ")
        Senna._Year = Console.ReadLine()
        Console.Write("Please enter the car's manufacturer: ")
        Senna._Manufacturer = Console.ReadLine()
        Console.WriteLine("The car " & Senna._Name & " was first built in " & Senna._Year & " by " & Senna._Manufacturer)
        Console.ReadLine()
        Console.WriteLine("Task 5:" & vbCrLf)
        Dim Monkey As pet
        Console.Write("Please enter the pet's name: ")
        Monkey._Name = Console.ReadLine()
        Console.Write("Please enter the pet's age: ")
        Monkey._Age = Console.ReadLine()
        Console.Write("Please enter the type of pet they are : ")
        Monkey._Type = Console.ReadLine()
        Console.WriteLine("The pet " & Monkey._Name & " ia a " & Monkey._Type & " who is aged " & Monkey._Age)
        Console.ReadLine()
    End Sub
    Sub OtherBuiltInDataTypes()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub OneDimensionalArrays()

    End Sub
    Sub ReadWriteTextFromToATextFile()

    End Sub
    Sub ReadWriteRecordsFromToAFileOfRecords()

    End Sub
    Sub Validation()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Task 1:" & vbCrLf)
            Dim age As Integer = 0
            Console.WriteLine("Please enter your age: ")
            If age > 17 And age < 80 Then
                Console.WriteLine("You are old enough to drive")
            Else
                Console.WriteLine("You are not old enough to drive")
            End If
            Console.ReadLine()
            Console.WriteLine("Task 2:" & vbCrLf)
            Dim UserPhoneNum As String = ""
            Console.Write("Please enter a phone number: ")
            UserPhoneNum = Console.ReadLine()
            If UserPhoneNum.Length = 11 Then
                Console.WriteLine("Correct Length")
            Else
                Console.WriteLine("Incorrect Length")
            End If
            Console.ReadLine()
            Console.WriteLine("Task 3:" & vbCrLf)
            Dim Validated As Boolean = False
            Dim Username As String = ""
            Dim StoredUsername As String = "joshu-git"
            Dim Password As String = ""
            Dim StoredPassword As String = "nottellingyou"
            Do
                Console.Write("Please enter your username: ")
                Username = Console.ReadLine()
                Console.Write("Please enter your password: ")
                Password = Console.ReadLine()
                If Username = StoredUsername And Password = StoredPassword Then
                    Validated = True
                    Console.WriteLine("Correct. Welcome!")
                Else
                    Console.WriteLine("Incorrect. Please try again!")
                End If
                Console.ReadLine()
            Loop Until Validated
            userinput = ProgramFooter()
        End While
    End Sub
    Sub TwoDimensionalArrays()

    End Sub
    Sub Enumerated()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub SetOperators()
        Dim userinput As Integer = 1
        While userinput = 1
            Console.WriteLine("Error: No tasks found")
            Console.ReadLine()
            userinput = ProgramFooter()
        End While
        Dim MenuName As String = ""
        Call MainMenu(MenuName)
    End Sub
    Sub LinearSearch()

    End Sub
    Sub BubbleSearch()

    End Sub
End Module
