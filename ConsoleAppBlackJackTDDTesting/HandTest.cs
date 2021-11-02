using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBlackJackTDD;

namespace ConsoleAppBlackJackTDDTesting
{
    [TestClass]
    public class HandTest
    {
        private Hand _hand;
        [TestMethod]
        [TestInitialize()]
        public void Check_ConstructorHand()
        {
            _hand = new Hand();
        }
        [TestMethod]
        public void Check_CountAfterAddingCardInHand()
        {
            Card _card = new Card(6);
            _hand.AddCard(_card);
            Assert.AreEqual(1, _hand.cards.Count);
        }
        [TestMethod]
        public void Check_ValueAfterAddingCardInHand()
        {
            Card _card = new Card(7);
            _hand.AddCard(_card);
            ArrayList _arr = new ArrayList();
            _arr.Add(_card);
            Assert.AreEqual(_arr[0], _hand.cards[0]);
        }
    }
}