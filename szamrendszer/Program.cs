using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    class Szamrendszer
    {
        int szamrend;
        int szam2;
        public Szamrendszer()
        {

        }
        public int beolvas()
        {
            Console.WriteLine("Melyik számrendszer?");
            this.szamrend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("milyen szam?");
            this.szam2 = Convert.ToInt32(Console.ReadLine());
            return szamrend;
        }
        public void kettes()
        {

            string bin = "";
            int[] kettesek = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };

            for (int i = 0; i < kettesek.Length; i++)
            {
                if (this.szam2 - kettesek[i] >= 0)
                {
                    bin += "1 ";
                    this.szam2 -= kettesek[i];

                }
                else
                {
                    bin += "0 ";
                }
            }
            Console.WriteLine(bin);
        }
        public void hex()
        {
            string ertek = Convert.ToHexString(this.szam2);
        }

        



    }
    class Program
    {
        static void Main(string[] args)
        {

            Szamrendszer a = new Szamrendszer();
            if(a.beolvas()==2)
            {
                a.kettes();
            }
            Console.ReadKey();

        }
    }
}
