using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomvektor
{
    class Vektor
    {
        int elem;
        int [] szamok;
        public Vektor()
        {

        }
        public void bekeres()
        {
            Console.Write("ird be hany db szam kell:");
            this.elem = Convert.ToInt32(Console.ReadLine());
            szamok = new int[this.elem];
        }
        public void Tomb()
        {
           
            Random r = new Random();
            for (int i = 0; i <szamok.Length; i++)
            {
                szamok[i] = r.Next(0, 100);
                Console.WriteLine(szamok[i]);               
            }

        }
        public void Min()
        {
            Console.WriteLine(szamok.Min());
        }
        public void Max()
        {
            Console.WriteLine(szamok.Max());
        }
        public void atlag()
        {
            
            double ertek = 0;
            double atlag;
            for (int i = 0; i < szamok.Length; i++)
            {
                ertek +=szamok[i];
            }
            atlag = ertek / this.elem;
            Console.WriteLine("szamok osszege {0}",ertek);
            Console.WriteLine(atlag);

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vektor n = new Vektor();
            n.bekeres();
            n.Tomb();
            Console.WriteLine("Minimum:");
            n.Min();
            Console.WriteLine("max:");
            n.Max();
            Console.WriteLine("atlag:");
            n.atlag();
            Console.ReadKey();
        }
    }
}
