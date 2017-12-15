using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    public class Cards
    {

        string[] playerCards = new string[10];
        string[] computerCards = new string[10];

        public void PopulateCardArrays()
        {
            for (int i = 0; i < 10; i++)
            {
                playerCards[i] = string.Empty;
                computerCards[i] = string.Empty;
            }
        }

        public string InitialPlay(int card1Val, int Card2Val, int playerOrComputer) // 1 = player || 2 = computer
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

        }

        public string GetCardString(int cardValue, int playerOrComputer, int numberOfCards) // 1 = player || 2 = computer
        {
            string ret = string.Empty;
            switch (playerOrComputer)
            {
                case 1:
                    playerCards[numberOfCards] = GetCard(cardValue);
                    ret = CardString(playerCards, numberOfCards);
                    break;
                case 2:
                    computerCards[numberOfCards] = GetCard(cardValue);
                    ret = CardString(computerCards, numberOfCards);
                    break;
            }
            return ret;
        }

        public string CardString(string[] cards, int numberOfCards)
        {
            string tableTemplate = string.Empty;
            switch (numberOfCards)
            {
                case 1:
                    tableTemplate = @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--. |" + @"  |" + cards[1] + ".--. |" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  | '--'" + cards[0] + "|" + @"  | '--'" + cards[1] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + "\n";
                    break;
                case 2:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--. |" + @"  |" + cards[1] + ".--. |" + @"  |" + cards[2] + ".--. |" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  | '--'" + cards[0] + "|" + @"  | '--'" + cards[1] + "|" + @"  | '--'" + cards[2] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 3:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--. |" + @"  |" + cards[1] + ".--. |" + @"  |" + cards[2] + ".--. |" + @"  |" + cards[3] + ".--. |" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  | '--'" + cards[0] + "|" + @"  | '--'" + cards[1] + "|" + @"  | '--'" + cards[2] + "|" + @"  | '--'" + cards[3] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 4:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--. |" + @"  |" + cards[1] + ".--. |" + @"  |" + cards[2] + ".--. |" + @"  |" + cards[3] + ".--. |" + @"  |" + cards[4] + ".--. |" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  | '--'" + cards[0] + "|" + @"  | '--'" + cards[1] + "|" + @"  | '--'" + cards[2] + "|" + @"  | '--'" + cards[3] + "|" + @"  | '--'" + cards[4] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 5:
                    tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                    @"  |" + cards[0] + ".--. |" + @"  |" + cards[1] + ".--. |" + @"  |" + cards[2] + ".--. |" + @"  |" + cards[3] + ".--. |" + @"  |" + cards[4] + ".--. |" + @"  |" + cards[5] + ".--. |" + "\n" +
                                    @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                    @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                    @"  | '--'" + cards[0] + "|" + @"  | '--'" + cards[1] + "|" + @"  | '--'" + cards[2] + "|" + @"  | '--'" + cards[3] + "|" + @"  | '--'" + cards[4] + "|" + @"  | '--'" + cards[5] + "|" + "\n" +
                                    @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
                    break;
                case 6:

                    break;
            }
            return tableTemplate;
        }
        
        public string GetCard(int iCardType)
        {
            string[] cardType = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "X", "J", "Q", "K" };
            string sCardType = cardType[iCardType - 1];
            return sCardType;
        }
    }
}