using System;

namespace ConsoleBlackjack
{
    class BlackjackTable
    {
        Cards cards = new Cards();

        public string playerCardString = string.Empty;
        public string computerCardString = string.Empty;

        public void AddCard(int cardType, int cardSort, int playerOrComputer, int numOfCards) // 1=player||2=computer 
        {
            switch (playerOrComputer)
            {
                case 1:
                    playerCardString = cards.GetCardString(cardType, cardSort, playerOrComputer, numOfCards);

                    Display(playerCardString);
                    break;
                case 2:
                    computerCardString = cards.GetCardString(cardType, cardSort, playerOrComputer, numOfCards);
                    break;
            }
        }

        public void DisplayAllCards(int playerTotal, int computerTotal, string winner)
        {
            string display = playerCardString + "\nPlayer: " + playerTotal + "\n\n"+ winner +
                            
                "\n\n" + computerCardString + "\nComputer: " + computerTotal;

            Display(display);
        }

        private void Display(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }

        public void ResetCards()
        {
            cards.ResetCards();
        }
    }
}
