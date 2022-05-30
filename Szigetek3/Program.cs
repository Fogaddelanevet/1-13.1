using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sziget
{
    public class Szigetek
    {
        int islandCount = 0;
        int maxIslandLength = 0;
        int i = 0;
        string data = "010111110000101";
        public Szigetek()
        {

        }

        public int Szigetszam()
        {
            while (i < this.data.Length)
            {
                if (this.data[i] == '1')
                {
                    ++this.islandCount;
                    int j = i;
                    int tmp = 0;

                    while (j < this.data.Length && this.data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }

                    i = j;

                    if (tmp > this.maxIslandLength)
                    {
                        this.maxIslandLength = tmp;
                    }
                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("Szigetek száma: {0}", this.islandCount);

            return this.islandCount;

        }
        public int Szigethossz()
        {
            while (i < this.data.Length)
            {
                if (this.data[i] == '1')
                {
                    ++this.islandCount;
                    int j = i;
                    int tmp = 0;

                    while (j < this.data.Length && this.data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }

                    i = j;

                    if (tmp > this.maxIslandLength)
                    {
                        this.maxIslandLength = tmp;
                    }
                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("Legnagyobb sziget: {0}", this.maxIslandLength);
            return this.maxIslandLength;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Szigetek a = new Szigetek();
            Console.WriteLine(a.Szigetszam());
            Console.WriteLine(a.Szigethossz());


            Console.ReadKey();
        }
    }
}
