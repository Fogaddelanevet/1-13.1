using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    class Program
    {
        public class Henger
        {
            double sugar;
            double magassag;
            public  Henger()
            { 

            }
            public void getSugar()
            {
                Console.WriteLine("Mekkora sugara van?");
                this.sugar=Convert.ToDouble(Console.ReadLine());
            }
            public void getMagas()
            {
                Console.WriteLine("mekkora magassága van?");
                this.magassag=Convert.ToDouble(Console.ReadLine());
            }
            public double getKerulet()
            {
                double kerulet=this.sugar*2*Math.PI;
                return kerulet;
            }
            public double getTerulet()
            {
                double terulet=this.sugar*this.sugar*Math.PI;
                return terulet;
            }
            public double getFelszin()
            {
                double felszin=2*this.sugar*Math.PI*(this.sugar+this.magassag);
                return felszin;
            }
            public double getTerfogat()
            {
                double terfogat=Math.PI*(this.sugar*this.sugar)*this.magassag;
                return terfogat;

            }
        }
        static void Main(string[] args)
        {
            Henger a = new Henger();
            a.getSugar;
            a.getMagas;
            a.getKerulet;
            a.getTerulet;
            a.getFelszin;
            a.getTerfogat;
            Console.ReadKey();
        }
    }
}
