using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikelsofeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int paros=0, paratlan=0,paratlanosszeg=0,parososszeg=0;
            Random r = new Random();
          
            for (int i = 0; i < r.Next(5,10); i++)
            {
                Console.WriteLine("irj be egy szamot");
                n = int.Parse(Console.ReadLine());
                if(n%2==0)
                {
                    paros++;
                    parososszeg=parososszeg+n;
                }
                else
                {
                    paratlan++;
                    paratlanosszeg=paratlanosszeg+n;
                }

            }
            Console.WriteLine("parosok:{0} osszeg {1} paratlanok: {2} osszeg {3} ", paros,parososszeg ,paratlan,paratlanosszeg);
            Console.ReadKey();
        }
    }
}
