using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace REKORDOK
{
    internal class BaratLista
    {
        class Baratok
        {
            private string nev;
            private DateTime szuletett;
            private char neme;
            private int bulis;
            public Baratok() { }

            public Baratok(string nev, DateTime szuletett, char nem, int bulis)
            {
                this.nev = nev;
                this.szuletett = szuletett;
                this.neme = nem;
                this.bulis = bulis;
            }
            public void printBarat()
            {
                Console.WriteLine("{0,-20} {1,10} {2,1} {3}", nev, szuletett.ToShortDateString(), neme, bulis);
            }
            private List<Baratok> baratlista;

            private string fajlNev;
            public BaratLista()
            {
               baratlista = new List<Baratok>();
            }
            public void beolvas()
            {
                string sor;
                string[] mezok;

                Console.WriteLine("fáljneve?");
                fajlNev = Console.ReadLine();

                if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";


                using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))

                    while (sr.EndOfStream == false)
                    {
                        sor = sr.ReadLine();
                        if (sor.Trim().Length == 0) continue;

                        mezok = sor.Split(',');

                        baratlista.Add(new Baratok(mezok[0],
                            DateTime.Parse(mezok[1]),
                            char.Parse(mezok[2]),
                            int.Parse(mezok[3])));
                    }


            }
            public void kiir()
            {
                foreach (Baratok p in baratlista)
                {
                    p.printBarat();
                }
                Console.ReadKey();
            }


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaratLista br = new BaratLista();
            
        }
    }
}
