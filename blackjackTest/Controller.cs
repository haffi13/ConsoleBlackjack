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
                        //game.GetCardValue();
                        running = true;
                        break;
                    case 2:
                        //game.GetValuesForComputer();
                        game.Hit(2);
                        game.FindWinner();
                        Console.ReadKey();
                        game.ResetTable();
                        running = false;
                        Decision();
                        break;
                    default:
                        Console.WriteLine("Selection is not valid");
                        break;
                }
            }
        }
    }
}
