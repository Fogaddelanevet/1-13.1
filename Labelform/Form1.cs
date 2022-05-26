using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labelform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblfull_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblfull.Text = "heloszia";
        }

        private void lblfull_MouseClick(object sender, MouseEventArgs e)
        {
            int o = (int)e.X / (lblfull.Width / 3);
            int h=(int)e.X / (lblfull.Height / 3);
        }
    }
}
