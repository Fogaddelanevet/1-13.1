using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honapok
{
    class Honapok

    {
        int min = 0;
        int max = 0;
        double honapatlag;
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
            for (int i = 0; i < this.homersekletek.GetLength(0); i++)
            {
                for (int j = 0; j < this.homersekletek.GetLength(1); j++)
                {
                    this.honapatlag += homersekletek[i, j];
                }

            }
            
        }
        public void kiiratas()
        {
            double atlag = (this.homersekletek[this.nap, 0] + this.homersekletek[this.nap, 1]) / 2;
            Console.WriteLine("a nap hőmérsékletei: max: {0} min {1} atlag {2}", this.homersekletek[nap,0],this.homersekletek[nap,1], atlag);
            Console.WriteLine("honap atlag:{0}", Math.Round(this.honapatlag/ 31));
            Console.WriteLine("havi min:{0} havi max:{1}", this.min, this.max);
        }
        public void maxmin()
        {
           
            for (int i = 0; i < this.homersekletek.GetLength(0); i++)
            {
                if(this.homersekletek[i,0]<this.min)
                {
                    this.min = this.homersekletek[i, 0];
                }
                
            }
            for (int i = 0; i < this.homersekletek.GetLength(0); i++)
            {
                if (this.homersekletek[i, 1] > this.max)
                {
                    this.max = this.homersekletek[i, 1];
                }

            }
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            Honapok a = new Honapok();
            a.Tavasz();
            a.kiiratas();
            a.maxmin();
            Console.ReadKey();
        }
    }
}
