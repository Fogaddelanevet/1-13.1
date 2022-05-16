using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listakezeles
{
    class Varosok
    {
        int varosdb;
        string nevek;
        List<string> lista = new List<string>();
        public Varosok()
        {

        }
        public void setDb()
        {
           try
            {
                do
                {
                    Console.WriteLine("hány várost szeretnél kezelni?");
                    this.varosdb = Convert.ToInt32(Console.ReadLine());
                }
                while (this.varosdb == 0);
                {
                    Console.WriteLine("hány várost szeretnél kezelni?");
                    this.varosdb = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("nem megfelelő karakter");
            }
        }
        public void setname()
        {
            Console.WriteLine("Milyen város nevekre van szükséged?");
            for (int i = 0; i < this.varosdb; i++)
            {
                this.nevek = Console.ReadLine();
                this.lista.Add(this.nevek);
            }

            
        }
        public void getNevek()
        {
            foreach (var item in this.lista)
            {
                Console.Write(item+",");
            }
        }
        public void GetVan()
        {
            Console.WriteLine();
            string bekeres;
            int db=0;
            Console.WriteLine("Milyen nevet keressek?");
            bekeres = Console.ReadLine();
            foreach (var item in this.lista)
            {
                if(bekeres==item)
                {
                    db++;
                }
            }
            if(db>0)
            {
                Console.WriteLine("szerepel a listában");
            }
            else
            {
                Console.WriteLine("nem szerepel a listában.");
            }
        }
        public void Delnev()
        {
            Console.WriteLine();
            string bekeres;
            Console.WriteLine("Milyen nevet keressek?");
            bekeres = Console.ReadLine();

            foreach (var item in this.lista)
            {
                if(bekeres==item)
                {
                 this.lista.Remove(item);
                 break;
                }
                else
                {
                  this.lista.Add(bekeres);
                }
            }

        }
        public void Dellast()
        {
            this.lista.RemoveAt(this.lista.Count - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Varosok a = new Varosok();
            a.setDb();
            a.setname();
            a.getNevek();
            a.GetVan();
            a.Delnev();
            a.Dellast();
            Console.ReadKey();
        }
    }
}
