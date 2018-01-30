using System;

namespace ConsoleBlackjack
{
    class Menu
    {
        string menuMessage = "\n\n1.Blackjack\n0.Exit\n\nSelection: ";
        Controller controller = new Controller();

        public void MainMenu()
        {
            bool running = true;
            controller.Display(menuMessage);
            while (running)
                switch (controller.GetUserInput())
                {
                    case 1: StartGame(); break;
                    case 0: running = false; Environment.Exit(0); break; //no need for exiting the loop if enviroment.exit terminates the application
                    default: controller.Display("Selection is not valid"); break;// Console.WriteLine("Selection is not valid"); break;
                }
        }

        public void StartGame()
        {
            controller.Decision();
            MainMenu();
        }
    }
}
