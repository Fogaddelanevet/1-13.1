using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honapok
{
    class Honapok

    {

        string honap;
        int nap;
        int[,] homersekletek = new int[31, 2];
        Dictionary<string, int> honapok = new Dictionary<string, int>
        {{"Január",1},{"Február",2 },{"Március",3 },{"Április",4},{"Május",5},{"Június",6 },{"Julius",7},{"Augusztus",8 },{"Szeptember",9 },{"Október",10 },{"November",11 },{"December",12 } };
        public Honapok()
        {
            beolvasas();
        }
        public void beolvasas()
        {
            Console.WriteLine("HÓNAP?!");
            this.honap = Console.ReadLine();
            Console.WriteLine("NAP?!");
            this.nap = Convert.ToInt32(Console.ReadLine());
        }
        public void Tavasz()
        {
            Random r = new Random();

            if (this.honapok[this.honap] >= 3 && this.honapok[this.honap] <= 5)
            {
                for (int i = 0; i < this.homersekletek.GetLength(0); i++)
                {

                    this.homersekletek[i, 0] = r.Next(-10, 0);
                    this.homersekletek[i, 1] = r.Next(0, 20);


                }

            }

        }
         public void Tavaszatlag()
        {
            int db=0;
            Random r = new Random()
            for (int j = 0; j < 3; j++)
			    {
                 for (int i = 0; i < homersekletek.GetLength(0); i++)
			         {
                       db+= this.homersekletek[i, 0] = r.Next(-10, 0);
                       db+= this.homersekletek[i, 1] = r.Next(0, 20);
			         }
			     }
          Console.WriteLine(db);
        }
        public void kiiratas()
        {
            double atlag = (this.homersekletek[this.nap, 0] + this.homersekletek[this.nap, 1]) / 2;
            Console.WriteLine("a nap hőmérsékletei: este: {0} nappal {1} atlag {2}", this.homersekletek[this.nap, 0], this.homersekletek[this.nap, 1], atlag);
        }

       
    }



    class Program
    {
        static void Main(string[] args)
        {
            Honapok a = new Honapok();
            a.Tavasz();
            a.kiiratas();
            a.Tavaszatlag();
            Console.ReadKey();
        }
    }
}
