using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazas
{
    class Lista
    {
        List<int> szamok = new List<int>();
        int hossz;
        List<int> paros = new List<int>();
        List<int> paratlan = new List<int>();
        public Lista(int hossz)
        {
            this.hossz = hossz;
        }
        public void feltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < this.hossz; i++)
            {
                this.szamok.Add(r.Next(1, 100));
            }
        }
        public void valasztas()
        {
            foreach (var item in this.szamok)
            {
                Console.WriteLine(item);
                 if(item%2==0)
                    {
                        paros.Add(item);
                    }
                 else
                {
                    paratlan.Add(item);
                }
            }
        }
        public void kiir()
        {
            Console.WriteLine("parosszamok:");
            foreach (var item in paros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("paratlanszamok:");
            foreach (var item in paratlan)
            {
                Console.WriteLine(item);
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Milyen hosszu legyen a lista?");
            Lista a = new Lista(Convert.ToInt32(Console.ReadLine()));
            a.feltoltes();
            a.valasztas();
            a.kiir();
            Console.ReadKey();
        }
    }
}
