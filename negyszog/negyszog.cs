using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    public class Negyszog
    {
        //tagváltozó
        double Side { get; set; }
        //konst.
        public Negyszog(double side)
        {
            this.Side = side;
        }
        //ker
        public double kerület()
        {
            return 4 * this.Side;
        }
        //ter
        public double terület()
        {
            return this.Side * this.Side;
        }
        public double Atlo()
        {
            return Math.Sqrt(Math.Pow(this.Side,2) + Math.Pow(this.Side, 2));
        }
    }
}
