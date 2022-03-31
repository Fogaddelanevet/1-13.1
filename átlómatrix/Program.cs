using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace átlómatrix
{
    class Matrix
    {
        int[,] tomb;
        int n, m;
        public Matrix()
        {

        }
        public void beolvas()
        {
            Console.WriteLine("n oldal:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("m oldal:");
            m = int.Parse(Console.ReadLine());
            tomb = new int[n, m];
        }
        public void tombfeltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    tomb[i, j] = r.Next(0, 50);
                    Console.Write("{0} ",tomb[i, j]);


                }
                Console.WriteLine();
            }
        }
        public void atlo()
        {
            int total=0;
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(tomb[i, j] + " ");
                        total += tomb[i, j];
                    }

                }
               
            }

           
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix();
            a.beolvas();
            a.tombfeltoltes();
            Console.WriteLine();
            a.atlo();


            Console.ReadKey();
        }
    }
}
