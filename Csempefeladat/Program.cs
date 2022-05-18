using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezes
{
    public class Csempe
    {
        double szelesseg;
        double hosszusag;
        public Csempe()
        {
            this.szelesseg = 10; 
            this.hosszusag = 10;
        }
        public void setSzelesseg()
        {
            this.szelesseg = 10;
        }
        public void setHosszusag()
        {
            this.hosszusag = 10;
        }
        public double Getszam()
        {
            double t = Math.Round(((this.szelesseg * this.hosszusag) / (0.2 * 0.2))*0.1,2);
            return t;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Csempe cs = new Csempe();
            cs.setHosszusag();
            cs.setSzelesseg();
            Console.WriteLine(cs.Getszam());



            Console.ReadKey();
        }
    }
}
