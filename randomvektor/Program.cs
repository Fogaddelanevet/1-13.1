using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomvektor
{
    class Vektor
    {
        protected int elem;
        int [] szamok;
        public Vektor()
        {
            this.bekeres();
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

    class Matrix : Vektor
    {
        
          private int [,] tombike;


        public Matrix() : base()
        {
            tombike=new int [this.elem,this.elem];
        }
        public void tombketto()
        {
          
           Random r = new Random();
            for (int i = 0; i < tombike.GetLength(0); i++)
			{
                for (int j = 0; j < tombike.GetLength(1); j++)
			    {
                    tombike[i,j]=r.Next(0,50);
                    Console.Write("{0} ",tombike[i,j]);
			    }
                Console.WriteLine();
			}
        }

        public void minimum()
        {
         int min = tombike.Cast<int>().Min();
            Console.WriteLine(min);
        }
        public void maximum()
        {
            int max=tombike.Cast<int>().Max(); 
            Console.WriteLine(max);
        }
        public void atlag2()
        {
             double osszeg=0;
            double atlagok=0;
            for (int i = 0; i < tombike.GetLength(0); i++)
			{
                for (int j = 0; j < tombike.GetLength(1); j++)
			    {
                  osszeg+=tombike[i,j];

			    }
			}
            atlagok=osszeg/(this.elem*2);
            Console.WriteLine(atlagok);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix n = new Matrix();
            
            n.Tomb();
            Console.WriteLine("Minimum:");
            n.Min();
            Console.WriteLine("max:");
            n.Max();
            Console.WriteLine("atlag:");
            n.atlag();
            Console.WriteLine("2d:");
            n.tombketto();
            Console.WriteLine("minimum:");
            n.minimum();
            Console.WriteLine("maximum:");
            n.maximum();
            Console.WriteLine("atlag2:");
            n.atlag2();
            Console.ReadKey();
        }
    }
}
