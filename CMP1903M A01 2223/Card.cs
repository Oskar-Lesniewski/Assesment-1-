using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public string Suit { get; set; }

        public Card(int val)
        {
            Value = (val % 13) + 1;
            if (val / 13 == 0)
            {
                Suit = "Spades";
            }
            else if (val / 13 == 1)
            {
                Suit = "Hearts";
            }
            else if (val / 13 == 2)
            {
                Suit = "Diamonds";
            }
            else
            {
                Suit = "Clubs";
            }
        }
        public string Display()
        {
            if (Value == 1)
            {
                return "Ace of " + Suit;
            }
            else if (Value == 11)
            {
                return "Jack of " + Suit;
            }
            else if (Value == 12)
            {
                return "Queen of " + Suit;
            }
            else if (Value == 13)
            {
                return "King of " + Suit;
            }
            else
            {
                return Value + " of " + Suit;
            }
        }
     
    }
    
}
