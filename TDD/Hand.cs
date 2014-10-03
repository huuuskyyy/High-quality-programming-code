using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        private IList<ICard> cards;
        public IList<ICard> Cards
        {
            get
            {
                return this.cards;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Hand cannot contain 0 cards");
                }
                this.cards = value;
            }
        }

        public Hand(IList<ICard> cards)
        {
            if (cards.Count == 0)
            {
                throw new ArgumentException("Hand cannot contain 0 cards");
            }
            this.cards = cards;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach(var card in this.cards)
            {
                builder.Append(card.ToString()+" ");
            }

            return builder.ToString();
        }

        
    }
}
