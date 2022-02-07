using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nev
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,num2; 
            

            if (args.Length == 0) 
            {
                number = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

            }
            if (args.Length==0)
            {
                Random r = new Random(); 
                number = r.Next(100);
                num2 = r.Next(100);
            }
            else 
            { 
                number = int.Parse(args[0]);
                num2 = int.Parse(args[0]);
            }
            Console.WriteLine(number * num2);









            Console.ReadKey();
        }






        
        }
    }

