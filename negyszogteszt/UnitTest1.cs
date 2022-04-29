using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using negyszog;

namespace negyszogteszt
{
    [TestClass]
    public class UnitTest1
    {
        static double s = 2.0;
        Negyszog nsz = new Negyszog(s);
        
        [TestMethod]
        public void Keruletteszt()
        {
            double vartered = 8;
            double kapottered = nsz.kerület();
            double ker = nsz.kerület();
            //
            Assert.AreEqual(vartered, kapottered);
        }
        public void TeruletTeszt()
        {
            double varteredmeny = 77;
            double kapotteredmeny = nsz.terület();
            double ter =nsz.terület();
            Assert.AreEqual(varteredmeny, kapotteredmeny);

        }
        public void TestMethod1()
        {
            
        }
    }
}
