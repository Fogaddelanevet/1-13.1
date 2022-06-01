using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halmazok
{
    public partial class Form1 : Form
    {
        int [] a;
        int [] b;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int a1 = Convert.ToInt32(textBox1.Text);
             int b1 = Convert.ToInt32(textBox2.Text);
            a = new int[a1];
            b = new int[b1];



          
            for (int i = 0; i < a.Length; i++)
            {

               int elem = r.Next(1, 10);

               if(elem!=a[i])
                {
                    a[i] = elem;
                    listBox1.Items.Add(a[i]);
                   
                }

            }
          
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = r.Next(1, 10);
                listBox2.Items.Add(b[i]);
            }




        }
    }
}
