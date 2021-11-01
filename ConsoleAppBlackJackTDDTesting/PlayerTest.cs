using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBlackJackTDD;

namespace ConsoleAppBlackJackTDDTesting
{
    [TestClass]
    public class PlayerTest
    {
        private Player _player;
        private Hand _hand;
        [TestInitialize()]
        public void createTestPlayer()
        {
            _player = new Player();
        }

    }
}
