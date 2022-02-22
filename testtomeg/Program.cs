using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomeg
{
    class Program
    {
        static void Main(string[] args)
        {
            double magassag = 0,tomeg = 0,szamolas=0;
            Console.Write("ird be a magassagod:");
            magassag = double.Parse(Console.ReadLine());
            Console.WriteLine("ird be a tomeged:");
            tomeg= double.Parse(Console.ReadLine());

            szamolas = tomeg / (magassag * magassag);
            Console.WriteLine("bmi: {0}", szamolas);
           

            if(szamolas<18.5)
            {
                Console.WriteLine("soványság");
            }
            else if (szamolas<18.5 && szamolas<24.9)
            {
                Console.WriteLine("normalis testsuly");
            }
            else if (szamolas>25 && szamolas<29.9)
            {
                Console.WriteLine("tulsuly");
            }
            else if (szamolas>30)
            {
                Console.WriteLine("elhizas");
            }
            Console.ReadKey();

        }
    }
}
