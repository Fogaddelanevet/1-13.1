using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using h;
namespace hteszt
{
    [TestClass]
    public class UnitTest1
    {
        Henger x = new Henger();
            
        public void keruletteszt()
        { 
            double vareredmeny = 20;
            double kapotteredmeny = x.getKerulet();
            double kerulet=x.getKerulet();
            Assert.AreEqual(vareredmeny, kapotteredmeny);
            
        }           
        
       
        
         
        
        [TestMethod]
        public void TestMethod1()
        {
          
           
            
        }
    }
}
