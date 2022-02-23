using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikmasodikmasodik
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int szam = 0;
            int max = 0;
            do
            {
                Console.WriteLine("irj be egy szamot");
                szam = int.Parse(Console.ReadLine());
                if (szam > max)
                {
                    max = szam;
                }
            }
            while (szam != 0);
            {
               
                
            }
           
            Console.WriteLine("a legnagyobb szam: {0}",max);
            Console.ReadKey();
        }
    }
}
