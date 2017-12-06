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

        public void AddPlayerCard(int cardValue)
        {
            Console.Clear();
            playerCardString += cards.GetCard(cardValue);
            Console.WriteLine(playerCardString);
        }

    }
}
