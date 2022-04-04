using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo
{
    class Fibo
    {
        int[] a = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155 };
        int b;
        public Fibo(int b)
        {
            this.b = b;
        }
        public void kiir()
        {
            for (int i = 0; i < this.b; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hány elemet kérsz?");
            Fibo a = new Fibo(Convert.ToInt32(Console.ReadLine()));
            a.kiir();
            Console.ReadKey();
        }
    }
}
