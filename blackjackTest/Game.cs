using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    class Game 
    {
        Random random = new Random();
        int playerTotalValue = 0;
        int computerTotalValue = 0;
        int[] PlayerCardValueArray = new int[10];
        int[] ComputerCardValueArray = new int[10];
        int hitCount = 1;
        
        public int GetCardValue()
        {
            int cardValue = random.Next(1, 14);
            if(cardValue > 10)
            {
                cardValue = 10;
            }
            if(cardValue == 1)
            {
                cardValue = 11;
            }
            return cardValue;
        }

        public void InitialPlay()
        {
            PlayerCardValueArray[0] = GetCardValue();
            PlayerCardValueArray[1] = GetCardValue();

            ComputerCardValueArray[0] = GetCardValue();
            ComputerCardValueArray[1] = GetCardValue();
            Console.Clear();
            Console.WriteLine("Player: " + PlayerCardValueArray[0] + " - " + PlayerCardValueArray[1]);
            playerTotalValue = PlayerCardValueArray[0] + PlayerCardValueArray[1];
            Console.WriteLine("Total: " + playerTotalValue);
        }

        public void Hit()
        {
            hitCount++;
            PlayerCardValueArray[hitCount] = GetCardValue();
            playerTotalValue += PlayerCardValueArray[hitCount];
            for (int i = 0; i <= hitCount; i++)
            {
                Console.Write(PlayerCardValueArray[i] + "  ");
            }
            Console.WriteLine("Total: " + playerTotalValue);
            if(playerTotalValue > 21 && PlayerCardValueArray.Contains(1))
            {
                playerTotalValue -= 10;
            }
        }

        public void Show()
        {
            int compHitCount = 1;
            computerTotalValue = ComputerCardValueArray[0] + ComputerCardValueArray[1];
            while(computerTotalValue < 16)
            {
                compHitCount++;
                ComputerCardValueArray[compHitCount] = GetCardValue();
                computerTotalValue += ComputerCardValueArray[compHitCount];

                if (computerTotalValue > 21 && ComputerCardValueArray.Contains(1))
                {
                    computerTotalValue -= 10;
                }
            }
            
            
            Console.Write("Player: ");
            for (int i = 0; i <= hitCount; i++)
            {
                Console.Write(PlayerCardValueArray[i] + " - ");
            }
            Console.WriteLine("Player total: " + playerTotalValue);
            Console.Write("\nComputer: ");
            for (int i = 0; i <= compHitCount; i++)
            {
                Console.Write(ComputerCardValueArray[i] + " - ");
            }
            Console.WriteLine("Computer total: " + computerTotalValue);


            if (computerTotalValue > 21 && playerTotalValue < 21)
            {
                Console.WriteLine("Player wins!");
            }
            else if(playerTotalValue > 21 && computerTotalValue < 21)
            {
                Console.WriteLine("Computer wins!");
            }
            else if(playerTotalValue < 21 && computerTotalValue < 21)
            {
                if(playerTotalValue > computerTotalValue)
                {
                    Console.WriteLine("Player wins!");
                }
                if(computerTotalValue > playerTotalValue)
                {
                    Console.WriteLine("Computer wins!");
                }
            }
            else
            {
                Console.WriteLine("DRAW!");
            }
            Console.ReadKey();
        }
        
    }
}