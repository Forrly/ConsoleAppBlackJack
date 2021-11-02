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
        [TestMethod]
        public void Check_TotalValueAllCardsInHand()
        {
            Card _card1, _card2, _card3;
            _card1 = new Card(7);
            _card2 = new Card(4);
            _card3 = new Card(10);
            _hand.AddCard(_card1);
            _hand.AddCard(_card2);
            _hand.AddCard(_card3);
            int _totalValue = _hand.Total();
            Assert.AreEqual(21, _totalValue);
        }
    }
}