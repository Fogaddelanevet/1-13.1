using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace körgenyo
{
    
    class Kör
    {
        private  double sugar;
        public Kör()
        {
          
        }
        public void beker()
        {
            this.sugar = Convert.ToDouble(Console.ReadLine());
            
        }
        public double terület()
        {
            return this.sugar * this.sugar * 3.14;
        }
        public double kerület()
        {
            return 2 * 3.14 * this.sugar;
        }  
    }
    class Henger : Kör
    {
        private double magassag;
        public Henger() : base()
        {

        }
        public void beolvasas()
        {
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }
        public double terfogat()
        {
            return this.terület() * this.magassag;
        }



    }
    

    class Program
    {
        static void Main(string[] args)
        {

            Henger b = new Henger();
            Console.WriteLine("add meg a sugarat:");
            b.beker();
            Console.WriteLine("kerület:{0}  terület:{1} ", b.kerület(), b.terület());
            Console.WriteLine("ird be a magassagot:");
            b.beolvasas();
            Console.WriteLine("{0}",b.terfogat());

           
            Console.ReadKey();
        }
    }
}
