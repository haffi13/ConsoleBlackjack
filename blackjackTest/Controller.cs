using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackjack
{
    class Controller
    {
        Game game = new Game();
        Program p = new Program();
        public void Decision()
        {
            game.InitialPlay();
            bool running = true;
            while (running)
            {
                Console.WriteLine("1 - Hit\n2 - Show");
                int dec = Convert.ToInt32(Console.ReadLine());

                switch (dec)
                {
                    case 1:
                        game.Hit(1);
                        running = true;
                        break;
                    case 2:
                        game.Hit(2);
                        Console.ReadKey();
                        game.ResetTable();
                        running = false;
                        Console.Clear();
                        Menu m = new Menu();
                        m.MainMenu();
                        break;
                    default:
                        Console.WriteLine("Selection is not valid");
                        break;
                }
            }
        }
    }
}
