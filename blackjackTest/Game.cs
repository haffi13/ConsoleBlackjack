using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    class Game 
    {
        BlackjackTable table = new BlackjackTable();

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
            table.InitialPlay(PlayerCardValueArray[0], PlayerCardValueArray[1]);
            playerTotalValue = PlayerCardValueArray[0] + PlayerCardValueArray[1];
            //Console.WriteLine("Total: " + playerTotalValue);
        }

        public void Hit()
        {
            hitCount++;
        
            PlayerCardValueArray[hitCount] = GetCardValue();
            switch (hitCount)
            {
                case 2:
                    table.AddPlayerCard(PlayerCardValueArray[hitCount] ,2); //2 = 3spil, 0based index
                    break;
                case 3:
                    table.AddPlayerCard(PlayerCardValueArray[hitCount], 3);// 4spil
                    break;
                case 4:
                    table.AddPlayerCard(PlayerCardValueArray[hitCount], 4);//5spil
                    break;
            }
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

        public void GetValuesForComputer()
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
        }

        public void FindWinner()
        {
            if(playerTotalValue > 21 && computerTotalValue <= 21)
            {
                //computerWins
                Console.WriteLine("computerWins");
            }
            else if(computerTotalValue > 21 && playerTotalValue <= 21)
            {
                //playerWins
                Console.WriteLine("playerWins");
            }
            else if(playerTotalValue < computerTotalValue)
            {
                //computerWins
                Console.WriteLine("computerWins");
            }
            else if(computerTotalValue < playerTotalValue)
            {
                //playerWins
                Console.WriteLine("playerWins");
            }
            else
            {
                Console.WriteLine("draw");
                //draw
            }   
        }
    }
}