using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pontook
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, x2 = 0,y1=0,y2=0,szamolas=0;
            Console.WriteLine("x1:");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("x2:");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("y1:");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2:");
            y2 = int.Parse(Console.ReadLine());

            szamolas = (x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1);
            Console.WriteLine(Math.Sqrt(szamolas));
            Console.ReadKey();


        }
    }
}
