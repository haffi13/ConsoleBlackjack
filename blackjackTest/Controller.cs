using System;

namespace ConsoleBlackjack
{
    class Controller
    {
        Game game = new Game();

        public void Decision()
        {
            game.InitialPlay(1);
            bool running = true;
            while (running)
            {
                Console.WriteLine("1 - Hit\n2 - Show");

                switch (GetUserInput())
                {
                    case 1:
                        game.Hit(1);
                        running = true;
                        break;
                    case 2:
                        game.InitialPlay(2);
                        game.Hit(2);
                        Console.ReadKey();
                        game.ResetTable();
                        running = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Selection is not valid");
                        break;
                }
            }
        }

        public int GetUserInput()
        {
            bool invalidSelection = true;
            int iInput = 0;
            while (invalidSelection)
            {
                string sInput = Console.ReadLine();
                bool validSelection = Int32.TryParse(sInput, out iInput);
                if (validSelection)
                {
                    invalidSelection = false;
                }
                else
                {
                    Console.WriteLine("Selection is not valid.");
                }
            }
            return iInput;
        }
    }
}
