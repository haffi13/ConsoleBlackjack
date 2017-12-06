using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    public class Cards
    {
        string cardTemplate;

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
                    sCardType = "10";
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

            cardTemplate =    @".------." +
                              @"|" + sCardType + ".--. |" +
                              @"| (\/) |" +
                              @"| :\/: |" +
                              @"| '--'" + sCardType + "|" +
                              @"`------'";
            return cardTemplate;
        }
    }
}
