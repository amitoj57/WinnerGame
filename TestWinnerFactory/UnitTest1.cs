using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WinnerGame.Common;

namespace TestWinnerFactory
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FactoryTest()
        {
            Punter punter = Factory.GetPunter(10);
            Assert.AreEqual(punter == null, true);
        }
    }
}
