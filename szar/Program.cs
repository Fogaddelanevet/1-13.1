using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            bool ismetel=true;
            while (ismetel)
            {
                try
                {
                    Console.WriteLine("irj be egy szamot");
                    x = Convert.ToInt32(Console.ReadLine());
                    ismetel = false;
                }
                catch(FormatException e )
                {
                    Console.WriteLine("szamot.",e);
                    ismetel = true;
                }
             }
            Console.ReadKey();
        }
    }
}
