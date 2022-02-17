using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            Random r = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(0,100);
                
            }
            int min = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if(tomb[i]<min)
                {
                    min = tomb[i];
                }
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            int max = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            int maxindex = Array.IndexOf(tomb, tomb.Max());
            int minindex = Array.IndexOf(tomb, tomb.Min());
            Console.WriteLine("a legkisebb elem :{0}", min);
            Console.WriteLine("a legnagyobb elem :{0}", max);
            Console.WriteLine("a legkisebb elem indexe:{0} a legnagyobb index helye: {1}",minindex,maxindex);
            int a = 0;

            while (a < tomb.Length)
            {
                tomb[a] = a;
                Console.WriteLine(tomb[a]);
                a++;
            }
            Console.ReadKey();

           
        }
    }
}
