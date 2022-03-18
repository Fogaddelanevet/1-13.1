using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz
{
    class Halmaz
    {
        int [] a;
        int [] b;
        int c;
        public Halmaz()
        {
            beolvasas();
        }

        public void beolvasas()
        {
            
            
            Console.WriteLine("hany elemu legyen a halmaz?");
            this.c = int.Parse(Console.ReadLine());

            
           
        }
        public void feltolt()
        {
            Random r = new Random();
            if (this.c > 200)
            {
                a = new int[r.Next(0, 100)];
                b = new int[r.Next(0, 100)];
                Console.WriteLine("a halmaz:");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = r.Next(-100, 100);
                }

                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = r.Next(-100, 100);
                }
            }
            else
            {
                a = new int[this.c];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = r.Next(0, 5);
                }
                b = new int[this.c];
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = r.Next(0, 5);
                }
            }
        }
        public void kiiratas()
        {
            Console.WriteLine("a halmaz:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("b halmaz:");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("{0} ",b[i]);
            }

          
        }
        public void akulonb()
        {
          var diff = this.a.Except(this.b);
          Console.WriteLine(String.Join(", ", diff));
           
        }
        public void bkulonb()
        {
           var diff = this.b.Except(this.a);
          Console.WriteLine(String.Join(", ", diff));

        }
        public void metszet()
        {
            for (int i = 0; i < a.Length; i++)
			{
                for (int j = 0; j < b.Length; j++)
			    {
                    if(a[i]==b[j])
                    {
                    Console.WriteLine(a[i]);
                    }
			    }
                
			}
        }
        public void unio()
        {
            var unio=this.a.Union(this.b);
             Console.WriteLine(String.Join(", ", unio));
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Halmaz a = new Halmaz();
            a.feltolt();
            a.kiiratas();
            Console.WriteLine();
            Console.WriteLine("a-b:");
            a.akulonb();
            Console.WriteLine("b-a:");
            a.bkulonb();
             Console.WriteLine("metszet:");
            a.metszet();
            Console.WriteLine("unio:");
            a.unio();
            Console.ReadKey();
        }
    }
}
