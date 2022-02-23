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
            int paros=0, paratlan=0;
            Random r = new Random();
          
            for (int i = 0; i < r.Next(5,10); i++)
            {
                Console.WriteLine("irj be egy szamot");
                n = int.Parse(Console.ReadLine());
                if(n%2==0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }

            }
            Console.WriteLine("parosok:{0} paratlanok: {1} ", paros, paratlan);
            Console.ReadKey();
        }
    }
}
