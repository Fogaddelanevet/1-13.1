using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using szamok;

namespace szamoktesztje
{

    [TestClass]

    public class UnitTest1
    {
        Szamok a = new Szamok("15");

        [TestMethod]
        public void otosteszt()
        {
            string varteredmeny = "otos";
            string kapotteredmeny = a.otos();
            string otos = a.otos();
            Assert.AreEqual(varteredmeny, kapotteredmeny);

        }
        public void harmasteszt()
        {
            string varteredmeny = "harom";
            string kapotteredmeny = a.harmas();
            string harmas = a.harmas();
            Assert.AreEqual(varteredmeny, kapotteredmeny);

        } 
        public void TestMethod1()
        {

        }
    }
}
