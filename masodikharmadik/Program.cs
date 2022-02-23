using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikharom
{
    class Program
    {
        static void Main(string[] args)
        {
            int kezdo = 0, veg = 0;
            Console.WriteLine("ird be a kezdoerteket:");
            kezdo = int.Parse(Console.ReadLine());
            Console.WriteLine("ird be a vegerteket:");
            veg = int.Parse(Console.ReadLine());

            for (int i = kezdo; i < veg; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
