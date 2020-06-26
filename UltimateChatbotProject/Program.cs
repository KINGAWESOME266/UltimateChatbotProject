using System;
using System.Threading;

namespace UltimateChatbotProject
{
    class Program
    {
        public static void RPS()
        {
            Console.Clear();
            
            Random gen = new Random();
            string compchoices = "";
            string userchoices = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors!");
            Console.WriteLine("Type R/r (Rock), P/p (Paper), or S/s (Scissors)!");
            ConsoleKeyInfo userchoice = Console.ReadKey();

            int compchoice = gen.Next(1, 3);
            // If compchoice statements  
            if (compchoice == 1)
            {
                compchoices = "Rock";
            }
            else
            {
                if (compchoice == 2)
                {
                    compchoices = "Paper";
                }
                else
                {
                    if (compchoice == 3)
                    {
                        compchoices = "Scissors";
                    }

                }
            }
            // If userchoice statements  
            if (userchoice.Key == ConsoleKey.R)
            {
                userchoices = "Rock";
            }
            else if (userchoice.Key == ConsoleKey.P)
            {
                userchoices = "Paper";
            }
            else if (userchoice.Key == ConsoleKey.S)
            {
                userchoices = "Scissors";
            }
            // If userchoice and compchoice statements  
            if (userchoices == "Rock" && compchoices == "Rock")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                Console.WriteLine("It's a draw!!");
                Console.ReadLine();
                Choices();
            }
            else
            {
                if (userchoices == "Rock" && compchoices == "Paper")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                    Console.WriteLine("The computer wins!");
                    Console.ReadLine();
                    Choices();
                }
                else
                {
                    if (userchoices == "Rock" && compchoices == "Scissors")
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                        Console.WriteLine("The User wins!");
                        Console.ReadLine();
                        Choices();
                    }
                    else
                    {
                        if (userchoices == "Paper" && compchoices == "Rock")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                            Console.WriteLine("The User Wins!");
                            Console.ReadLine();
                            Choices();
                        }
                        else
                        {
                            if (userchoices == "Paper" && compchoices == "Scissors")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                Console.WriteLine("The Computer Wins!");
                                Console.ReadLine();
                                Choices();
                            }
                            else
                            {
                                if (userchoices == "Paper" && compchoices == "Paper")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                    Console.WriteLine("It's a Draw!");
                                    Console.ReadLine();
                                    Choices();
                                }

                                else
                                {
                                    if (userchoices == "Scissors" && compchoices == "Scissors")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                        Console.WriteLine("It's a Draw!");
                                        Console.ReadLine();
                                        Choices();
                                    }
                                    else
                                    {
                                        if (userchoices == "Scissors" && compchoices == "Paper")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                            Console.WriteLine("The User Wins");
                                            Console.ReadLine();
                                            Choices();
                                        }
                                        else
                                        {
                                            if (userchoices == "Scissors" && compchoices == "Rock")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                                Console.WriteLine("The Computer Wins!");
                                                Console.ReadLine();
                                                Choices();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void Chat()
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\niChatbot is loading...");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's Introduce Ourselves");
            Console.WriteLine("My name is Siri. What's yours?");
            string name = Console.ReadLine();
            if (name == "Siri")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHmmm");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nHello " + name + " nice to meet you! \n");
            }
            Console.WriteLine("How old are you");
            var age = Console.ReadLine();
            if (Convert.ToInt32(age) == 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMe too!");
                Console.WriteLine("\nWhat year are you in ?");
                var year = Console.ReadLine();
                if (Convert.ToInt16(year) == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nSame!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nI'm in year 10!");
                }
            }
            else
            {
                Console.WriteLine("\nI'm 14 years old");
                if (Convert.ToInt16(age) > Convert.ToInt16(14))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nI'm younger than you!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nI'm older than you!");
                }
            }
            Console.WriteLine("\nWhat's your favorite TV Show");
            string Show = Console.ReadLine();
            if (Show == "Designated Survivor" ^ Show == "designated survivor")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThat's a great TV Show");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nI haven't watched that yet");
                Console.WriteLine("\nIs it available on Netflix? (Y/N)");
                ConsoleKeyInfo yesbutton = Console.ReadKey();
                if (yesbutton.Key == ConsoleKey.Y)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nI'll check it out");
                }
                else if (yesbutton.Key == ConsoleKey.N)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nI'll try to watch it somehow");
                }
            }
            Console.WriteLine("\nWhat's your favorite song?");
            string song = Console.ReadLine();
            if (song == "Secreto" ^ song == "secreto")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nI love that song!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIs it on Spotify? (Y/N)");
                var spotifybutton = Console.ReadKey();
                if (spotifybutton.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\nI'll listen to it soon.");
                }
                else if (spotifybutton.Key == ConsoleKey.N)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nI'll try to listen to it sometime.");
                }
            }
            Console.WriteLine(name + " do you have any pets? (Y/N)\n");
            ConsoleKeyInfo pets = Console.ReadKey();
            if (pets.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine("Do you have a cat or a dog " + name + " ?" + " (C/D/N)\n ");
                ConsoleKeyInfo catdog = Console.ReadKey();
                if (catdog.Key == ConsoleKey.C)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("I have a cat\n");
                    Console.WriteLine("Is your cat big/small? (B/S)\n");
                    ConsoleKeyInfo catsize = Console.ReadKey();
                    if (catsize.Key == ConsoleKey.B)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("I like big cats.\n");
                    }
                    else if (catsize.Key == ConsoleKey.S)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Small cats are cute!\n");
                    }
                }
                else if (catdog.Key == ConsoleKey.D)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("I don't like dogs\n");
                }
                else if (catdog.Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nOh! I thought you had a cat or a dog!");
                }
            }
            else if (pets.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("I understand\n");
            }
            Console.WriteLine("\nHow did you enjoy this chatbot out of 1-10?\n");
            var rating = Console.ReadLine();
            if (Convert.ToInt16(rating) > 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Thank you for the nice rating!\n");
                Choices();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("I hope to improve for next time.\n");
                Choices();
            }
        }
        public static void Quit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Quitting...\n");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
        public static void Choices()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("What do you want to do now?");
            Console.WriteLine("R = RockPaperScissors, C = Chatbot, E = Even, N = Number Counter, M = Magic 8 Ball, X = Calculator, Q = Quit");
            ConsoleKeyInfo choicebutton = Console.ReadKey();
            if (choicebutton.Key == ConsoleKey.R)
            {
                RPS();
            }
            else if (choicebutton.Key == ConsoleKey.C)
            {
                Chat();
            }
            else if (choicebutton.Key == ConsoleKey.E)
            {
                Even();
            }
            else if (choicebutton.Key == ConsoleKey.Q)
            {
                Quit();
            }
            else if (choicebutton.Key == ConsoleKey.N)
            {
                Numbers();
            }
            else if (choicebutton.Key == ConsoleKey.M)
            {
                Magic8();
            }
            else if (choicebutton.Key == ConsoleKey.X)
            {
                Calc();
            }
        }
        public static void Even()
        {
            Console.Clear();
            
            Console.WriteLine("\nEnter a number below...");
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("\nThis is even!!!");
                Console.ReadLine();
                Choices();
            }
            else
            {
                Console.WriteLine("\nThis is odd...");
                Console.ReadLine();
                Choices();
            }
            Console.ReadLine();
        }
        public static void Numbers()
        {
            Console.Clear();
            
            Console.WriteLine("\nEnter a number below, I will count up to that number!");
            int countnum = int.Parse(Console.ReadLine());
            for (int i = 0; i < countnum; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press enter for choices");
            ConsoleKeyInfo choices = Console.ReadKey();
            if (choices.Key == ConsoleKey.Enter)
            {
                Console.ReadLine();
                Choices();
            }
            else
            {
                Quit();
            }
            Console.ReadLine();
        }
        public static void Magic8()
        {
            Console.Clear();
            
            Random gen = new Random();
            Console.WriteLine("Welcome to Magic 8 Ball. Write your question below: ");
            string question = Console.ReadLine();
            int random = gen.Next(1, 8);
            Console.WriteLine(random);
            if (random == 1)
            {
                Console.WriteLine("Definitely not! ");
                Console.ReadLine();
                Choices();
            }
            else
            {
                if (random == 2)
                {
                    Console.WriteLine("Highly Unlikely!");
                    Console.ReadLine();
                    Choices();
                }
                else
                {
                    if (random == 3)
                    {
                        Console.WriteLine("Unlikely...");
                        Console.ReadLine();
                        Choices();
                    }
                    else
                    {
                        if (random == 4)
                        {
                            Console.WriteLine("Even... Could be or could be not...");
                            Console.ReadLine();
                            Choices();
                        }
                        else
                        {
                            if (random == 5)
                            {
                                Console.WriteLine("Likely!");
                                Console.ReadLine();
                                Choices();
                            }
                            else
                            {
                                if (random == 6)
                                {
                                    Console.WriteLine("Highly Likely!");
                                    Console.ReadLine();
                                    Choices();
                                }
                                else
                                {
                                    if (random == 7)
                                    {
                                        Console.WriteLine("Imminent!");
                                        Console.ReadLine();
                                        Choices();
                                    }
                                    else
                                    {
                                        if (random == 8)
                                        {
                                            Console.WriteLine("Congratulations! It will happen!");
                                            Console.ReadLine();
                                            Choices();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Console.ReadLine();
            }
        }
        public static void Page1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Assistant. I'm your chatbot today.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(R = RockPaperScissors, C = iChatbot, E = Even or Not, Press -> for more!)");
            
            ConsoleKeyInfo button = Console.ReadKey();
            if (button.Key == ConsoleKey.R)
            {
                RPS();
                Console.ReadLine();
            }
            else if (button.Key == ConsoleKey.RightArrow)
            {
                Page2();
            }
            else if (button.Key == ConsoleKey.C)
            {
                Chat();
                Console.ReadLine();

            }
            else if (button.Key == ConsoleKey.E)
            {
                Even();

            }
            else
            {
                Quit();
            }
        }
        public static void Page2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("N = Number Counter, M = Magic 8 Ball, X = Calculator, Q = Quit, C = Convert, Press <- to go back)");
            ConsoleKeyInfo button2 = Console.ReadKey();
            if (button2.Key == ConsoleKey.N)
            {
                Numbers();
            }
            else if (button2.Key == ConsoleKey.M)
            {
                Magic8();
            }
            else if (button2.Key == ConsoleKey.Q)
            {
                Quit();
            }
            else if (button2.Key == ConsoleKey.X)
            {
                Calc();
            }
            else if (button2.Key == ConsoleKey.LeftArrow)
            {
                Page1();
            }
            else if (button2.Key == ConsoleKey.C)
            {
                Converter_StartPage();
            }

        }
        public static void Calc()
        {
            Console.Clear();
            // Declare variables and then initialize to zero.
            Console.ForegroundColor = ConsoleColor.Cyan;
            int num1 = 0;
            int num2 = 0;
            
            // Display title as the C# console calculator ap
            Console.WriteLine("\nWelcome to the Calculator!\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            ConsoleKeyInfo calckey = Console.ReadKey();
            if (calckey.Key == ConsoleKey.A)
            {
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                Console.ReadLine();
            }
            else if (calckey.Key == ConsoleKey.S)
            {
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                Console.ReadLine();
            }
            else if (calckey.Key == ConsoleKey.M)
            {
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                Console.ReadLine();
            }
            else if (calckey.Key == ConsoleKey.D)
            {
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                Console.ReadLine();
            }
            else
            {
                Quit();
            }
            Console.ReadLine();
            Choices();
            Console.ReadLine();
        }
        public static void Converter_StartPage()
        {
            Console.Clear();

            Console.WriteLine("Welcome to iCalc! Please choose to convert Weight, Temperature, Length and Speed, or go back to the main menu! (W/T/L/S/B)");
            ConsoleKeyInfo startpage = Console.ReadKey();
            if (startpage.Key == ConsoleKey.W)
            {
                Converter_WeightPage();
            }
            else if (startpage.Key == ConsoleKey.T)
            {
                Converter_TempPage();
            }
            else if (startpage.Key == ConsoleKey.L)
            {
                Converter_LengthPage();
            }
            else if (startpage.Key == ConsoleKey.S)
            {
                Convert_SpeedPage();
            }
            else if (startpage.Key == ConsoleKey.B)
            {
                Page2();
            }
        }
        public static void Converter_WeightPage()
        {
            Console.Clear();
            Console.WriteLine("Choose between converting KG to: LB, OZ, G, ST, Back (L/O/G/S/B)");
            ConsoleKeyInfo weightpage = Console.ReadKey();
            if (weightpage.Key == ConsoleKey.L)
            {
                Converter_LBS();
            }
            else if (weightpage.Key == ConsoleKey.O)
            {
                Converter_OZ();
            }
            else if (weightpage.Key == ConsoleKey.G)
            {
                Converter_Grams();
            }
            else if (weightpage.Key == ConsoleKey.S)
            {
                Converter_Stones();
            }
            else if (weightpage.Key == ConsoleKey.B)
            {
                Converter_StartPage();
            }
        }
        public static void Converter_LBS()
        {
            Console.Clear();
            Console.WriteLine("Enter the weight in KGs to convert to Lbs");
            int kgs = int.Parse(Console.ReadLine());
            var lbs = kgs * 2.2046;
            Console.WriteLine(kgs + " in kgs is " + lbs + "lbs");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_WeightPage();
            }
        }
        public static void Converter_OZ()
        {
            Console.Clear();
            Console.WriteLine("Enter the weight in KGs to convert to oz");
            int kgs = int.Parse(Console.ReadLine());
            var oz = kgs * 35.274;
            Console.WriteLine(kgs + " in kgs is " + oz + "oz");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_WeightPage();
            }
        }
        public static void Converter_Grams()
        {
            Console.Clear();
            Console.WriteLine("Enter the weight in KGs to convert to grams");
            int kgs = int.Parse(Console.ReadLine());
            var gram = kgs * 1000;
            Console.WriteLine(kgs + " in kgs is " + gram + "grams");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_WeightPage();
            }
        }
        public static void Converter_Stones()
        {
            Console.Clear();
            Console.WriteLine("Enter the weight in KGs to convert to stones");
            int kgs = int.Parse(Console.ReadLine());
            var st = kgs * 0.1574;
            Console.WriteLine(kgs + " in kgs is " + st + "stones");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_WeightPage();
            }
        }
        public static void Converter_TempPage()
        {
            Console.Clear();
            Console.WriteLine("Choose between converting Celsius to: Farenheit, Kelvin or Back (F/K/B)");
            ConsoleKeyInfo temppage = Console.ReadKey();
            if (temppage.Key == ConsoleKey.F)
            {
                Converter_Farenheit();
            }
            else if (temppage.Key == ConsoleKey.K)
            {
                Converter_Kelvin();
            }
            else if (temppage.Key == ConsoleKey.B)
            {
                Converter_StartPage();
            }

        }
        public static void Converter_Farenheit()
        {
            Console.Clear();
            Console.WriteLine("Enter the temperature in Celsius to convert to Farenheit");
            int celsius = int.Parse(Console.ReadLine());
            var farenheit = (celsius * 1.8) + 32;
            Console.WriteLine(celsius + " in Celsius is " + farenheit + "Farenheit");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_TempPage();
            }

        }
        public static void Converter_Kelvin()
        {
            Console.Clear();
            Console.WriteLine("Enter the temperature in Celsius to convert to Kelvin");
            int celsius = int.Parse(Console.ReadLine());
            var kelvin = celsius + 273.15;
            Console.WriteLine(celsius + " in Celsius is " + kelvin + "Kelvin");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_TempPage();
            }

        }
        public static void Converter_LengthPage()
        {
            Console.Clear();
            Console.WriteLine("Choose between converting Metres to: Feet, Inches, Centimetres, Yards, Kilometres, Miles, Back (F/I/C/Y/K/M/B)");
            ConsoleKeyInfo lengthpage = Console.ReadKey();
            if (lengthpage.Key == ConsoleKey.F)
            {
                Converter_Feet();
            }
            else if (lengthpage.Key == ConsoleKey.I)
            {
                Converter_Inch();
            }
            else if (lengthpage.Key == ConsoleKey.C)
            {
                Converter_Cm();
            }
            else if (lengthpage.Key == ConsoleKey.Y)
            {
                Converter_Yard();
            }
            else if (lengthpage.Key == ConsoleKey.K)
            {
                Converter_Kilometre();
            }
            else if (lengthpage.Key == ConsoleKey.M)
            {
                Converter_Miles();
            }
            else if (lengthpage.Key == ConsoleKey.B)
            {
                Converter_StartPage();
            }
        }
        public static void Converter_Feet()
        {
            Console.Clear();
            Console.WriteLine("Enter the length in metres to convert to feet");
            int metres = int.Parse(Console.ReadLine());
            var feet = metres * 3.2808;
            Console.WriteLine(metres + " in metres is " + feet + "feet");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_LengthPage();
            }
        }
        public static void Converter_Inch()
        {
            Console.Clear();
            Console.WriteLine("Enter the length in metres to convert to inches");
            int metres = int.Parse(Console.ReadLine());
            var inches = metres * 39.370;
            Console.WriteLine(metres + " in metres is " + inches + "inches");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_LengthPage();
            }
        }
        public static void Converter_Cm()
        {
            Console.Clear();
            
            Console.WriteLine("Enter the length in metres to convert to centimetres");
            int metres = int.Parse(Console.ReadLine());
            var cm = metres /0.01;
            Console.WriteLine(metres + " in metres is " + cm + "cm");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_LengthPage();
            }
        }
        public static void Converter_Yard()
        {
            Console.Clear();
            
            Console.WriteLine("Enter the weight in metres to convert to yards");
            int metres = int.Parse(Console.ReadLine());
            var yards = metres * 1.0936;
            Console.WriteLine(metres + " in metres is " + yards + "yards");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_LengthPage();
            }
        }
        public static void Converter_Kilometre()
        {
            Console.Clear();
            
            Console.WriteLine("Enter the length in metres to convert to kilometres");
            int metres = int.Parse(Console.ReadLine());
            var kilometres = metres /1000;
            Console.WriteLine(metres + " in metres is " + kilometres + "km");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_LengthPage();
            }
        }
        public static void Converter_Miles()
        {
            Console.Clear();
            
            Console.WriteLine("Enter the length in metres to convert to miles");
            int metres = int.Parse(Console.ReadLine());
            var miles = metres * 0.00062137;
            Console.WriteLine(metres + " in metres is " + miles + "miles");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Converter_LengthPage();
            }
        }
        public static void Convert_SpeedPage()
        {
            Console.Clear();
            
            Console.WriteLine("Choose between converting MPH to: KPH, Knots, Mach, Back (K/O/M/B)");
            ConsoleKeyInfo speedpage = Console.ReadKey();
            if (speedpage.Key == ConsoleKey.K)
            {
                Converter_KPH();
            }
            else if (speedpage.Key == ConsoleKey.O)
            {
                Converter_Knots();
            }
            else if (speedpage.Key == ConsoleKey.M)
            {
                Converter_Mach();
            }
            else if (speedpage.Key == ConsoleKey.B)
            {
                Converter_StartPage();
            }
        }
        public static void Converter_KPH()
        {
            Console.Clear();
            
            Console.WriteLine("Enter the speed in MPH to convert to KPH");
            int mph = int.Parse(Console.ReadLine());
            var kph = mph * 1.609344;
            Console.WriteLine(mph + " in MPH is " + kph + "KPH");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Convert_SpeedPage();
            }

        }
        public static void Converter_Knots()
        {
            Console.Clear();
            
            Console.WriteLine("Enter the speed in MPH to convert to Knots");
            int mph = int.Parse(Console.ReadLine());
            var knots = mph / 1.852;
            Console.WriteLine(mph + " in MPH is " + knots + "knots");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Convert_SpeedPage();
            }

        }
        public static void Converter_Mach()
        {
            Console.Clear();
            
            Console.WriteLine("Enter the speed in MPH to convert to Mach");
            int mph = int.Parse(Console.ReadLine());
            var mach = mph / 1225.044;
            Console.WriteLine(mph + " in MPH is " + mach + "Mach");
            Console.WriteLine("Press enter to go back");
            ConsoleKeyInfo enterback = Console.ReadKey();
            if (enterback.Key == ConsoleKey.Enter)
            {
                Convert_SpeedPage();
            }

        }
        static void Main(string[] args)
        {
            Page1();
            //Prevent the application from quitting automatically on completion.
            Console.ReadLine();
        }
    }
}
