using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using csempezes;

namespace csempeteszt
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]

        
        
        public void TestMethod1()
        {
            Csempe cs = new Csempe();
            double kapotteredmeny = cs.Getszam();
            double varteredmeny = 250;
            
            Assert.AreEqual(kapotteredmeny, varteredmeny);

        }
    }
}
