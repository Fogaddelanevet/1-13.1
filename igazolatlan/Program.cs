using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igazolatlan
{
    class Program
    {
        static void Main(string[] args)
        {
        Random r =new Random();
        Console.WriteLine("tefasz:");
        int szam;
        szam=Convert.ToInt32(Console.ReadLine());
        int [,] matrix = new int [szam,szam];
        for (int i = 0; i < matrix.GetLength(0); i++)
			{
                for (int j = 0; j < matrix.GetLength(1); j++)
			    {
                    matrix[i,j]=r.Next(0,50);
                    Console.Write("{0}, ",matrix[i,j]);
			    }
                Console.WriteLine();
			}
        Console.ReadKey();
        }
    }
}
