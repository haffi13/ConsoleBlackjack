using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    class Menu
    {
        Decide decide = new Decide();
        public void MainMenu()
        {
            bool running = true;
            Console.WriteLine("Press 1 to start game");
            while (running)
                switch (GetUserInput())
                {
                    case 1: StartGame(); break;
                    case 0: running = false; break;
                    default: Console.WriteLine("Wrong input"); break;
                }
        }
        public void StartGame()
        {
            decide.Decision();
        }
        public int GetUserInput()
        {
            bool invalidSelection = true;
            int iInput = 0;
            while (invalidSelection)
            {
                string sInput = string.Empty;
                sInput = Console.ReadLine();
                bool validSelection = Int32.TryParse(sInput, out iInput);
                if (validSelection)
                {
                    invalidSelection = false;
                    iInput = Int32.Parse(sInput);
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
