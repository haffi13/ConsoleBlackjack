using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackTest
{
    class BlackjackTable
    {
        Cards cards = new Cards();

        string playerCardString = string.Empty;

        public void AddPlayerCard(int cardValue, int numOfCards)
        {
            Console.Clear();
            //playerCardString += cards.GetCard(cardValue);
            switch (numOfCards)
            {
                case 2:
                    playerCardString = cards.ThirdCard(cardValue);
                    break;
                case 3:
                    playerCardString = cards.FourthCard(cardValue);
                    break;
                case 4:
                    playerCardString = cards.FifthCard(cardValue);
                    break;

            }
            Console.WriteLine(playerCardString);
        }

        public void InitialPlay(int card1Value, int card2Value)
        {
            Console.Clear();
            playerCardString = cards.InitialPlay(card1Value, card2Value);
            Console.WriteLine(playerCardString);
        }

    }
}
