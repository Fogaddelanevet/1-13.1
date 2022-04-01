using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binearis
{
    class Binearis
    {
        string beolvas;
        public Binearis()
        {

        }
        public void beolvasas()
        {
            Console.WriteLine("Irj be egy bineáris számot:");
            this.beolvas = Convert.ToString(Console.ReadLine());
        }
        public void egyesek()
        {
            int db = 0;
            for (int i = 0; i < this.beolvas.Length; i++)
            {
               if(this.beolvas[i]=='1')
                {
                    db++;
                }
            }
            Console.WriteLine("egyesek szama {0}", db);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Binearis a = new Binearis();
            a.beolvasas();
            a.egyesek();
            Console.ReadKey();
        }
    }
}
