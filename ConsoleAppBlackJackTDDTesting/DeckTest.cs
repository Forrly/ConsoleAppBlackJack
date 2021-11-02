using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBlackJackTDD;

namespace ConsoleAppBlackJackTDDTesting
{
    [TestClass]
    public class DeckTest
    {
        private Deck _deck;
        [TestMethod]
        [TestInitialize()]
        public void Check_ConstructorDeck()
        {
            _deck = new Deck();
        }
        [TestMethod]
        public void Check_ValueInTheRange_1_11_()
        {
            Card _card = _deck.GetCard();
            Assert.AreEqual(1, objectsAreInRange(1, 11, _card.Value));
        }

        int objectsAreInRange(int actual, int expected, int delta)
        {
            if (delta > actual && delta < expected)
                return 1;
            else
                return 0;
        }
        
    }
}