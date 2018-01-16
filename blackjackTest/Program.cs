using System;
using System.Text;

namespace ConsoleBlackjack
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Menu m = new Menu();
            m.MainMenu();
        }   
    }
}
