using System;

namespace UltimateChatbotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            Console.WriteLine("Welcomt to Assistant. I'm your chatbot today. Do you want to play Rock, Paper, Scissors? (Enter = yes, other key = no)");
            var button = Console.ReadKey();
            if (button.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");



                Console.WriteLine("Type R (Rock), P (Paper), or S (Scissors)!");

                string compchoices = "";

                string userchoices = "";

                string userchoice = Console.ReadLine();



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



                if (userchoice == "R")



                {



                    userchoices = "Rock";



                }



                else



                {



                    if (userchoice == "P")



                    {



                        userchoices = "Paper";



                    }



                    else



                    {



                        if (userchoice == "S")



                        {



                            userchoices = "Scissors";



                        }



                        else



                        {



                            Console.WriteLine("Quitting...");



                            Environment.Exit(0);



                        }



                    }



                }



                // If userchoice and compchoice statements  



                if (userchoices == "Rock" && compchoices == "Rock")



                {



                    Console.WriteLine("It's a draw!!");



                }



                else



                {



                    if (userchoices == "Rock" && compchoices == "Paper")



                    {



                        Console.WriteLine("The computer wins!");



                    }



                    else



                    {



                        if (userchoices == "Rock" && compchoices == "Scissors")



                        {



                            Console.WriteLine("The User wins!");



                        }



                        else



                        {



                            if (userchoices == "Paper" && compchoices == "Rock")

                            {

                                Console.WriteLine("The User Wins!");

                            }

                            else

                            {

                                if (userchoices == "Paper" && compchoices == "Scissors")

                                {

                                    Console.WriteLine("The Computer Wins!");

                                }

                                else

                                {

                                    if (userchoices == "Paper" && compchoices == "Paper")

                                    {

                                        Console.WriteLine("It's a Draw!");

                                    }

                                    else

                                    {

                                        if (userchoices == "Scissors" && compchoices == "Scissors")

                                        {

                                            Console.WriteLine("It's a Draw!");

                                        }

                                        else

                                        {

                                            if (userchoices == "Scissors" && compchoices == "Paper")

                                            {

                                                Console.WriteLine("The User Wins");

                                            }

                                            else

                                            {

                                                if (userchoices == "Scissors" && compchoices == "Rock")

                                                {

                                                    Console.WriteLine("The Computer Wins!");

                                                }

                                                else

                                                {

                                                    Console.WriteLine("Quitting...");

                                                    Environment.Exit(0);

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
            else
            {

            }
            //Prevent the application from quitting automatically on completion.
            Console.ReadLine();
        }
    }
}