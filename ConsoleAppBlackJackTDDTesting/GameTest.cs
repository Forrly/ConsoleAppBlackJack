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
        public void initializeGame()
        {
            _game = new Game();
            _game.Play();
        }
    }
}
