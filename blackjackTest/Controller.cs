using System;

namespace ConsoleBlackjack
{
    class Controller
    {
        Game game = new Game();
        int playerHitCount = 2;

        public void Decision()
        {
            game.InitialPlay(1);
            bool running = true;
            while (running)
            {
                //Console.WriteLine("1 - Hit\n2 - Show");
                Display("1 - Hit\n2 - Show");

                switch (GetUserInput())
                {
                    case 1:
                        playerHitCount++;
                        if(playerHitCount > 11)
                        {
                            running = false;
                            ComputersTurn();
                        }
                        game.Hit(1);
                        running = true;
                        break;
                    case 2:
                        running = false;
                        ComputersTurn();
                        break;
                    default:
                        Display("Selection is not valid");
                        break;
                }
            }
        }

        private void ComputersTurn()
        {
            playerHitCount = 0;
            game.InitialPlay(2);
            game.Hit(2);
            Console.ReadKey();
            game.ResetTable();
            Console.Clear();
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
                    Display("Selection is not valid");
                }
            }
            return iInput;
        }

        public void Display(string message)
        {
            game.Display(message);
        }
    }
}
