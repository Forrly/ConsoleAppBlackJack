using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBlackJackTDD;

namespace ConsoleAppBlackJackTDDTesting
{
    [TestClass]
    public class CardTest
    {
        private Card _card;
        [TestMethod]
        [TestInitialize()]
        public void Check_ConstructorCard()
        {
            _card = new Card(6);
        }
        [TestMethod]
        public void CheckCard_Value()
        {
            Assert.AreEqual(6, _card.Value);
        }
        [TestMethod]
        public void CheckCard_ToString()
        {
            Assert.AreEqual("6", _card.ToString());
        }
    }
}