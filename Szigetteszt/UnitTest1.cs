using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sziget;

namespace Szigetteszt
{
   

    [TestClass]
    
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Szigetek a = new Szigetek();
            int szigetszamvart = 4;
            int szigetszamkapott = a.Szigetszam();
            Assert.AreEqual(szigetszamkapott, szigetszamvart);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Szigetek a = new Szigetek();
            int szigetszamvart = 5;
            int szigetszamkapott = a.Szigethossz();
            Assert.AreEqual(szigetszamkapott, szigetszamvart);
        }
    }
}
