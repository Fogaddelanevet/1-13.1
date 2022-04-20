using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill2
{
    class Matrix
    {
        int db;
        int[,] tomb;
        int a;
        int b;
        public Matrix(int a, int b)
        {

            this.a = a;
            this.b = b;
            this.db = 0;   

        }
        public void feltolt()
        {

            this.tomb = new int[this.a, this.b];
            for (int i = 0; i < this.tomb.GetLength(0); i++)
            {

                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    db++;
                    tomb[i, j] = Convert.ToInt32(Console.ReadLine());
                    if(db==this.tomb.GetLength(1))
                    {
                        this.db = 0;
                        for (int k = 0; k < this.tomb.GetLength(1); k++)
                        {
                            
                            Console.Write("Sor: {0} ",this.tomb[i, k]);
                        }
                        Console.WriteLine();
                    }
                }
                
            }
        }
        public void kiir()
        {
            for (int i = 0; i < this.tomb.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.tomb.GetLength(1); j++)
                {
                    Console.Write("{0} ",tomb[i, j]);

                }

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("oszlopok száma? sorok száma?");
            Matrix m = new Matrix(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
            m.feltolt();
            Console.WriteLine();
            Console.WriteLine("kiiras");
            m.kiir();
            Console.ReadKey();
        }
    }
}

