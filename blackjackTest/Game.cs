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
        int totalCount = 0;
        int[] cardValueArr = new int[10];
        int[] compCardValueArr = new int[10];
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
                Console.WriteLine("Press 1 if");
            }
            return cardValue;
        }

        public void InitialPlay()
        {
            cardValueArr[0] = GetCardValue();
            cardValueArr[1] = GetCardValue();

            compCardValueArr[0] = GetCardValue();
            compCardValueArr[1] = GetCardValue();
            Console.Clear();
            Console.WriteLine("Player: " + cardValueArr[0] + " - " + cardValueArr[1]);
            totalCount = cardValueArr[0] + cardValueArr[1];
            Console.WriteLine("Total: " + totalCount);
        }

        public void Hit()
        {
            hitCount++;
            cardValueArr[hitCount] = GetCardValue();
            totalCount += cardValueArr[hitCount];
            for (int i = 0; i <= hitCount; i++)
            {
                Console.Write(cardValueArr[i] + "  ");
            }
            Console.WriteLine("Total: " + totalCount);
            if(totalCount >= 21)
            {
                Show();
            }
        }

        public void Show()
        {
            int compHitCount = 1;
            int compTotal = compCardValueArr[0] + compCardValueArr[1];
            while(compTotal < 16)
            {
                compHitCount++;
                compCardValueArr[compHitCount] = GetCardValue();
                compTotal += compCardValueArr[compHitCount];
            }
            Console.Write("Player: ");
            for (int i = 0; i <= hitCount; i++)
            {
                Console.Write(cardValueArr[i] + " - ");
            }
            Console.WriteLine("Player total: " + totalCount);
            Console.Write("\nComputer: ");
            for (int i = 0; i <= compHitCount; i++)
            {
                Console.Write(compCardValueArr[i] + " - ");
            }
            Console.WriteLine("Computer total: " + compTotal);


            if (compTotal > 21 && totalCount < 21)
            {
                Console.WriteLine("Player wins!");
            }
            else if(totalCount > 21 && compTotal < 21)
            {
                Console.WriteLine("Computer wins!");
            }
            else if(totalCount < 21 && compTotal < 21)
            {
                if(totalCount > compTotal)
                {
                    Console.WriteLine("Player wins!");
                }
                if(compTotal > totalCount)
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