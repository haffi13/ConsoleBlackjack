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

        public string ThirdCard(int card3Val, int playerOrComputer, int numberOfCards) // 1 = player || 2 = computer
        {
            string ret = string.Empty;
            switch (playerOrComputer)
            {
                case 1:
                    playerCards[numberOfCards] = GetCard(card3Val);
                    ret = GetTable(playerCards, numberOfCards);
                    break;
                case 2:
                    computerCards[numberOfCards] = GetCard(card3Val);
                    ret = GetTable(computerCards, numberOfCards);
                    break;
            }
            return ret;

        }
       /* public string GetThirdCard(string[] cards)
        {

            string cardtemplate3 = @"  .------." + @"  .------." + @"  .------." + "\n" +
                                   @"  |" + cards[0] + ".--. |" + @"  |" + cards[1] + ".--. |" + @"  |" + cards[2] + ".--. |" + "\n" +
                                   @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                   @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                   @"  | '--'" + cards[0] + "|" + @"  | '--'" + cards[1] + "|" + @"  | '--'" + cards[2] + "|" + "\n" +
                                   @"  `------'" + @"  `------'" + @"  `------'" + "\n";
            return cardtemplate3;
        }*/

        public string GetTable(string[] cards, int numberOfCards)
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



        /*public string FourthCard(int card4Val, int playerOrComputer) // 1 = player || 2 = computer
        {
            string card1 = string.Empty, card2 = string.Empty, card3 = string.Empty, card4 = string.Empty;
            if(playerOrComputer == 1)
            {
                pCard4 = GetCard(card4Val);
                card1 = pCard1;
                card2 = pCard2;
                card3 = pCard3;
                card4 = pCard4;

            }
            else if(playerOrComputer == 2)
            {
                cCard4 = GetCard(card4Val);
                card1 = cCard1;
                card2 = cCard2;
                card3 = cCard3;
                card4 = cCard4;
            }
            string cardtemplate4 = @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                   @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + @"  |" + card3 + ".--. |" + @"  |" + card4 + ".--. |" + "\n" +
                                   @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                   @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                   @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + @"  | '--'" + card3 + "|" + @"  | '--'" + card4 + "|" + "\n" +
                                   @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
            return cardtemplate4;
        }

        public string FifthCard(int card5Val, int playerOrComputer) // 1 = player || 2 = computer
        {
            string card1 = string.Empty, card2 = string.Empty, card3 = string.Empty, card4 = string.Empty, card5 = string.Empty;
            if (playerOrComputer == 1)
            {
                pCard5 = GetCard(card5Val);
                card1 = pCard1;
                card2 = pCard2;
                card3 = pCard3;
                card4 = pCard4;
                card5 = pCard5;
            }
            else if(playerOrComputer == 2)
            {
                cCard5 = GetCard(card5Val);
                card1 = cCard1;
                card2 = cCard2;
                card3 = cCard3;
                card4 = cCard4;
                card5 = cCard5;
            }
            string cardtemplate5 = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                       @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + @"  |" + card3 + ".--. |" + @"  |" + card4 + ".--. |" + @"  |" + card5 + ".--. |" + "\n" +
                       @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                       @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                       @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + @"  | '--'" + card3 + "|" + @"  | '--'" + card4 + "|" + @"  | '--'" + card5 + "|" + "\n" +
                       @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
            return cardtemplate5;
        }

        public string SixthCard(int card6Val, int playerOrComputer) // 1 = player || 2 = computer
        {
            string card1 = string.Empty, card2 = string.Empty, card3 = string.Empty, card4 = string.Empty, card5 = string.Empty, card6 = string.Empty;
            if (playerOrComputer == 1)
            {
                pCard6 = GetCard(card6Val);
                card1 = pCard1;
                card2 = pCard2;
                card3 = pCard3;
                card4 = pCard4;
                card5 = pCard5;
                card6 = pCard6;
            }
            else if (playerOrComputer == 2)
            {
                cCard6 = GetCard(card6Val);
                card1 = cCard1;
                card2 = cCard2;
                card3 = cCard3;
                card4 = cCard4;
                card5 = cCard5;
                card6 = cCard6;
            }
            pCard5 = GetCard(card6Val);
            string cardtemplate6 = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                       @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + @"  |" + card3 + ".--. |" + @"  |" + card4 + ".--. |" + @"  |" + card5 + ".--. |" + @"  |" + card6 + ".--. |" + "\n" +
                       @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                       @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                       @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + @"  | '--'" + card3 + "|" + @"  | '--'" + card4 + "|" + @"  | '--'" + card5 + "|" + @"  | '--'" + card6 + "|" + "\n" +
                       @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
            return cardtemplate6;
        }
        public void SeventhCard() //samt string, fuk a redline!
        {

        }
        */
        public string GetCard(int iCardType)
        {
            string sCardType = string.Empty;
            switch (iCardType)
            {
                case 1:
                    sCardType = "A";
                    break;
                case 2:
                    sCardType = "2";
                    break;
                case 3:
                    sCardType = "3";
                    break;
                case 4:
                    sCardType = "4";
                    break;
                case 5:
                    sCardType = "5";
                    break;
                case 6:
                    sCardType = "6";
                    break;
                case 7:
                    sCardType = "7";
                    break;
                case 8:
                    sCardType = "8";
                    break;
                case 9:
                    sCardType = "9";
                    break;
                case 10:
                    sCardType = "X"; //for the format...þarf að breyta hvernig spilið er sett upp með if setningu ef það á að virka með 2 stafa númeri
                    break;
                case 11:
                    sCardType = "J";
                    break;
                case 12:
                    sCardType = "Q";
                    break;
                case 13:
                    sCardType = "K";
                    break;
            }

            return sCardType;
        }
    }
}



/*string cardtemplate2 = @"  .------." + @"  .------." + "\n" +
                                   @"  |" + sCardType + ".--. |" + @"  |" + sCardType + ".--. |" + "\n" +
                                   @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                   @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                   @"  | '--'" + sCardType + "|" + @"  | '--'" + sCardType + "|" + "\n" +
                                   @"  `------'" + @"  `------'" + "\n";*/




/*cardTemplate =    @"  .------." + "\n" +
                              @"  |" + sCardType + ".--. |" + "\n" +
                              @"  | (\/) |" + "\n" +
                              @"  | :\/: |" + "\n" +
                              @"  | '--'" + sCardType + "|" + "\n" +
                              @"  `------'" + "\n";*/
                              
   
