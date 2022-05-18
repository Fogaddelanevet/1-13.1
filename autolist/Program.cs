using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace autolist
{
internal class Autolist
    {
        class Autok
        {
            private string rendszam;
            private string gyartas;
            public string tipus;
            public DateTime gyartasiev;
            public DateTime vizsga;
            public string tulajdonos;

            public Autok() { }

            public Autok(string rendszam, string gyartas, string tipus, DateTime gyartasiev, DateTime vizsga, string tulajdonos)
            {
                this.rendszam = rendszam;
                this.gyartas = gyartas;
                this.tipus = tipus;
                this.gyartasiev = gyartasiev;
                this.vizsga = vizsga;
                this.tulajdonos = tulajdonos;
            }
            public void printAutok()
            {
                Console.WriteLine("{0,-20} {1,10} {2,1} {6}", rendszam,gyartas,tipus, gyartasiev.ToShortDateString(), vizsga.ToShortDateString(), tulajdonos);
            }
            private List<Autok> autolista;

            private string fajlNev;

            public AutoList()
            {
               autolista = new List<Autok>();
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

                        autolista.Add(new Autok(mezok[0],
                             mezok[1],
                             mezok[2],
                             DateTime.Parse(mezok[3]),
                             DateTime.Parse(mezok[4]), 
                             mezok[5]));



                    }


            }
            public void kiir()
            {
                foreach (Autok p in autolista)
                {
                    p.printAutok();
                }
                Console.ReadKey();
            }

        }





















    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
