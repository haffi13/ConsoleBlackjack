using System;

namespace ConsoleBlackjack
{
    class Menu
    {
        Controller controller = new Controller();
        public void MainMenu()
        {
            bool running = true;
            Console.WriteLine("\n\n1.Blackjack");
            Console.WriteLine("0.Exit");
            Console.Write("\nSelection: ");
            while (running)
                switch (controller.GetUserInput())
                {
                    case 1: StartGame(); break;
                    case 0: running = false; Environment.Exit(0); break; //no need for exiting the loop if enviroment.exit terminates the application
                    default: Console.WriteLine("Selection is not valid"); break;
                }
        }
        public void StartGame()
        {
            controller.Decision();
            MainMenu();
        }
    }
}
