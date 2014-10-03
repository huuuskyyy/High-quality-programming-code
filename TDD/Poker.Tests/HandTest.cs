using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Hand was allowed to be created with zero cards")]
        public void TestIfProperExceptionIsThrownWhenPassHandWithZeroCards()
        {
            List<ICard> cards = new List<ICard>();
            Hand hand = new Hand(cards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Hand was allowed to accept zero cards after it is created")]
        public void TestIfProperExceptionIsThrownWhenHandAcceptNewCardsAfterHandCreation()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Eight, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Eight, CardSuit.Clubs));

            Hand hand = new Hand(cards);

            List<ICard> cardsEmpty = new List<ICard>();

            hand.Cards = cardsEmpty;
        }

        [TestMethod]
        public void TestIfHadIsProperlyDisplayerAsString()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Eight, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Eight, CardSuit.Clubs));

            Hand hand = new Hand(cards);

            Assert.AreEqual("Eight-Hearts Eight-Clubs ", hand.ToString(), string.Format("Expected output Eight-Hearts Eight-Clubs  .Received {0}", hand.ToString()));
        }
    }
}
