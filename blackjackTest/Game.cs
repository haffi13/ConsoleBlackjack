using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackjack
{
    class Game
    {
        //Taka góðan tour um forritið og samhæfa nöfn á methods.
        //Checka að bæta við class eða rename-a table og display-a bara þar
        //til að fylgja standards. 

        BlackjackTable table = new BlackjackTable();

        Random random = new Random();
        int playerTotalValue = 0;
        int computerTotalValue = 0;

        //char[] cardSort = { '\u2665', '\u2660', '\u2666', '\u2663' };// h s d c
        List<int> UnavailableCards = new List<int>();

        int[] PlayerCardValueArray = new int[10];
        int[] PlayerCardType = new int[10];
        int[] ComputerCardValueArray = new int[10];
        int[] ComputerCardType = new int[10];
        int hitCount = 1;

        private int CardSort { get; set; } //0 = hearts, 1 = spades, 2 = diamonds, 3 = clubs

        //utf-8 encoding here, in table or both?
        //if only in table then send utf-8 value as string or num which corresponds with symbol in the other class.
        //keep tracks of what ranNums have come before and if it lands on one of those it gets a new number

        private int GetCardAttributes()
        {
            bool CardUnavailable = true;
            int ranNum = 0;
            int cardType = 0;
            while (CardUnavailable)
            {
                ranNum = random.Next(1, 53);
                if (!UnavailableCards.Contains(ranNum))
                {
                    CardUnavailable = false;
                }
            }
            UnavailableCards.Add(ranNum);

            if (ranNum <= 13)
            {
                //sort is hearts 
                CardSort = 0;
                cardType = ranNum;
            }
            if (ranNum > 13 && ranNum <= 26)
            {
                //sort is spades
                CardSort = 1;
                cardType = ranNum - 13;
            }
            else if(ranNum > 26 && ranNum <= 39)
            {
                //sort is diamonds
                CardSort = 2;
                cardType = ranNum - 26;
            }
            else if(ranNum > 39 && ranNum <= 52)
            {
                //sort is clubs
                CardSort = 3;
                cardType = ranNum - 39;
            }           
            return cardType;
        }

        private int ConvertCardValue(int cardType)
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
            //laga þetta rusl...vesen þar sem ég passa bara einni sort í einu
            //hægt að taka út variables hér og senda beint í arrays sem eru til staðar í class-inum. 
            //hægt að gera þetta í einni for loop-u þar sem bæði initial-play eru bara 2 spil.
            //hægt að converta og gera allt inní looppunni
            //Gera annað method meðan ég er að testa 
            int playerCard1Value, playerCard2Value, playerCard1Type, playerCard2Type;
            int computerCard1Value, computerCard2Value, computerCard1Type, computerCard2Type;
            playerCard1Type = GetCardAttributes();
            playerCard2Type = GetCardAttributes();
            PlayerCardType[0] = playerCard1Type;
            PlayerCardType[1] = playerCard2Type;
            computerCard1Type = GetCardAttributes();
            computerCard2Type = GetCardAttributes();
            ComputerCardType[0] = computerCard1Type;
            ComputerCardType[1] = computerCard2Type;
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
                    int currentType = GetCardAttributes();
                    PlayerCardType[hitCount] = currentType;
                    int currentValue = ConvertCardValue(currentType);
                    PlayerCardValueArray[hitCount] = currentValue;
                    playerTotalValue += currentValue;
                    table.AddCard(currentType, CardSort, playerOrComputer, hitCount);//bæta við sortinni hér
                    
                    int pIndexOfAce = Array.IndexOf(PlayerCardType, 1);

                    if (playerTotalValue > 21 && pIndexOfAce != -1)
                    {
                        playerTotalValue -= 10;
                        PlayerCardType[pIndexOfAce] = 15;//some random value that is not being used otherwise
                    }                                   //did this so the next time around it will not minus 10 again if the arguments are met
                    break;
                case 2:
                    int compHitCount = 1;
                    while (computerTotalValue < 17)
                    {
                        compHitCount++;
                        int cardType = GetCardAttributes();
                        ComputerCardType[compHitCount] = cardType;
                        int cardValue = ConvertCardValue(cardType);
                        ComputerCardValueArray[compHitCount] = cardValue;
                        computerTotalValue += cardValue;
                        table.AddCard(cardType, CardSort, compHitCount, playerOrComputer);

                        int cIndexOfAce = Array.IndexOf(ComputerCardType, 1);
                        if (computerTotalValue > 21 && cIndexOfAce != -1) 
                        {
                            computerTotalValue -= 10;
                            ComputerCardType[cIndexOfAce] = 15;
                        }
                    }
                    table.DisplayAllCards(playerTotalValue, computerTotalValue, FindWinner());
                    break;
            }
        }
        
        private string FindWinner()
        {
            string results = string.Empty;
            if(playerTotalValue > 21 && computerTotalValue <= 21) //afhverju telur gosi 11 ??
            {
                results = ("\n  --- Computer Wins ---");
            }
            else if(computerTotalValue > 21 && playerTotalValue <= 21)
            {
                results = ("\n --- Player Wins ---");
            }
            else if(computerTotalValue > 21 && playerTotalValue > 21)
            {
                results = ("\n --- Draw ---");
            }
            else if (playerTotalValue < computerTotalValue)
            {
                results = ("\n  --- Computer Wins ---");
            }
            else if (computerTotalValue < playerTotalValue)
            {
                results = ("\n  --- Player Wins ---");
            }
            else
            {
                results = ("\n --- Draw ---");
            }
            return results;
        }

        public void ResetTable()
        {
            table.playerCardString = string.Empty;
            table.computerCardString = string.Empty;
            table.displayString = string.Empty;
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