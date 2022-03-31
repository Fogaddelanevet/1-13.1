using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[4];
            int kulonb;
            int kulonb2=0;
           
            Console.WriteLine("ird be az első négy elemet!");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            kulonb = tomb[1] - tomb[0];
           
            for (int i = 1; i < tomb.Length; i++)
            {
               kulonb2 = tomb[i] - tomb[i - 1];
                if (kulonb2 != kulonb)
                {
                    Console.WriteLine(" nem sorozat");
                    break;

                }
                else
                {
                    Console.WriteLine("sorozat");
                    
                }

            }
           
                
           
            Console.ReadKey();
        }
    }
}
