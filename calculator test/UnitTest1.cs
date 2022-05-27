using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calculator;

namespace calculator_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator a = new Calculator();
            double varteredmeny = a.eredmeny();
            double kapotteredmeny = 20;
            Assert.AreEqual(kapotteredmeny, varteredmeny);

        }
    }
}
