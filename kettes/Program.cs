using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kettes
{
    class Kettes
    {
        int szam;
        string bin;
        int[] kettesek = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
        public Kettes(int szam)
        {
            this.szam = szam;
            this.bin = "";
        }
        public void szamolas()
        {
            for (int i = 0; i < this.kettesek.Length; i++)
            {
                if(this.szam-this.kettesek[i]>=0)
                {
                    this.bin += "              1 ";
                    this.szam -= kettesek[i];
                    
                }
                else
                {
                    this.bin += "          0 ";
                }
            }
        }
        public string ertek()
        {
            return this.bin;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irj be egy szamot:");
            Kettes a = new Kettes(Convert.ToInt32(Console.ReadLine()));
            a.szamolas();
            Console.WriteLine(a.ertek());
            Console.ReadKey();
        }
    }
}
