using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackjack
{
    class BlackjackTable
    {
        Cards cards = new Cards();

        public string playerCardString = string.Empty;
        public string computerCardString = string.Empty;
        public string displayString = string.Empty;

        public void AddCard(int cardType, int cardSort, int playerOrComputer, int numOfCards) // 1=player||2=computer 
        {
            switch (playerOrComputer)
            {
                case 1:
                    playerCardString = cards.GetCardString(cardType, cardSort, playerOrComputer, numOfCards);
                    Console.Clear();
                    Console.WriteLine(playerCardString);
                    break;
                case 2:
                    computerCardString = cards.GetCardString(cardType, cardSort, playerOrComputer, numOfCards);
                    break;
            }
        }

        public void DisplayAllCards(int playerTotal, int computerTotal, string winner)
        {
            Console.Clear();
            displayString = playerCardString + "\nPlayer: " + playerTotal + "\n\n"+ winner +
                            
                "\n\n" + computerCardString + "\nComputer: " + computerTotal;

            Console.WriteLine(displayString);
            //Console.ReadKey();
        }

        public void ResetCards()
        {
            cards.ResetCards();
        }
    }
}
