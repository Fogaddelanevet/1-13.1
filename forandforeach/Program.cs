using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forandforeach
{
    class forandforeach
    {
        int[] tomb = new int[10];

        public void feltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < this.tomb.Length; i++)
            {
                this.tomb[i] = r.Next(1, 100);
            }
        }
        public void forciklus()
        {
            for (int i = 0; i < this.tomb.Length; i++)
            {
                Console.WriteLine(this.tomb[i]);
            }
        }
        public void foreachciklus()
        {
            foreach (var item in tomb)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            forandforeach a = new forandforeach();
            a.feltoltes();
            Console.WriteLine("forciklus");
            a.forciklus();
            Console.WriteLine("foreach");
            a.foreachciklus();
            Console.ReadKey();

        }
    }
}
