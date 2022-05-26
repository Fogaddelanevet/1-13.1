using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tizennyolc
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

            public BaratLista
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
            //18.3
            static List<Baratok> valogat(List<Baratok>mindenki)
            {
                Baratok p;
                int koraiEv = Convert.ToDateTime(DateTime.Now.Year)-20;
                List<Baratok> ret = new List<Baratok>( );
                foreach (Baratok item in mindenki)
                {
                    if(p.szuletett.Year<=koraiEv && p.bulis>=5)
                    {
                        ret.Add(p);

                    }
                    
                }

                foreach (var item in ret)
	                {
                       p.nev;
	                }
                return ret;
            }
            //18.4
            static void rendezes(List<Baratok> bulizok)
             {
             for (int i =0; i<bulizok.Count ; i++)
                 for (int j=i +1; j<bulizok.Count ; j++)
                 if(bulizok[i].bulis > bulizok[j].bulis)
                 {
                     Baratok c =bulizok[i];
                     bulizok[i] = bulizok[j] ;
                     bulizok[j] = c ;
                 }
               }
            public void kiir()
             {
                Baratok p;
                
               for (int i = 0; i < 15; i++)
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
            br.kiir();

        }
    }
}
