using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11CardLib
{
    public class Card
    {
        public Rank rank;
        public Suit suit;

        private Card()
        {
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
