using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count-1; i++)
            {
                for (int j = i+1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face.Equals(hand.Cards[j].Face) && hand.Cards[i].Suit.Equals(hand.Cards[j].Suit))
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
           if(IsStraight(hand) && IsFlush(hand))
           {
               return true;
           }

           return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int matchCount = 1;

            for (int i = 0; i < hand.Cards.Count - 3; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        matchCount++;
                    }
                }

                if (matchCount == 4)
                {
                    return true;
                }

                matchCount = 1;
            }

            
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (IsOnePair(hand) && IsThreeOfAKind(hand))
            {
                return true;
            }
            return false;
        }

        public bool IsFlush(IHand hand)
        {
            ICard card = hand.Cards[0];

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (card.Suit != hand.Cards[i].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            IEnumerable<ICard> sortedCards = hand.Cards.OrderBy(x => x.Face);
            IList<ICard> cards = sortedCards.ToList();
            ICard card = cards[0];

            for (int i = 1; i < cards.Count; i++)
            {
                if (card.Face == cards[i].Face - 1)
                {
                    card = cards[i];
                    continue;
                }

                return false;
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            int matchCount = 1;

            for (int i = 0; i < hand.Cards.Count - 2; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        matchCount++;
                    }
                }

                if (matchCount == 3)
                {
                    return true;
                }

                matchCount = 1;
            }

            
            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            int pairCount = 0;
            int matchCount = 1;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        matchCount++;

                        if(matchCount>2)
                        {
                            return false;
                        }

                        pairCount++;
                    }
                }

                matchCount = 1;
            }
            
            if(pairCount == 2)
            {
                return true;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            bool hasPair = false;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i+1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        hasPair = true;
                    }
                }
            }
            return hasPair;
        }

        public bool IsHighCard(IHand hand)
        {
            if(!IsFlush(hand) && !IsStraight(hand) && 
                !IsOnePair(hand) && !IsTwoPair(hand) && 
                !IsThreeOfAKind(hand) && IsFourOfAKind(hand))
            {
                return true;
            }

            return false;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            int valueHandOne = GetHandValue(firstHand);
            int valueHandTwo = GetHandValue(secondHand);

            if(valueHandOne == valueHandTwo)
            {
                return 0;
            }
            else if(valueHandTwo > valueHandOne)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        private int GetHandValue(IHand targetHand)
        {
            if(IsStraightFlush(targetHand))
            {
                return 30;
            }
            else if(IsFourOfAKind(targetHand))
            {
                return 29;
            }
            else if (IsFullHouse(targetHand))
            {
                return 28;
            }
            else if (IsFlush(targetHand))
            {
                return 27;
            }
            else if (IsStraight(targetHand))
            {
                return 26;
            }
            else if (IsThreeOfAKind(targetHand))
            {
                return 25;
            }
            else if (IsTwoPair(targetHand))
            {
                return 24;
            }
            else if (IsOnePair(targetHand))
            {
                return 23;
            }
            else
            {
                IEnumerable<ICard> sortedCards = targetHand.Cards.OrderBy(x => x.Face);
                IList<ICard> cards = sortedCards.ToList();
               // ICard card = cards[0];
                return (int)cards[cards.Count-1].Face.GetTypeCode();
            }
        }
    }
}
