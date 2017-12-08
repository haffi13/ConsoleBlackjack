using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    public class Cards
    {
        //string cardTemplate;
        //string playerCards = string.Empty;
        //string computerCards = string.Empty;
        string card1 = string.Empty, card2 = string.Empty, card3 = string.Empty, card4 = string.Empty, card5 = string.Empty, card6 = string.Empty, card7 = string.Empty, card8 = string.Empty, card9 = string.Empty, card10 = string.Empty;

        public string InitialPlay(int card1Val, int Card2Val)
        {
            
            card1 = GetCard(card1Val);
            card2 = GetCard(Card2Val);

            string cardtemplate2 = @"  .------." + @"  .------." + "\n" +
                                   @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + "\n" +
                                   @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                   @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                   @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + "\n" +
                                   @"  `------'" + @"  `------'" + "\n";

            return cardtemplate2;

        }

        public string ThirdCard(int card3Val)
        {
            card3 = GetCard(card3Val);
            string cardtemplate2 = @"  .------." + @"  .------." + @"  .------." + "\n" +
                                   @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + @"  |" + card3 + ".--. |" + "\n" +
                                   @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                   @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                   @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + @"  | '--'" + card3 + "|" + "\n" +
                                   @"  `------'" + @"  `------'" + @"  `------'" + "\n";
            return cardtemplate2;
        }

        public string FourthCard(int card4Val)
        {
            string cardtemplate4 = @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                                   @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + @"  |" + card3 + ".--. |" + @"  |" + card4 + ".--. |" + "\n" +
                                   @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                                   @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                                   @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + @"  | '--'" + card3 + "|" + @"  | '--'" + card4 + "|" + "\n" +
                                   @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
            return cardtemplate4;
        }

        public string FifthCard(int card5Val)
        {
            string cardtemplate5 = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
                       @"  |" + card1 + ".--. |" + @"  |" + card2 + ".--. |" + @"  |" + card3 + ".--. |" + @"  |" + card4 + ".--. |" + @"  |" + card5 + ".--. |" + "\n" +
                       @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
                       @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
                       @"  | '--'" + card1 + "|" + @"  | '--'" + card2 + "|" + @"  | '--'" + card3 + "|" + @"  | '--'" + card4 + "|" + @"  | '--'" + card5 + "|" + "\n" +
                       @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
            return cardtemplate5;
        }

        public void SixthCard()
        {

        }

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
