using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestIfCardIsCreatedWithCorrectSiut()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);

            Assert.AreEqual(CardSuit.Spades, card.Suit, string.Format("Expected output spades. Actual output {0}", card.Suit));
        }

        [TestMethod]
        public void TestIfCardIsCreatedWithCorrectFace()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);

            Assert.AreEqual(CardFace.Ace, card.Face, string.Format("Expected output Ace. Actual output {0}", card.Face));
        }

        [TestMethod]
        public void TestIfCardHasCorrectStringOutput()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);

            Assert.AreEqual("Ace-Spades", card.ToString(), string.Format("Expected output A-spades. Received output {0}", card.ToString()));
        }
    }
}
