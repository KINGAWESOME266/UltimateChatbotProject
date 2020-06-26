

public void RPS2C()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDo you want to go to the chatbot now? (Y/N)");
            ConsoleKeyInfo chatbotyes = Console.ReadKey();
            if (chatbotyes.Key == ConsoleKey.Y)
            {
                p.Chat();
            }
            else if (chatbotyes.Key == ConsoleKey.N)
            {
                p.Quit();
            }
        }
        
       
        public void C2RPS()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("\nDo you want to go to RPS now? (Y/N)");
            ConsoleKeyInfo rpsyes = Console.ReadKey();
            if (rpsyes.Key == ConsoleKey.Y)
            {
                p.RPS();
            }
            else if (rpsyes.Key == ConsoleKey.N)
            {
                p.Quit();
            }
        }
