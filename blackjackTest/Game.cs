﻿using System;
using System.Collections.Generic;

namespace ConsoleBlackjack
{
    class Game
    {
        BlackjackTable table = new BlackjackTable();

        Random random = new Random();
        
        List<int> UnavailableCards = new List<int>();

        int playerTotalValue = 0;
        int computerTotalValue = 0;

        int[] PlayerCardValueArray = new int[10];
        int[] PlayerCardType = new int[10];
        int[] ComputerCardValueArray = new int[10];
        int[] ComputerCardType = new int[10];
        int playerHitCount = -1;
        int computerHitCount = -1;

        int cardsDrawn = 0;// just there for testing purposes

        private int CardSort { get; set; } //0 = hearts, 1 = spades, 2 = diamonds, 3 = clubs

        //need to figure out how to keep going if the deck is finishing or how to structure the game around it...figure out!
        private int GetCardAttributes()
        {
            cardsDrawn++;
            if(cardsDrawn > 51)
            {
                Console.Clear();
                Console.WriteLine("adafad");
            }
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

        public void InitialPlay(int playerOrComputer)
        {
            for (int i = 0; i < 2; i++)   
            {
                Hit(playerOrComputer);
            }
        }

        public void Hit(int playerOrComputer)
        {
            switch (playerOrComputer)
            {
                case 1:
                    playerHitCount++;
                    int currentType = GetCardAttributes();
                    PlayerCardType[playerHitCount] = currentType;
                    int currentValue = ConvertCardValue(currentType);
                    PlayerCardValueArray[playerHitCount] = currentValue;
                    playerTotalValue += currentValue;
                    table.AddCard(currentType, CardSort, playerOrComputer, playerHitCount);//bæta við sortinni hér
                    
                    int pIndexOfAce = Array.IndexOf(PlayerCardType, 1);

                    if (playerTotalValue > 21 && pIndexOfAce != -1)
                    {
                        playerTotalValue -= 10;
                        PlayerCardType[pIndexOfAce] = 15;//some random value that is not being used otherwise
                    }                                   //did this so the next time around it will not minus 10 again if the arguments are met
                    break;
                case 2:
                    
                    while (computerTotalValue < 17)
                    {
                        computerHitCount++;
                        int cardType = GetCardAttributes();
                        ComputerCardType[computerHitCount] = cardType;
                        int cardValue = ConvertCardValue(cardType);
                        ComputerCardValueArray[computerHitCount] = cardValue;
                        computerTotalValue += cardValue;
                        table.AddCard(cardType, CardSort, playerOrComputer, computerHitCount);

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
            if(playerTotalValue > 21 && computerTotalValue <= 21) 
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

        public void ResetTable()        //remember the reason for using a deck!! implement
        {
            table.playerCardString = string.Empty;
            table.computerCardString = string.Empty;
            table.ResetCards();                         
            //have only one for loop going 10 times as the array size is fixed at 10
            for (int i = 0; i < 10; i++)
            {
                PlayerCardValueArray[i] = 0;
                PlayerCardType[i] = 0;
                ComputerCardValueArray[i] = 0;
                ComputerCardType[i] = 0;
            }
            playerHitCount = -1;
            computerHitCount = -1;
            playerTotalValue = 0;
            computerTotalValue = 0;
        }
    }
}