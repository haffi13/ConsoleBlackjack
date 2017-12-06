using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    class Decide
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
                        game.Hit();
                        running = true;
                        break;
                    case 2:
                        game.Show();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Selection is not valid");
                        break;

                }
            }
            

        }

    }
}
