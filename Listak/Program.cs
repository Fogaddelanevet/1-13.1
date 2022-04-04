using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Listak
    {
        List<int> szamok = new List<int>();
        int hossz;
        public Listak(int hossz)
        {
            this.hossz = hossz;
        }
        public void feltolt()
        {
            Random r = new Random();
            for (int i = 0; i < this.hossz; i++)
            {
                this.szamok.Add(r.Next(10, 99));
            }
        }
        public void kiir()
        {
            foreach (var item in this.szamok)
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
            Listak a = new Listak(Convert.ToInt32(Console.ReadLine()));
            a.feltolt();
            a.kiir();
            Console.ReadKey();
        }
    }
}
