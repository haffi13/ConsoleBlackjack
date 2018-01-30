using System.Collections.Generic;

namespace ConsoleBlackjack
{
    public class Cards
    {
        string[] playerCards = new string[12];
        char[] playerSorts = new char[12];
        string[] computerCards = new string[12];
        char[] computerSorts = new char[12];

        //-----------------Refactoring stuffs

        string[] c = { @"  .------.", @"  |", @".--.", @"|", @"  | (\/) |", @"  | :\/: |", @"'--'", @"  '------'" };
        //inital play from player should have one c card and one b card, b card array as backside of the card, or maybe just showcase one card
        //need to change that in display and also in the initial play function in game

        string card1;
        string card2;
        string card3;
        string card4;
        string card5;
        string card6;
        List<string> card = new List<string>();
        bool firstCardComputer = true;

        //-----------------

        public string GetCardString(int cardType, int cardSort, int playerOrComputer, int numberOfCards) // 1 = player || 2 = computer
        {
            string ret = string.Empty;
            switch (playerOrComputer)
            {
                case 1:
                    playerCards[numberOfCards] = GetCardLogo(cardType);
                    playerSorts[numberOfCards] = GetSortLogo(cardSort);
                    ret = CardString(playerCards, playerSorts, numberOfCards, playerOrComputer);
                    break;
                case 2:
                    computerCards[numberOfCards] = GetCardLogo(cardType);
                    computerSorts[numberOfCards] = GetSortLogo(cardSort);
                    ret = CardString(computerCards, computerSorts, numberOfCards, playerOrComputer);
                    break;
            }
            return ret;
        }

        private string CardString(string[] cards, char[] sorts, int numberOfCards, int playerOrComputer)
        {
            string ret = string.Empty;
            card.Clear();
            if(playerOrComputer == 2 && firstCardComputer)
            {
                firstCardComputer = false;
                EmptyCardStrings();
            }
            
            card1 += c[0];
            card2 += c[1] + cards[numberOfCards] + c[2] + sorts[numberOfCards] + c[3];
            card3 += c[4];
            card4 += c[5];
            card5 += c[1] + sorts[numberOfCards] + c[6] + cards[numberOfCards] + c[3];
            card6 += c[7];
            card.Add(card1);
            card.Add(card2);
            card.Add(card3);
            card.Add(card4);
            card.Add(card5);
            card.Add(card6);
            foreach (string c in card)
            {
                ret += c + "\n";
            }
            return ret;
        }

        //private string CardString(string[] cards, char[] sorts, int numberOfCards)
        //{
        //    string tableTemplate = string.Empty;
        //    switch (numberOfCards)
        //    {
        //        case 1:
        //            tableTemplate = @"  .------." + @"  .------." + "\n" +
        //                            @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + "\n" +
        //                            @"  | (\/) |" + @"  | (\/) |" + "\n" +
        //                            @"  | :\/: |" + @"  | :\/: |" + "\n" +
        //                            @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + "\n" +
        //                            @"  `------'" + @"  `------'" + "\n";
        //            break;
        //        case 2:
        //            tableTemplate = @"  .------." + @"  .------." + @"  .------." + "\n" +
        //                            @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + "\n" +
        //                            @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
        //                            @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
        //                            @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + "\n" +
        //                            @"  `------'" + @"  `------'" + @"  `------'" + "\n";
        //            break;
        //        case 3:
        //            tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
        //                            @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + "\n" +
        //                            @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
        //                            @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
        //                            @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + "\n" +
        //                            @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
        //            break;
        //        case 4:
        //            tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
        //                            @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + @"  |" + cards[4] + ".--." + sorts[4] + "|" + "\n" +
        //                            @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
        //                            @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
        //                            @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + @"  |" + sorts[4] + "'--'" + cards[4] + "|" + "\n" +
        //                            @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
        //            break;
        //        case 5:
        //            tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
        //                            @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + @"  |" + cards[4] + ".--." + sorts[4] + "|" + @"  |" + cards[5] + ".--." + sorts[5] + "|" + "\n" +
        //                            @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
        //                            @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
        //                            @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + @"  |" + sorts[4] + "'--'" + cards[4] + "|" + @"  |" + sorts[5] + "'--'" + cards[5] + "|" + "\n" +
        //                            @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
        //            break;
        //        case 6: // 6 = 7spil
        //                //bæta við upp að 10 spilum
        //            tableTemplate = @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + @"  .------." + "\n" +
        //                        @"  |" + cards[0] + ".--." + sorts[0] + "|" + @"  |" + cards[1] + ".--." + sorts[1] + "|" + @"  |" + cards[2] + ".--." + sorts[2] + "|" + @"  |" + cards[3] + ".--." + sorts[3] + "|" + @"  |" + cards[4] + ".--." + sorts[4] + "|" + @"  |" + cards[5] + ".--." + sorts[5] + "|" + @"  |" + cards[6] + ".--." + sorts[6] + "|" + "\n" +
        //                        @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + @"  | (\/) |" + "\n" +
        //                        @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + @"  | :\/: |" + "\n" +
        //                        @"  |" + sorts[0] + "'--'" + cards[0] + "|" + @"  |" + sorts[1] + "'--'" + cards[1] + "|" + @"  |" + sorts[2] + "'--'" + cards[2] + "|" + @"  |" + sorts[3] + "'--'" + cards[3] + "|" + @"  |" + sorts[4] + "'--'" + cards[4] + "|" + @"  |" + sorts[5] + "'--'" + cards[5] + "|" + @"  |" + sorts[6] + "'--'" + cards[6] + "|" + "\n" +
        //                        @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + @"  `------'" + "\n";
        //            break;
        //        case 7:
        //            //8spil
        //            break;

        //        case 8:
        //            //9spil
        //            break;
        //        case 9:
        //            //10spil
        //            break;
        //    }
        //    return tableTemplate;
        //}
        //væri einfaldara að gera backsida á card ef ég myndi búa til cardTemplates úr arrays

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

        private void EmptyCardStrings()
        {
            card1 = string.Empty;
            card2 = string.Empty;
            card3 = string.Empty;
            card4 = string.Empty;
            card5 = string.Empty;
            card6 = string.Empty;
        }

        public void ResetCards()
        {
            EmptyCardStrings();
            firstCardComputer = true;
            card.Clear();
            for (int i = 0; i < playerCards.Length; i++)
            {
                playerCards[i] = string.Empty;
                playerSorts[i] = ' ';
                computerCards[i] = string.Empty;
                computerSorts[i] = ' ';
            }
        }
    }
}