using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valamelyikfeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] tomb = new int[12,30];
            int min = tomb[0, 0];
            int max = tomb[0, 0];
            int minhonap=0;
            int minnap=0;
            int maxhonap=0;
            int maxnap=0;
            //tomb feltoltés
            for (int i = 0; i <tomb.GetLength(0); i++)
            {
                Console.WriteLine("{0} : ",i+1);
                for (int j = 0; j <tomb.GetLength(1); j++)
                {
                    tomb[i, j] = r.Next(-10, 30);
                    Console.Write("{0}: ",tomb[i, j]);     
                  
                }
                Console.WriteLine();
            }

            //minimum,maximum 
            for (int i = 0; i < tomb.GetLengthdadsa(0); i++)
			{
                for (int j = 0; j < tomb.GetLength(1); j++)
			    {
                    if(tomb[i,j]<min)
                    {
                        min=tomb[i,j];
                        minhonap=i;
                        minnap=j;
                    }
                    //max
                     if(tomb[i,j]>max)
                    {
                        max=tomb[i,j];
                        maxhonap=i;
                        maxnap=j;
                    }
			    }
			}

           
            Console.WriteLine("a leghidegebb nap {0}:{1} a legmelegebb nap : {2}:{3}",minhonap,minnap,maxhonap,maxnap);
            
            Console.ReadKey();

            
        }
    }
}
