using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];//實例化生成 new numberOfCards
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    pickedCards[i] = RandomValue() +"of"+ RandomSuit();

                }
                return pickedCards; 
            }
        }

        static Random random = new Random();
        private static string RandomSuit()//藉由第一次Random生成花色(1黑桃/2紅心/3梅花/4方塊
        {
            int value = random.Next(1, 5);
            if (value == 1) return "黑桃";
            if (value == 2) return "紅心";
            if (value == 3) return "梅花";
            return "方塊";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "ACE";  
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
