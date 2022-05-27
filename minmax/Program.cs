using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    public class Kivalasztas
    {
        int [] tomb= { 10,3,55,6,88,0,3333,5,11,1,200000};
        public Kivalasztas()
        {

        }
        public int min()
        {
            return this.tomb.Min();
        }
        public int max()
        {
            return this.tomb.Max();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kivalasztas a = new Kivalasztas();
            a.min();
            Console.WriteLine(a.max());
            Console.ReadKey();

        }
    }
}
