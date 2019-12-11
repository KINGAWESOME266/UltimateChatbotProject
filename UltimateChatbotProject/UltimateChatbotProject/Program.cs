using System;
using System.Threading;

namespace UltimateChatbotProject
{
    class Program
    {
        public void RPS()
        {
            Program p = new Program();
            Random gen = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors!");
            Console.WriteLine("Type R/r (Rock), P/p (Paper), or S/s (Scissors)!");

            string compchoices = "";

            string userchoices = "";

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
                p.Appchoice();
            }
            else
            {
                if (userchoices == "Rock" && compchoices == "Paper")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                    Console.WriteLine("The computer wins!");
                    p.Appchoice();
                }
                else
                {
                    if (userchoices == "Rock" && compchoices == "Scissors")



                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                        Console.WriteLine("The User wins!");
                        p.Appchoice();



                    }



                    else



                    {



                        if (userchoices == "Paper" && compchoices == "Rock")

                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                            Console.WriteLine("The User Wins!");
                            p.Appchoice();

                        }

                        else

                        {

                            if (userchoices == "Paper" && compchoices == "Scissors")

                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                Console.WriteLine("The Computer Wins!");
                                p.Appchoice();

                            }

                            else

                            {

                                if (userchoices == "Paper" && compchoices == "Paper")

                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                    Console.WriteLine("It's a Draw!");
                                    p.Appchoice();

                                }

                                else

                                {

                                    if (userchoices == "Scissors" && compchoices == "Scissors")

                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                        Console.WriteLine("It's a Draw!");
                                        p.Appchoice();

                                    }

                                    else

                                    {

                                        if (userchoices == "Scissors" && compchoices == "Paper")

                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                            Console.WriteLine("The User Wins");
                                            p.Appchoice();

                                        }

                                        else

                                        {
                                            if (userchoices == "Scissors" && compchoices == "Rock")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nYou did " + userchoices + " and the computer did " + compchoices + "! ");
                                                Console.WriteLine("The Computer Wins!");
                                                p.Appchoice();
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
        public void Chat()
        {
            Program p = new Program();
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
            if (Convert.ToInt32(age) == 14)
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
            if (Show == "Designated Survivor")
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
            if (song == "Secreto")
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
                p.Appchoice();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("I hope to improve for next time.\n");
                p.Appchoice();
            }
        }
        public void Quit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Quitting...\n");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
        public void Appchoice()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Program p = new Program();
            Console.WriteLine("What do you want to do now?");
            Console.WriteLine("R = RockPaperScissors, C = Chatbot, E = Even, N = Number Counter, M = Magic 8 Ball, X = Calculator, Q = Quit");
            ConsoleKeyInfo choicebutton = Console.ReadKey();
            if (choicebutton.Key == ConsoleKey.R)
            {
                p.RPS();
            }
            else if (choicebutton.Key == ConsoleKey.C)
            {
                p.Chat();
            }
            else if (choicebutton.Key == ConsoleKey.E)
            {
                p.Even();
            }
            else if (choicebutton.Key == ConsoleKey.Q)
            {
                p.Quit();
            }
            else if (choicebutton.Key == ConsoleKey.N)
            {
                p.Numbers();
            }
            else if (choicebutton.Key == ConsoleKey.M)
            {
                p.Magic8();
            }
            else if (choicebutton.Key == ConsoleKey.X)
            {
                p.Calc();
            }
        }
        public void Even()
        {
            Program p = new Program();
            Console.WriteLine("\nEnter a number below...");
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("\nThis is even!!!");
                p.Appchoice();
            }
            else
            {
                Console.WriteLine("\nThis is odd...");
                p.Appchoice();
            }
            Console.ReadLine();
        }
        public void Numbers()
        {
            Program p = new Program();
            Console.WriteLine("\nEnter a number below, I will count up to that number!");
            int countnum = int.Parse(Console.ReadLine());
            for (int i = 0; i < countnum; i++)
            {
                Console.WriteLine(i);
            }
            p.Appchoice();
            Console.ReadLine();
        }
        public void Magic8()
        {
            Program p = new Program();
            Random gen = new Random();
            Console.WriteLine("Welcome to Magic 8 Ball. Write your question below: ");
            string question = Console.ReadLine();
            int random = gen.Next(1,8);
            Console.WriteLine(random);
            if (random == 1)
            {
                Console.WriteLine("Definitely not! ");
                p.Appchoice();
            }
            else
            {
                if (random == 2)
                {
                    Console.WriteLine("Highly Unlikely!");
                    p.Appchoice();
                }
                else
                {
                    if (random == 3)

                    {
                        Console.WriteLine("Unlikely...");
                        p.Appchoice();
                    }
                    else
                    {
                        if (random == 4)
                        {
                            Console.WriteLine("Even... Could be or could be not...");
                            p.Appchoice();
                        }
                        else
                        {
                            if (random == 5)
                            {
                                Console.WriteLine("Likely!");
                                p.Appchoice();
                            }
                            else
                            {
                                if (random == 6)
                                {
                                    Console.WriteLine("Highly Likely!");
                                    p.Appchoice();
                                }
                                else
                                {
                                    if (random == 7)
                                    {
                                        Console.WriteLine("Imminent!");
                                        p.Appchoice();
                                    }
                                    else
                                    {
                                        if (random == 8)
                                        {
                                            Console.WriteLine("Congratulations! It will happen!");
                                            p.Appchoice();
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
        public void Page1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Assistant. I'm your chatbot today.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(R = RockPaperScissors, C = iChatbot, E = Even or Not, Press -> for more!)");
            Program p = new Program();
            ConsoleKeyInfo button = Console.ReadKey();
            if (button.Key == ConsoleKey.R)
            {
                p.RPS();
                Console.ReadLine();
            }
            else if (button.Key == ConsoleKey.RightArrow)
            {
                p.Page2();
            }
            else if (button.Key == ConsoleKey.C)
            {
                p.Chat();
                Console.ReadLine();

            }
            else if (button.Key == ConsoleKey.E)
            {
                p.Even();

            }
            else
            {
                p.Quit();
            }
        }
        public void Page2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Program p = new Program();
            Console.WriteLine("N = Number Counter, M = Magic 8 Ball, X = Calculator, Q = Quit, Press <- to go back)");
            ConsoleKeyInfo button2 = Console.ReadKey();
            if (button2.Key == ConsoleKey.N)
            {
                p.Numbers();
            }
            else if (button2.Key == ConsoleKey.M)
            {
                p.Magic8();
            }
            else if (button2.Key == ConsoleKey.Q)
            {
                p.Quit();
            }
            else if (button2.Key == ConsoleKey.X)
            {
                p.Calc();
            }            
            else if (button2.Key == ConsoleKey.LeftArrow)
            {
                p.Page1();
            }
            
        }
        public void Calc()
        {
            // Declare variables and then initialize to zero.
            Console.ForegroundColor = ConsoleColor.Cyan;
            int num1 = 0;
            int num2 = 0;
            Program p = new Program();
            // Display title as the C# console calculator app.
            Console.WriteLine("\nConsole Calculator in C#\r");
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
            }
            else if (calckey.Key == ConsoleKey.S)
            {
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            }
            else if (calckey.Key == ConsoleKey.M)
            {
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            }
            else if (calckey.Key == ConsoleKey.D)
            {
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            }
            else
            {
                p.Quit();
            }
            p.Appchoice();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Page1();

            //Prevent the application from quitting automatically on completion.
            Console.ReadLine();
        }
    }
}
