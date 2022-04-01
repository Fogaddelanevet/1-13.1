using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoslotto
{
    class Lotto
    {
        string szam;
        string[] szamok = new string[5];
        public void sorsolas()
        {
            Random r = new Random();
            for (int i = 0; i < this.szamok.Length; i++)
            {
                this.szam = Convert.ToString(r.Next(1, 99));
               if(this.szamok.Contains(szam))
                {
                    this.szamok[i] = Convert.ToString(r.Next(1, 99));

                }
               else
                {
                    this.szamok[i] = this.szam;
                }

                Console.WriteLine(this.szamok[i]);
                        
              
            }
        }





    }
    class Program
    {
        static void Main(string[] args)
        {
            Lotto a = new Lotto();
            a.sorsolas();
            Console.ReadKey();
        }
    }
}
