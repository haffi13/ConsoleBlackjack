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

        public string playerCardString = string.Empty;
        public string computerCardString = string.Empty;
        public string displayString = string.Empty;

        public void AddCard(int cardType, int numOfCards)
        {
            Console.Clear();
            //playerCardString += cards.GetCard(cardValue);
            switch (numOfCards)
            {
                case 2:
                    playerCardString = cards.ThirdCard(cardType, 1, numOfCards);
                    break;
                case 3:
                    playerCardString = cards.FourthCard(cardType, 1);
                    break;
                case 4:
                    playerCardString = cards.FifthCard(cardType, 1);
                    break;
                case 5:
                    playerCardString = cards.SixthCard(cardType, 1);
                    break;

            }
            Console.WriteLine(playerCardString);
        }

        public void AddComputerCards(int cardType, int numOfCards)
        {
            switch (numOfCards)
            {
                case 2:
                    computerCardString = cards.ThirdCard(cardType, 2);
                    break;
                case 3:
                    computerCardString = cards.FourthCard(cardType, 2);
                    break;
                case 4:
                    computerCardString = cards.FifthCard(cardType, 2);
                    break;
                case 5:
                    computerCardString = cards.SixthCard(cardType, 2);
                    break;

            }
        }

        public void DisplayAllCards(int playerTotal, int computerTotal)
        {

            Console.Clear();
            displayString = playerCardString + "\nPlayer: " + playerTotal + "\n\n\n\n\n" + computerCardString + "\nComputer: " + computerTotal;
            Console.WriteLine(displayString);
            Console.ReadKey();
        }
        
        public void PlayerInitialPlay(int card1Type, int card2Type)
        {
            Console.Clear();
            playerCardString = cards.InitialPlay(card1Type, card2Type, 1);
            Console.WriteLine(playerCardString);
        }
        public void ComputerInitialPlay(int card1Type, int card2Type)
        {
            computerCardString = cards.InitialPlay(card1Type, card2Type, 2);
        }

        public void ClearLocalCards()
        {
            cards.ClearCardStrings();
        }
    }
}
