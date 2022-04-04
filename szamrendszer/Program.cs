using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    class Kettes
    {
        
        int szam2;
        public Kettes(int szam2)
        {
            this.szam2=szam2;
        }
       
        public void kettes()
        {

            string bin = "";
            int[] kettesek = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };

            for (int i = 0; i < kettesek.Length; i++)
            {
                if (this.szam2 - kettesek[i] >= 0)
                {
                    bin += "1 ";
                    this.szam2 -= kettesek[i];

                }
                else
                {
                    bin += "0 ";
                }
            }
            Console.WriteLine(bin);
        }
    }
    class Hex
    { 
        int szam;
        public Hex(int szam)
        {
            this.szam=szam;
        }
       public void Hexa()
        {
            string hex = this.szam.ToString("X");
            Console.WriteLine(hex); 
           
        }
     }
    class Oct
    {
        int szam3;
        public Oct(int szam3)
        {
            this.szam3=szam3;
        }
    
        public void Octe()
        {
            int counter, i = 1, j;

            counter = this.szam3;
            int[] octalValue = new int[80];
            while (counter != 0)
            {
                octalValue[i++] = counter % 8;
                counter /= 8;
            }
            
            for (j = i - 1; j > 0; j--)
                Console.Write(octalValue[j]);
        }

    }



    
    class Program
    {
        static void Main(string[] args)
        {
            int szamrendszer;
            Console.WriteLine("melyik szamrendszer?");
            szamrendszer=Convert.ToInt32(Console.ReadLine());
            if(szamrendszer==2)
            {
                Console.WriteLine("adj meg egy szamot:");
                Kettes a =new Kettes(Convert.ToInt32(Console.ReadLine()));
                a.kettes();

            }
            if(szamrendszer==16)
            {
                Console.WriteLine("adj meg egy szamot:");
                Hex h =new Hex(Convert.ToInt32(Console.ReadLine()));
                h.Hexa();
            }
             if(szamrendszer==8)
            {
                Console.WriteLine("adj meg egy szamot:");
                Oct o =new Oct(Convert.ToInt32(Console.ReadLine()));
                o.Octe();
            }
            

            Console.ReadKey();

        }
    }
}