using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace harmadikfeladat
{
    class Program
    {   
        static void Main(string[] args)
        {
            string kiir;
            string nev;
            string foglalkozas;
            string nem="";
            string[] tomb = new string[3];
            Random r = new Random();
          

            for (int i = 0; i <tomb.Length; i++)
            { 
                Console.WriteLine("ird be a neved:");
                nev = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine("ird be a foglalkozasod:");
                foglalkozas = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine("ird be a nemed f/n:");
                nem = Convert.ToString(Console.ReadLine());
               
                if (nem == "f")
                {
                    nem = "ferfi";
                }
                else if (nem == "n")
                {
                    nem = "no";
                }

                kiir = nev + " egy  " + foglalkozas + " " + nem + " volt,szerencseszáma: "+r.Next(1,50);
                tomb[i] = kiir;
                
            }

            Console.WriteLine();
           
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("{0}" ,tomb[i]);
               
            }
           
           
            Console.ReadKey();

        }
    }
}
