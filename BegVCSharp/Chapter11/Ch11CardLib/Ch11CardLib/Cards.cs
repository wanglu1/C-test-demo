using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    public class Cards : CollectionBase
    {
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }

        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }

        public Card this[int cardIndex]
        {
            get
            {
                return (Card)List[cardIndex];
            }
            set
            {
                List[cardIndex] = value;
            }
        }

        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// istance-used in Deck.Shuffle(). This implementation assumes that
        /// source and target collection are the same size.
        /// </summary>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Check to see if the Cards collection contains a particular card
        /// This calls the Contains() method of the ArraryList for the collection
        /// which you access through the InterList property
        /// </summary>
        public bool Contains(Card card)
        {
            return InnerList.Contains(card);
        }
    }
}
