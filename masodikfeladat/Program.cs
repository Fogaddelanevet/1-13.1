using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikfeladat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int oldalak;
            string nev;

           /* Console.WriteLine("ird be az oldalak szamat:");
            oldalak = int.Parse(Console.ReadLine());
            Console.WriteLine("ird be a konyv cimet:");
            nev = Convert.ToString(Console.ReadLine());*/

           
            while (Console.ReadKey().KeyChar != (char)13)   
            {

                Console.WriteLine("ird be az oldalak szamat:");
                oldalak = int.Parse(Console.ReadLine());
                Console.WriteLine("ird be a konyv cimet:");
                nev = Convert.ToString(Console.ReadLine());
                if(oldalak>150)
                {
                    Console.WriteLine("{0} könyv hosszu terjedelmu",nev);

                }
                else
                {
                    Console.WriteLine("{0} könyv rovid terjedelmu", nev);
                }
            }
            Console.ReadKey();
        }
    }
}
