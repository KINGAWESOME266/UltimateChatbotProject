using System;
using System.Threading;

namespace UltimateChatbotProject
{
    class Program
    {
        public void RPS()
        {
            Random gen = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Type R/r (Rock), P/p (Paper), or S/s (Scissors)!");

            string compchoices = "";

            string userchoices = "";

            ConsoleKeyInfo userchoice = Console.ReadKey();



            int compchoice = gen.Next(0, 4);



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



                    else



                    {



                        Console.WriteLine("Quitting...");



                        Environment.Exit(0);



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
                Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                Console.WriteLine("It's a draw!!");



            }



            else



            {



                if (userchoices == "Rock" && compchoices == "Paper")



                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                    Console.WriteLine("The computer wins!");



                }



                else



                {



                    if (userchoices == "Rock" && compchoices == "Scissors")



                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                        Console.WriteLine("The User wins!");



                    }



                    else



                    {



                        if (userchoices == "Paper" && compchoices == "Rock")

                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                            Console.WriteLine("The User Wins!");

                        }

                        else

                        {

                            if (userchoices == "Paper" && compchoices == "Scissors")

                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                                Console.WriteLine("The Computer Wins!");

                            }

                            else

                            {

                                if (userchoices == "Paper" && compchoices == "Paper")

                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                                    Console.WriteLine("It's a Draw!");

                                }

                                else

                                {

                                    if (userchoices == "Scissors" && compchoices == "Scissors")

                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                                        Console.WriteLine("It's a Draw!");

                                    }

                                    else

                                    {

                                        if (userchoices == "Scissors" && compchoices == "Paper")

                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                                            Console.WriteLine("The User Wins");

                                        }

                                        else

                                        {

                                            if (userchoices == "Scissors" && compchoices == "Rock")

                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You did " + userchoices + " and the computer did " + compchoices + "! ");
                                                Console.WriteLine("The Computer Wins!");

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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\niChatbot is loading...");
            Thread.Sleep(5000);
            Console.WriteLine("Let's Introduce Ourselves");
            Console.WriteLine("My name is Siri. What's yours?");
            string name = Console.ReadLine();

            if (name == "Siri")
            {
                Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nI'm older than you!");
                }
            }
            Console.WriteLine("\nWhat's your favorite TV Show");
            string Show = Console.ReadLine();

            if (Show == "Designated Survivor")
            {
                Console.ForegroundColor = ConsoleColor.White;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nI'll check it out");
                }
                else if (yesbutton.Key == ConsoleKey.N)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nI'll try to watch it somehow");
                }
            }

            Console.WriteLine("\nWhat's your favorite song?");
            string song = Console.ReadLine();

            if (song == "Secreto")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nI love that song!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIs it on Spotify? (Y/N)");
                var spotifybutton = Console.ReadKey();
                if (spotifybutton.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\nI'll listen to it soon.");
                }
                else if (spotifybutton.Key == ConsoleKey.N)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nI'll try to listen to it sometime.");
                }
            }

            Console.WriteLine(name + " do you have any pets? (Y/N)\n");
            ConsoleKeyInfo pets = Console.ReadKey();
            if (pets.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine("Do you have a cat or a dog " + name + " ?" + " (C/D)\n ");
                ConsoleKeyInfo catdog = Console.ReadKey();

                if (catdog.Key == ConsoleKey.C)
                {
                    Console.ForegroundColor = ConsoleColor.White;
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
                        Console.ForegroundColor = ConsoleColor.White;
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
            }
            else if (pets.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("I understand\n");
            }

            Console.WriteLine("How did you enjoy this chatbot out of 1-10?\n");
            var rating = Console.ReadLine();
            if (Convert.ToInt16(rating) > 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("Thank you for the nice rating!\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("I hope to improve for next time.\n");
            }
        }
        public void Quit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Quitting...\n");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
        public void Appchoice()
        {
            Program p = new Program();
            Console.WriteLine("What do you want to do now?");
            Console.WriteLine("R = RockPaperScissors, C = Chatbot, E = Even, Q = Quit");
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
            else if (choicebutton.Key == )
            {

            }
        }
        public void Even()
        {
            Console.WriteLine("Enter a number below...");
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("This is even!!!");
            }
            else
            {
                Console.WriteLine("This is odd...");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Assistant. I'm your chatbot today.");
            Console.WriteLine("What do you want to do (R = RockPaperScissors, C = iChatbot, Q = Quit)");
            Program p = new Program();
            ConsoleKeyInfo button = Console.ReadKey();
            if (button.Key == ConsoleKey.R)
            {
                p.RPS();
                p.RPS2C();
                Console.ReadLine();
            }
            //The chatbot software below
            else if (button.Key == ConsoleKey.C)
            {
                p.Chat();
                p.C2RPS();
                Console.ReadLine();

            }
            else if (button.Key == ConsoleKey.Q)
            {
                p.Quit();
            }

            //Prevent the application from quitting automatically on completion.
            Console.ReadLine();
        }
    }
}
