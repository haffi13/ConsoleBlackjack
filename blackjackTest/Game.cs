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
            playerTotalValue = PlayerCardValueArray[0] + PlayerCardValueArray[1];
            ComputerCardValueArray[0] = computerCard1Value;
            ComputerCardValueArray[1] = computerCard2Value;
            computerTotalValue = ComputerCardValueArray[0] + ComputerCardValueArray[1];

            Console.Clear();
            //table.PlayerInitialPlay(PlayerCardValueArray[0], PlayerCardValueArray[1]);
            table.PlayerInitialPlay(playerCard1Type, playerCard2Type);
            playerTotalValue = PlayerCardValueArray[0] + PlayerCardValueArray[1];

            //table.ComputerInitialPlay(ComputerCardValueArray[0], ComputerCardValueArray[1]);
            table.ComputerInitialPlay(computerCard1Type, computerCard2Type);
        }

        public void Hit(int playerOrComputer)
        {
            switch (playerOrComputer)
            {
                case 1:
                    hitCount++;
                    int currentType = GetCardType();
                    int currentValue = ConvertCardValue(currentType);
                    PlayerCardValueArray[hitCount] = currentValue;
                    playerTotalValue += currentValue;
                    table.AddCard(currentType, playerOrComputer, hitCount);

                    if (playerTotalValue > 21 && PlayerCardValueArray.Contains(1))
                    {
                        playerTotalValue -= 10;
                    }
                    break;
                case 2:
                    int compHitCount = 1;
                    while (computerTotalValue < 17)
                    {
                        compHitCount++;
                        int cardType = GetCardType();
                        int cardValue = ConvertCardValue(cardType);
                        ComputerCardValueArray[compHitCount] = cardValue;
                        computerTotalValue += cardValue;
                        table.AddCard(cardType,compHitCount, playerOrComputer);
                        if (computerTotalValue > 21 && ComputerCardValueArray.Contains(1)) //þarf að vera 11!!!! breyta úr value í type fyrir rétt conversion...
                        {
                            computerTotalValue -= 10;
                        }
                    }
                    table.DisplayAllCards(playerTotalValue, computerTotalValue);
                    break;
            }
        }
        
        public void FindWinner()
        {
            if(playerTotalValue > 21 && computerTotalValue <= 21) //afhverju telur gosi 11 ??
            {
                Console.WriteLine("  --- Computer Wins ---");
            }
            else if(computerTotalValue > 21 && playerTotalValue <= 21)
            {
                Console.WriteLine(" --- Player Wins ---");
            }
            else if(computerTotalValue > 21 && playerTotalValue > 21)
            {
                Console.WriteLine(" --- Draw ---");
            }
            else if (playerTotalValue < computerTotalValue)
            {
                Console.WriteLine("  --- Computer Wins ---");
            }
            else if (computerTotalValue < playerTotalValue)
            {
                Console.WriteLine("  --- Player Wins ---");
            }
            else
            {
                Console.WriteLine(" --- Draw ---");
            }   
        }

        public void ResetTable()
        {
            table.playerCardString = string.Empty;
            table.computerCardString = string.Empty;
            table.displayString = string.Empty;
            table.ClearLocalCards();
            for (int i = 0; i < PlayerCardValueArray.Length; i++)
            {
                PlayerCardValueArray[i] = 0;
            }
            for (int i = 0; i < ComputerCardValueArray.Length; i++)
            {
                ComputerCardValueArray[i] = 0;
            }
            hitCount = 1;
            playerTotalValue = 0;
            computerTotalValue = 0;
        }
    }
}