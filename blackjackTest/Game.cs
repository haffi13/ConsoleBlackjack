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
        
        public int GetCardType()
        {
            int cardType = random.Next(1, 14);
           
            return cardType;
        }

        public int ConvertCardValue(int cardType)
        {
            int cardValue = cardType;
            if (cardValue > 10)
            {
                cardValue = 10;
            }
            if (cardValue == 1)
            {
                cardValue = 11;
            }
            return cardValue;
        }

        public void InitialPlay()
        {
            int playerCard1Value, playerCard2Value, playerCard1Type, playerCard2Type;
            int computerCard1Value, computerCard2Value, computerCard1Type, computerCard2Type;
            playerCard1Type = GetCardType();
            playerCard2Type = GetCardType();
            computerCard1Type = GetCardType();
            computerCard2Type = GetCardType();
            playerCard1Value = ConvertCardValue(playerCard1Type);
            playerCard2Value = ConvertCardValue(playerCard2Type);
            computerCard1Value = ConvertCardValue(computerCard1Type);
            computerCard2Value = ConvertCardValue(computerCard2Type);
            PlayerCardValueArray[0] = playerCard1Value;
            PlayerCardValueArray[1] = playerCard2Value;
            ComputerCardValueArray[0] = computerCard1Value;
            ComputerCardValueArray[1] = computerCard2Value;

            Console.Clear();
            table.PlayerInitialPlay(PlayerCardValueArray[0], PlayerCardValueArray[1]);
            playerTotalValue = PlayerCardValueArray[0] + PlayerCardValueArray[1];

            table.ComputerInitialPlay(ComputerCardValueArray[0], ComputerCardValueArray[1]);
            Console.WriteLine("Total: " + playerTotalValue);
        }

        

        public void Hit()
        {
            hitCount++;
            int currentType = GetCardType();
            int currentValue = ConvertCardValue(currentType);

            PlayerCardValueArray[hitCount] = currentValue;
            table.AddCard(PlayerCardValueArray[hitCount], hitCount);
           
            playerTotalValue += PlayerCardValueArray[hitCount];

            if (playerTotalValue > 21 && PlayerCardValueArray.Contains(1))
            {
                playerTotalValue -= 10;
            }

            /*for (int i = 0; i <= hitCount; i++)
            {
                Console.Write(PlayerCardValueArray[i] + "  ");
            }
            Console.WriteLine("Total: " + playerTotalValue);*/
            
        }

        public void GetValuesForComputer()
        {
            int compHitCount = 1;
            computerTotalValue = ComputerCardValueArray[0] + ComputerCardValueArray[1];
            //computer InitialPlay begins


            //computer InitialPlay ends
            //þarf að græja initial play fyrir computer...eða sleppa og láta þetta runna bara frá byrjun
            //jafnvel betra þannig
            while(computerTotalValue < 17)
            {
                compHitCount++;
                int cardType = GetCardType();
                int cardValue = ConvertCardValue(cardType);
                ComputerCardValueArray[compHitCount] = cardValue;  //sama problem of í initial play
                computerTotalValue += ComputerCardValueArray[compHitCount];
                table.AddComputerCards(cardType, compHitCount);

                if (computerTotalValue > 21 && ComputerCardValueArray.Contains(1))
                {
                    computerTotalValue -= 10;
                }
            }
            table.DisplayAllCards();
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