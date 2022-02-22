using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponthatarok
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontok = 0;
            Console.WriteLine("ird be a pontod");
            pontok = int.Parse(Console.ReadLine());

            if (pontok < 50)
            {
                Console.WriteLine("1");
            }
            else if (pontok > 50 && pontok < 65)
            {
                Console.WriteLine("2");
            }
            else if(pontok>65 && pontok <80)
            {
                Console.WriteLine("3");
            }
            else if (pontok>80 && pontok <90)
            {
                Console.WriteLine("4");
            }
            else if (pontok > 90)
            {
                Console.WriteLine("5");
            }
            Console.ReadKey();
        }
    }
}
