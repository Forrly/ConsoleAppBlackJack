using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBlackJackTDD;

namespace ConsoleAppBlackJackTDDTesting
{
    [TestClass]
    public class GameTest
    {
        private Game _game;
        [TestMethod]
        [TestInitialize()]
        public void Check_ConstructorGame()
        {
            _game = new Game();
        }
        
    }
}
