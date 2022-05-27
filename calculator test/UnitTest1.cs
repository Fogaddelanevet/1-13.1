using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calculator;

namespace calculator_test
{
    [TestClass]
    public class UnitTest1
    {
        Calculator a = new Calculator();
        [TestMethod]

        public void hibamethodus()
        {

            double varteredmeny1 = a.eredmeny();
            double kapotteredmeny1 = 10.0;
            double eredmeny = a.eredmeny();
            Assert.AreNotEqual(varteredmeny1, kapotteredmeny1);

        }
        [TestMethod]
        public void jomethodus()
        {
            double varteredmeny = a.eredmeny();
            double kapotteredmeny = 20.0;
            double eredmeny = a.eredmeny();
            Assert.AreEqual(kapotteredmeny, varteredmeny);


        }
        [TestMethod]
        public void nulla()
        {
            double kapotteredmeny = a.eredmeny();
            double varteredmeny = 0;
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
        public void TestMethod1()
        {
                       
        }
        
    }
}
