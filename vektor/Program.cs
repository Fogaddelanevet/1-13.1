using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektor
{
    class Vektor
    {
        int[]  tomb = new int[4];
        public Vektor()
        {
            beolvas();
        }
        public void beolvas()
        {
            Console.WriteLine("Ird be a sorozat elemeit:");
            for (int i = 0; i < this.tomb.Length; i++)
            {
                this.tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void szamtani()
        {
            int dif = this.tomb[1] - this.tomb[0];
            int db = 0, db1 = 0;
            for (int i = 1; i < this.tomb.Length; i++)
            {
                if(this.tomb[i]-this.tomb[i-1]==dif)
                {
                    db++;
                }
                else
                {
                    db1++;
                }    
            }
            if(db==3)
            {
                Console.WriteLine("sorozat");
            }
            else
            {
                Console.WriteLine("nem sorozat");
            }
        }
        public void mertani()
        {
            double hany = this.tomb[1] / this.tomb[0];
            int db = 0, db1 = 0;
            for (int i = 1; i < this.tomb.Length; i++)
            {
                if(this.tomb[i] / this.tomb[i - 1] == hany)
                    {
                        db++;
                    }
                else
                    {
                        db1++;
                    }
    
            }
            if (db == 3)
            {
                Console.WriteLine("mértani sorozat");
            }
            else
            {
                Console.WriteLine("nem mértani sorozat");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Vektor a = new Vektor();
            a.szamtani();
            a.mertani();
            Console.ReadKey();

        }
    }
}
