using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace többelem
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan ts = new TimeSpan();
            TimeSpan ts2 = new TimeSpan();
            Console.Write("Irj bee egy idot:");
            ts = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Irj bee egy idot:");
            ts2 = TimeSpan.Parse(Console.ReadLine());
            

            if (ts2 > ts)
            {
                Console.WriteLine(ts2 - ts);
            }
            else if(ts>ts2)
            {
                Console.WriteLine(ts - ts2);
            }
            Console.ReadKey();
        }
    }
}
