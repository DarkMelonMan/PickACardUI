using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit(); 
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) { return "♠"; }
            if (value == 2) { return "♥"; }
            if (value == 3) { return "♣"; }
            return "♦";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) { return "A";  }
            if (value == 11) { return "J";  }
            if (value == 12) { return "Q";  }
            if (value == 13) { return "K";  }
            return value.ToString();
        }
    }
}
