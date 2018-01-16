using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackjack
{
    public class Cards
    {
        //þar sem initial play kallar á GetCard þarf að bæta við cardSort sem argument, reyna að finna leið til að
        //sleppa initial play í stað þess að laga þetta...

        string[] playerCards = new string[10];
        char[] playerSorts = new char[10];
        string[] computerCards = new string[10];
        char[] computerSorts = new char[10];
        
       /* public string InitialPlay(int card1Val, int Card2Val, int playerOrComputer) // 1 = player || 2 = computer
        {
            string card1 = string.Empty, card2 = string.Empty;
            switch (playerOrComputer)
            {
                case 1:
                    playerCards[0] = GetCard(card1Val);
                    playerCards[1] = GetCard(Card2Val);
                    card1 = playerCards[0];
                    card2 = playerCards[1];
                    break;
                case 2:
                    computerCards[0] = GetCard(card1Val);
                    computerCards[1] = GetCard(Card2Val);
                    card1 = computerCards[0];
                    card2 = computerCards[1];
                    break;
            }

            string cardtemplate = @"  .------." + @"  .------." + "\n" +
                                   @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + "\n" +
                                   @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                   @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                   @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + "\n" +
                                   @"  `------'" + @"  `------'" + "\n";

            return cardtemplate;

        }*/

        public string GetCardString(int cardType, int cardSort, int playerOrComputer, int numberOfCards) // 1 = player || 2 = computer
        {
            string ret = string.Empty;
            switch (playerOrComputer)
            {
                case 1:
                    playerCards[numberOfCards] = GetCardLogo(cardType);
                    playerSorts[numberOfCards] = GetSortLogo(cardSort);
                    ret = CardString(playerCards, playerSorts, numberOfCards);
                    break;
                case 2:
                    computerCards[numberOfCards] = GetCardLogo(cardType);
                    computerSorts[numberOfCards] = GetSortLogo(cardSort);
                    ret = CardString(computerCards, computerSorts, numberOfCards);
                    break;
            }
            return ret;
        }

        private string CardString(string[] cards, char[] sorts, int numberOfCards)
        {
            string tableTemplate = string.Empty;
            switch (numberOfCards)
            {
                case 1:
                    tableTemplate = @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + "\n";
                    break;
                case 2:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 3:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 4:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + @"  |" + cards[4] + ".--." + sorts[4] + "|" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + @"  |" + sorts[4] + "'--'" + cards[4] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 5:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + @"  |" + cards[4] + ".--." + sorts[4] + "|" + @"  |" + cards[5] + ".--." + sorts[5] + "|" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + @"  |" + sorts[4] + "'--'" + cards[4] + "|" + @"  |" + sorts[5] + "'--'" + cards[5] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 6: // 6 = 7spil
                        //bæta við upp að 10 spilum
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + @"  |" + cards[4] + ".--." + sorts[4] + "|" + @"  |" + cards[5] + ".--." + sorts[5] + "|" + @"  |" + cards[6] + ".--." + sorts[6] + "|" + "\n" +
                                @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + @"  |" + sorts[4] + "'--'" + cards[4] + "|" + @"  |" + sorts[5] + "'--'" + cards[5] + "|" + @"  |" + sorts[6] + "'--'" + cards[6] + "|" + "\n" +
                                @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 7:
                    //8spil
                    break;

                case 8:
                    //9spil
                    break;
                case 9:
                    //10spil
                    break;
            }
            return tableTemplate;
        }
        
        private string GetCardLogo(int iCardType)
        {
            string[] cardType = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "X", "J", "Q", "K" };
            return cardType[iCardType - 1];// -1 for zero based index
        }

        private char GetSortLogo(int iCardSort) //sort is 0-3 heart,spade,diamond,clubs
        {
            char[] cardSort = { '\u2665', '\u2660', '\u2666', '\u2663' };// h s d c
            return cardSort[iCardSort];
        }

        public void ResetCards()
        {
            for (int i = 0; i < 10; i++)
            {
                playerCards[i] = string.Empty;
                playerSorts[i] = ' ';
                computerCards[i] = string.Empty;
                computerSorts[i] = ' ';
            }
        }

    }
}