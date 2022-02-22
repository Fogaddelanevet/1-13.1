using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igazolatlan
{
    class Program
    {
        static void Main(string[] args)
        {
            int igazolatlan = 0;
            DateTime szuletes;
            Console.WriteLine("igazolatlanok szama: ");
            igazolatlan = int.Parse(Console.ReadLine());

            if(igazolatlan >= 10 )
            {
                Console.WriteLine("add meg a születési évet:");
                szuletes = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("az igazolatlanok szama:{0}", igazolatlan);
            }
            if (igazolatlan<10)
            {
                Console.WriteLine("nincs problema");
            }
            else if (igazolatlan>=10 && igazolatlan<20)
            {
                Console.WriteLine("figyelmeztetes");
            }   
            else if (igazolatlan>=21 && igazolatlan <25)
            {
                Console.WriteLine("osztalyfonoki");
            }
            else if(igazolatlan >=26 && igazolatlan <30 )
            {
                Console.WriteLine("igazgatoi");
            }
            else if (igazolatlan >= 31 )
            {
                Console.WriteLine("felfuggesztes");
            }
            Console.ReadKey();
        }
    }
}
