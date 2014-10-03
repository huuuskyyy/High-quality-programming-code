using System;

namespace Poker
{
    public class Card : ICard
    {
        private CardFace face;
        private CardSuit suit;
        public CardFace Face
        {
            get
            {
                return this.face;
            }
            set
            {
                this.face = value;
            }
        }
        public CardSuit Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
            }
        }

        public Card(CardFace face, CardSuit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public override string ToString()
        {
            return string.Format(this.face + "-" + this.suit);
        }
    }
}
