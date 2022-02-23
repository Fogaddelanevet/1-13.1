using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1feladatdolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            int elso, masodik;
            Console.WriteLine("Irj be egy szamot:");
            elso = int.Parse(Console.ReadLine());
            Console.WriteLine("Irj be egy masik szamot:");
            masodik = int.Parse(Console.ReadLine());



             if (elso < 0 && masodik < 0)
            {
                Console.WriteLine("mind a ketto negativ");
            }
            else if (elso<0)
            {
                Console.WriteLine("az elso a negativ");
            }
            else if(masodik <0)
            {
                Console.WriteLine("a masodik a negativ");
            }
            
            else 
            {
                Console.WriteLine("egyik sem negativ");
            }
            Console.ReadKey();
        }
    }
}
