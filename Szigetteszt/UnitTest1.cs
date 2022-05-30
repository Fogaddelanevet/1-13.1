using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sziget;

namespace Szigetteszt
{
   

    [TestClass]
    
    public class UnitTest1
    {
        [TestMethod]
        public void Szigetszamjo()
        {
            Szigetek a = new Szigetek();
            int szigetszamvart = 4;
            int szigetszamkapott = a.Szigetszam();
            Assert.AreEqual(szigetszamkapott, szigetszamvart);
        }
        [TestMethod]
        public void Szigethosszjo()
        {
            Szigetek a = new Szigetek();
            int szigetszamvart = 5;
            int szigetszamkapott = a.Szigethossz();
            Assert.AreEqual(szigetszamkapott, szigetszamvart);
        }
        [TestMethod]
        public void Szigetszamhiba()
        {
            Szigetek a = new Szigetek();
            int szigetszamvart = 6;
            int szigetszamkapott = a.Szigethossz();
            Assert.AreNotEqual(szigetszamkapott, szigetszamvart);
        }
        [TestMethod]
        public void Szigethosszhiba()
        {
            Szigetek a = new Szigetek();
            int szigetszamvart = 7;
            int szigetszamkapott = a.Szigethossz();
            Assert.AreNotEqual(szigetszamkapott, szigetszamvart);
        }
    }
}
