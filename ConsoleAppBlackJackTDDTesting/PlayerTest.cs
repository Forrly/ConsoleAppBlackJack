using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBlackJackTDD;

namespace ConsoleAppBlackJackTDDTesting
{
    [TestClass]
    public class PlayerTest
    {
        private Player _player;
        [TestMethod]
        [TestInitialize()]
        public void Check_ConstructorPlayer()
        {
            _player = new Player();
        }
        [TestMethod]
        public void Check_CountOfCardsAfterDealPlayer()
        {
            Deck _deck = new Deck();
            _player.DealCards(2,_deck);
            Assert.AreEqual(2, _player.hand.cards.Count);
        }

    }
}
