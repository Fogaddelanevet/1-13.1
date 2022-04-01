using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Menu
    {
        string[] menu = new string[] { "Első menüpont", "második menupont", "harmadik menupont", "negyedik menupont", "Kilépés" };
        int szam;
        public Menu()
        {

        }
        public void beker()
        {
            Console.WriteLine("Hanyadik menupontot szeretnéd?");
            this.szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(this.menu[this.szam-1]);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu a = new Menu();
            a.beker();
            Console.ReadKey();

        }
    }
}
