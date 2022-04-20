using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4
{
    class Matrix4
    {
        int sor;
        int oszlop;
        int elemszam;
        int[] tomb1;

        public Matrix4() { }
        public void feltolt()
        {
            this.sor = Convert.ToInt32(Console.ReadLine());
            this.oszlop = Convert.ToInt32(Console.ReadLine());
            string[,] c = new string[sor, oszlop];
            this.elemszam = this.oszlop * this.sor;

            while (c.Cast<string>().Any(x => x == null))
            {
                try
                {
                    tomb1 = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), Convert.ToInt32);
                    if (tomb1[0] <= sor && tomb1[1] <= oszlop)
                    {
                        if (c[tomb1[0], tomb1[1]] == null)
                        {
                            if (tomb1[2] > 0)
                            {
                                c[tomb1[0], tomb1[1]] = Convert.ToString(tomb1[2]);
                            }
                            else
                            {
                                Console.WriteLine("Ez nem pozitiv egész szám.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ez az érték már szerepel.");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nem egész szám");
                }
                string a;
                int db=0;
                Console.WriteLine("Akarod folytatni?(i/n)");
                a = Convert.ToString(Console.ReadLine());
                if (a == "n")
                {
                    for (int i = 0; i < c.GetLength(0); i++)
                    {
                        Console.WriteLine();
                        for (int j = 0; j < c.GetLength(1); j++)
                        {

                            if (c[i, j] == null)
                            {
                                db++;
                               
                            } 
                        }
                    }
                    Console.WriteLine("uresen hagyott elemek szama:{0}", db);
                    break;
                }
                if (a == "i")
                {
                    continue;
                }
            }


            for (int i = 0; i < c.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorok/Oszlopok száma:");
            Matrix4 a = new Matrix4();
            a.feltolt();


            Console.ReadKey();
        }
    }
}
