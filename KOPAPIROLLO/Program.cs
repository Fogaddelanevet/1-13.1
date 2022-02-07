using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOPAPIROLLO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string gepdont = "";
            string jatekos = "";

            int geppont=0;
            int jatekospont=0;
            
            bool l = true;

            do
            {
                Console.WriteLine("Akarsz játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    l = false;
                    
                }
            }
            while (l==true);
            {
                Console.WriteLine("Mit választasz? (k/p/o)");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k': jatekos = "kő";
                        break;
                    case 'p': jatekos = "papír";
                        break;
                    case 'o': jatekos = "olló";
                        break;
                }
                switch (r.Next(0, 3))
                {
                    case 0: gepdont = "kő";
                        break; 
                    case 1: gepdont = "papír";
                        break;
                    case 2: gepdont = "olló";
                        break;
                }
                if ((jatekos == "kő" && gepdont == "papír")
                    || 
                    (jatekos == "papír" && gepdont == "olló")
                    || 
                    (jatekos == "olló" && gepdont == "kő"))
                { 
                    Console.WriteLine("Veszítettél! Az állás:\nSzámítógép: {0}\nJátékos:{1}", ++geppont, jatekospont);
                }
                else if(jatekos == gepdont)
                    { Console.WriteLine("Döntetlen! Az állás:\nSzámítógép: {0}\nJátékos:{1}", geppont, jatekospont);
                } 
                else
                { 
                    Console.WriteLine("Nyertél! Az állás:\nSzámítógép: {0}\nJátékos:{1}", geppont, ++jatekospont);
                }


            }
        }
    }
}
