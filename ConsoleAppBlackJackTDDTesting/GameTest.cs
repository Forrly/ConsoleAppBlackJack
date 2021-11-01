using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBlackJackTDD;

namespace ConsoleAppBlackJackTDDTesting
{
    [TestClass]
    class GameTest
    {
        private Game _game;
        [TestInitialize()]
        public void createTestGame()
        {
            _game = new Game();
        }
    }
}
