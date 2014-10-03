using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandCheckerTests
    {
        [TestMethod]
        public void TestIfHandIsValidWhenProvidingValidHand()
        {
            Card cardOne = new Card(CardFace.Eight, CardSuit.Spades);
            Card cardTwo = new Card(CardFace.Eight, CardSuit.Clubs);
            Card cardThree = new Card(CardFace.Eight, CardSuit.Diamonds);
            Card cardFour = new Card(CardFace.Eight, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Nine, CardSuit.Spades);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsValidHand(hand), string.Format("Expetected output that the hand is valid - true. Received {0}", checker.IsValidHand(hand)));
        }

        [TestMethod]
        public void TestIfHandIsInvalidWhenProvidingInvalidHand()
        {
            Card cardOne = new Card(CardFace.Eight, CardSuit.Spades);
            Card cardTwo = new Card(CardFace.Eight, CardSuit.Clubs);
            Card cardThree = new Card(CardFace.Eight, CardSuit.Clubs);
            Card cardFour = new Card(CardFace.Eight, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Nine, CardSuit.Spades);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsValidHand(hand), string.Format("Expetected output that the hand is not valid - false. Received {0}", checker.IsValidHand(hand)));
        }

        [TestMethod]
        public void TestIfHandIsStraightFlushReturnsTrueWhenHandIsStraightFlush()
        {
            Card cardOne = new Card(CardFace.Eight, CardSuit.Spades);
            Card cardTwo = new Card(CardFace.Nine, CardSuit.Spades);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Jack, CardSuit.Spades);
            Card cardFive = new Card(CardFace.Queen, CardSuit.Spades);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsStraightFlush(hand), string.Format("Expetected output that it is straight flush - true. Received {0}", checker.IsStraightFlush(hand)));
        }

        [TestMethod]
        public void TestIfHandIsStraightFlushReturnsFalseWhenHandIsWithDifferentSuits()
        {
            Card cardOne = new Card(CardFace.Eight, CardSuit.Spades);
            Card cardTwo = new Card(CardFace.Nine, CardSuit.Clubs);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Jack, CardSuit.Spades);
            Card cardFive = new Card(CardFace.Queen, CardSuit.Spades);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsStraightFlush(hand), string.Format("Expetected output that it is not straight flush - false. Received {0}", checker.IsStraightFlush(hand)));
        }

        [TestMethod]
        public void TestIfHandIsStraightFlushReturnsFalseWhenHandIsWithDifferentFaces()
        {
            Card cardOne = new Card(CardFace.Eight, CardSuit.Spades);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Spades);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Jack, CardSuit.Spades);
            Card cardFive = new Card(CardFace.Queen, CardSuit.Spades);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsStraightFlush(hand), string.Format("Expetected output that it is not straight flush - false. Received {0}", checker.IsStraightFlush(hand)));
        }

        [TestMethod]
        public void TestIfHandIsFourOfAKindWhenHandIsFourOfAKind()
        {
            Card cardOne = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Spades);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsFourOfAKind(hand), string.Format("Expetected output that it is four of a kind - true. Received {0}", checker.IsFourOfAKind(hand)));
        }

        [TestMethod]
        public void TestIfHandIsFourOfAKindWhenHandIsNotFourOfAKind()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Spades);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsFourOfAKind(hand), string.Format("Expetected output that it is not four of a kind - false. Received {0}", checker.IsFourOfAKind(hand)));
        }

        [TestMethod]
        public void TestIfHandIsFullHousedWhenHandIsFullHouse()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Spades);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsFullHouse(hand), string.Format("Expetected output that it is a full house - true. Received {0}", checker.IsFullHouse(hand)));
        }

        [TestMethod]
        public void TestIfHandIsFullHousedWhenHandIsNotFullHouse()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Two, CardSuit.Spades);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Three, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Clubs);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsFullHouse(hand), string.Format("Expetected output that it is not a full house - false. Received {0}", checker.IsFullHouse(hand)));
        }

        [TestMethod]
        public void TestIfHandIsFlushWhenHandIsFlush()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Queen, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardFour = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Hearts);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsFlush(hand), string.Format("Expetected output that it is a flush - true. Received {0}", checker.IsFlush(hand)));
        }

        [TestMethod]
        public void TestIfHandIsFlushWhenHandIsNotFlush()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Queen, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardFour = new Card(CardFace.Three, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Ace, CardSuit.Hearts);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsFlush(hand), string.Format("Expetected output that it is not a flush - false. Received {0}", checker.IsFlush(hand)));
        }

        [TestMethod]
        public void TestIfHandIsStraightWhenHandIsStraight()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Five, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Four, CardSuit.Hearts);
            Card cardFour = new Card(CardFace.Six, CardSuit.Clubs);
            

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsStraight(hand), string.Format("Expetected output that it is a straight - true. Received {0}", checker.IsStraight(hand)));
        }

        [TestMethod]
        public void TestIfHandIsStraightWhenHandIsNotStraight()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Five, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardFour = new Card(CardFace.Six, CardSuit.Clubs);


            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsStraight(hand), string.Format("Expetected output that it is not a straight - false. Received {0}", checker.IsStraight(hand)));
        }

        [TestMethod]
        public void TestIfHandIsTwoPairstWhenHandIsTwoPairs()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Five, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardFour = new Card(CardFace.Two, CardSuit.Clubs);


            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsTwoPair(hand), string.Format("Expetected output that it is  two pairs - true. Received {0}", checker.IsTwoPair(hand)));
        }

        [TestMethod]
        public void TestIfHandIsTwoPairstWhenHandIsNotTwoPairs()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Five, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Seven, CardSuit.Hearts);
            Card cardFour = new Card(CardFace.Two, CardSuit.Clubs);


            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsTwoPair(hand), string.Format("Expetected output that it is not  two pairs - false. Received {0}", checker.IsTwoPair(hand)));
        }

        [TestMethod]
        public void TestIfHandIsOnePairtWhenHandIsOnePair()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Five, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Seven, CardSuit.Hearts);
            Card cardFour = new Card(CardFace.Two, CardSuit.Clubs);


            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsOnePair(hand), string.Format("Expetected output that it is  one pairs - true. Received {0}", checker.IsOnePair(hand)));
        }

        [TestMethod]
        public void TestIfHandIsOnePairtWhenHandIsNotOnePair()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Five, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Four, CardSuit.Diamonds);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);


            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand hand = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsOnePair(hand), string.Format("Expetected output that it is not one pair - false. Received {0}", checker.IsOnePair(hand)));
        }

        [TestMethod]
        public void TestIfStraightIsHigherThanTwoPairsShouldReturnTrue()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            Card cardFive = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardTwo = new Card(CardFace.Five, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);

            List<ICard> cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand handOne = new Hand(cards);

            cardOne = new Card(CardFace.Two, CardSuit.Hearts);
            cardFive = new Card(CardFace.Four, CardSuit.Hearts);
            cardTwo = new Card(CardFace.Three, CardSuit.Hearts);
            cardThree = new Card(CardFace.Six, CardSuit.Diamonds);
            cardFour = new Card(CardFace.Five, CardSuit.Clubs);

            cards = new List<ICard>();

            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);

            Hand handTwo = new Hand(cards);

            PokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(-1,checker.CompareHands(handOne, handTwo), string.Format("Expected result straight should be higher than two pairs and to return -1. Returned {0}",checker.CompareHands(handOne, handTwo)));
        }

    }

    
    }

