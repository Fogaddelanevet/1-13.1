using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._3feladat
{
    internal class Program
    {
        class Ember
            {

            public string nev;
            public string foglalkozas;
            public string nem;
            public string szerencseszam;
            }
        static bool nemek(string ferfie)
        {
            
            if(ferfie=="f")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        static string kiiratas(string neve,string foglalkozasa,string neme,string szam,string kiir)
        {
            kiir = neve + " egy " + foglalkozasa+" " + neme + " volt szerencseszáma:"+szam;
            return kiir;
        }
        static void Main(string[] args)
        {
            Ember ember=new Ember();
            Random rnd=new Random();
            string [] tomb = new string[3];
            
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("ird be a neved:");
                ember.nev = Console.ReadLine();
                Console.WriteLine("ird be a foglalkozásod:");
                ember.foglalkozas = Console.ReadLine();
                Console.WriteLine("ird be a nemed: f/n");
                ember.nem = Console.ReadLine();
                ember.szerencseszam = Convert.ToString(rnd.Next(1, 50));

                if (nemek(ember.nem) == true)
                {
                    ember.nem = "ferfi";
                }
                else
                {
                    ember.nem = "no";
                }
                tomb[i]=kiiratas(ember.nev, ember.foglalkozas, ember.nem,ember.szerencseszam,ember.szerencseszam);
               
            }

            for (int j = 0; j < tomb.Length; j++)
            {
                Console.WriteLine(tomb[j]);
            }
           
            
            Console.ReadKey();
        }
    }
}
