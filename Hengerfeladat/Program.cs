using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hengerfeladat
{
    public class Henger
    {
        double sugar;
        double magassag;
        double kerulet;
        double alapterulet;
        double hengerter;
        double felszin;
        double terfogat;
         public Henger()
        {

        }
        public double setsugar()
        {
            
            Console.WriteLine("Sugar nagysága:");
            this.sugar = Convert.ToDouble(Console.ReadLine());
            return this.sugar;
        }
        public double setmagassag()
        {
            Console.WriteLine("magassag:");
            this.magassag = Convert.ToDouble(Console.ReadLine());
            return this.magassag;

        }
        public double getkerulet()
        {

            this.kerulet = 2 * this.sugar * Math.PI;
            return this.kerulet;
        }
        public double getalapter()
        {
            this.alapterulet = 2 * Math.PI * this.sugar * this.sugar;
            return this.alapterulet;
        }
        public double getterulet()
        {
            this.hengerter = 2 * (Math.PI * this.sugar * this.magassag);
            return this.hengerter;
        }
        public double getFelszin()
        {
            this.felszin = 2 * (getterulet() + getalapter());
            return this.felszin;
        }
        public double getTerfogat()
        {
            this.terfogat = Math.PI * this.sugar * this.sugar * this.magassag;
            return this.terfogat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Henger a = new Henger();
            a.setsugar();
            a.setmagassag();
            
            Console.WriteLine(a.getkerulet());
            Console.WriteLine(a.getalapter());
            Console.WriteLine(a.getFelszin());
            Console.WriteLine(a.getTerfogat());
            Console.ReadKey();
        }
    }
}
