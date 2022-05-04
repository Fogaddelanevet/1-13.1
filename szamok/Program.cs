using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamok
{
public class Szamok
    {
        string szam;
        public Szamok(string szam)
        {
            this.szam = szam;
        }
        public string harmas()
        {
            int a = Convert.ToInt32(this.szam);
            string b = "harom";
            if(a %3==0)
            {
                return b; 
            }
            else
            {
                return this.szam;
            }

        }
        public string otos()
        {
            int a = Convert.ToInt32(this.szam);
            string b = "otos";

            if (a% 5 ==0)
            {
                return b;
            }
            else
            {
                return this.szam;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szamok sz = new Szamok("15");
            Console.WriteLine("harmas osztas:");
            Console.WriteLine(sz.harmas());
            Console.WriteLine("otos osztas:");
            Console.WriteLine(sz.otos());
            Console.ReadKey();
        }
    }
}
