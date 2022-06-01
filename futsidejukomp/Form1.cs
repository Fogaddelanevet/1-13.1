using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futsidejukomp
{
    public partial class Form1 : Form
    {
        double atlag;
        int osszeg;
        int min;
        int max;
        int db;
        List<int> lista = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int i = r.Next(0, 100);


            Label lb = new Label();
            lb.Location = new Point(e.X, e.Y);
            lb.Text = i.ToString();
            lb.AutoSize = true;
            lb.Text = i.ToString();
            Controls.Add(lb);
            db++;
            osszeg = osszeg+i;
            atlag = osszeg / db;
            lista.Add(i);
            min = lista.Min();
            max = lista.Max();

            label1.Text = String.Format("db {0} , osszeg:{1},atlag:{2},min:{3},max{4}", db, osszeg, atlag, min, max);
            

            



        }
    }
}
