using System;

namespace ConsoleBlackjack
{
    class Controller
    {
        Game game = new Game();
        //Program p = new Program();
        public void Decision()
        {
            game.InitialPlay(1);
            bool running = true;
            while (running)
            {
                Console.WriteLine("1 - Hit\n2 - Show");
                int dec = Convert.ToInt32(Console.ReadLine());  //make this better!

                switch (dec)
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
    }
}
