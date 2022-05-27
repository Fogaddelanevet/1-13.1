using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using minmax;

namespace minmaxteszt
{
    [TestClass]
    public class UnitTest1
    {
        Kivalasztas a = new Kivalasztas();
        [TestMethod]
        public void MIn()
        {
            int legkisebb = 0;
            int varteredmeny = a.min();
            Assert.AreEqual(legkisebb, varteredmeny);
        }
        [TestMethod]
        public void MAx()
        {
            int legnagyobb = 200000;
            int varteredmeny = a.max();
            Assert.AreEqual(legnagyobb, varteredmeny);
        }
        [TestMethod]
        public void rosszMAx()
        {
            int legnagyobb = 20000000;
            int varteredmeny = a.max();
            Assert.AreNotEqual(legnagyobb, varteredmeny);
        }
        [TestMethod]
        public void rosszmin()
        {
            int legnagyobb = 20000000;
            int varteredmeny = a.min();
            Assert.AreNotEqual(legnagyobb, varteredmeny);
        }
    }
}
