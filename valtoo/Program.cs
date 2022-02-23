using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valto
{
    class Program
    {
        static void Main(string[] args)
        {
            int maradek = 0, cimlet = 0, osszeg = 0;
            int[,] cimletek = { { 20000, 0 }, { 10000, 0 }, { 5000, 0 }, { 2000, 0 }, { 1000, 0 }, { 500, 0 }, { 200, 0 }, { 100, 0 }, { 50, 0 }, { 20, 0 }, { 10, 0 }, { 5, 0 } };

            Console.WriteLine("irj be egy osszeget:");
            osszeg = int.Parse(Console.ReadLine());

            for (int i = 0; i < cimletek.GetLength(0); i++)
            {

                if (osszeg >= cimletek[i, 0])
                {
                    cimlet = osszeg / cimletek[i, 0];
                    cimletek[i, 1] = cimlet;
                    osszeg = osszeg - cimlet * cimletek[i, 0];
                    Console.WriteLine("{0} ft cimletből {1} db kell", cimletek[i, 0], cimletek[i, 1]);
                    if (osszeg == 0)
                    {
                        break;
                    }
                }

            }


            Console.ReadKey();
        }
    }
}
