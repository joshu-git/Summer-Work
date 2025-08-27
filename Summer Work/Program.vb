Imports System.IO
Module Menu
    'Declares useable menu names as enum
    Enum MenuName
        _MainMenu
        _ModerationTasks
        _ProgrammingTasks
        _ExtensionTasks
    End Enum
    Sub Main()
        'Calls the main menu in Menu
        Menu(MenuName._MainMenu)
    End Sub
    Sub Menu(SelectedMenu As MenuName)
        'Declares 2D of that includes all menus
        Dim Menus(,) As String = {{"Moderation Tasks", "Programming Tasks", "Extension Tasks", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""},
                                  {"Central Heating", "Car Hire", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""},
                                  {"Sequence", "Arithmetic", "Selection", "Logical Bitwise", "Arithmetic Functions", "String Handling", "String Conversion", "Iteration", "Flowcharts", "Procedures & Functions", "Data Structures", "1D Arrays", "Text Files", "Record Files", "Validation", "2D Arrays", "Linear Search", "Bubble Search"},
                                  {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}}

        'Declares user's selected option as an integer
        Dim SelectedOption As Integer

        'Ensures areas of programming are ignored based on value
        Dim BackspacePressed As Boolean

        'Loops menu until program is closed
        Do
            'Makes the cursor invisible
            Console.CursorVisible = False
            'Decides which menu to display
            Select Case SelectedMenu
                Case MenuName._MainMenu
                    'If BackspacePressed is true it's set to false
                    If BackspacePressed Then
                        BackspacePressed = False
                    End If

                    'Calls menu interface with MainMenu information
                    MenuInterface(SelectedMenu, SelectedOption, 3, Menus, BackspacePressed)
                    'Decides which program to call based on selected option
                    Select Case SelectedOption
                        Case 0
                            SelectedMenu = MenuName._ModerationTasks
                        Case 1
                            SelectedMenu = MenuName._ProgrammingTasks
                        Case 2
                            SelectedMenu = MenuName._ExtensionTasks
                    End Select

                Case MenuName._ModerationTasks
                    'Calls menu interface with ModerationTasks information
                    MenuInterface(SelectedMenu, SelectedOption, 2, Menus, BackspacePressed)
                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                CentralHeating()
                            Case 1
                                CarHire()
                        End Select
                    End If
                Case MenuName._ProgrammingTasks
                    'Calls menu interface with ProgrammingTasks information
                    MenuInterface(SelectedMenu, SelectedOption, 17, Menus, BackspacePressed)
                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                Sequence()
                            Case 1
                                Arithmetic()
                            Case 2
                                Selection()
                            Case 3
                                LogicalBitwiseOperators()
                            Case 4
                                ArithmeticFunctions()
                            Case 5
                                StringHandlingFunctions()
                            Case 6
                                StringConversionFunctions()
                            Case 7
                                Iteration()
                            Case 8
                                Flowcharts()
                            Case 9
                                ProceduresAndFunctions()
                            Case 10
                                DataStructures()
                            Case 11
                                OneDimensionalArrays()
                            Case 12
                                ReadWriteTextFromToATextFile()
                            Case 13
                                ReadWriteRecordsFromToAFileOfRecords()
                            Case 14
                                Validation()
                            Case 15
                                TwoDimensionalArrays()
                            Case 16
                                LinearSearch()
                            Case 17
                                BubbleSearch()
                        End Select
                    End If
                Case MenuName._ExtensionTasks
                    'Calls menu interface with Extensionasks information
                    MenuInterface(SelectedMenu, SelectedOption, 0, Menus, BackspacePressed)
                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                        End Select
                    End If
            End Select
        Loop
    End Sub

    Sub MenuInterface(ByRef SelectedMenu As MenuName, ByRef SelectedOption As Integer, MenuSize As Integer, Menus(,) As String, ByRef BackspacePressed As Boolean)
        'Stores information from Console.ReadKey()
        Dim MenuSelect As ConsoleKeyInfo

        'Resets the selected option to 0
        SelectedOption = 0

        'Loops menu interface until enter has been pressed
        Do
            'Displays selected menu information
            Select Case SelectedMenu
                Case MenuName._MainMenu
                    Console.WriteLine("Main Menu:               Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ModerationTasks
                    Console.WriteLine("Moderation Tasks:        Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ProgrammingTasks
                    Console.WriteLine("Programming Tasks:       Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ExtensionTasks
                    Console.WriteLine("Extension Tasks:         Navigate using arrows. Enter to select. Backspace to return.")
            End Select

            'Displays selected menu with selected option highlighted
            For x = 0 To MenuSize - 1
                'Adds a line break every four options
                If x Mod 3 = 0 Then
                    Console.WriteLine()
                End If
                If SelectedOption = x Then
                    'Displays user's selected item in magenta
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.Write(Menus(SelectedMenu, x).PadRight(30, " "))
                    'Sets the color back to white
                    Console.ForegroundColor = ConsoleColor.White
                Else
                    'Displays unselected items
                    Console.Write(Menus(SelectedMenu, x).PadRight(30, " "))
                End If
            Next

            'Changes user's selected option in menu based on keypress
            MenuSelect = Console.ReadKey()
            Select Case MenuSelect.Key
                Case ConsoleKey.Backspace
                    'Takes user back to the main menu
                    SelectedMenu = MenuName._MainMenu
                    BackspacePressed = True
                    Console.Clear()
                    Return
                Case ConsoleKey.LeftArrow
                    'Checks if it can move selected option left
                    If SelectedOption - 1 > -1 Then
                        'Moves selected option left
                        SelectedOption = SelectedOption - 1
                    End If
                Case ConsoleKey.RightArrow
                    'Checks if it can move selected option right
                    If SelectedOption + 1 < MenuSize Then
                        'Moves selected option right
                        SelectedOption = SelectedOption + 1
                    End If
                Case ConsoleKey.UpArrow
                    'Checks if it can move selected option up
                    If SelectedOption - 3 > -1 Then
                        'Moves selected option up
                        SelectedOption = SelectedOption - 3
                    End If
                Case ConsoleKey.DownArrow
                    'Checks if it can move selected option down
                    If SelectedOption + 3 < MenuSize Then
                        'Moves selected option down
                        SelectedOption = SelectedOption + 3
                    End If
            End Select
            Console.Clear()
        Loop Until MenuSelect.Key = ConsoleKey.Enter
        'Makes cursor visible
        Console.CursorVisible = True
    End Sub
End Module

Module ModerationExercises
    Sub CentralHeating()
        'Stores ArtTemp, EnglishTemp and MusicTemp from user input
        Console.Write("Please enter the temperature of the Art Department: ")
        Dim ArtTemp As Double = Console.ReadLine()
        Console.Write("Please enter the temperature of the English Department: ")
        Dim EnglishTemp As Double = Console.ReadLine()
        Console.Write("Please enter the temperature of the Music Department: ")
        Dim MusicTemp As Double = Console.ReadLine()

        'Calculates the avergae temperature and diplays it
        Dim AverageTemp As Double = (ArtTemp + EnglishTemp + MusicTemp) / 3
        Console.WriteLine("The average temperature is: " & AverageTemp)

        'Determines if the heating should be on or off
        If AverageTemp < 17 Then
            Console.WriteLine("Heating should be on")
        Else
            Console.WriteLine("Heating should be off")
        End If
        Console.ReadLine()
    End Sub
    Sub CarHire()
        'Declares variables for user inputted information
        Dim CarMake As String
        Dim CarModel As String
        Dim DailyRate As Decimal

        'Loops untila valid price is inputted
        Dim ValidPrice As Boolean
        Do
            'Resets console and displays information
            Console.Clear()
            Console.WriteLine("TERVEUN CAR HIRE COMPANY" & vbCrLf)

            'Stores userinputted information about the car
            Console.Write("Enter car make. ")
            CarMake = Console.ReadLine()
            Console.Write("Enter car model. ")
            CarModel = Console.ReadLine()
            Console.Write("Enter daily rate. ")
            DailyRate = Console.ReadLine()

            'Decides if the daily rate is within the valid range
            If DailyRate >= 20 And DailyRate <= 70 Then
                ValidPrice = True
            Else
                Console.WriteLine("Invalid price. Please try again!")
            End If
        Loop Until ValidPrice

        'Displays the price for up to 14 days of using the car
        Console.WriteLine(vbCrLf & "Days    Price (£)")
        For x = 1 To 14
            If x < 10 Then
                Console.WriteLine(x & "       " & x * DailyRate)
            Else
                Console.WriteLine(x & "      " & x * DailyRate)
            End If
        Next

        'Displays a custom message if the car make is VW
        If CarMake = "VW" Then
            Console.WriteLine(vbCrLf & "YOU GET A FREE ROAD ATLAS WITH THIS HIRE")
        End If
        Console.ReadLine()
    End Sub
End Module

Module ProgrammingTasks
    Public Const Pi As Double = 3.14159265358979
    Sub Sequence()
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
    End Sub
    Sub Arithmetic()
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
    End Sub
    Sub Selection()
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
    End Sub
    Sub LogicalBitwiseOperators()
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
    End Sub
    Sub ArithmeticFunctions()
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
    End Sub
    Sub StringHandlingFunctions()
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
    End Sub
    Sub StringConversionFunctions()
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
    End Sub
    Sub Iteration()
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
    End Sub
    Sub Flowcharts()
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
    End Sub
    Sub ProceduresAndFunctions()
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
        Console.Write("Please enter the car's release year: ")
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
    Structure cars
        Public _Name As String
        Public _Manufacturer As String
        Public _Cost As Decimal
        Public _Year As Integer
    End Structure
    Structure people
        Public _Name As String
        Public _Age As Integer
    End Structure
    Sub OneDimensionalArrays()
        Console.WriteLine("Task 1:" & vbCrLf)
        Dim numbers(50) As Integer
        For x = 1 To UBound(numbers)
            Console.WriteLine("(" & x & ") " & numbers(x - 1))
        Next
        Console.WriteLine(UBound(numbers))
        Console.ReadLine()
        Console.WriteLine("Task 2:" & vbCrLf)
        Dim cars(5) As cars
        Dim createspace As Integer = 0
        For x = 1 To UBound(cars)
            If createspace <> x Then
                createspace = x
                Console.WriteLine()
            End If
            Console.WriteLine("(" & x & ") Please enter the car's name: ")
            cars(x - 1)._Name = Console.ReadLine()
            Console.WriteLine("(" & x & ") Please enter the car's manafacuter: ")
            cars(x - 1)._Manufacturer = Console.ReadLine()
            Console.WriteLine("(" & x & ") Please enter the car's cost: ")
            cars(x - 1)._Cost = Console.ReadLine()
            Console.WriteLine("(" & x & ") Please enter the car's release year: ")
            cars(x - 1)._Year = Console.ReadLine()
        Next
        For x = 1 To UBound(cars)
            Console.WriteLine("(" & x & ") " & cars(x - 1)._Year & " " & cars(x - 1)._Name & " by " & cars(x - 1)._Manufacturer & " : " & cars(x - 1)._Cost)
        Next
        Console.ReadLine()
        Console.WriteLine("Task 3:" & vbCrLf)
        Dim people(5) As people
        For x = 1 To UBound(people)
            If createspace <> x Then
                createspace = x
                Console.WriteLine()
            End If
            Console.WriteLine("(" & x & ") Please enter the person's name: ")
            people(x - 1)._Name = Console.ReadLine()
            Console.WriteLine("(" & x & ") Please enter the person's age: ")
            people(x - 1)._Age = Console.ReadLine()
        Next
        For x = 1 To UBound(people)
            Console.WriteLine("(" & x & ") " & people(x - 1)._Name & " : " & people(x - 1)._Age)
        Next
        Console.ReadLine()
        Console.WriteLine("Task 4:" & vbCrLf)
        Dim SearchKey As String = ""
        Dim LinearResult As Integer = 0
        Dim ValidName As Boolean = False
        Do
            Console.Write("Please enter the car you'd like to search for: ")
            SearchKey = Console.ReadLine()
            LinearResult = LinearSearchCars(SearchKey, cars)
            If LinearResult <> -1 Then
                Console.WriteLine(cars(LinearResult)._Year & " " & cars(LinearResult)._Name & " by " & cars(LinearResult)._Manufacturer & " : " & cars(LinearResult)._Cost)
            Else
                Console.WriteLine("Error: Car could not be found. Please try again!")
            End If
            Console.ReadLine()
        Loop Until ValidName
    End Sub
    Function LinearSearchCars(SearchKey As String, Array() As cars) As Integer
        Dim x As Integer = 0
        For x = 1 To UBound(Array)
            If Array(x - 1)._Name = SearchKey Then
                Return x - 1
            End If
        Next
        Return -1
    End Function
    Sub ReadWriteTextFromToATextFile()
        Console.WriteLine("Task 1:" & vbCrLf)
        Dim objStreamReader As IO.StreamReader
        Dim strLine As String = ""
        objStreamReader = New IO.StreamReader("studentnames.txt")
        strLine = objStreamReader.ReadLine
        Do While Not strLine Is Nothing
            Console.WriteLine(strLine)
            strLine = objStreamReader.ReadLine
        Loop
        objStreamReader.Close()
        Console.ReadLine()
    End Sub
    Sub ReadWriteRecordsFromToAFileOfRecords()

    End Sub
    Sub Validation()
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
    End Sub
    Sub TwoDimensionalArrays()

    End Sub
    Structure Teamsheet
        Public _Name As String
        Public _Surname As String
    End Structure
    Sub LinearSearch()
        Console.WriteLine("Task 1:" & vbCrLf)
        Dim Teamsheet(5) As Teamsheet
        Dim SearchKey As String = ""
        Dim LinearResult As Integer = 0
        Dim ValidName As Boolean = False
        For x = 1 To UBound(Teamsheet)
            Console.Write("Please enter a player name: ")
            Teamsheet(x - 1)._Name = Console.ReadLine()
            Console.Write("Please enter a player surname: ")
            Teamsheet(x - 1)._Surname = Console.ReadLine()
        Next
        Do
            Console.Write("Please search for a player by surname: ")
            SearchKey = Console.ReadLine()
            LinearResult = LinearSearchTeamsheet(SearchKey, Teamsheet)
            If LinearResult <> -1 Then
                Console.WriteLine(Teamsheet(LinearResult)._Name & " " & Teamsheet(LinearResult)._Surname)
                ValidName = True
            Else
                Console.WriteLine("Error: Player could not be found. Please try again!")
            End If
            Console.ReadLine()
        Loop Until ValidName
        Console.WriteLine("Task 2:" & vbCrLf)
        Dim TopSongs() As String = {"Golden", "The Subway", "No Broke Boys", "Daisies", "Soda Pop", "Your Idol", "Ordinary", "Saphire", "Beautiful Things"}
        ValidName = False
        For x = 1 To UBound(TopSongs)
            Console.WriteLine("(" & x & ") " & TopSongs(x - 1))
        Next
        Do
            Console.Write("Please search for a top 10 song: ")
            SearchKey = Console.ReadLine()
            LinearResult = LinearSearchTopSongs(SearchKey, TopSongs)
            If LinearResult <> -1 Then
                Console.WriteLine("(" & LinearResult + 1 & ") " & TopSongs(LinearResult))
                ValidName = True
            Else
                Console.WriteLine("Error: Song could not be found. Please try again!")
            End If
            Console.ReadLine()
        Loop Until ValidName
        Console.WriteLine("Task 3:" & vbCrLf)
        Dim Names(5) As String
        Dim Addresses(5) As String
        For x = 1 To UBound(Names)
            Console.Write("(" & x & ") Please enter a name: ")
            Names(x - 1) = Console.ReadLine
            Console.Write("(" & x & ") Please enter their address")
            Addresses(x - 1) = Console.ReadLine()
        Next
        Console.ReadLine()
        Console.WriteLine("Task 4:" & vbCrLf)
        ValidName = False
        Do
            Console.Write("Please search for a person: ")
            SearchKey = Console.ReadLine()
            LinearResult = LinearSearchNames(SearchKey, Names)
            If LinearResult <> -1 Then
                Console.WriteLine("(" & LinearResult + 1 & ") " & Names(LinearResult) & " : " & Addresses(LinearResult))
                ValidName = True
            Else
                Console.WriteLine("Error: Person could not be found. Please try again!")
            End If
            Console.ReadLine()
        Loop
        Console.WriteLine("Task 5:" & vbCrLf)
        Dim Numbers(5) As String
        Dim ValidNumber As Boolean = False
        For x = 1 To UBound(Numbers)
            Do
                Console.WriteLine("(" & x & ") Please enter " & Names(x - 1) & "'s number: ")
                Numbers(x - 1) = Console.ReadLine
                If Numbers(x - 1).Length = 11 Then
                    ValidNumber = True
                Else
                    Console.WriteLine("Error: Incorrect length. Please try again!")
                    Console.ReadLine()
                End If
            Loop Until ValidNumber
        Next
        ValidName = False
        Do
            Console.Write("Please search for a person: ")
            SearchKey = Console.ReadLine()
            LinearResult = LinearSearchNames(SearchKey, Names)
            If LinearResult <> -1 Then
                Console.WriteLine("(" & LinearResult + 1 & ") " & Names(LinearResult) & " : " & Addresses(LinearResult) & " : " & Numbers(LinearResult))
                ValidName = True
            Else
                Console.WriteLine("Error: Person could not be found. Please try again!")
            End If
            Console.ReadLine()
        Loop
    End Sub
    Function LinearSearchTeamsheet(SearchKey As String, Array() As Teamsheet) As Integer
        Dim x As Integer = 0
        For x = 1 To UBound(Array)
            If SearchKey = Array(x - 1)._Surname Then
                Return x
            End If
        Next
        Return -1
    End Function
    Function LinearSearchTopSongs(SearchKey As String, Array() As String) As Integer
        Dim x As Integer = 0
        For x = 1 To UBound(Array)
            If SearchKey = Array(x - 1) Then
                Return x
            End If
        Next
        Return -1
    End Function
    Function LinearSearchNames(SearchKey As String, Array() As String) As Integer
        Dim x As Integer = 0
        For x = 1 To UBound(Array)
            If SearchKey = Array(x - 1) Then
                Return x
            End If
        Next
        Return -1
    End Function
    Sub BubbleSearch()
        Console.WriteLine("Task 1:" & vbCrLf)
        Console.WriteLine("Enter any sequence of ages followed by a space: ")
        Dim Ages As String() = Console.ReadLine().Split(" ")
        For a = 0 To UBound(Ages) Step 1
            For b = 0 To UBound(Ages) - 1
                If CInt(Ages(b + 1)) < CInt(Ages(b)) Then
                    Dim temp As Integer = CInt(Ages(b + 1))
                    Ages(b + 1) = Ages(b)
                    Ages(b) = temp
                End If
            Next
        Next
        Console.WriteLine("The sorted ages will be:")
        For Each x In Ages
            Console.Write(x & " ")
        Next
        Console.ReadLine()
    End Sub
End Module
Module SubSystems
    'Declares useable datatypes as enum
    Enum DataType
        _String
        _Boolean
        _Integer
        _Double
        _Decimal
    End Enum
    'Fills an array with user inputs in a given datatype
    Function ArrayFiller(Subject As String, ArrayType As DataType)
        'Repeats code until valid array is returned
        Do
            'Creates an array as string from user inputs
            Console.WriteLine("Enter any sequence of " & Subject & " seperated by spaces: ")
            Dim TesterArray() As String = Console.ReadLine().Split(" ")

            'Determines the intended data type of array
            Select Case ArrayType
                Case DataType._String
                    Return TesterArray
                Case DataType._Boolean
                    'Declares array as boolean
                    Dim CheckedArray(TesterArray.GetUpperBound(0)) As Boolean
                    For Test = 0 To TesterArray.GetUpperBound(0)
                        'Converts string array to boolean and checks for errors
                        If Boolean.TryParse(TesterArray(Test), False) Then
                            CheckedArray(Test) = Boolean.Parse(TesterArray(Test))
                        Else
                            'Exits select if an error occurs
                            Exit Select
                        End If
                    Next
                    'Returns converted array
                    Return CheckedArray
                Case DataType._Integer
                    'Declares array as integer
                    Dim CheckedArray(TesterArray.GetUpperBound(0)) As Integer
                    For Test = 0 To TesterArray.GetUpperBound(0)
                        'Converts string array to integer and checks for errors
                        If Integer.TryParse(TesterArray(Test), 0) Then
                            CheckedArray(Test) = Integer.Parse(TesterArray(Test))
                        Else
                            'Exits select if an error occurs
                            Exit Select
                        End If
                    Next
                    'Returns converted array
                    Return CheckedArray
                Case DataType._Double
                    'Declares array as double
                    Dim CheckedArray(TesterArray.GetUpperBound(0)) As Double
                    For Test = 0 To TesterArray.GetUpperBound(0)
                        'Converts string array to double and checks for errors
                        If Double.TryParse(TesterArray(Test), 0) Then
                            CheckedArray(Test) = Double.Parse(TesterArray(Test))
                        Else
                            'Exits select if an error occurs
                            Exit Select
                        End If
                    Next
                    'Returns converted array
                    Return CheckedArray
                Case DataType._Decimal
                    'Declares array as decimal
                    Dim CheckedArray(TesterArray.GetUpperBound(0)) As Decimal
                    For Test = 0 To TesterArray.GetUpperBound(0)
                        'Converts string array to decimal and checks for errors
                        If Decimal.TryParse(TesterArray(Test), 0) Then
                            CheckedArray(Test) = Decimal.Parse(TesterArray(Test))
                        Else
                            'Exits select if an error occurs
                            Exit Select
                        End If
                    Next
                    'Returns converted array
                    Return CheckedArray
            End Select
            'Calls error message for invalid array
            ErrorMessage(ErrorCodes._InvalidArray)
        Loop
    End Function
End Module

Module Errors
    'Declares known errorcodes as enum
    Enum ErrorCodes
        _InvalidArray
    End Enum
    'Displays an error message based on a given error code
    Sub ErrorMessage(ErrorCode As ErrorCodes)
        'Sets text color to red
        Console.ForegroundColor = ConsoleColor.Red
        'Chooses error message to display
        Select Case ErrorCode
            Case ErrorCodes._InvalidArray
                Console.WriteLine("Code 0: Error invalid array.")
        End Select
        'Sets text colour to white
        Console.ForegroundColor = ConsoleColor.White
        'Clears user interface after enter
        Console.ReadLine()
        Console.Clear()
    End Sub
End Module
